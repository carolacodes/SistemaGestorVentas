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
using SistemaGestorDeVentas.middleware;
using SistemaGestorDeVentas.db;

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


            //valido que los textbox no esten vacios 
            if (string.IsNullOrWhiteSpace(txtClienteDni.Text))
            {
                MessageBox.Show("Por favor, ingrese el DNI del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClienteNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre completo del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClienteCorreo.Text))
            {
                MessageBox.Show("Por favor, ingrese el correo del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtClienteTelefono.Text))
            {
                MessageBox.Show("Por favor, ingrese el teléfono del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el estado esté seleccionado
            if (cbClienteEstado.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione el estado del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //boton guardar
            string dniCliente = txtClienteDni.Text;
            string nombreCompletoCliente = txtClienteNombre.Text;
            string correoCliente = txtClienteCorreo.Text;
            string telefonoCliente = txtClienteTelefono.Text;
            int estadoCliente = (int)cbClienteEstado.SelectedValue;



            try
            {   
                var nuevoCliente = new Cliente
                {
                    DNI_cliente = dniCliente,
                    nombre = nombreCompletoCliente,
                    correo = correoCliente,
                    telefono = telefonoCliente,
                    id_estado = estadoCliente
                };

                var clienteService = new ClienteService();

                if (clienteService.getCliente(nuevoCliente.DNI_cliente) == null)
                {
                    clienteService.CreateCliente(nuevoCliente);
                    MessageBox.Show("Cliente registrado exitosamente");
                }
                else
                {
                    clienteService.updateCliente(nuevoCliente);
                    MessageBox.Show("Cliente modificado exitosamente");
                }
                txtClienteDni.Clear();
                txtClienteNombre.Clear();
                txtClienteCorreo.Clear();
                txtClienteTelefono.Clear();

                cargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar un cliente en la base de datos: " + ex.Message);
            }
        }

        private void cbClienteEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void detalleCliente_Load(object sender, EventArgs e)
        {
            // Estados
            
            var estadoService = new EstadoService();
            var estados = estadoService.getEstados();
            cbClienteEstado.DataSource = estados;
            cbClienteEstado.DisplayMember = "nombre";
            cbClienteEstado.ValueMember = "id_estado";

            //Clientes

            var clienteService = new ClienteService();
            var clientes = clienteService.getClientes();
            foreach (var cliente in clientes)
            {
                dataGridCliente.Rows.Add(cliente.DNI_cliente, cliente.nombre, cliente.correo, cliente.telefono, estadoService.getEstado(cliente.id_estado).nombre);
            }
            //dataGridCliente.DataSource = clientes;
        }

        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegúrate de que se ha hecho clic en una fila válida
            if (e.RowIndex >= 0)
            {
                var estadoService = new EstadoService();
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridCliente.Rows[e.RowIndex];

                // Rellenar los TextBox con los datos de la fila
                txtClienteDni.Text = row.Cells["detalleClienteDni"].Value.ToString();
                txtClienteNombre.Text = row.Cells["detalleClienteNombre"].Value.ToString(); // Cambia "Nombre" por el nombre de la columna correspondiente
                txtClienteCorreo.Text = row.Cells["detalleClienteCorreo"].Value.ToString();
                txtClienteTelefono.Text = row.Cells["detalleClienteTelefono"].Value.ToString();

                string nombreEstado = row.Cells["detalleClienteEstado"].Value.ToString();
                int? estadoID = estadoService.GetEstadoIdByNombre(nombreEstado);

                cbClienteEstado.SelectedValue = estadoID;
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtClienteDni.Clear();
            txtClienteNombre.Clear();
            txtClienteCorreo.Clear();
            txtClienteTelefono.Clear();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string dniCliente = txtClienteDni.Text;

            try
            {
                var clienteService = new ClienteService();
                var cliente = clienteService.deleteCliente(dniCliente);
                MessageBox.Show("Eliminacion del cliente exitosa");
                cargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el cliente: " + ex.Message);
            }
        }

        private void cargarClientes()
        {
            ClienteService clienteService = new ClienteService();

            List<Cliente> clientes = clienteService.getClientes();

            var estadoService = new EstadoService();
            
            var estados = estadoService.getEstados();

            dataGridCliente.Rows.Clear();

            foreach (var cliente in clientes)
            {
                dataGridCliente.Rows.Add(cliente.DNI_cliente, cliente.nombre, cliente.correo, cliente.telefono,
                                estadoService.getEstado(cliente.id_estado).nombre);
            }
        }
    }
}
