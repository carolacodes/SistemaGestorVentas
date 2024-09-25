using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.cart
{
    public partial class cartView : Form
    {
        public cartView()
        {
            InitializeComponent();
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
            if (string.IsNullOrWhiteSpace(txtCartViewDNI.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtCartNombreCliente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCartNombreCliente.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtCartCodProduct_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCartCodProduct.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtCartProducto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCartProducto.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtCartPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCartPrecio.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtCartStock_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCartStock.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
