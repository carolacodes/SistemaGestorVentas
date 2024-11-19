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

namespace SistemaGestorDeVentas.api.category
{
    public partial class categoryMenu : Form
    {
        public categoryMenu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void limpiar()
        {
            txtCategoriaNombre.Clear();
            txtIDCategoria.Clear();
            dataGridCategoria.Rows.Clear();

            // Si está enlazado a una fuente de datos
            dataGridCategoria.DataSource = null;

            // Opcional: Refrescar el control
            dataGridCategoria.Refresh();
        }
        private void categoryMenu_Load(object sender, EventArgs e)
        {
            CategoriaService categoriaService = new CategoriaService();

  

            var categorias = categoriaService.getCategorias();
            limpiar();
            foreach (var categoria in categorias)
            {
                dataGridCategoria.Rows.Add(categoria.id_categoria ,categoria.nombre);
            }

        }

        private void txtCategoriaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es una letra, no es borrar, no es espacio entonces bloquea
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Bloquear caracteres que no sean letras o espacios
            }
        }

        private void txtCategoriaBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // bloqeua caracteres que no sean letras o espacios
            }
        }

        private void txtCategoriaNombre_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCategoriaNombre.Text))
            //{
                //  MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // e.Cancel = true;
            //}
        }

        private void txtCategoriaNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoriaNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idCategoria;
            if (string.IsNullOrWhiteSpace(txtIDCategoria.Text))
            {
                idCategoria = "0";
            }
            else
            {
                idCategoria = txtIDCategoria.Text;
            }

            string nombreCategoria = txtCategoriaNombre.Text;
                try
                {
                    
                    var nuevaCategoria = new Categoria
                    {
                        id_categoria = int.Parse(idCategoria),
                        nombre = nombreCategoria
                    };

                    CategoriaService categoriaService = new CategoriaService();

                    if(nuevaCategoria.id_categoria == 0 || categoriaService.getCategoria(nuevaCategoria.id_categoria) == null)
                    {
                        categoriaService.createCategoria(nuevaCategoria);
                        MessageBox.Show("Categoria registrada exitosamente");
                        categoryMenu_Load(sender, e);
                        return;
                    }
                    else
                    {
                        var categoriaEncontrada = categoriaService.getCategoria(nuevaCategoria.id_categoria);
                        DialogResult result = MessageBox.Show(
                       "El código de categoria ya existe. ¿Desea modificar esta categoria: " + categoriaEncontrada.nombre + " ?",
                       "Confirmación",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
   );

                        if (result == DialogResult.Yes)
                        {
                            categoriaService.updateCateoria(nuevaCategoria);
                            MessageBox.Show("Se modifico la categoria correctamente ");
                            categoryMenu_Load(sender, e);
                            return;
                        }
                        else
                        {
                            // Cancelar la operación
                            MessageBox.Show("La modificación de la categoria ha sido cancelada.");
                            return;
                        }
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar una categoria en la base de datos: " + ex.Message);
                }
        }

        private void dataGridCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCategoria.Rows[e.RowIndex];
                // Validar si la celda "id_categoria" tiene un valor
                if (row.Cells["id_categoria"].Value != null)
                {
                    txtIDCategoria.Text = row.Cells["id_categoria"].Value.ToString();
                }
                else
                {
                    txtIDCategoria.Text = ""; // O deja vacío el TextBox
                }

                // Validar si la celda "detalleCategoriaNombre" tiene un valor
                if (row.Cells["detalleCategoriaNombre"].Value != null)
                {
                    txtCategoriaNombre.Text = row.Cells["detalleCategoriaNombre"].Value.ToString();
                }
                else
                {
                    txtCategoriaNombre.Text = ""; // O deja vacío el TextBox
                }
            }
            
        }

        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            categoryMenu_Load(sender, e);
        }

        private void txtIDCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
