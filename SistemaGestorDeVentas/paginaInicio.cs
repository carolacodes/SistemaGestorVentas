using SistemaGestorDeVentas.api.cart;
using SistemaGestorDeVentas.api.user;
using SistemaGestorDeVentas.components;
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

namespace SistemaGestorDeVentas
{
    public partial class paginaInicio : Form
    {
        public Usuario UsuarioLogueado { get; private set; }

        private Dictionary<string, string> contraseñas = new Dictionary<string, string>
        {
            //clave: nombre usuario valor: contraseña
            { "admin@gmail.com", "admin123" },
            { "vendedor@gmail.com", "vendedor123" },
            { "supervisor@gmail.com", "supervisor123" }
        };

        private Dictionary<string, string> roles = new Dictionary<string, string>
        {
            //clave: nombre usuario valor: rol
            { "admin@gmail.com", "Administrador" },
            { "vendedor@gmail.com", "Vendedor" },
            { "supervisor@gmail.com", "Supervisor" }
        };

        public paginaInicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = obtengoUsuario();

            // Si el usuario fue encontrado, se abre el formulario navegador
            if (usuario != null)
            {
                metodoPago metodoPagoForm = new metodoPago(pagInicioForm: this);
                navegador navForm = new navegador();
                navForm.Show();
                this.Hide();
            }
        }

        public Usuario obtengoUsuario()
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseñaUsuario = txtContraseñaUsuario.Text;

            UserService userService = new UserService();
            var usuarioEncontrado = userService.getUserByEmail(nombreUsuario);

            if (usuarioEncontrado != null)
            {
                if (contraseñaUsuario == usuarioEncontrado.pass)
                {
                    UsuarioLogueado = usuarioEncontrado; // Almacena el usuario encontrado
                    return usuarioEncontrado; // Retorna el usuario encontrado
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario incorrecto.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Retorna null si no se encuentra el usuario
            return null;
        }

    }
}
