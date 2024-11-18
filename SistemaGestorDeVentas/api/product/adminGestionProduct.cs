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
            if (!decimal.TryParse(txtProductPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un valor válido para el Precio.");
                txtProductPrecio.Focus();
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

            // Si todo está correcto, se guarda el producto
            MessageBox.Show("Producto guardado correctamente.");
        }

        private void txtProductCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtProductCodigo.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un valor válido para el Codigo.");
                txtProductCodigo.Focus();
                return;
            }
        }

        private void txtProductStock_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtProductStock.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un valor válido para el Stock.");
                txtProductStock.Focus();
                return;
            }
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

        private void adminGestionProduct_Load(object sender, EventArgs e)
        {
            EstadoService estadoService = new EstadoService();  
            ProductService productService = new ProductService();
            CategoriaService categoriaService = new CategoriaService();
            ProveedorServices proveedorServices = new ProveedorServices();
            var estados = estadoService.getEstados();
            List<Proveedor> proveedores = proveedorServices.getProveedores();

            cboxProductEstado.DataSource = estados;
            cboxProductEstado.DisplayMember = "nombre";
            cboxProductEstado.ValueMember = "id_estado";

            cbProveedor.DataSource = proveedores;
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.ValueMember = "id_proveedor";

            var productos = productService.getProductsService();

            foreach (var producto in productos)
            {
                dataGrid_productos.Rows.Add(producto.nombre, producto.codigo_producto, producto.descripcion,categoriaService.getCategoria(producto.id_categoria).nombre,producto.precio_compra, producto.precio_venta , producto.stock ,estadoService.getEstado(producto.id_estado).nombre, proveedorServices.getProveedor(producto.id_proveedor).nombre);
            }
        }

        /*  private void dataGrid_productos_CellClick(object sender, DataGridViewCellEventArgs e)
          {
              if (e.RowIndex >= 0)
              {
                  var estadoService = new EstadoService();
                  CategoriaService categoriaService = new CategoriaService();
                  // Obtener la fila seleccionada
                  DataGridViewRow row = dataGrid_productos.Rows[e.RowIndex];

                  // Rellenar los TextBox con los datos de la fila
                  txtProductNombre.Text = row.Cells["detalleProductoNombre"].Value.ToString();
                  txtProductCodigo.Text = row.Cells["detalleProductoCodigo"].Value.ToString(); // Cambia "Nombre" por el nombre de la columna correspondiente
                  txtProductDescripcion.Text = row.Cells["detalleProductoDescripcion"].Value.ToString();
                  txtProductPrecio.Text = row.Cells["precio_venta"].Value.ToString();
                  txtProductStock.Text = row.Cells["detalleProductoStock"].Value.ToString();
                  string nombreEstado = row.Cells["detalleProductoEstado"].Value.ToString();
                  int? estadoID = estadoService.GetEstadoIdByNombre(nombreEstado);
                  string nombreCategoria = row.Cells["detalleProductoCategoria"].Value.ToString();
                  Categoria categoria = categoriaService.getCategoriaPorNombre(nombreCategoria);
                  int? categoriaID = categoria.id_categoria;
                  cboxProductEstado.SelectedValue = estadoID;
                  cboxProductCategoria.SelectedValue = categoriaID;
              }
          }*/
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
                txtProductPrecio.Text = row.Cells["precio_venta"].Value.ToString();
                txtProductStock.Text = row.Cells["detalleProductoStock"].Value.ToString();


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
    }
}
