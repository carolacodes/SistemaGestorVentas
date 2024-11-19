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
using SistemaGestorDeVentas.api.category;
using SistemaGestorDeVentas.api.product;
using SistemaGestorDeVentas.db;
using SistemaGestorDeVentas.middleware;

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

        private void cargarNAv(object sender, EventArgs e)
        {
            navbar nav = new navbar();

            nav.Dock = DockStyle.Fill;

        }
        private void panelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void limpiar()
        {
            txtProveedorCodigo.Clear();
            txtProveedorNombre.Clear();
            txtProveedorEmail.Clear();
            txtProveedorDireccion.Clear();
            txtProveedorTelefono.Clear();
            txtProveedorSitioWeb.Clear();
            cboxProveedorEstado.SelectedIndex = -1;

            // Si no está enlazado a una fuente de datos
            dataGrid_proveedores.Rows.Clear();

            // Si está enlazado a una fuente de datos
            dataGrid_proveedores.DataSource = null;

            // Opcional: Refrescar el control
            dataGrid_proveedores.Refresh();
        }
        private void gestionProveedores_Load(object sender, EventArgs e)
        {
            ProveedorServices proveedorServices = new ProveedorServices();
            List<Proveedor> proveedores = proveedorServices.getProveedores();
            EstadoService estadoService = new EstadoService();
            var estados = estadoService.getEstados();

            cboxProveedorEstado.DataSource = estados;
            cboxProveedorEstado.DisplayMember = "nombre";
            cboxProveedorEstado.ValueMember = "id_estado";
            limpiar();
            foreach (var proveedor in proveedores)
            {
                dataGrid_proveedores.Rows.Add(proveedor.nombre, proveedor.id_proveedor, proveedor.direccion,
                    proveedor.telefono, proveedor.email, proveedor.web, estadoService.getEstado(proveedor.id_estado).nombre);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedorGuardar_Click(object sender, EventArgs e)
        {
            // Validar TextBox de Nombre
            string codigoProveedor;
            string direccionProveedor;
            string telefonoProveedor;
            string emailProveedor;
            string webProveedor;

            if (string.IsNullOrWhiteSpace(txtProveedorCodigo.Text))
            {
                codigoProveedor = "0";
            }
            else
            {
                codigoProveedor = txtProveedorCodigo.Text;
            }


            if (string.IsNullOrWhiteSpace(txtProveedorDireccion.Text))
            {
                direccionProveedor = "";
            }
            else
            {
                direccionProveedor = txtProveedorDireccion.Text;
            }


            if (string.IsNullOrWhiteSpace(txtProveedorTelefono.Text))
            {
                telefonoProveedor = "";
            }
            else
            {
                telefonoProveedor = txtProveedorTelefono.Text;
            }


            if (string.IsNullOrWhiteSpace(txtProveedorEmail.Text))
            {
                emailProveedor = "";
            }
            else
            {
                emailProveedor = txtProveedorEmail.Text;
            }


            if (string.IsNullOrWhiteSpace(txtProveedorSitioWeb.Text))
            {
                webProveedor = "";
            }
            else
            {
                webProveedor = txtProveedorSitioWeb.Text;
            }

            if (string.IsNullOrWhiteSpace(txtProveedorNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                txtProveedorNombre.Focus();
                return;
            }

            // Validar ComboBox de Estado
            if (cboxProveedorEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Estado.");
                cboxProveedorEstado.Focus();
                return;
            }


            string nombreProveedor = txtProveedorNombre.Text;
            int estadoProveedor = (int)cboxProveedorEstado.SelectedValue;

            try
            {
                var nuevoProveedor = new Proveedor
                {
                    id_proveedor = int.Parse(codigoProveedor),
                    nombre = nombreProveedor,
                    direccion = direccionProveedor,
                    telefono = telefonoProveedor,
                    email = emailProveedor,
                    web = webProveedor,
                    id_estado = estadoProveedor
                };

                ProveedorServices proveedorService = new ProveedorServices();
                if (nuevoProveedor.id_proveedor == 0 || proveedorService.getProveedor(nuevoProveedor.id_proveedor) == null)
                {
                    proveedorService.createProveedor(nuevoProveedor);
                    MessageBox.Show("proveedor registrado exitosamente");
                    gestionProveedores_Load(sender, e);
                    return;

                }
                else
                {
                    Proveedor proveedorEncontrado = proveedorService.getProveedor(nuevoProveedor.id_proveedor);
                    DialogResult result = MessageBox.Show(
                       "El código del producto ya existe. ¿Desea modificar este proveedor: " + proveedorEncontrado.nombre + " ?",
                       "Confirmación",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
   );

                    if (result == DialogResult.Yes)
                    {
                        // Proceder con la actualización
                        var BoolModificado = proveedorService.updateProveedor(nuevoProveedor);
                        if (BoolModificado != null)
                        {
                            MessageBox.Show("Proveedor modificado exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error");
                        }
                        gestionProveedores_Load(sender, e);
                        return;
                    }
                    else
                    {
                        // Cancelar la operación
                        MessageBox.Show("La modificación del proveedor ha sido cancelada.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar un proveedor en la base de datos: " + ex.Message);
            }
            // Si todas las validaciones son correctas, se guarda el proveedor
            MessageBox.Show("Proveedor guardado correctamente.");
        }

        private void txtProveedorCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedorTelefono_TextChanged(object sender, EventArgs e)
        {
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

        private void txtProveedorDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedorNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboxProveedorEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedorSitioWeb_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedorEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var estadoService = new EstadoService();
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGrid_proveedores.Rows[e.RowIndex];

                // Rellenar los TextBox con los datos de la fila
                if (row.Cells["CodigoProveedor"].Value != null)
                {
                    txtProveedorCodigo.Text = row.Cells["CodigoProveedor"].Value.ToString();
                }
                else
                {
                    txtProveedorCodigo.Text = "";
                }

                if (row.Cells["nombreProveedor"].Value != null)
                {
                    txtProveedorNombre.Text = row.Cells["nombreProveedor"].Value.ToString();
                }
                else
                {
                    txtProveedorNombre.Text = "";
                }

                if (row.Cells["sitioWebProveedor"].Value != null)
                {
                    txtProveedorSitioWeb.Text = row.Cells["sitioWebProveedor"].Value.ToString();
                }
                else
                {
                    txtProveedorSitioWeb.Text = "";
                }
                if (row.Cells["telefonoProveedor"].Value != null)
                {
                    txtProveedorTelefono.Text = row.Cells["telefonoProveedor"].Value.ToString();
                }
                else
                {
                    txtProveedorTelefono.Text = "";
                }
                if (row.Cells["direccionProveedor"].Value != null)
                {
                    txtProveedorDireccion.Text = row.Cells["direccionProveedor"].Value.ToString();
                }
                else
                {
                    txtProveedorDireccion.Text = "";
                }
                if (row.Cells["emailProveedor"].Value != null)
                {
                    txtProveedorEmail.Text = row.Cells["emailProveedor"].Value.ToString();
                }
                else
                {
                    txtProveedorEmail.Text = "";
                }

                if (row.Cells["detalleProveedorEstado"].Value != null)
                {
                    string nombreEstado = row.Cells["detalleProveedorEstado"].Value.ToString();
                    int? estadoID = estadoService.GetEstadoIdByNombre(nombreEstado);

                    cboxProveedorEstado.SelectedValue = estadoID;
                }
                else
                {
                    cboxProveedorEstado.SelectedIndex = -1;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_proveedor_Click(object sender, EventArgs e)
        {
            gestionProveedores_Load(sender, e);
        }

        private void btn_eliminar_proveedor_Click(object sender, EventArgs e)
        {
            // Validar TextBox de Nombre
            string codigoProveedor;
            string direccionProveedor;
            string telefonoProveedor;
            string emailProveedor;
            string webProveedor;

            if (string.IsNullOrWhiteSpace(txtProveedorCodigo.Text))
            {
                codigoProveedor = "0";
            }
            else
            {
                codigoProveedor = txtProveedorCodigo.Text;
            }


            if (string.IsNullOrWhiteSpace(txtProveedorDireccion.Text))
            {
                direccionProveedor = "";
            }
            else
            {
                direccionProveedor = txtProveedorDireccion.Text;
            }


            if (string.IsNullOrWhiteSpace(txtProveedorTelefono.Text))
            {
                telefonoProveedor = "";
            }
            else
            {
                telefonoProveedor = txtProveedorTelefono.Text;
            }


            if (string.IsNullOrWhiteSpace(txtProveedorEmail.Text))
            {
                emailProveedor = "";
            }
            else
            {
                emailProveedor = txtProveedorEmail.Text;
            }


            if (string.IsNullOrWhiteSpace(txtProveedorSitioWeb.Text))
            {
                webProveedor = "";
            }
            else
            {
                webProveedor = txtProveedorSitioWeb.Text;
            }

            if (string.IsNullOrWhiteSpace(txtProveedorNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                txtProveedorNombre.Focus();
                return;
            }

            // Validar ComboBox de Estado
            if (cboxProveedorEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Estado.");
                cboxProveedorEstado.Focus();
                return;
            }


            string nombreProveedor = txtProveedorNombre.Text;
            int estadoProveedor = (int)cboxProveedorEstado.SelectedValue;

            try
            {
                var nuevoProveedor = new Proveedor
                {
                    id_proveedor = int.Parse(codigoProveedor),
                    nombre = nombreProveedor,
                    direccion = direccionProveedor,
                    telefono = telefonoProveedor,
                    email = emailProveedor,
                    web = webProveedor,
                    id_estado = estadoProveedor
                };

                ProveedorServices proveedorService = new ProveedorServices();
                if (nuevoProveedor.id_proveedor == 0 || proveedorService.getProveedor(nuevoProveedor.id_proveedor) == null)
                {
                    MessageBox.Show("no se encontro el proveedor");
                    gestionProveedores_Load(sender, e);
                    return;

                }
                else
                {
                    Proveedor proveedorEncontrado = proveedorService.getProveedor(nuevoProveedor.id_proveedor);
                    DialogResult result = MessageBox.Show(
                       "El código del producto ya existe. ¿Desea dar de baja este proveedor: " + proveedorEncontrado.nombre + " ?",
                       "Confirmación",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
   );

                    if (result == DialogResult.Yes)
                    {
                        // Proceder con la actualización
                        proveedorService.deleteProveedor(nuevoProveedor.id_proveedor);
                        MessageBox.Show("proveedor dado de baja correctamente");
                        gestionProveedores_Load(sender, e);
                        return;

                    }
                    else
                    {
                        // Cancelar la operación
                        MessageBox.Show("La eliminacion del proveedor ha sido cancelada.");
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo eliminar el proveedor: " + ex);
            }
        }
    }
}
