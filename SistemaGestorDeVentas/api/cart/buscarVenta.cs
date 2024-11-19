using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.api.product;
using SistemaGestorDeVentas.api.report;
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

namespace SistemaGestorDeVentas.api.cart
{
    public partial class buscarVenta : Form
    {
        private detalleVenta _detalleVenta;
        public buscarVenta(detalleVenta detalleVenta)
        {
            InitializeComponent();
            _detalleVenta = detalleVenta;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el DNI del cliente ingresado
            var nroVenta = txtBuscarVenta.Text.Trim();

            // Verificar si el DNI está vacío
            if (string.IsNullOrEmpty(nroVenta))
            {
                MessageBox.Show("Por favor, ingrese un nro venta correcto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fecha = txtBuscarVenta.Text;
            if (string.IsNullOrEmpty(fecha))
            {
                MessageBox.Show("Por favor, ingrese una fecha.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de VentaService;
            VentaService ventaService = new VentaService();

            //instancia de reportes para acceder a los metodos de filtros
            reportes reporteService = new reportes();

            try
            {
                int indiceSeleccionado = cbBuscarVenta.SelectedIndex;

                switch (indiceSeleccionado)
                {
                    case 0:
                        Venta ventaExiste = ventaService.getVenta(int.Parse(nroVenta));

                        dataGridBuscarVenta.Rows.Clear();
                        
                        if(ventaExiste != null)
                        {
                            dataGridBuscarVenta.Rows.Add(ventaExiste.cod_venta, ventaExiste.fecha_venta,
                                ventaExiste.DNI_usuario, ventaExiste.DNI_cliente, ventaExiste.id_pago);
                        } else
                        {
                            MessageBox.Show("No se encontró ninguna venta con el nro venta proporcionado. Por favor vuelva a ingresar el DNI", "Cliente No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridBuscarVenta.Rows.Clear();
                            List<Venta> ventas = ventaService.getVentas();
                            foreach(var venta in ventas)
                            {
                                dataGridBuscarVenta.Rows.Add(venta.cod_venta, venta.fecha_venta,
                                venta.DNI_usuario, venta.DNI_cliente, venta.id_pago);
                            }
                        }
                        break;
                    case 1:
                        dataGridBuscarVenta.Rows.Clear();
                        dateBuscarVenta.Visible = true;
                        
                        DateTime fechaSeleccionada = dateBuscarVenta.Value;
                        txtBuscarVenta.Text = fechaSeleccionada.ToString();

                        DateTime fechaActual = DateTime.Today; // O DateTime.Now para obtener fecha y hora
                        List<Venta> ventasPorFecha = reporteService.filtrarVentasPorFecha(fechaSeleccionada, fechaActual);
                        foreach (var venta in ventasPorFecha)
                        {
                            dataGridBuscarVenta.Rows.Add(venta.cod_venta, venta.fecha_venta,
                            venta.DNI_usuario, venta.DNI_cliente, venta.id_pago);
                        }
                        
                        break;
                    //ver si agreguar filtro por usuario y cliente
                }
            }catch (Exception ex)
            {
                // Capturar excepciones y mostrar mensaje de error
                MessageBox.Show($"Error al intentar obtener las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarVenta_Load(object sender, EventArgs e)
        {

            VentaService ventaService = new VentaService();

            List<Venta> ventas = ventaService.getVentas();

            dataGridBuscarVenta.Rows.Clear();

            foreach (var venta in ventas)
            {
                dataGridBuscarVenta.Rows.Add(venta.cod_venta, venta.fecha_venta, venta.DNI_usuario,
                    venta.DNI_cliente, venta.id_pago);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBuscarVenta.ReadOnly=false;
            txtBuscarVenta.Text = "";
            buscarVenta_Load(sender, e);
        }

        private void dateBuscarVenta_ValueChanged(object sender, EventArgs e)
        {
            // Actualiza el TextBox con la fecha seleccionada en formato corto
            txtBuscarVenta.Text = dateBuscarVenta.Value.ToShortDateString();
        }

        private void cbBuscarVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = cbBuscarVenta.SelectedIndex;

            // Mostrar el DateTimePicker solo si la opción seleccionada es la opción 1
            dateBuscarVenta.Visible = (indiceSeleccionado == 1);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridBuscarVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridBuscarVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //me aseguro de que se hizo click en una fila valida
            if (e.RowIndex >= 0)
            {
                //obtengo la fila que selecciono el cliente
                DataGridViewRow row = dataGridBuscarVenta.Rows[e.RowIndex];

                VentaService ventaService = new VentaService();
                UserService userService = new UserService();
                ClienteService clienteService = new ClienteService();
                var cod_venta = row.Cells["buscarVentaNroVenta"].Value.ToString();
                var dni_cliente = row.Cells["buscarVentaDniCliente"].Value.ToString();

                DateTime dateTimeVenta = (DateTime)row.Cells["buscarVentaFecha"].Value;
                _detalleVenta.dateCartDetalleFecha.Value = dateTimeVenta;

                _detalleVenta.txtCartDetalleNroVenta.Text = cod_venta;
                // Asigna los valores directamente a los TextBox en _carritoForm
                Venta venta = ventaService.getVenta(int.Parse(cod_venta));
                
                Usuario user = userService.getUser(venta.DNI_usuario);
                _detalleVenta.txtUsuario.Text = user.nombre;

                Cliente cliente = clienteService.getCliente(dni_cliente);
                _detalleVenta.txtClienteVenta.Text = dni_cliente;
                _detalleVenta.txtNombreCliVenta.Text = cliente.nombre;

                ProductoVentaService prodVentaService = new ProductoVentaService();
                ProductService productService = new ProductService();


                //BUSCAMOS EL PRODUCTO-VENTA
                //lista de productos_venta con el mismo codigo de venta
                List<Producto_Venta> producto_ventas = prodVentaService.getProductVentaByCodVenta(int.Parse(cod_venta));

                foreach (var productVenta in producto_ventas)
                {
                    Producto productoEncontrado = productService.getProductService(productVenta.id_producto);
                    var subtotal = productoEncontrado.precio_venta * productVenta.cantidad;
                    _detalleVenta.dataProductosVenta.Rows.Add(productoEncontrado.nombre, productoEncontrado.precio_venta, productVenta.cantidad, subtotal);
                }

                _detalleVenta.CalcularTotal();

                this.Close();
            }
        }
    }
}
