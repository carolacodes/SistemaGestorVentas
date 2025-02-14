using SistemaGestorDeVentas.api.cart;
using SistemaGestorDeVentas.api.product;
using SistemaGestorDeVentas.api.proveedor;
using SistemaGestorDeVentas.api.user;
using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SistemaGestorDeVentas.api.compra.compraProducto;
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

        private string email = UsuarioEmail;
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

            UserService userService = new UserService();
            Usuario usuario = userService.getUserByEmail(email);
            string nombreUser = usuario.nombre;
            txtCorreoUser.Text = email;
            txtUser.Text = nombreUser;

            //foreach (var proveedor in proveedores)
            //{
            //    cbProveedores.Items.Add(proveedor.nombre);
            //}

            var cod_product = txtCartCodProduct.Text;
            var nombre_product = txtCartProducto.Text;
            var precio = txtCartPrecio.Text;
            var cantidad = dmCantidad.Text;

            ////--------------------------------------------------------------------------------------------
            //ProductService productService = new ProductService();

            //// Validar y convertir el código del producto
            //if (int.TryParse(cod_product, out int codProducto))
            //{
            //    Producto prod = productService.getProductService(codProducto);

            //    if (prod != null) // Asegurarse de que el producto existe
            //    {
            //        var stockProducto = prod.stock;
            //        // Aquí puedes continuar con tu lógica
            //        Console.WriteLine($"Stock actual: {stockProducto}");
            //    }
            //    else
            //    {
            //        MessageBox.Show("El producto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("El código de producto debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //// Configuración del NumericUpDown
            //dmCantidad1.Minimum = 1;      // Valor mínimo
            //dmCantidad1.Maximum = 100;    // Valor máximo
            //dmCantidad1.Increment = 1;    // Incremento de 1
            //dmCantidad1.Value = 1;        // Valor inicial
            //dmCantidad1.ReadOnly = true;  // Evita que el usuario escriba texto directamente

            ////----------------------------------------------------------------------------------------------


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
            var userNombre = txtUser.Text;
            var userCorreo = txtCorreoUser.Text;
            ProductService productService = new ProductService();
            if (!string.IsNullOrEmpty(cod_product) && !string.IsNullOrEmpty(nombre_product) &&
                !string.IsNullOrEmpty(precio) && !string.IsNullOrEmpty(cantidad) &&
                !string.IsNullOrEmpty(userNombre) && !string.IsNullOrEmpty(userCorreo))

            {
                if(int.TryParse(cod_product, out int codProducto))
                {
                    Producto prod = productService.getProductService(codProducto);
                    


                    //agrega al datagrid
                    if (prod != null)
                    {
                        //Verificar si el codigo esta asociado con el nombre
                        if (prod.nombre != nombre_product)
                        {
                            var result = MessageBox.Show($"Código incorrecto\nEl código pertenece a: {prod.nombre}\n\n¿Deseas actualizar el nombre del producto?",
                            "Advertencia",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Warning);
                            if(result == DialogResult.Yes)
                            {
                                txtCartCodProduct.Text = prod.codigo_producto.ToString();
                                txtCartProducto.Text = prod.nombre;
                                txtCartPrecio.Text = prod.precio_compra.ToString();
                                dmCantidad.Value = 1;
                                //dmCantidad.Maximum = prod.stock; // que no supere el maximo del producto
                                return;
                            }
                            else
                            {
                                txtCartCodProduct.Text = "";
                                txtCartProducto.Text = "";
                                txtCartPrecio.Text = "";
                                dmCantidad.Value = 1;
                                return;
                            }
                        }

                        var stockDisponible = prod.stock;

                        int cantidadEnGrid = 0;
                        foreach (DataGridViewRow row in dataGridCartView.Rows)
                        {
                            if (row.Cells["CompraProdutProducto"].Value != null && row.Cells["CompraProdutProducto"].Value.ToString() == prod.nombre)
                            {
                                cantidadEnGrid += Convert.ToInt32(row.Cells["CompraProdutCantidad"].Value);
                            }
                        }

                       // int stockRestante = stockDisponible - cantidadEnGrid; 

                        
                            var subtotal = float.Parse(precio) * int.Parse(cantidad);
                            foreach (DataGridViewRow row in dataGridCartView.Rows)
                            {
                                if (row.Cells["CompraProdutProducto"].Value != null && row.Cells["CompraProdutProducto"].Value.ToString() == prod.nombre)
                                {
                                    int cantidadActial = Convert.ToInt32(row.Cells["CompraProdutCantidad"].Value);
                                    int nuevaCantidad = cantidadEnGrid + (int)dmCantidad.Value;
                                    row.Cells["CompraProdutCantidad"].Value = nuevaCantidad;
                                    subtotal = float.Parse(precio) * nuevaCantidad;
                                    row.Cells["CompraProdutSubtotal"].Value = subtotal;
                                    CalcularTotal();
                                    txtCartCodProduct.Text = "";
                                    txtCartProducto.Text = "";
                                    txtCartPrecio.Text = "";
                                    dmCantidad.Value = 1;
                                    return;
                                }
                            }

                            
                            dataGridCartView.Rows.Add(nombre_product, precio, cantidad, subtotal);
                            txtCartCodProduct.Text = "";
                            txtCartProducto.Text = "";
                            txtCartPrecio.Text = "";
                            dmCantidad.Value = 1;
                            //dmCantidad.Maximum = Convert.ToDecimal(prod.stock);
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

                CalcularTotal();
            }
            else
            {
                MessageBox.Show("ERROR: Campos vacios. Completalos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        public class productCantidad
        {
            public int ProductoId { get; set; }
            public int cantidad { get; set; }
        }

        /* private void btnRegistrarCompra_Click(object sender, EventArgs e)
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

             Usuario usuario = userService.getUserByEmail(email);


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
             List<productCantidad> productosCompraClass = new List<productCantidad>();
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
                         productosCompraClass.Add(new productCantidad
                         {
                             ProductoId = productoCompra.id_producto,
                             cantidad = productoCompra.cantidad
                         });
                         // Añade el producto a la lista de productos de compra
                         //productosCompra.Add(productoCompra);

                     }
                 }
             }

             foreach (var ProductoDatos in productosCompraClass)
             {
                 ProductService productoService = new ProductService();

                 Producto producto = productService.getProductService(ProductoDatos.ProductoId);
                 producto.stock = producto.stock - ProductoDatos.cantidad;
                 productService.updateProductService(producto);
             }
             MessageBox.Show("Se registros la compra de productos correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
         }*/

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {

            if (dataGridCartView.Rows.Count == 0 || (dataGridCartView.Rows.Count == 1 && dataGridCartView.Rows[0].IsNewRow))
            {
                MessageBox.Show("Carrito vacío. Agrega productos antes de registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cod_prod = txtCartCodProduct.Text;

            // Reemplaza la validación de código de producto si es necesario
            // Si el producto existe o no, realiza las verificaciones necesarias

            DateTime fechaCompra = dateCartViewFecha.Value;
            UserService userService = new UserService();
            Usuario usuario = userService.getUserByEmail(email);
            ProductService productService = new ProductService();
            Compra compra = new Compra
            {
                DNI_usuario = usuario.DNI_usuario,
                fecha_compra = fechaCompra,
            };

            CompraService compraService = new CompraService();
            Compra nuevaCompra = compraService.crearCompra(compra);

            ProductoCompraService productoCompraService = new ProductoCompraService();
            List<productCantidad> productosCompraClass = new List<productCantidad>();

            foreach (DataGridViewRow fila in dataGridCartView.Rows)
            {
                if (fila.IsNewRow) continue;  // Ignora la nueva fila

                var valorCeldaProducto = fila.Cells["CompraProdutProducto"].Value.ToString();
                var cantidadProd = fila.Cells["CompraProdutCantidad"].Value.ToString();

                if (!string.IsNullOrEmpty(valorCeldaProducto) && int.TryParse(cantidadProd, out int cantidadInt))
                {
                    Producto produc = productService.getProductServiceByName(valorCeldaProducto);

                    if (produc != null)
                    {
                        Producto_Compra productoCompra = new Producto_Compra
                        {
                            id_compra = nuevaCompra.id_compra,
                            id_producto = produc.codigo_producto,
                            cantidad = cantidadInt
                        };

                        ProductoCompraService prodCompraService = new ProductoCompraService();
                        prodCompraService.createProductoCompraService(productoCompra);

                        productosCompraClass.Add(new productCantidad
                        {
                            ProductoId = productoCompra.id_producto,
                            cantidad = productoCompra.cantidad
                        });
                    }
                }
            }

            //// Actualiza el stock de los productos en la base de datos
            //using (var context = new sistema_de_ventas_taller_Entities())
            //{
            //    try
            //    {
            //        foreach (var ProductoDatos in productosCompraClass)
            //        {
            //            Producto producto = context.Producto.Find(ProductoDatos.ProductoId);
            //            if (producto != null)
            //            {
            //                producto.stock += ProductoDatos.cantidad; // Actualiza el stock
            //                context.SaveChanges();  // Guarda los cambios de manera sincrónica
            //            }
            //        }

            //        MessageBox.Show("Se registró la compra de productos correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error al actualizar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

            sistema_de_ventas_taller_Entities context = null;
            try
            {
                context = new sistema_de_ventas_taller_Entities();

                foreach (var ProductoDatos in productosCompraClass)
                {
                    Producto producto = context.Producto.Find(ProductoDatos.ProductoId);
                    if (producto != null)
                    {
                        producto.stock += ProductoDatos.cantidad; // Actualiza el stock
                        context.SaveChanges();  // Guarda los cambios de manera sincrónica
                    }
                }

                MessageBox.Show("Se registró la compra de productos correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Liberación de recursos en el bloque finally
                if (context != null)
                {
                    context.Dispose();
                }
            }

            clearPantalla();

            adminGestionProduct.ActualizarDatosProductos();
        }

        private void clearPantalla()
        {
            dataGridCartView.Rows.Clear();
            txtTotal.Text = "";
        }


        private void dmCantidad_SelectedItemChanged(object sender, EventArgs e)
        {
        //    // Obtén el valor actual como entero
        //    int currentValue = int.Parse(dmCantidad.SelectedItem.ToString());
        //    Console.WriteLine("Valor actual: " + currentValue);
        }

        private void dmCantidad1_ValueChanged(object sender, EventArgs e)
        {
            //int currentValue = (int)dmCantidad1.Value;
            //Console.WriteLine("Valor actual: " + currentValue);
            
        }

        private void dmCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
