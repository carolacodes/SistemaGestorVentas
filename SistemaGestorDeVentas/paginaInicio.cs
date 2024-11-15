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
using SistemaGestorDeVentas.api.compra;

namespace SistemaGestorDeVentas
{
    public partial class paginaInicio : Form
    {
        //public Usuario UsuarioLogueado { get; set; }

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
            var email = txtNombreUsuario.Text;
            var pass = txtContraseñaUsuario.Text;
            Usuario usuario;

            UserService userService = new UserService();

            usuario = userService.getUserByEmail(email);

            if(usuario != null)
            {
                if(usuario.pass == pass)
                {
                    metodoPago.UsuarioEmail = email; // Asigna el email como propiedad estática
                    metodoPago metodoPagoForm = new metodoPago();
                    compraProducto.UsuarioEmail = email;
                    compraProducto compraProductoForm = new compraProducto();
                    //metodoPago metodoPagoForm = new metodoPago(null, this);
                    //metodoPagoForm.UsuarioEmail = email; // Guarda el email en metodoPago
                    navegador navForm = new navegador();
                    navForm.Show();
                    this.Hide();
                    Console.WriteLine("email desde login para metodo pago" + (metodoPago.UsuarioEmail = email));
                    Console.WriteLine("email desde login para compra producto" + (compraProducto.UsuarioEmail = email));
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
        }


    }
}
