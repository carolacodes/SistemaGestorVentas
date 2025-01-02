using SistemaGestorDeVentas.api.cart;
using SistemaGestorDeVentas.api.category;
using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.api.compra;
using SistemaGestorDeVentas.components;
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

namespace SistemaGestorDeVentas.api.product
{
    public partial class buscarProducto : Form
    {
        private cartView _carritoForm;
        private compraProducto _compraProductoForm;
        public buscarProducto(cartView cartViewForm = null, compraProducto compraProdForm = null)
        {
            InitializeComponent();
            _carritoForm = cartViewForm;
            _compraProductoForm = compraProdForm;

        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            // Obtener el DNI del cliente ingresado
            var cod_product = txtBuscarProd.Text;

            // Verificar si el DNI está vacío
            if (string.IsNullOrEmpty(cod_product))
            {
                MessageBox.Show("Por favor, ingrese codigo valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nombre_product= txtBuscarProd.Text;
            if (string.IsNullOrEmpty(nombre_product))
            {
                MessageBox.Show("Por favor, ingrese un nombre valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de ClienteService
            ProductService productService = new ProductService();

            CategoriaService categoriaService = new CategoriaService();

            try
            {
                int indiceSeleccionado = cbBuscarProd.SelectedIndex;
                if (indiceSeleccionado == 0)
                {
                    // Llamar al método para obtener el cliente con el DNI ingresado
                    //Cliente clienteExiste = clienteService.getCliente(dniCliente);

                    Producto productoExiste = productService.getProductService(int.Parse(cod_product));
                    //int idCategoriaProd = productoExiste.id_categoria;
                    //Categoria categoriaExiste = categoriaService.getCategoria(idCategoriaProd);
                    // Limpiar las filas actuales del DataGridView
                    dataGridBuscarProd.Rows.Clear();

                    // Verificar si el cliente existe
                    if (productoExiste != null)
                    {
                        // Si el cliente existe, mostrar los datos en el DataGridView
                        //dataGridBuscarCliente.DataSource = new List<Cliente> { cliente }; // Usamos una lista con un solo cliente

                        dataGridBuscarProd.Rows.Add(productoExiste.nombre, productoExiste.codigo_producto, productoExiste.descripcion, categoriaService.getCategoria(productoExiste.id_categoria).nombre, productoExiste.stock, productoExiste.id_estado);

                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún producto con el codigo proporcionado. Por favor vuelva a ingresar el DNI", "Cliente No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        List<Producto> productos = productService.getProductsService();

                        foreach (var prod in productos)
                        {
                            dataGridBuscarProd.Rows.Add(prod.nombre, prod.codigo_producto, prod.descripcion, categoriaService.getCategoria(prod.id_categoria).nombre, prod.stock, prod.id_estado);
                        }
                    }
                }
                else
                {
                    // Llamar al método para obtener el producto por nombre
                    List<Producto> productos = productService.getProductByName(nombre_product);

                    // Limpiar las filas actuales del DataGridView
                    dataGridBuscarProd.Rows.Clear();

                    // Verificar si el cliente existe
                    if (productos != null)
                    {
                        foreach (var prod in productos)
                        {
                            dataGridBuscarProd.Rows.Add(prod.nombre, prod.codigo_producto, prod.descripcion, categoriaService.getCategoria(prod.id_categoria).nombre, prod.stock, prod.precio_venta);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún cliente con el DNI proporcionado. Por favor vuelva a ingresar el DNI", "Cliente No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (var prod in productos)
                        {
                            dataGridBuscarProd.Rows.Add(prod.nombre, prod.codigo_producto, prod.descripcion, categoriaService.getCategoria(prod.id_categoria).nombre, prod.stock, prod.precio_venta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturar excepciones y mostrar mensaje de error
                MessageBox.Show($"Error al intentar obtener el Producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buscarProducto_Load(object sender, EventArgs e)
        {
            try
            {
                //ClienteService clienteService = new ClienteService();
                CategoriaService categoriaService = new CategoriaService();
                ProductService productService = new ProductService();

                List<Producto> productos = productService.getProductsService();

                foreach (var prod in productos)
                {
                    Console.WriteLine("stock: " + prod.stock);
                    if(_carritoForm != null && _carritoForm.Visible)
                    {
                        dataGridBuscarProd.Rows.Add(prod.nombre, prod.codigo_producto, prod.descripcion, categoriaService.getCategoria(prod.id_categoria).nombre, prod.stock, prod.precio_venta);
                    }
                    if (_compraProductoForm != null && _compraProductoForm.Visible)
                    {
                        dataGridBuscarProd.Rows.Add(prod.nombre, prod.codigo_producto, prod.descripcion, categoriaService.getCategoria(prod.id_categoria).nombre, prod.stock, prod.precio_compra);

                    }
                        
                }

                //dataGridBuscarCliente.DataSource = clientes;
                // Opcional: Ajustar el formato de las columnas si es necesario
                //dataGridBuscarCliente.AutoGenerateColumns = true; // Esto genera las columnas automáticamente basándose en las propiedades de la clase Cliente
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewProd_Click(object sender, EventArgs e)
        {
            //Form gestionCliente = new detalleCliente();


            this.Close();
            if (_carritoForm != null && _carritoForm.Visible)
            {
                _carritoForm.Close();
            }
            if (_compraProductoForm != null && _compraProductoForm.Visible)
            {
                _compraProductoForm.Close();
            }

                //Form navbar = new navegador();
                ////opcion 1
                //navbar.clientesToolStripMenuItem_Click(object sender, EventArgs e);

                ////opcion 2
                ////// Verificar si el formulario detalleCliente ya está abierto
                //Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is detalleCliente);

                //if (existingForm != null)
                //{
                //    // Si ya está abierto, traerlo al frente
                //    existingForm.BringToFront();
                //}
                //else
                //{
                //    // Si no está abierto, crear una nueva instancia

                //    detalleCliente gestionCliente = new detalleCliente();

                //    navbar = gestionCliente.MdiParent;
                //    gestionCliente.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                //    gestionCliente.Show();



                //}

                // Busca la instancia abierta de navegador
                Form navegadorForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is navegador);

            if (navegadorForm != null)
            {
                // Llama al método para abrir el formulario de detalleCliente
                ((navegador)navegadorForm).productosToolStripMenuItem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró el formulario de navegación principal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridBuscarProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //me aseguro de que se hizo click en una fila valida
            if (e.RowIndex >= 0)
            {
                //obtengo la fila que selecciono el cliente
                DataGridViewRow row = dataGridBuscarProd.Rows[e.RowIndex];

                if (_carritoForm != null && _carritoForm.Visible)
                {
                    // Asigna los valores directamente a los TextBox en _carritoForm
                    _carritoForm.txtCartCodProduct.Text = row.Cells["detalleProductoCodigo"].Value.ToString();
                    _carritoForm.txtCartProducto.Text = row.Cells["detalleProductoNombre"].Value.ToString();
                    _carritoForm.txtCartPrecio.Text = row.Cells["detalleProductoPrecio"].Value.ToString();
                    //_carritoForm.txtCartStock.Text = row.Cells["detalleProductoStock"].Value.ToString();
                }
                //_compraProductoForm
                // Verifico si _compraProductoForm no es nulo y está visible antes de asignar los valores
                if (_compraProductoForm != null && _compraProductoForm.Visible)
                {
                    _compraProductoForm.txtCartCodProduct.Text = row.Cells["detalleProductoCodigo"].Value.ToString();
                    _compraProductoForm.txtCartProducto.Text = row.Cells["detalleProductoNombre"].Value.ToString();
                    _compraProductoForm.txtCartPrecio.Text = row.Cells["detalleProductoPrecio"].Value.ToString();
                    //_compraProductoForm.txtCartStock.Text = row.Cells["detalleProductoStock"].Value.ToString();
                }

                    this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarBP_Click(object sender, EventArgs e)
        {
            txtBuscarProd.Text = "";
            buscarProducto_Load(sender, e);
        }
    }
}
