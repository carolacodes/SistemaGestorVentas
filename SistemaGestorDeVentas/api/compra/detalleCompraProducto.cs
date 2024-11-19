using SistemaGestorDeVentas.api.product;
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

namespace SistemaGestorDeVentas.api.compra
{
    public partial class detalleCompraProducto : Form
    {
        public detalleCompraProducto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            var nroCompra = txtCartDetalleNroVenta.Text.Trim();
            if (string.IsNullOrEmpty(nroCompra))
            {
                buscarCompra buscarCompraForm = new buscarCompra(this);
                buscarCompraForm.Show();
                //detalleCompraProducto_Load(sender, e);
            }
            else
            {
                CompraService compraService = new CompraService();
                UserService userService = new UserService();
                ProductoCompraService product = new ProductoCompraService();
                try
                {
                    Compra compraExiste = compraService.GetCompra(int.Parse(nroCompra));

                    if (compraExiste == null)
                    {
                        MessageBox.Show("No se encontró ninguna compra con el número ingresado.",
                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Usuario usuarioExiste = userService.getUser(compraExiste.DNI_usuario);

                    if (usuarioExiste == null)
                    {
                        MessageBox.Show("Usuario no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dateCartDetalleFecha.Value = (DateTime)compraExiste.fecha_compra;
                    txtUsuarioCompra.Text = usuarioExiste.nombre;

                    List<Producto_Compra> prod_compras = product.getProductosCompraService(int.Parse(nroCompra));

                    ProductService productService = new ProductService();
                    dataGridDetalleCompra.Rows.Clear();
                    foreach (var prodCompra in prod_compras)
                    {
                        Producto prod = productService.getProductService(prodCompra.id_producto);
                        if (prod != null)
                        {
                            var subtotal = prodCompra.cantidad * prod.precio_compra;
                            dataGridDetalleCompra.Rows.Add(prod.nombre, prod.precio_compra,
                                prodCompra.cantidad, subtotal);
                        }
                    }
                    CalcularTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar obtener los datos de la compra: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //Compra compraExiste = compraService.GetCompra(int.Parse(nroCompra));
                //Usuario usuarioExiste = userService.getUser(compraExiste.DNI_usuario);

                //if(usuarioExiste == null)
                //{
                //    MessageBox.Show("Usuario no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                //txtUsuarioCompra.Text = usuarioExiste.nombre;

                //List<Producto_Compra> prod_compras = product.getProductosCompraService(int.Parse(nroCompra));

                //ProductService productService = new ProductService();
                //dataGridDetalleCompra.Rows.Clear();
                //foreach (var prodCompra in prod_compras)
                //{
                //    Producto prod = productService.getProductService(prodCompra.id_producto);
                //    if (prod != null)
                //    {
                //        var subtotal = prodCompra.cantidad * prod.precio_compra;
                //        dataGridDetalleCompra.Rows.Add(prod.nombre, prod.precio_compra,
                //            prodCompra.cantidad, subtotal);
                //    }
                //}
                //CalcularTotal();

            }
            
        }



        public void CalcularTotal()
        {
            decimal total = 0;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow row in dataGridDetalleCompra.Rows)
            {
                // Verifica que la fila no sea la fila vacía al final del DataGridView
                if (row.Cells["DetalleCompraProvSubtotal"].Value != null)
                {
                    // Intenta convertir el valor de la columna 'cartSubtotal' a decimal y acumularlo
                    decimal subtotal;
                    if (decimal.TryParse(row.Cells["DetalleCompraProvSubtotal"].Value.ToString(), out subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            // Asigna el total calculado al TextBox txtTotal
            txtMontoTotal.Text = total.ToString(); // Formato de dos decimales
        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dateCartDetalleFecha.Value = DateTime.Today;
            txtCartDetalleNroVenta.Text = "";
            txtUsuarioCompra.Text = "";
            dataGridDetalleCompra.Rows.Clear();
            txtMontoTotal.Text = "";
        }

        private void dataGridDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void detalleCompraProducto_Load(object sender, EventArgs e)
        {
            
            dateCartDetalleFecha.Value = DateTime.Today;
            txtCartDetalleNroVenta.Text = "";
            txtUsuarioCompra.Text = "";
            dataGridDetalleCompra.Rows.Clear();
            txtMontoTotal.Text = "";
            CalcularTotal();
        }
    }
}
