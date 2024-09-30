using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaGestorDeVentas.api.cliente
{
    public partial class detalleCliente : Form
    {
        public detalleCliente()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-QN2EB52\\SQLEXPRESS; database=sistema_de_ventas; ");

        private void txtClienteDni_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txtClienteDni.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // bloqueo las teclas si hay mas de 8 caract
            }
        }

        private void txtClienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // si no es una letra, no es borrar, no es espacio entonces bloquea
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; // Bloquear caracteres que no sean letras o espacios
            }
        }

        private void txtClienteCorreo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtClienteCorreo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtClienteCorreo.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtClienteCorreo.Text, emailPattern))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                e.Cancel = true; // Evita que el control pierda el foco hasta que se ingrese un correo válido
            }
        }

        private void txtClienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, el signo de más (+) al principio, guiones, paréntesis y retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloquear si no es un carácter permitido
            }

            // Permitir el signo de más (+) solo al principio
            if (e.KeyChar == '+' && txtClienteTelefono.Text.Length > 0)
            {
                e.Handled = true; // Bloquear el signo de más si no es el primer carácter
            }

            // Bloquear espacios
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Bloquear espacios
            }

        }

        private void txtClienteBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //buscar por DNI
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
            if (txtClienteDni.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // bloqueo las teclas si hay mas de 8 caract
            }
        }

        private void txtClienteDni_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtClienteDni.Text))
            //{
            //    MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void txtClienteNombre_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtClienteNombre.Text))
            //{
              //  MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
              //  e.Cancel = true;
            //}
        }

        private void txtClienteTelefono_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtClienteTelefono.Text))
            //{
                //MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //e.Cancel = true;
            //}
        }

        private void txtClienteDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton guardar
            string dni = txtClienteDni.Text;
            string nombreCompleto = txtClienteNombre.Text;
            string correo = txtClienteCorreo.Text;
            string telefono = txtClienteTelefono.Text;

            // Determinar el estado como 1 o 0
            /*
             * int estado = 0; // Valor por defecto
            if (cbClienteEstado.SelectedItem != null)
            {
                estado = cbClienteEstado.SelectedItem.ToString() == "Activo" ? 1 : 0;
            }
             */

            int estado = 0; // valor por defecto
            string estadoTexto = "Inactivo"; //valor por defecto para el datagrid
            if (cbClienteEstado.SelectedItem != null)
            {
                if (cbClienteEstado.SelectedItem.ToString() == "Activo")
                {
                    estado = 1;
                    estadoTexto = "Activo";
                }
                else
                {
                    estado = 0;
                    estadoTexto = "Inactivo";
                }
            }



         // dataGridCliente.Rows.Add(dni, nombreCompleto, correo, telefono, estadoTexto);

            

            // Limpiar los campos después de guardar
            txtClienteDni.Clear();
            txtClienteNombre.Clear();
            txtClienteCorreo.Clear();
            txtClienteTelefono.Clear();
            cbClienteEstado.SelectedIndex = -1;


            //insert data base

            try
            {
                conexion.Open();

                /*
                 * string consulta = "INSERT INTO Cliente (DNI_cliente, nombre, correo, telefono, id_estado) " +
                                  "VALUES ('" + dni + "', '" + nombreCompleto + "', '" + correo + "', '" + telefono + "', " + estado + ")";

                SqlCommand command = new SqlCommand(consulta, conexion);
                command.ExecuteNonQuery();
                */

                string consulta = "INSERT INTO Cliente (DNI_cliente, nombre, correo, telefono, id_estado) VALUES (@dni, @nombre, @correo, @telefono, @estado)";
                SqlCommand command = new SqlCommand(consulta, conexion);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@nombre", nombreCompleto);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@estado", estado);
                command.ExecuteNonQuery();

                MessageBox.Show("Se registro correctamente en la bases de datos");
                dataGridCliente.Rows.Add(dni, nombreCompleto, correo, telefono, estadoTexto);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar un cliente en la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
