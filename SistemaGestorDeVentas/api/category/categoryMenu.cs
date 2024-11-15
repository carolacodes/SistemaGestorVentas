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

        private void categoryMenu_Load(object sender, EventArgs e)
        {
            CategoriaService categoriaService = new CategoriaService();

  

            var categorias = categoriaService.getCategorias();

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


            if (string.IsNullOrWhiteSpace(txtIDCategoria.Text))
            {
                try
                {
                    string nombreCategoria = txtCategoriaNombre.Text;
                    var nuevaCategoria = new Categoria
                    {
                        nombre = nombreCategoria
                    };

                    CategoriaService categoriaService = new CategoriaService();
                    categoriaService.createCategoria(nuevaCategoria);
                    MessageBox.Show("Categoria registrada exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar una categoria en la base de datos: " + ex.Message);
                }
            }
            else
            {
                try
                {

                    string nombreCategoria = txtCategoriaNombre.Text;
                    int idCategoria = int.Parse(txtIDCategoria.Text);
                    var nuevaCategoria = new Categoria
                    {
                        id_categoria = idCategoria,
                        nombre = nombreCategoria
                    };

                    CategoriaService categoriaService = new CategoriaService();

                    if (categoriaService.getCategoria(nuevaCategoria.id_categoria) == null)
                    {
                        categoriaService.createCategoria(nuevaCategoria);
                        MessageBox.Show("Categoria registrada exitosamente");
                    }
                    else
                    {
                        categoriaService.updateCateoria(nuevaCategoria);
                        MessageBox.Show("Categoria modificada exitosamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar una categoria en la base de datos: " + ex.Message);
                }
            }
        }

        private void dataGridCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridCategoria.Rows[e.RowIndex];
            txtIDCategoria.Text = row.Cells["id_categoria"].Value.ToString();
            txtCategoriaNombre.Text = row.Cells["detalleCategoriaNombre"].Value.ToString();
        }

        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            txtCategoriaNombre.Clear();
        }


    }
}
