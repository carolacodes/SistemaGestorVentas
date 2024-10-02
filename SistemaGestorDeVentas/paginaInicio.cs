using SistemaGestorDeVentas.components;
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
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseñaUsuario = txtContraseñaUsuario.Text;

            
            if (contraseñas.ContainsKey(nombreUsuario) && contraseñas[nombreUsuario] == contraseñaUsuario)
            {
              
                navegador navForm = new navegador();

                
                string rolUsuario = roles[nombreUsuario];

                
                switch (rolUsuario)
                {
                    case "Administrador":
                        navForm.MostrarMenuAdministrador(); // Mostrar menú para Administrador
                        break;
                    case "Vendedor":
                        navForm.MostrarMenuVendedor(); // Mostrar menú para Vendedor
                        break;
                    case "Supervisor":
                        navForm.Show(); // Mostrar menú para Supervisor
                        break;
                }

                
                navForm.Show();

                
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
