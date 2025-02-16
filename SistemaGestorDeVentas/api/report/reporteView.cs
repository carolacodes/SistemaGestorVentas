using SistemaGestorDeVentas.api.cart;
using SistemaGestorDeVentas.api.pago;
using SistemaGestorDeVentas.api.user;
using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static SistemaGestorDeVentas.api.report.reportes;

namespace SistemaGestorDeVentas.api.report
{
    public partial class reporteView : Form
    {
        public reporteView()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CargarComboBoxGrafico()
        {
            cbox_grafico.Items.Clear();  // Limpia cualquier elemento existente en el ComboBox

            // Agrega elementos de texto al ComboBox
            cbox_grafico.Items.Add("Ventas Mensuales");
            cbox_grafico.Items.Add("Ventas Historicas");
            cbox_grafico.Items.Add("Producto");
            cbox_grafico.Items.Add("Categoria");
            cbox_grafico.Items.Add("Vendedor");
        }

        private void CargarComboBoxReporte()
        {
            UserService user = new UserService();
            var nombresUsuarios = user.getUsers();
            cboxReportEmpleado.DataSource = nombresUsuarios;
            cboxReportEmpleado.DisplayMember = "nombre";
            cboxReportEmpleado.ValueMember = "DNI_usuario";

            cboxReportEmpleado.SelectedIndex = -1;
        }
        private void reporteView_Load(object sender, EventArgs e)
        {

            CargarComboBoxGrafico();
            CargarComboBoxReporte();
            int currentYear = DateTime.Now.Year;
            for (int year = 2020; year <= currentYear; year++)
            {
                cbYear.Items.Add(year.ToString());
            }
            cbYear.SelectedIndex = cbYear.Items.Count - 1; // Seleccionar el año actual por defecto

            // Inicialmente, ocultar el ComboBox de años
            dateTimeGradicoDesde.Visible = false;
            dateTimeGraficoHasta.Visible = false;
            lbl_desde.Visible = false;
            lbl_hasta.Visible = false;
            cbYear.Visible = false;
            //chartTortaReport.Legends.Clear();
            chartVentasBarras.Legends.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*
        private void btn_generar_reporte_Click(object sender, EventArgs e)
        {

            dataGridReportes.AutoGenerateColumns = false;
            dataGridReportes.Columns.Clear();
            reportes report = new reportes();
            // Obtener las fechas de los DateTimePicker
            DateTime fechaDesde = dateTimeReportDesde.Value;
            DateTime fechaHasta = dateTimeReportHasta.Value;
            List<Venta> resultados;
            
            // Verificar si hay un empleado seleccionado en el ComboBox
            if (cboxReportEmpleado.SelectedItem == null) // Si no hay selección en el ComboBox
            {
                // Llamar a la función de filtro solo por fecha
                resultados = report.filtrarVentasPorFecha(fechaDesde, fechaHasta);
            }
            else
            {
                // Obtener el ID del usuario seleccionado en el ComboBox
                string usuarioId = cboxReportEmpleado.SelectedValue.ToString();

                // Llamar a la función de filtro por vendedor y fecha
                resultados = report.filtrarVentasPorVendedorYFecha(usuarioId, fechaDesde, fechaHasta);

            }

            var ventasConTotal = resultados.Select(v => new
            {
                v.cod_venta,
                v.fecha_venta,
                v.DNI_cliente,
                v.DNI_usuario,
                Total = v.Pago != null ? v.Pago.total : 0  // Accede al total en Pago o usa 0 si no existe
            }).ToList();


            // Configurar el DataGridView

            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nro Venta", DataPropertyName = "cod_venta" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha Venta", DataPropertyName = "fecha_venta" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI Cliente", DataPropertyName = "DNI_cliente" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI Usuario", DataPropertyName = "DNI_usuario" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "total" });


            dataGridReportes.DataSource = ventasConTotal;

            //   foreach (Venta venta in resultados)
            // {
            //  dataGridReportes.Rows.Add(venta.cod_venta, venta.fecha_venta, venta.DNI_cliente, venta.DNI_usuario);
            //}
        }
*/

        private void btn_generar_reporte_Click(object sender, EventArgs e)
        {
            dataGridReportes.AutoGenerateColumns = false;
            dataGridReportes.Columns.Clear();
            reportes report = new reportes();
            DateTime fechaDesde = dateTimeReportDesde.Value;
            DateTime fechaHasta = dateTimeReportHasta.Value;
            List<Venta> resultados;

            if (cboxReportEmpleado.SelectedItem == null)
            {
                resultados = report.filtrarVentasPorFecha(fechaDesde, fechaHasta);
            }
            else
            {
                string usuarioId = cboxReportEmpleado.SelectedValue.ToString();
                resultados = report.filtrarVentasPorVendedorYFecha(usuarioId, fechaDesde, fechaHasta);
            }

            var ventasConTotal = resultados.Select(v => new
            {
                v.cod_venta,
                v.fecha_venta,
                v.DNI_cliente,
                v.DNI_usuario,
                Total = v.Pago != null ? v.Pago.total : 0
            }).ToList();

            // Configuración del DataGridView
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nro Venta", DataPropertyName = "cod_venta" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha Venta", DataPropertyName = "fecha_venta" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI Cliente", DataPropertyName = "DNI_cliente" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI Usuario", DataPropertyName = "DNI_usuario" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "Total" });

            dataGridReportes.DataSource = ventasConTotal;
        }
        private void dataGridReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_generar_grafico_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dateTimeGradicoDesde.Value;
            DateTime fechaHasta = dateTimeGraficoHasta.Value;
            if (cbox_grafico.SelectedItem != null && cbox_grafico.SelectedItem.ToString() == "Producto")
            {
                CargarGraficoProductosMasVendidos(fechaDesde, fechaHasta);
            }
            if (cbox_grafico.SelectedItem != null && cbox_grafico.SelectedItem.ToString() == "Categoria")
            {
                CargarGraficoCategoriasMasVendidas(fechaDesde, fechaHasta);
            }
            if (cbox_grafico.SelectedItem != null && cbox_grafico.SelectedItem.ToString() == "Vendedor")
            {
                CargarGraficoVendedores(fechaDesde, fechaHasta);
            }
            if(cbox_grafico.SelectedItem != null && cbox_grafico.SelectedItem.ToString() == "Ventas Mensuales")
            {
                int anio = fechaDesde.Year;
                CargarGraficoVentasMensuales(anio);
            }
            if (cbox_grafico.SelectedItem != null && cbox_grafico.SelectedItem.ToString() == "Ventas Historicas")
            {
                CargarGraficoVentasAnuales();
            }
        }

        private void CargarGraficoProductosMasVendidos(DateTime fechaInicio, DateTime fechaFin)
        {   reportes reportes = new reportes();
            // Llama a la función para obtener los productos más vendidos
            int topN = 5; // Número de productos más vendidos que deseas mostrar
            List<ProductoMasVendido> productosMasVendidos = reportes.ObtenerProductosMasVendidosPorFecha(fechaInicio, fechaFin, topN);

            // Limpia las series y puntos existentes en el gráfico, en caso de que haya datos previos
            chartTortaReport.Series.Clear();
            chartTortaReport.Titles.Clear();

            // Configura el título del gráfico
            chartTortaReport.Titles.Add("Productos Más Vendidos");

            // Crea una nueva serie para el gráfico de torta
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Productos",
                IsValueShownAsLabel = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            // Agrega la serie al gráfico
            chartTortaReport.Series.Add(series);

            // Agrega los datos de productos más vendidos a la serie
            foreach (var producto in productosMasVendidos)
            {
                // Agrega el nombre del producto como la etiqueta y la cantidad vendida como el valor
                int index = series.Points.AddXY(producto.NombreProducto, producto.CantidadVendida);

                // Accede al punto agregado por su índice para configurar Label y LegendText
                var punto = series.Points[index];
                punto.Label = producto.CantidadVendida.ToString(); // Muestra la cantidad vendida en la etiqueta
                punto.LegendText = producto.NombreProducto; // Muestra el nombre del producto en la leyenda
            }

            // Configura la leyenda para que esté visible
            if (chartTortaReport.Legends.Count > 0)
            {
                chartTortaReport.Legends[0].Enabled = true;
            }
        }

        private void CargarGraficoCategoriasMasVendidas(DateTime fechaInicio, DateTime fechaFin)
        {
            reportes reportes = new reportes();
            // Llama a la función para obtener los productos más vendidos
            int topN = 5; // Número de productos más vendidos que deseas mostrar
            List<CategoriaMasVendida> CategoriasMasVendidas = reportes.ObtenerCategoriasMasVendidasPorFecha(fechaInicio, fechaFin, topN) ;

            // Limpia las series y puntos existentes en el gráfico, en caso de que haya datos previos
            chartTortaReport.Series.Clear();
            chartTortaReport.Titles.Clear();

            // Configura el título del gráfico
            chartTortaReport.Titles.Add("Categorias mas Vendidas");

            // Crea una nueva serie para el gráfico de torta
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Categoria",
                IsValueShownAsLabel = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            // Agrega la serie al gráfico
            chartTortaReport.Series.Add(series);

            // Agrega los datos de productos más vendidos a la serie
            foreach (var categoria in CategoriasMasVendidas)
            {
                // Agrega el nombre del producto como la etiqueta y la cantidad vendida como el valor
                int index = series.Points.AddXY(categoria.NombreCategoria, categoria.CantidadVendida);

                // Accede al punto agregado por su índice para configurar Label y LegendText
                var punto = series.Points[index];
                punto.Label = categoria.CantidadVendida.ToString(); // Muestra la cantidad vendida en la etiqueta
                punto.LegendText = categoria.NombreCategoria; // Muestra el nombre del producto en la leyenda
            }

            // Configura la leyenda para que esté visible
            if (chartTortaReport.Legends.Count > 0)
            {
                chartTortaReport.Legends[0].Enabled = true;
            }
        }

        private void CargarGraficoVendedores(DateTime fechaInicio, DateTime fechaFin)
        {
            reportes reportes = new reportes();
            List<VentasPorVendedor> ventasVendedores = reportes.ObtenerCantidadVentasPorVendedorPorFecha(fechaInicio, fechaFin);

            if (ventasVendedores.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.");
                return;
            }

            chartTortaReport.Series.Clear();
            chartTortaReport.Titles.Clear();

            chartTortaReport.Titles.Add("Cantidad de Ventas por Vendedor");

            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Vendedor",
                IsValueShownAsLabel = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            chartTortaReport.Series.Add(series);

            foreach (var vendedor in ventasVendedores)
            {
                int index = series.Points.AddXY(vendedor.NombreVendedor, vendedor.CantidadVentas);

                var punto = series.Points[index];
                punto.Label = vendedor.CantidadVentas.ToString();
                punto.LegendText = vendedor.NombreVendedor;
            }

            if (chartTortaReport.Legends.Count == 0)
            {
                chartTortaReport.Legends.Add(new System.Windows.Forms.DataVisualization.Charting.Legend("Legend"));
            }
            chartTortaReport.Legends[0].Enabled = true;
        }

        private void btn_limpiar_reporte_Click(object sender, EventArgs e)
        {
            cboxReportEmpleado.SelectedIndex = -1;
            dataGridReportes.DataSource = null;
            dataGridReportes.Columns.Clear();
            dateTimeReportDesde.Value = DateTime.Today;
            dateTimeReportHasta.Value = DateTime.Today;
        }

        // GRAFICO DE BARRAS
        /*
        private void CargarGraficoVentasMensuales(int anio)
        {
            reportes reportes = new reportes();
            var ventasMensuales = reportes.ObtenerVentasMensuales(anio);
            chartVentasBarras.Series.Clear();

            Series serie = new Series("Ventas Mensuales")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var venta in ventasMensuales)
            {
                serie.Points.AddXY(venta.Key, venta.Value);
            }

            chartVentasBarras.Series.Add(serie);
            chartVentasBarras.ChartAreas[0].AxisX.Title = "Meses";
            chartVentasBarras.ChartAreas[0].AxisY.Title = "Total Vendido ($)";
        }
        */
        private void CargarGraficoVentasMensuales(int anio)
        {
            reportes reportes = new reportes();
            var ventasMensuales = reportes.ObtenerVentasMensuales(anio);
            chartVentasBarras.Series.Clear();

            Series serie = new Series("Ventas Mensuales")
            {
                ChartType = SeriesChartType.Column
            };

            // Diccionario para convertir números de mes a nombres de mes
            string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            foreach (var venta in ventasMensuales)
            {
                string nombreMes = nombresMeses[venta.Key - 1]; // Convertir número de mes a texto
                serie.Points.AddXY(nombreMes, venta.Value);
            }

            chartVentasBarras.Series.Add(serie);
            chartVentasBarras.ChartAreas[0].AxisX.Title = "Meses";
            chartVentasBarras.ChartAreas[0].AxisY.Title = "Total Vendido ($)";

            // Asegurar que el eje X trate los meses como etiquetas de texto
            chartVentasBarras.ChartAreas[0].AxisX.Interval = 1;
            chartVentasBarras.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true; // Evita superposición
        }

        /*
        private void CargarGraficoVentasAnuales()
        {
            reportes reportes = new reportes();
            var ventasAnuales = reportes.ObtenerVentasAnuales();
            chartVentasBarras.Series.Clear();

            Series serie = new Series("Ventas Anuales")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var venta in ventasAnuales)
            {
                serie.Points.AddXY(venta.Key, venta.Value);
            }

            chartVentasBarras.Series.Add(serie);
            chartVentasBarras.ChartAreas[0].AxisX.Title = "Años";
            chartVentasBarras.ChartAreas[0].AxisY.Title = "Total Vendido ($)";
        }
        */


        private void CargarGraficoVentasAnuales()
        {
            reportes reportes = new reportes();
            var ventasAnuales = reportes.ObtenerVentasAnuales();
            chartVentasBarras.Series.Clear();

            Series serie = new Series("Ventas Anuales")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var venta in ventasAnuales)
            {
                // Convertir el año a string para que el eje X lo interprete como etiqueta
                serie.Points.AddXY(venta.Key.ToString(), venta.Value);
            }

            chartVentasBarras.Series.Add(serie);
            chartVentasBarras.ChartAreas[0].AxisX.Title = "Años";
            chartVentasBarras.ChartAreas[0].AxisY.Title = "Total Vendido ($)";

            // Forzar que el eje X trate los valores como etiquetas en lugar de valores numéricos
            chartVentasBarras.ChartAreas[0].AxisX.Interval = 1;
            chartVentasBarras.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true; // Evita superposición
        }
        

        //
        private void btn_limpiar_grafico_Click(object sender, EventArgs e)
        {
            cbox_grafico.SelectedIndex = -1;
            dateTimeGradicoDesde.Value = DateTime.Today;   
            dateTimeGraficoHasta.Value = DateTime.Today;
            chartTortaReport.Series.Clear();
            chartTortaReport.Titles.Clear();
            chartVentasBarras.Series.Clear();
            chartVentasBarras.Titles.Clear();

        }

        private void chartTortaReport_Click(object sender, EventArgs e)
        {

        }

        private void cbox_grafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay una selección válida
            if (cbox_grafico.SelectedItem == null || cbox_grafico.SelectedIndex == -1)
            {
                // Si no hay selección, ocultar todo
                dateTimeGradicoDesde.Visible = false;
                dateTimeGraficoHasta.Visible = false;
                lbl_desde.Visible = false;
                lbl_hasta.Visible = false;
                cbYear.Visible = false;
                return; // Salir de la función para evitar errores
            }

            if (cbox_grafico.SelectedItem.ToString() == "Ventas Mensuales")
            {
                // Ocultar DateTimePickers y mostrar ComboBox de año
                dateTimeGradicoDesde.Visible = false;
                dateTimeGraficoHasta.Visible = false;
                lbl_desde.Text = "Elegir Año";
                lbl_hasta.Visible = false;
                cbYear.Visible = true;
            }

            else if (cbox_grafico.SelectedItem.ToString() == "Ventas Historicas")
            {
                // Ocultar DateTimePickers y mostrar ComboBox de año
                dateTimeGradicoDesde.Visible = false;
                dateTimeGraficoHasta.Visible = false;
                lbl_desde.Visible = false;
                lbl_hasta.Visible = false;
                cbYear.Visible = false;
            }

            else
            {
                // Mostrar DateTimePickers y ocultar ComboBox de año
                dateTimeGradicoDesde.Visible = true;
                dateTimeGraficoHasta.Visible = true;
                cbYear.Visible = false;
            }
        }
    }
}
