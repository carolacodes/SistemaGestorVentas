using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestorDeVentas;

namespace SistemaGestorDeVentas.api.proveedor
{
    public partial class gestionProveedores : Form
    {
        public gestionProveedores()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cargarNAv(object sender, EventArgs e) {
            navbar nav = new navbar();

            nav.Dock = DockStyle.Fill;
            
        }
        private void panelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gestionProveedores_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedorGuardar_Click(object sender, EventArgs e)
        {
            // Validar TextBox de Nombre
            if (string.IsNullOrWhiteSpace(txtProveedorNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                txtProveedorNombre.Focus();
                return;
            }

            // Validar TextBox de Código
            if (string.IsNullOrWhiteSpace(txtProveedorCodigo.Text))
            {
                MessageBox.Show("El campo Código es obligatorio.");
                txtProveedorCodigo.Focus();
                return;
            }

            // Validar ComboBox de Estado
            if (cboxProveedorEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Estado.");
                cboxProveedorEstado.Focus();
                return;
            }


            // Si todas las validaciones son correctas, se guarda el proveedor
            MessageBox.Show("Proveedor guardado correctamente.");
        }

        private void txtProveedorCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtProveedorCodigo.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un valor válido para el Codigo.");
                txtProveedorCodigo.Focus();
                return;
            }
        }

        private void txtProveedorTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtProveedorTelefono.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un valor válido para el Telefono.");
                txtProveedorTelefono.Focus();
                return;
            }
        }

        private void txtProveedorCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la acción, no permite la entrada
            }
        }

        private void txtProveedorTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la acción, no permite la entrada
            }
        }
    }
}
