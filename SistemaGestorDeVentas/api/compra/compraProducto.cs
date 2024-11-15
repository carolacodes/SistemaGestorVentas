using SistemaGestorDeVentas.api.product;
using SistemaGestorDeVentas.api.proveedor;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaGestorDeVentas.api.compra
{
    public partial class compraProducto : Form
    {
        public static string UsuarioEmail { get; set; }
        public compraProducto()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
           
            var cod_prod = txtCartCodProduct.Text;
            if (string.IsNullOrEmpty(cod_prod))
            {
                buscarProducto buscarProductoForm = new buscarProducto(null, this);
                buscarProductoForm.Show();
            }
            else
            {
                CompraService compraService = new CompraService();

                ProductService productService = new ProductService();
                Producto productoExiste = productService.getProductService(int.Parse(cod_prod));

                //Producto_Compra producto_Compra = compraService.GetProductoCompra()
                if (productoExiste != null)
                {
                    //obtengo fecha compra
                    //DateTime fechaCompra = dateCartViewFecha.Value;

                    //Compra compra = new Compra
                    //{
                    //    DNI_usuario = UsuarioEmail,
                    //    fecha_compra = fechaCompra,
                    //};

                    txtCartCodProduct.Text = productoExiste.codigo_producto.ToString();
                    txtCartProducto.Text = productoExiste.nombre;
                    txtCartPrecio.Text = productoExiste.precio_compra.ToString();
                    var cantidad = dmCantidad.ToString();

                    //Producto_Compra producto_Compra = new Producto_Compra
                    //{
                    //    id_compra = compra.id_compra,
                    //    id_producto = productoExiste.codigo_producto,
                    //    cantidad = int.Parse(cantidad)
                    //};
                }
                else
                {
                    MessageBox.Show("Codigo de producto no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void cbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void compraProducto_Load(object sender, EventArgs e)
        {
            ProveedorServices proveedorServices = new ProveedorServices();

            List<Proveedor> proveedores = proveedorServices.getProveedores();

            foreach (var proveedor in proveedores)
            {
                cbProveedores.Items.Add(proveedor.nombre);
            }

            var cod_product = txtCartCodProduct.Text;
            var nombre_product = txtCartProducto.Text;
            var precio = txtCartPrecio.Text;
            var cantidad = dmCantidad.Text;

            if (!string.IsNullOrEmpty(cod_product) && !string.IsNullOrEmpty(nombre_product) &&
                !string.IsNullOrEmpty(precio) && !string.IsNullOrEmpty(cantidad))
            {
                var subtotal = float.Parse(precio) * int.Parse(cantidad);
                dataGridCartView.Rows.Add(nombre_product, precio, cantidad, subtotal);

                //txtCartStock.Text = "";
            }

            Console.WriteLine("email desde compra para compra producto" + UsuarioEmail);
        }

        private void btnAgregarCompraView_Click(object sender, EventArgs e)
        {
            var cod_product = txtCartCodProduct.Text;
            var nombre_product = txtCartProducto.Text;
            var precio = txtCartPrecio.Text;
            var cantidad = dmCantidad.Text;

            if (!string.IsNullOrEmpty(cod_product) && !string.IsNullOrEmpty(nombre_product) &&
                !string.IsNullOrEmpty(precio) && !string.IsNullOrEmpty(cantidad))
            {
                var subtotal = float.Parse(precio) * int.Parse(cantidad);
                dataGridCartView.Rows.Add(nombre_product, precio, cantidad, subtotal);
                txtCartCodProduct.Text = "";
                txtCartProducto.Text = "";
                txtCartPrecio.Text = "";
                //txtCartStock.Text = "";
                txtPrecioVenta.Text = "";
                //txtCartStock.Text = "";
            }

            CalcularTotal();
            

        }

        public void CalcularTotal()
        {
            decimal total = 0;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow row in dataGridCartView.Rows)
            {
                // Verifica que la fila no sea la fila vacía al final del DataGridView
                if (row.Cells["CompraProdutSubtotal"].Value != null)
                {
                    // Intenta convertir el valor de la columna 'cartSubtotal' a decimal y acumularlo
                    decimal subtotal;
                    if (decimal.TryParse(row.Cells["CompraProdutSubtotal"].Value.ToString(), out subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            // Asigna el total calculado al TextBox txtTotal
            txtTotal.Text = total.ToString(); // Formato de dos decimales
        }

        private void dataGridCartView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el índice de columna coincide con la columna del botón "cartEliminar"
            if (dataGridCartView.Columns[e.ColumnIndex].Name == "CompraProdutEliminar")
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

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            var cod_prod = txtCartCodProduct.Text;

            //if (string.IsNullOrEmpty(cod_prod) || !int.TryParse(cod_prod, out int codigoProducto))
            //{
            //    MessageBox.Show("Por favor, ingrese un código de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return; // Salimos del método si el código de producto no es válido
            //}

            //var cantidad = dmCantidad.ToString(); 
            //CompraService compraService = new CompraService();

            ProductService productService = new ProductService();
            //// Intentamos obtener el producto con el código especificado
            //Producto productoExiste = productService.getProductService(codigoProducto);
            //if (productoExiste == null)
            //{
            //    MessageBox.Show("El producto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return; // Salimos del método si el producto no se encuentra
            //}

            DateTime fechaCompra = dateCartViewFecha.Value;
            UserService userService = new UserService();
            Usuario usuario = userService.getUserByEmail(UsuarioEmail);


            Compra compra = new Compra
            {
                DNI_usuario = usuario.DNI_usuario,
                fecha_compra = fechaCompra,
            };

            CompraService compraService = new CompraService();

            Compra nuevaCompra = compraService.crearCompra(compra);
            //List<Producto> productos = new List<Producto>();

            //foreach (DataGridCell dataGrid in dataGridCartView.Rows)
            //{
            //    var nombreProduct = productoExiste.nombre;
            //    var valorCelda = dataGridCartView.Rows[0].Cells["CompraProdutProducto"].Value;
            //    if (nombreProduct == valorCelda.ToString())
            //    {
            //        Producto_Compra producto_Compra = new Producto_Compra
            //        {
            //            id_compra = compra.id_compra,
            //            id_producto = productoExiste.codigo_producto,
            //            cantidad = int.Parse(cantidad)
            //        };
            //    }
            //}

            // Lista para almacenar los productos_compra
            //List<Producto_Compra> productosCompra = new List<Producto_Compra>();
            ProductoCompraService productoCompraService = new ProductoCompraService();

            foreach (DataGridViewRow fila in dataGridCartView.Rows)
            {
                // Asegúrate de que la fila no esté vacía (por ejemplo, si la fila es la nueva fila al final de un DataGridView)
                if (fila.IsNewRow) continue;

                // Obtiene los valores de las celdas correspondientes en la fila
                var valorCeldaProducto = fila.Cells["CompraProdutProducto"].Value.ToString();
                var cantidadProd = fila.Cells["CompraProdutCantidad"].Value.ToString();

                //var cantidad = Convert.ToString(fila.Cells["CompraProdutCantidad"].Value);

                if (!string.IsNullOrEmpty(valorCeldaProducto) && int.TryParse(cantidadProd, out int cantidadInt))
                {
                    // Obtén el producto usando el nombre u otro identificador, según cómo obtienes el producto.
                    //Producto productoExiste = productService.getProductServiceByName(valorCeldaProducto);

                    Producto produc = productService.getProductServiceByName(valorCeldaProducto);

                    if (produc != null)
                    {
                        Producto_Compra productoCompra = new Producto_Compra
                        {
                            id_compra = nuevaCompra.id_compra,
                            id_producto = produc.codigo_producto,
                            cantidad = cantidadInt
                        };

                        // Añade el producto a la lista de productos de compra
                        //productosCompra.Add(productoCompra);
                        productoCompraService.createProductoCompraService(productoCompra);
                    }
                }
            }
            MessageBox.Show("Se registros la compra de productos correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
