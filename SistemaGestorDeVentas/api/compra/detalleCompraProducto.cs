using SistemaGestorDeVentas.api.product;
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
            buscarCompra buscarCompraForm = new buscarCompra(this);
            buscarCompraForm.Show();
            if(txtCartDetalleNroVenta != null)
            {
                CompraService compraService = new CompraService();
                ProductoCompraService productoCompraService = new ProductoCompraService();

                var codVentaText = txtCartDetalleNroVenta.Text.Trim(); // Elimina espacios adicionales

                if (!string.IsNullOrEmpty(codVentaText) && int.TryParse(codVentaText, out int codVenta))
                {
                    dataGridDetalleCompra.Rows.Clear();
                    // Llama al servicio con el valor convertido
                    List<Producto_Compra> productosCompra = productoCompraService.getProductosCompraService(codVenta);

                    foreach (var prod in productosCompra)
                    {
                        ProductService productService = new ProductService();
                        Producto prodEncontrado = productService.getProductService(prod.id_producto);
                        var subtotal = prodEncontrado.precio_compra * prod.cantidad;
                        dataGridDetalleCompra.Rows.Add(prodEncontrado.nombre,
                            prodEncontrado.precio_compra, prod.cantidad, subtotal);
                    }

                    CalcularTotal();
                }

                

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
            CalcularTotal();
        }
    }
}
