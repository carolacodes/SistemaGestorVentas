using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.user
{
    public partial class usuarioView : Form
    {
        public usuarioView()
        {
            InitializeComponent();
        }

        private void btnUsuarioGuardar_Click(object sender, EventArgs e)
        {
            // Validar TextBox de Nro DNI
            if (string.IsNullOrWhiteSpace(txtUsuarioDNI.Text))
            {
                MessageBox.Show("El campo Nro DNI es obligatorio.");
                txtUsuarioDNI.Focus();
                return;
            }

            // Validar TextBox de Nombre Completo
            if (string.IsNullOrWhiteSpace(txtUsuarioNombre.Text))
            {
                MessageBox.Show("El campo Nombre Completo es obligatorio.");
                txtUsuarioNombre.Focus();
                return;
            }

            // Validar TextBox de Correo
            if (string.IsNullOrWhiteSpace(txtUsuarioCorreo.Text))
            {
                MessageBox.Show("El campo Correo es obligatorio.");
                txtUsuarioCorreo.Focus();
                return;
            }
            // Validar formato de correo electrónico
            if (!IsValidEmail(txtUsuarioCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                txtUsuarioCorreo.Focus();
                return;
            }

            // Validar TextBox de Contraseña
            if (string.IsNullOrWhiteSpace(txtUsuarioContraseña.Text))
            {
                MessageBox.Show("El campo Contraseña es obligatorio.");
                txtUsuarioContraseña.Focus();
                return;
            }

            // Validar TextBox de Confirmar Contraseña
            if (string.IsNullOrWhiteSpace(txtUsuarioConfirmarContraseña.Text))
            {
                MessageBox.Show("El campo Confirmar Contraseña es obligatorio.");
                txtUsuarioConfirmarContraseña.Focus();
                return;
            }

            // Verificar que las contraseñas coincidan
            if (txtUsuarioContraseña.Text != txtUsuarioConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                txtUsuarioConfirmarContraseña.Focus();
                return;
            }

            // Validar ComboBox de Rol
            if (cboxUsuarioRol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Rol.");
                cboxUsuarioRol.Focus();
                return;
            }

            // Validar ComboBox de Estado
            if (cboxUsuarioEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Estado.");
                cboxUsuarioEstado.Focus();
                return;
            }

            // Si todas las validaciones son correctas, se guarda el usuario
            MessageBox.Show("Usuario guardado correctamente.");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtUsuarioDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                // Verificar si la tecla presionada no es un número ni la tecla de retroceso
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // Cancela la acción, no permite la entrada
                }
            }
        }

        private void txtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es una letra, no es borrar, no es espacio entonces bloquea
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Bloquear caracteres que no sean letras o espacios
            }
        }

        private void txtUsuarioCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite letras, números, @, puntos, guiones y retroceso
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '_' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear la tecla si no es válida
            }

            // bloqueo  espacios
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
