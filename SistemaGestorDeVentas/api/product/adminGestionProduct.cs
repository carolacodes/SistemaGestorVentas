using SistemaGestorDeVentas.api.category;
using SistemaGestorDeVentas.api.proveedor;
using SistemaGestorDeVentas.db;
using SistemaGestorDeVentas.middleware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.product
{
    public partial class adminGestionProduct : Form
    {
        public adminGestionProduct()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtProductPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla es un número, la tecla de retroceso o el punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela la acción, no permite la entrada
            }

            // Si el punto decimal ya ha sido ingresado, no permitir otro punto
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Cancela la acción
            }
        }

        private void txtProductStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la acción, no permite la entrada
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Verificar si se proporcionó un código válido
            if (string.IsNullOrWhiteSpace(txtProductCodigo.Text))
            {
                MessageBox.Show("El campo Codigo es obligatorio.");
                txtProductCodigo.Focus();
                return;
            }
            


            // Validar TextBox de Nombre
            if (string.IsNullOrWhiteSpace(txtProductNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                txtProductNombre.Focus();
                return;
            }   

            // Validar longitud mínima del campo Nombre (al menos 3 caracteres)
            if (txtProductNombre.Text.Length < 3)
            {
                MessageBox.Show("El Nombre debe tener al menos 3 caracteres.");
                txtProductNombre.Focus();
                return;
            }

            // Validar que el campo Precio sea numérico
            if (!decimal.TryParse(txtProductPrecioVenta.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un valor válido para el Precio.");
                txtProductPrecioVenta.Focus();
                return;
            }

            if (!decimal.TryParse(txtProductPrecioCompra.Text, out decimal precioCompra) || precioCompra <= 0)
            {
                MessageBox.Show("Ingrese un valor válido para el Precio.");
                txtProductPrecioVenta.Focus();
                return;
            }

            // Validar el campo Stock como numérico
            if (!int.TryParse(txtProductStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El Stock debe ser un número entero positivo.");
                txtProductStock.Focus();
                return;
            }
            
            // Validar ComboBox de Categoría
            if (cboxProductCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Categoría.");
                cboxProductCategoria.Focus();
                return;
            }

            // Validar ComboBox de Estado
            if (cboxProductEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Estado.");
                cboxProductEstado.Focus();
                return;
            }



            
            string nombreProducto = txtProductNombre.Text;
            string codigoProducto = txtProductCodigo.Text;
            string descripcionProducto = txtProductDescripcion.Text;
            int categoriaProducto = (int)cboxProductCategoria.SelectedValue;
            int proveedorProducto = (int)cbProveedor.SelectedValue;
            string precioProductoVenta = txtProductPrecioVenta.Text; // marca error
            string precioProductoCompra = txtProductPrecioCompra.Text;
            string stockProducto = txtProductStock.Text; //marca error
            int estadoProducto = (int)cboxProductEstado.SelectedValue; // marca error

            try
            {
                Producto nuevoProducto = new Producto
                {
                    codigo_producto = int.Parse(codigoProducto),
                    nombre = nombreProducto,
                    descripcion = descripcionProducto,
                    id_categoria = categoriaProducto,
                    id_proveedor = proveedorProducto,
                    precio_compra = decimal.Parse(precioProductoCompra),
                    precio_venta = decimal.Parse(precioProductoVenta),
                    stock = int.Parse(stockProducto),
                    id_estado = estadoProducto,
                };

                ProductService productService = new ProductService();

                if (productService.getProductService(nuevoProducto.codigo_producto) == null)
                {
                    productService.createProductService(nuevoProducto);
                    MessageBox.Show("Producto registrado exitosamente");
                    adminGestionProduct_Load(sender, e);
                    return;
                }
                else {
                    Producto productoEncontrado = productService.getProductService(nuevoProducto.codigo_producto);
                    DialogResult result = MessageBox.Show(
                       "El código del producto ya existe. ¿Desea modificar este producto: " + productoEncontrado.nombre + " ? " ,
                       "Confirmación",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
   );

                    if (result == DialogResult.Yes)
                    {
                        // Proceder con la actualización
                        productService.updateProductService(nuevoProducto);
                        MessageBox.Show("Producto modificado exitosamente");
                        adminGestionProduct_Load(sender, e);
                        return;
                    }
                    else
                    {
                        // Cancelar la operación
                        MessageBox.Show("La modificación del producto ha sido cancelada.");
                        return;
                    }
                }



            }
            catch (Exception ex) {
                MessageBox.Show("Error al guardar un producto en la base de datos: " + ex.Message);
            }
        }

        private void txtProductCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductStock_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProductCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la acción, no permite la entrada
            }
        }

        private void txtProductNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es una letra, no es borrar, no es espacio entonces bloquea
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Bloquear caracteres que no sean letras o espacios
            }
        }

        private void txtProductDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es una letra, no es borrar, no es espacio entonces bloquea
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Bloquear caracteres que no sean letras o espacios
            }
        }

        private void limpiar()
        {
            txtProductCodigo.Clear();
            txtProductStock.Clear();
            txtProductNombre.Clear();
            txtProductDescripcion.Clear();
            txtProductPrecioVenta.Clear();
            txtProductPrecioCompra.Clear();
            txtProductStock.Clear();
            cboxProductCategoria.SelectedIndex = -1;
            cboxProductEstado.SelectedIndex = -1;
            cbProveedor.SelectedIndex = -1;
            // Si no está enlazado a una fuente de datos
            dataGrid_productos.Rows.Clear();

            // Si está enlazado a una fuente de datos
            dataGrid_productos.DataSource = null;

            // Opcional: Refrescar el control
            dataGrid_productos.Refresh();
        }
        public void adminGestionProduct_Load(object sender, EventArgs e)
        {
            EstadoService estadoService = new EstadoService();
            ProductService productService = new ProductService();
            CategoriaService categoriaService = new CategoriaService();
            ProveedorServices proveedorServices = new ProveedorServices();
            var estados = estadoService.getEstados();
            List<Proveedor> proveedores = proveedorServices.getProveedores();
            var categorias = categoriaService.getCategorias();



            cboxProductEstado.DataSource = estados;
            cboxProductEstado.DisplayMember = "nombre";
            cboxProductEstado.ValueMember = "id_estado";

            cbProveedor.DataSource = proveedores;
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.ValueMember = "id_proveedor";

            cboxProductCategoria.DataSource = categorias;
            cboxProductCategoria.DisplayMember = "nombre";
            cboxProductCategoria.ValueMember = "id_categoria";


            //cboxProductCategoria.SelectedIndex = -1;
            //cboxProductEstado.SelectedIndex = -1;
            //cbProveedor.SelectedIndex = -1;
            limpiar();

            var productos = productService.getProductsService();

            foreach (var producto in productos)
            {
                dataGrid_productos.Rows.Add(producto.nombre, producto.codigo_producto, producto.descripcion, categoriaService.getCategoria(producto.id_categoria).nombre, producto.precio_compra, producto.precio_venta, producto.stock, estadoService.getEstado(producto.id_estado).nombre, proveedorServices.getProveedor(producto.id_proveedor).nombre);
            }

            OrdenarPorCodigo();
        }

        private void OrdenarPorCodigo()
        {
            // Verifica si la columna "codigo_producto" existe
            if (dataGrid_productos.Columns["detalleProductoCodigo"] != null)
            {
                // Ordenar la columna "codigo_producto" en orden descendente
                dataGrid_productos.Sort(dataGrid_productos.Columns["detalleProductoCodigo"], System.ComponentModel.ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("La columna 'detalleProductoCodigo' no existe en el DataGridView.");
            }
        }
        private void dataGrid_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que se ha hecho clic en una fila válida
            if (e.RowIndex >= 0)
            {
                var estadoService = new EstadoService();
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGrid_productos.Rows[e.RowIndex];


                txtProductNombre.Text = row.Cells["detalleProductoNombre"].Value.ToString();
                txtProductCodigo.Text = row.Cells["detalleProductoCodigo"].Value.ToString();
                txtProductDescripcion.Text = row.Cells["detalleProductoDescripcion"].Value.ToString();
                txtProductPrecioVenta.Text = row.Cells["precio_venta"].Value.ToString();
                txtProductStock.Text = row.Cells["detalleProductoStock"].Value.ToString();
                txtProductPrecioCompra.Text = row.Cells["detalleProductoPrecio_compra"].Value.ToString();

                string nombreEstado = row.Cells["detalleProductoEstado"].Value.ToString();
                int? estadoID = estadoService.GetEstadoIdByNombre(nombreEstado);

                cboxProductEstado.SelectedValue = estadoID;

                CategoriaService categoriaService = new CategoriaService();


                string categorianombre = row.Cells["detalleProductoCategoria"].Value.ToString();
                var categoria = categoriaService.getCategoriaPorNombre(categorianombre);
                int? categoriaID = categoria.id_categoria;

                cboxProductCategoria.SelectedValue = categoriaID;


                ProveedorDao pro = new ProveedorDao();
                string proveedorNombre = row.Cells["proveedor"].Value.ToString();
                int? proveedorID = pro.GetProveedorIdByName(proveedorNombre);
                cbProveedor.SelectedValue = proveedorID;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProductDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProductLimpiar_Click(object sender, EventArgs e)
        {
            adminGestionProduct_Load(sender, e);
        }

        private void btnProductEliminar_Click(object sender, EventArgs e)
        {
            // Validar TextBox de Nombre
            if (string.IsNullOrWhiteSpace(txtProductNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                txtProductNombre.Focus();
                return;
            }

            // Validar longitud mínima del campo Nombre (al menos 3 caracteres)
            if (txtProductNombre.Text.Length < 3)
            {
                MessageBox.Show("El Nombre debe tener al menos 3 caracteres.");
                txtProductNombre.Focus();
                return;
            }

            // Validar que el campo Precio sea numérico
            if (!decimal.TryParse(txtProductPrecioVenta.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un valor válido para el Precio.");
                txtProductPrecioVenta.Focus();
                return;
            }

            if (!decimal.TryParse(txtProductPrecioCompra.Text, out decimal precioCompra) || precioCompra <= 0)
            {
                MessageBox.Show("Ingrese un valor válido para el Precio.");
                txtProductPrecioVenta.Focus();
                return;
            }

            // Validar el campo Stock como numérico
            if (!int.TryParse(txtProductStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El Stock debe ser un número entero positivo.");
                txtProductStock.Focus();
                return;
            }

            // Validar ComboBox de Categoría
            if (cboxProductCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Categoría.");
                cboxProductCategoria.Focus();
                return;
            }

            // Validar ComboBox de Estado
            if (cboxProductEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Estado.");
                cboxProductEstado.Focus();
                return;
            }

            string nombreProducto = txtProductNombre.Text;
            string codigoProducto = txtProductCodigo.Text;
            string descripcionProducto = txtProductDescripcion.Text;
            int categoriaProducto = (int)cboxProductCategoria.SelectedValue;
            int proveedorProducto = (int)cbProveedor.SelectedValue;
            string precioProductoVenta = txtProductPrecioVenta.Text; // marca error
            string precioProductoCompra = txtProductPrecioCompra.Text;
            string stockProducto = txtProductStock.Text; //marca error
            int estadoProducto = (int)cboxProductEstado.SelectedValue; // marca error

            try
            {
                Producto nuevoProducto = new Producto
                {
                    codigo_producto = int.Parse(codigoProducto),
                    nombre = nombreProducto,
                    descripcion = descripcionProducto,
                    id_categoria = categoriaProducto,
                    id_proveedor = proveedorProducto,
                    precio_compra = decimal.Parse(precioProductoCompra),
                    precio_venta = decimal.Parse(precioProductoVenta),
                    stock = int.Parse(stockProducto),
                    id_estado = estadoProducto,
                };

                ProductService productService = new ProductService();

                if (productService.getProductByCode(nuevoProducto.codigo_producto) != null)
                {
                    productService.deleteProductService(nuevoProducto.codigo_producto);
                    MessageBox.Show("Producto dado de baja exitosamente");
                    adminGestionProduct_Load(sender, e);
                    return;
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                    return;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al dar de baja el producto: " + ex.Message);
            }
        }
    }    
}

