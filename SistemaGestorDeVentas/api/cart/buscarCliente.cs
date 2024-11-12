using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.db;
using SistemaGestorDeVentas.middleware;
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
using SistemaGestorDeVentas.components;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaGestorDeVentas.api.cart
{
    public partial class buscarCliente : Form
    {
        private cartView _carritoForm;
        public buscarCliente(cartView cartViewForm)
        {
            InitializeComponent();
            _carritoForm = cartViewForm;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            // Obtener el DNI del cliente ingresado
            var dniCliente = txtCartViewDNI.Text.Trim();

            // Verificar si el DNI está vacío
            if (string.IsNullOrEmpty(dniCliente))
            {
                MessageBox.Show("Por favor, ingrese un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nombre_cliente = txtCartViewDNI.Text;
            if (string.IsNullOrEmpty(nombre_cliente))
            {
                MessageBox.Show("Por favor, ingrese un nombre valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una instancia de ClienteService
            ClienteService clienteService = new ClienteService();

            try
            {
                int indiceSeleccionado = cbBuscarCliente.SelectedIndex;
                if (indiceSeleccionado == 0)
                {
                    // Llamar al método para obtener el cliente con el DNI ingresado
                    Cliente clienteExiste = clienteService.getCliente(dniCliente);

                    // Limpiar las filas actuales del DataGridView
                    dataGridBuscarCliente.Rows.Clear();

                    // Verificar si el cliente existe
                    if (clienteExiste != null)
                    {
                        // Si el cliente existe, mostrar los datos en el DataGridView
                        //dataGridBuscarCliente.DataSource = new List<Cliente> { cliente }; // Usamos una lista con un solo cliente

                        dataGridBuscarCliente.Rows.Add(clienteExiste.DNI_cliente, clienteExiste.nombre, clienteExiste.correo, clienteExiste.telefono, clienteExiste.id_estado);

                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún cliente con el DNI proporcionado. Por favor vuelva a ingresar el DNI", "Cliente No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        List<Cliente> clientes = clienteService.getClientes();

                        foreach (var cliente in clientes)
                        {
                            dataGridBuscarCliente.Rows.Add(cliente.DNI_cliente, cliente.nombre, cliente.id_estado, cliente.telefono, cliente.correo);
                        }
                    }
                }
                else
                {
                    // Llamar al método para obtener el cliente con el DNI ingresado
                    List <Cliente> clientes = clienteService.getClienteByName(nombre_cliente);

                    // Limpiar las filas actuales del DataGridView
                    dataGridBuscarCliente.Rows.Clear();

                    // Verificar si el cliente existe
                    if (clientes != null)
                    {
                        foreach (var cliente in clientes)
                        {
                            dataGridBuscarCliente.Rows.Add(cliente.DNI_cliente, cliente.nombre, cliente.id_estado, cliente.telefono, cliente.correo);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún cliente con el DNI proporcionado. Por favor vuelva a ingresar el DNI", "Cliente No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (var cliente in clientes)
                        {
                            dataGridBuscarCliente.Rows.Add(cliente.DNI_cliente, cliente.nombre, cliente.id_estado, cliente.telefono, cliente.correo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturar excepciones y mostrar mensaje de error
                MessageBox.Show($"Error al intentar obtener el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridBuscarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteService clienteService = new ClienteService();

                List<Cliente> clientes = clienteService.getClientes();

                foreach (var cliente in clientes)
                {
                    dataGridBuscarCliente.Rows.Add(cliente.DNI_cliente, cliente.nombre, cliente.id_estado, cliente.telefono, cliente.correo);
                }

                //dataGridBuscarCliente.DataSource = clientes;
                // Opcional: Ajustar el formato de las columnas si es necesario
                //dataGridBuscarCliente.AutoGenerateColumns = true; // Esto genera las columnas automáticamente basándose en las propiedades de la clase Cliente
            }catch(Exception ex)
            {
                MessageBox.Show($"Error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridBuscarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            //me aseguro de que se hizo click en una fila valida
            if(e.RowIndex >= 0)
            {
                //obtengo la fila que selecciono el cliente
                DataGridViewRow row = dataGridBuscarCliente.Rows[e.RowIndex];

                // Asigna los valores directamente a los TextBox en _carritoForm
                _carritoForm.txtCartViewDNI.Text = row.Cells["detalleClienteDni"].Value.ToString();
                _carritoForm.txtCartNombreCliente.Text = row.Cells["detalleClienteNombre"].Value.ToString();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridBuscarCliente_CellClick();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form gestionCliente = new detalleCliente();


            this.Close();
            _carritoForm.Close();
            //Form navbar = new navegador();
            ////opcion 1
            //navbar.clientesToolStripMenuItem_Click(object sender, EventArgs e);

            ////opcion 2
            ////// Verificar si el formulario detalleCliente ya está abierto
            //Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is detalleCliente);

            //if (existingForm != null)
            //{
            //    // Si ya está abierto, traerlo al frente
            //    existingForm.BringToFront();
            //}
            //else
            //{
            //    // Si no está abierto, crear una nueva instancia

            //    detalleCliente gestionCliente = new detalleCliente();

            //    navbar = gestionCliente.MdiParent;
            //    gestionCliente.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
            //    gestionCliente.Show();



            //}

            // Busca la instancia abierta de navegador
            Form navegadorForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is navegador);

            if (navegadorForm != null)
            {
                // Llama al método para abrir el formulario de detalleCliente
                ((navegador)navegadorForm).clientesToolStripMenuItem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se encontró el formulario de navegación principal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txtCartViewDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
