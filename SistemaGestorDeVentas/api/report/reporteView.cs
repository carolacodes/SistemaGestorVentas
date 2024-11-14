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

        private void reporteView_Load(object sender, EventArgs e)
        {
            UserService user = new UserService();
            var nombresUsuarios = user.getUsers();
            cboxReportEmpleado.DataSource = nombresUsuarios;
            cboxReportEmpleado.DisplayMember = "nombre";
            cboxReportEmpleado.ValueMember = "DNI_usuario";

            cboxReportEmpleado.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_generar_reporte_Click(object sender, EventArgs e)
        {
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

            // Configurar el DataGridView
            dataGridReportes.AutoGenerateColumns = false;
            dataGridReportes.Columns.Clear();

            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nro Venta", DataPropertyName = "cod_venta" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha Venta", DataPropertyName = "fecha_venta" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI Cliente", DataPropertyName = "DNI_cliente" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DNI Usuario", DataPropertyName = "DNI_usuario" });
            dataGridReportes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total", DataPropertyName = "total" });


            dataGridReportes.DataSource = resultados;

         //   foreach (Venta venta in resultados)
           // {
              //  dataGridReportes.Rows.Add(venta.cod_venta, venta.fecha_venta, venta.DNI_cliente, venta.DNI_usuario);
            //}
        }

        private void dataGridReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
