﻿using System;
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
            var cod_product = txtCartCodProduct.Text;
            var nombre_product = txtCartProducto.Text;
            var precio = txtCartPrecio.Text;
            var cantidad = dpCantidad.Text;

            

            if (!string.IsNullOrEmpty(cod_product) && !string.IsNullOrEmpty(nombre_product) &&
                !string.IsNullOrEmpty(precio) && !string.IsNullOrEmpty(cantidad))
            {
                var subtotal = int.Parse(precio) * int.Parse(cantidad);
                dataGridCartView.Rows.Add(nombre_product, cod_product, cantidad, subtotal);
            }

            //var nuevoProducto = new Producto
            //{
            //    codigo_producto = cod_product,
            //    nombre = nombre_product,
            //    precio_venta = precio,
            //};

            

            //ProductService productService = new ProductService();

            //List<Producto> productos = productService.getProductsService();

            //foreach (var prod in productos)
            //{
            //    dataGridCartView.Rows.Add(prod.nombre, prod.codigo_producto, prod.descripcion, prod.id_categoria, prod.stock, prod.id_estado);
            //}
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
            // Verifica si el índice de columna coincide con la columna del botón "cartEliminar"
            if (dataGridCartView.Columns[e.ColumnIndex].Name == "cartEliminar")
            {
                // Muestra un mensaje de confirmación
                var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Elimina la fila actual
                    dataGridCartView.Rows.RemoveAt(e.RowIndex);

                    // Llama a la función para recalcular el total después de eliminar un producto
                    CalcularTotal();
                }
            }
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
                        //txtCartStock.Text = (productoExiste.stock).ToString();
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
            var dni_cliente = txtCartViewDNI.Text;
            var cod_product = txtCartCodProduct.Text;
            var nombre_product = txtCartProducto.Text;
            var precio = txtCartPrecio.Text;
            var cantidad =dpCantidad.Text;

            if (!string.IsNullOrEmpty(cod_product) && !string.IsNullOrEmpty(nombre_product) &&
                !string.IsNullOrEmpty(precio) && !string.IsNullOrEmpty(cantidad) && !string.IsNullOrEmpty(dni_cliente))
            {
                ProductService productService = new ProductService();

                // Validar y convertir el código del producto
                if (int.TryParse(cod_product, out int codProducto))
                {
                    Producto prod = productService.getProductService(codProducto);

                    if (prod != null) // Asegurarse de que el producto existe
                    {

                        //Verificar si el codigo esta asociado con el nombre
                        if (prod.nombre != nombre_product)
                        {
                            var result = MessageBox.Show($"Código incorrecto\nEl código pertenece a: {prod.nombre}\n\n¿Deseas actualizar el nombre del producto?",
                            "Advertencia",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                txtCartCodProduct.Text = prod.codigo_producto.ToString();
                                txtCartProducto.Text = prod.nombre;
                                txtCartPrecio.Text = prod.precio_compra.ToString();
                                dpCantidad.Value = 1;
                                //dmCantidad.Maximum = prod.stock; // que no supere el maximo del producto
                                return;
                            }
                            else
                            {
                                txtCartCodProduct.Text = "";
                                txtCartProducto.Text = "";
                                txtCartPrecio.Text = "";
                                dpCantidad.Value = 1;
                                return;
                            }
                        }





                        var stockProducto = prod.stock;
                        // Aquí puedes continuar con tu lógica
                        Console.WriteLine($"Stock actual: {stockProducto}");

                        ////

                        var stockDisponible = prod.stock;

                        int cantidadEnGrid = 0;
                        foreach (DataGridViewRow row in dataGridCartView.Rows)
                        {
                            if (row.Cells["cartProducto"].Value != null && row.Cells["cartProducto"].Value.ToString() == prod.nombre)
                            {
                                cantidadEnGrid += Convert.ToInt32(row.Cells["cartCantidad"].Value);
                            }
                        }

                        int stockRestante = stockDisponible - cantidadEnGrid;


                        /////


                        if (stockRestante >= int.Parse(cantidad))
                        {
                            var subtotal = float.Parse(precio) * int.Parse(cantidad);


                            foreach (DataGridViewRow row in dataGridCartView.Rows)
                            {
                                if (row.Cells["cartProducto"].Value != null && row.Cells["cartProducto"].Value.ToString() == prod.nombre)
                                {
                                    int cantidadActial = Convert.ToInt32(row.Cells["cartCantidad"].Value);
                                    int nuevaCantidad = cantidadEnGrid + (int)dpCantidad.Value;
                                    row.Cells["cartCantidad"].Value = nuevaCantidad;
                                    subtotal = float.Parse(precio) * nuevaCantidad;
                                    row.Cells["cartSubtotal"].Value = subtotal;
                                    CalcularTotal();
                                    txtCartCodProduct.Text = "";
                                    txtCartProducto.Text = "";
                                    txtCartPrecio.Text = "";
                                    dpCantidad.Value = 1;
                                    return;
                                }
                            }


                            dataGridCartView.Rows.Add(nombre_product, precio, cantidad, subtotal);
                            txtCartCodProduct.Text = "";
                            txtCartProducto.Text = "";
                            txtCartPrecio.Text = "";
                            dpCantidad.Value = 1;
                            //txtCartStock.Text = "";
                            CalcularTotal();
                        }
                        else
                        {
                            MessageBox.Show($"La cantidad ingresada excede el stock disponible ({stockRestante}).",
                             "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Codigo de producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Console.WriteLine($"ERROR: NO SE PUEDO CONVERTIR EL COD_PRODUCTO A TIPO INT");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Campos vacios. Completalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CalcularTotal();



            //ProductService productService = new ProductService();
            //Producto prodEncontrado = productService.getProductService(int.Parse(cod_product));
            //prodEncontrado.stock -= int.Parse(cantidad);
            //productService.updateProductService(prodEncontrado);
            //Console.WriteLine("Producto modif");


            //ProductService productService = new ProductService();

            //List<Producto> productos = productService.getProductsService();

            //foreach (var prod in productos)
            //{
            //    dataGridCartView.Rows.Add(prod.nombre, prod.codigo_producto, prod.descripcion, prod.id_categoria, prod.stock, prod.id_estado);
            //}

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            Form metodoPago = new metodoPago(this);
        }

        public void CalcularTotal()
        {
            decimal total = 0;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow row in dataGridCartView.Rows)
            {
                // Verifica que la fila no sea la fila vacía al final del DataGridView
                if (row.Cells["cartSubtotal"].Value != null)
                {
                    // Intenta convertir el valor de la columna 'cartSubtotal' a decimal y acumularlo
                    decimal subtotal;
                    if (decimal.TryParse(row.Cells["cartSubtotal"].Value.ToString(), out subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            // Asigna el total calculado al TextBox txtTotal
            txtTotal.Text = total.ToString(); // Formato de dos decimales
        }

        private void btnPago_Click(object sender, EventArgs e)
        {

            if (dataGridCartView.Rows.Count == 0 || (dataGridCartView.Rows.Count == 1 && dataGridCartView.Rows[0].IsNewRow))
            {
                MessageBox.Show("Carrito vacío. Agrega productos antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(txtTotal.Text))
            {
                MessageBox.Show("Debes cargar productos al carrito para realizar el pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                metodoPago metodoPagoForm = new metodoPago(this);
                metodoPagoForm.Show();
            }
        }

        public void clearPantalla()
        {
            txtCartNombreCliente.Text = "";
            txtCartViewDNI.Text = "";

            //txtCartStock.Text = "";
            txtCartProducto.Text = "";
            txtCartPrecio.Text = "";
            txtCartCodProduct.Text = "";

            txtTotal.Text = "";

            dataGridCartView.Rows.Clear();
        }
    }
}
