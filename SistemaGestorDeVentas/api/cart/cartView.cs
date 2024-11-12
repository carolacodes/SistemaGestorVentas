using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.api.product;
using SistemaGestorDeVentas.db;
namespace SistemaGestorDeVentas.api.cart
{
    public partial class cartView : Form
    {
        
        public cartView()
        {
            InitializeComponent();

            // Ocultar los botones de minimizar, maximizar y cerrar
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void cartView_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateCartViewFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dateCartViewFecha.Value == null || dateCartViewFecha.Value == DateTime.MinValue)
            {
                dateCartViewFecha.Value = DateTime.Now; 
            }
        }

        private void txtCartViewDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCartViewDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es numero y no es tecla borrar que no permita el ingreso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; 
            }

            // si es espacio que no permita ingreso 
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; 
            }

            // limito la cant de caracteres
            if (txtCartViewDNI.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // bloqueo las teclas si hay mas de 8 caract
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCartNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es una letra, no es borrar, no es espacio entonces bloquea
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Bloquear caracteres que no sean letras o espacios
            }
            
        }

        private void txtCartCodProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCartProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // bloqeua caracteres que no sean letras o espacios
            }
        }

        private void txtCartPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es numero y no es . y no es borrar bloquea
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // bloquea si no es un número, punto o retroceso
            }

            // verifica si ya existe un punto para que no cargue mas de uno
            if (e.KeyChar == '.' && txtCartPrecio.Text.Contains("."))
            {
                e.Handled = true; // bloquea si ya hay un punto decimal
            }
        }

        private void txtCartStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCartViewDNI_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCartViewDNI.Text))
            //{
            //    MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void txtCartNombreCliente_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCartNombreCliente.Text))
            //{
            //    MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void txtCartCodProduct_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCartCodProduct.Text))
            //{
            //    MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void txtCartProducto_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCartProducto.Text))
            //{
            //    MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void txtCartPrecio_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCartPrecio.Text))
            //{
            //    MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void txtCartStock_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCartStock.Text))
            //{
            //    MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void btnBuscarClienteVenta_Click(object sender, EventArgs e)
        {
            var nro_dni = txtCartViewDNI.Text;
            

            //MessageBox.Show("Por favor, ingrese un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (string.IsNullOrEmpty(nro_dni))
            {
                buscarCliente buscarClienteForm = new buscarCliente(this);
                buscarClienteForm.Show();
            }else
            {
                try
                {
                    ClienteService clienteService = new ClienteService();
                    Cliente clienteExiste = clienteService.getCliente(nro_dni);
                    if(clienteExiste != null)
                    {
                        txtCartNombreCliente.Text = clienteExiste.nombre;
                    }
                    else
                    {
                        MessageBox.Show("DNI no existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error al intentar obtener el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void btnBuscarProductVenta_Click(object sender, EventArgs e)
        {
            


            var cod_producto = txtCartCodProduct.Text;


            //MessageBox.Show("Por favor, ingrese un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (string.IsNullOrEmpty(cod_producto))
            {
                Form buscarProductoForm = new buscarProducto(this);
                buscarProductoForm.Show();
            }
            else
            {
                try
                {
                    //ClienteService clienteService = new ClienteService();
                    //Cliente clienteExiste = clienteService.getCliente(nro_dni);

                    ProductService productService = new ProductService();
                    Producto productoExiste = productService.getProductService(int.Parse(cod_producto));

                    if (productoExiste != null)
                    {
                        txtCartProducto.Text = productoExiste.nombre;
                        txtCartPrecio.Text = (productoExiste.precio_venta).ToString();
                        txtCartStock.Text = (productoExiste.stock).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Codigo de producto no existente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar obtener el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnAgregarCartView_Click(object sender, EventArgs e)
        {

            var cod_product = int.Parse(txtCartCodProduct.Text);
            var nombre_product = txtCartProducto.Text;
            var precio = int.Parse(txtCartPrecio.Text);
            var cantidad = int.Parse(dpCantidad.Text);

            var subtotal = precio * cantidad;

            //var nuevoProducto = new Producto
            //{
            //    codigo_producto = cod_product,
            //    nombre = nombre_product,
            //    precio_venta = precio,
            //};

            dataGridCartView.Rows.Add(nombre_product, cod_product, cantidad, subtotal);

            //ProductService productService = new ProductService();

            //List<Producto> productos = productService.getProductsService();

            //foreach (var prod in productos)
            //{
            //    dataGridCartView.Rows.Add(prod.nombre, prod.codigo_producto, prod.descripcion, prod.id_categoria, prod.stock, prod.id_estado);
            //}

        }
    }
}
