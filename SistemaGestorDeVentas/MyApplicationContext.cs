using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeVentas
{
    internal class MyApplicationContext : ApplicationContext
    {
        public MyApplicationContext(Form mainForm) : base(mainForm)
        {
        }

        public void SwitchMainForm(Form newMainForm)
        {
            //// Establece la nueva ventana principal antes de cerrar la actual
            //Form currentMainForm = MainForm;
            //MainForm = newMainForm;

            //// Muestra la nueva ventana principal
            //MainForm.Show();

            //// Cierra la ventana anterior (si no es la misma que la nueva)
            //currentMainForm.Close();

            //--------
            //Form oldMainForm = MainForm; // Guarda la referencia a la ventana actual

            //// Asigna primero la nueva ventana como ventana principal
            //MainForm = newMainForm;
            //MainForm.Show(); // Muestra la nueva ventana

            //oldMainForm?.Hide(); // Oculta la ventana anterior

            //if (oldMainForm == newMainForm)
            //{
            //    newMainForm.Show();
            //    MainForm.Close();
            //}
            //else
            //{
            //    // Ahora es seguro cerrar la anterior
            //    oldMainForm?.Close();
            //}

            //Form oldMainForm = MainForm; // Guarda la referencia a la ventana actual

            //// Si el nuevo formulario es el mismo que el actual, no hagas nada
            //if (oldMainForm == newMainForm)
            //{
            //    return;
            //}

            //// Asigna el nuevo formulario como el principal
            //MainForm = newMainForm;
            //MainForm.Show(); // Muestra la nueva ventana

            //// Cierra la anterior solo si es distinta a la nueva
            //oldMainForm?.Close();

            if (newMainForm == null)
                throw new ArgumentNullException(nameof(newMainForm));

            Form oldMainForm = MainForm; // Guarda la referencia a la ventana actual

            if (oldMainForm == newMainForm)
            {
                return; // Si es la misma ventana, no hacer nada
            }

            // Asigna el nuevo formulario como la ventana principal
            MainForm = newMainForm;

            // Antes de cerrar el anterior, mostrar la nueva ventana y asignarla correctamente al contexto
            MainForm.Show();

            // Usar Invoke para asegurarse de que el cierre ocurre en el hilo correcto
            oldMainForm?.BeginInvoke(new Action(() =>
            {
                oldMainForm.Close();
            }));
        }
    }
}
