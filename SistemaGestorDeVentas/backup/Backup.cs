using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SistemaGestorDeVentas.backup
{
    internal class Backup
    {
        public void BackupDatabase()
        {
            try
            {
                // Ruta del proyecto y creación de carpeta 'Backups' si no existe
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string backupFolder = Path.Combine(projectDirectory, "backup");

                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                // Ruta completa del archivo de backup con nombre y extensión
                string backupFilePath = Path.Combine(backupFolder, "Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak");

                using (var context = new sistema_de_ventas_taller_Entities())
                {
                    var commandText = $"BACKUP DATABASE [{context.Database.Connection.Database}] TO DISK = @backupFilePath WITH FORMAT, MEDIANAME = 'DB_Backup', NAME = 'Full Backup of Database';";
                    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, commandText,
                        new System.Data.SqlClient.SqlParameter("@backupFilePath", backupFilePath));
                }

                Console.WriteLine("Backup realizado con éxito en: " + backupFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error realizando el backup: " + ex.Message);
            }
        }

        public DataTable ListBackups()
        {
            DataTable backupsTable = new DataTable();
            backupsTable.Columns.Add("FileName", typeof(string));
            backupsTable.Columns.Add("FullPath", typeof(string));
            backupsTable.Columns.Add("CreationDate", typeof(DateTime));

            // Ruta específica para la carpeta "backup" en el proyecto
            string backupFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backup");

            // Verificar si la carpeta existe
            if (Directory.Exists(backupFolderPath))
            {
                // Obtener todos los archivos .bak en la carpeta
                var backupFiles = Directory.GetFiles(backupFolderPath, "*.bak");

                foreach (var filePath in backupFiles)
                {
                    FileInfo fileInfo = new FileInfo(filePath);
                    DataRow row = backupsTable.NewRow();
                    row["FileName"] = fileInfo.Name;
                    row["FullPath"] = fileInfo.FullName;
                    row["CreationDate"] = fileInfo.CreationTime;
                    backupsTable.Rows.Add(row);
                }
            }
            else
            {
                Console.WriteLine("La carpeta de backup no existe.");
            }

            return backupsTable;
        }

        public bool RestoreDatabase(string backupFileName, string databaseName)
        {
            try
            {
                // Ruta específica para la carpeta "backup" en el proyecto
                string backupFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "backup");

                // Construir la ruta completa al archivo de backup
                string backupFilePath = Path.Combine(backupFolderPath, backupFileName);

                // Verificar si el archivo de backup existe
                if (!File.Exists(backupFilePath))
                {
                    Console.WriteLine("El archivo de backup especificado no existe en la carpeta de Backups.");
                    return false;
                }

                // Obtener la cadena de conexión original y conectarse a la base de datos "master"
                var originalConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sistema_de_ventas_taller_Entities"].ConnectionString;
                var masterConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["masterConnection"].ConnectionString;


                using (var connection = new System.Data.SqlClient.SqlConnection(masterConnectionString))
                {
                    connection.Open();

                    // Cambiar la base de datos a modo SINGLE_USER
                    using (var command = new System.Data.SqlClient.SqlCommand($"ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Restaurar la base de datos
                    using (var command = new System.Data.SqlClient.SqlCommand($@"
                RESTORE DATABASE [{databaseName}] 
                FROM DISK = @backupFilePath
                WITH REPLACE", connection))
                    {
                        command.Parameters.AddWithValue("@backupFilePath", backupFilePath);
                        command.ExecuteNonQuery();
                    }

                    // Cambiar la base de datos de nuevo a MULTI_USER
                    using (var command = new System.Data.SqlClient.SqlCommand($"ALTER DATABASE [{databaseName}] SET MULTI_USER", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Restore realizado con éxito en la base de datos: " + databaseName);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error realizando el restore: " + ex.Message);
                return false;
            }
        }
    }
}
