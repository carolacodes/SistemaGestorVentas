﻿using System;
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
    }
}
