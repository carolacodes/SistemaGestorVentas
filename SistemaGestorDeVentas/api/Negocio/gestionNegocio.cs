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
using SistemaGestorDeVentas.api.cart;

namespace SistemaGestorDeVentas.api.negocio
{
    public partial class gestionNegocio : Form
    {
        public gestionNegocio()
        {
            InitializeComponent();
        }



        private void txtNegocioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es una letra, no es borrar, no es espacio entonces bloquea
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Bloquear caracteres que no sean letras o espacios
            }
        }

        private void txtNegocioRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNegocioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNegocioDireccion_Validating(object sender, CancelEventArgs e)
        {
            // Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtNegocioDireccion.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; 
            }
        }

        private void txtNegocioRUC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNegocioRUC.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtNegocioNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNegocioNombre.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navbar_Load(object sender, EventArgs e)
        {

        }

        private void guardarNegocio_Click(object sender, EventArgs e)
        {
            var nombre = txtNegocioNombre.Text;
            var direccion = txtNegocioDireccion.Text;
            var rut = txtNegocioRUC.Text;
            var imagen = pictureBox1.Image;

            NegocioService negocioService = new NegocioService();
            Negocio negocioExiste = negocioService.getNegocio(1);
            
            negocioExiste.nombre = nombre;
            negocioExiste.direccion = direccion;
            negocioExiste.rut = rut;
            
            negocioService.updateNegocio(negocioExiste);

            MessageBox.Show("Se guardaron los datos correctamente");


            //detalleVenta.NombreNegocio = nombre;
            //detalleVenta detalleVentaForm = new detalleVenta();
        }

        private void gestionNegocio_Load(object sender, EventArgs e)
        {
            NegocioService negocioService = new NegocioService();
            Negocio negocioExiste = negocioService.getNegocio(1);
            txtNegocioNombre.Text = negocioExiste.nombre;
            txtNegocioDireccion.Text = negocioExiste.direccion;
            txtNegocioRUC.Text = negocioExiste.rut;
        }
    }
}
