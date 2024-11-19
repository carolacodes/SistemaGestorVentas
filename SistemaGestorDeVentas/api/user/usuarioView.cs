using SistemaGestorDeVentas.api.proveedor;
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


            string dniUsuario = txtUsuarioDNI.Text;
            string nombreUsuario = txtUsuarioNombre.Text;
            string correoUsuario = txtUsuarioCorreo.Text;
            string contraseñaUsuario = txtUsuarioContraseña.Text;
            int estadoUsuario = (int)cboxUsuarioEstado.SelectedValue;
            int rolUsuario = (int)cboxUsuarioRol.SelectedValue;

            if (contraseñaUsuario == txtUsuarioConfirmarContraseña.Text)
            {
                try
                {
                    Usuario nuevoUsuario = new Usuario
                    {
                        DNI_usuario = dniUsuario,
                        nombre = nombreUsuario,
                        email = correoUsuario,
                        pass = contraseñaUsuario,
                        id_estado = estadoUsuario,
                        id_rol = rolUsuario,
                    };
                    UserService userService = new UserService();

                    if (userService.getUser(nuevoUsuario.DNI_usuario) == null)
                    {
                        userService.createUser(nuevoUsuario);
                        MessageBox.Show("Usuario registrado exitosamente");
                        usuarioView_Load(sender, e);
                        return;
                    }
                    else
                    {
                        Usuario usuarioEncontrado = userService.getUser(nuevoUsuario.DNI_usuario);
                        DialogResult result = MessageBox.Show(
                       "El usuario ya existe. ¿Desea modificar este usuario: " + usuarioEncontrado.nombre + " ?",
                       "Confirmación",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
   );

                        if (result == DialogResult.Yes)
                        {
                            // Proceder con la actualización
                            userService.updateUser(nuevoUsuario);
                            MessageBox.Show("Usuario modificado exitosamente");
                            usuarioView_Load(sender, e);
                            return;
                        }
                        else
                        {
                            // Cancelar la operación
                            MessageBox.Show("La modificación del usuario ha sido cancelada.");
                            return;
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar un usuario en la base de datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Vuelve a intentar");
                return;
            }
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

        public void limpiar()
        {
            txtUsuarioDNI.Clear();
            txtUsuarioNombre.Clear();
            txtUsuarioCorreo.Clear();
            txtUsuarioContraseña.Clear();
            txtUsuarioConfirmarContraseña.Clear();

            cboxUsuarioEstado.SelectedIndex = -1;
            cboxUsuarioRol.SelectedIndex = -1;

            // Si no está enlazado a una fuente de datos
            dataGrid_usuarios.Rows.Clear();

            // Si está enlazado a una fuente de datos
            dataGrid_usuarios.DataSource = null;

            // Opcional: Refrescar el control
            dataGrid_usuarios.Refresh();
        }
        private void usuarioView_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            List<Usuario> usuarios = userService.getUsers();
            EstadoService estadoService = new EstadoService();
            RolService rolService = new RolService();
            var estados = estadoService.getEstados();
            var roles = rolService.getRoles();

            cboxUsuarioEstado.DataSource = estados;
            cboxUsuarioEstado.DisplayMember = "nombre";
            cboxUsuarioEstado.ValueMember = "id_estado";

            cboxUsuarioRol.DataSource = roles;
            cboxUsuarioRol.DisplayMember = "nombre";
            cboxUsuarioRol.ValueMember = "id_rol";

            limpiar();

            foreach (var usuario in usuarios)
            {
                dataGrid_usuarios.Rows.Add(usuario.DNI_usuario, usuario.nombre,usuario.email ,usuario.pass,rolService.getRol(usuario.id_rol).nombre ,estadoService.getEstado(usuario.id_estado).nombre);
            }
        }

        private void dataGrid_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var estadoService = new EstadoService();
                var rolService = new RolService();
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGrid_usuarios.Rows[e.RowIndex];

                // Rellenar los TextBox con los datos de la fila
                if (row.Cells["listaUsuarioDni"].Value != null)
                {
                    txtUsuarioDNI.Text = row.Cells["listaUsuarioDni"].Value.ToString();
                }
                else
                {
                    txtUsuarioDNI.Text = "";
                }

                if (row.Cells["listaUsuarioNombre"].Value != null)
                {
                    txtUsuarioNombre.Text = row.Cells["listaUsuarioNombre"].Value.ToString();
                }
                else
                {
                    txtUsuarioNombre.Text = "";
                }

                if (row.Cells["listaUsuarioCorreo"].Value != null)
                {
                    txtUsuarioCorreo.Text = row.Cells["listaUsuarioCorreo"].Value.ToString();
                }
                else
                {
                    txtUsuarioCorreo.Text = "";
                }

                if (row.Cells["listaUsuarioContraseña"].Value != null)
                {
                    txtUsuarioContraseña.Text = row.Cells["listaUsuarioContraseña"].Value.ToString();
                }
                else
                {
                    txtUsuarioContraseña.Text = "";
                }


                //cboxProveedorEstado.Text =
                if (row.Cells["listaUsuarioEstado"].Value != null)
                {
                    string nombreEstado = row.Cells["listaUsuarioEstado"].Value.ToString();
                    int? estadoID = estadoService.GetEstadoIdByNombre(nombreEstado);
                    cboxUsuarioEstado.SelectedValue = estadoID;
                }
                else
                {
                    cboxUsuarioEstado.SelectedIndex = -1;
                }

                if (row.Cells["listaUsuarioRol"].Value != null)
                {
                    string nombreRol = row.Cells["listaUsuarioRol"].Value.ToString();
                    Rol rol = rolService.GetRolByNombre(nombreRol);
                    cboxUsuarioRol.SelectedValue = rol.id_rol;
                }
                else
                {
                    cboxUsuarioRol.SelectedIndex = -1;
                }
            }
        }

        private void btnUsuarioLimpiar_Click(object sender, EventArgs e)
        {
            usuarioView_Load(sender, e);
        }

        private void btnUsuarioEliminar_Click(object sender, EventArgs e)
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


            string dniUsuario = txtUsuarioDNI.Text;
            string nombreUsuario = txtUsuarioNombre.Text;
            string correoUsuario = txtUsuarioCorreo.Text;
            string contraseñaUsuario = txtUsuarioContraseña.Text;
            int estadoUsuario = (int)cboxUsuarioEstado.SelectedValue;
            int rolUsuario = (int)cboxUsuarioRol.SelectedValue;

            if (contraseñaUsuario == txtUsuarioConfirmarContraseña.Text)
            {
                try
                {
                    Usuario nuevoUsuario = new Usuario
                    {
                        DNI_usuario = dniUsuario,
                        nombre = nombreUsuario,
                        email = correoUsuario,
                        pass = contraseñaUsuario,
                        id_estado = estadoUsuario,
                        id_rol = rolUsuario,
                    };
                    UserService userService = new UserService();

                    if (userService.getUser(nuevoUsuario.DNI_usuario) == null)
                    {
                        MessageBox.Show("No se encuentra al usuario");
                        return;
                    }
                    else
                    {
                        Usuario usuarioEncontrado = userService.getUser(nuevoUsuario.DNI_usuario);
                        DialogResult result = MessageBox.Show(
                       "El usuario ya existe. ¿Desea dar de baja este usuario: " + usuarioEncontrado.nombre + " ?",
                       "Confirmación",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question
   );

                        if (result == DialogResult.Yes)
                        {
                            // Proceder con la actualización
                            userService.deleteUser(nuevoUsuario.DNI_usuario);
                            MessageBox.Show("Usuario dado de baja exitosamente");
                            usuarioView_Load(sender, e);
                            return;
                        }
                        else
                        {
                            // Cancelar la operación
                            MessageBox.Show("La baja del usuario ha sido cancelada.");
                            return;
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar un usuario en la base de datos: " + ex.Message);
                }
            }
        }
    }
}
