using SistemaGestorDeVentas.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeVentas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        //public static MyApplicationContext AppContext; // Variable global 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new paginaInicio());
            // Crea el contexto de la aplicación con la ventana de inicio de sesión como ventana principal
            //AppContext = new MyApplicationContext(new paginaInicio());

            //// Ejecuta la aplicación con el contexto personalizado
            //Application.Run(AppContext);
        }
    }
}
