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
                if(usuario.pass == pass && usuario.id_estado == 1)
                {
                    metodoPago.UsuarioEmail = email; // Asigna el email como propiedad estática
                    metodoPago metodoPagoForm = new metodoPago();
                    compraProducto.UsuarioEmail = email;
                    compraProducto compraProductoForm = new compraProducto();
                    //metodoPago metodoPagoForm = new metodoPago(null, this);
                    //metodoPagoForm.UsuarioEmail = email; // Guarda el email en metodoPago
                    
                    // Pasa el usuario al formulario navegador
                    navegador navForm = new navegador(usuario);
                    navForm.Show();
                    //this.Hide();

                    // Verifica que AppContext no sea null antes de cambiar la ventana
                    //if (Program.AppContext != null)
                    //{
                    //    Program.AppContext.SwitchMainForm(navForm);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error crítico: AppContext no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                    Console.WriteLine("email desde login para metodo pago" + (metodoPago.UsuarioEmail = email));
                    Console.WriteLine("email desde login para compra producto " + (compraProducto.UsuarioEmail = email));
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

        private void panel1_Click(object sender, EventArgs e)
        {
            //txtContraseñaUsuario.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Cambia el estado de UseSystemPasswordChar para mostrar u ocultar el texto
            if (txtContraseñaUsuario.UseSystemPasswordChar)
            {
                txtContraseñaUsuario.UseSystemPasswordChar = false; 
                btnMostrar.Text = "Ocultar"; 
            }
            else
            {
                txtContraseñaUsuario.UseSystemPasswordChar = true; 
                btnMostrar.Text = "Mostrar"; 
            }
        }
    }
}
