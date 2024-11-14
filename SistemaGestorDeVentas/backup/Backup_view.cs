using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeVentas.backup
{
    public partial class Backup_view : Form
    {
        Backup backup = new Backup();
        public Backup_view()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_backup_Click(object sender, EventArgs e)
        {

            // Mostrar ventana emergente de confirmación
            var result = MessageBox.Show("¿Desea realizar un Backup de la base de datos?", "Confirmación de Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar si el usuario seleccionó "Sí"
            if (result == DialogResult.Yes)
            {
             
                // Llamar a la función de backup
                backup.BackupDatabase();
                Backup_view_Load(sender, e);
            }
            else
            {
                // Si el usuario selecciona "No", no se hace nada y vuelve a la ventana principal
                MessageBox.Show("Operación de Backup cancelada.");
            }
        }

        private void Backup_view_Load(object sender, EventArgs e)
        {
            // Obtener la tabla con los datos de backups
            DataTable backupsTable = backup.ListBackups();

            // Limpiar el DataGridView antes de agregar los datos nuevos
            dataGrid_Backup.Rows.Clear();

            // Iterar sobre cada fila de la tabla y agregarla al DataGridView
            foreach (DataRow row in backupsTable.Rows)
            {
                dataGrid_Backup.Rows.Add(row["FileName"], row["FullPath"], row["CreationDate"]);
            }
        }

        private void dataGrid_Backup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_Backup.Rows[e.RowIndex];
                txt_backup_elegido.Text = row.Cells["nombre_backup"].Value.ToString();
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            // Verificar que el TextBox no esté vacío
            if (string.IsNullOrWhiteSpace(txt_backup_elegido.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del archivo de backup en el campo correspondiente.");
                return;
            }

            // Preguntar al usuario si desea realizar la restauración
            DialogResult result = MessageBox.Show("¿Está seguro de que desea restaurar la base de datos?",
                                                  "Confirmar Restauración",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // Nombre del archivo de backup

            if (result == DialogResult.Yes)
            {
                string backupFileName = txt_backup_elegido.Text;

                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    string databaseName = context.Database.Connection.Database;
                    // Llamar al método de restauración
                    bool restoreSuccessful = backup.RestoreDatabase(backupFileName, databaseName);
                    if (restoreSuccessful) {
                        MessageBox.Show("Restauración realizada con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("La restauración no se pudo completar. Verifique el archivo de backup.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Operación de restauración cancelada.");
            }
        }
    }
}
