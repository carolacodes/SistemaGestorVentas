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

        private void cargarNAv(object sender, EventArgs e) {
            navbar nav = new navbar();

            nav.Dock = DockStyle.Fill;

            panelNav.Controls.Add(nav);
            
        }
        private void panelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gestionProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
