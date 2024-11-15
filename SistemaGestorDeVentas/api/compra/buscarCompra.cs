using SistemaGestorDeVentas.api.user;
using SistemaGestorDeVentas.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.compra
{
    public partial class buscarCompra : Form
    {
        detalleCompraProducto _detalleCompraProducto;
        public buscarCompra(detalleCompraProducto detalleCompraProducto)
        {
            InitializeComponent();
            _detalleCompraProducto = detalleCompraProducto;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarCompra_Load(object sender, EventArgs e)
        {
            CompraService compraService = new CompraService();
            List<Compra> compras = compraService.getCompras();

            foreach (Compra compra in compras)
            {
                dataGridBuscarCompras.Rows.Add(compra.id_compra, compra.fecha_compra, compra.DNI_usuario);
            }
           

        }

        private void dataGridBuscarCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserService userService = new UserService();

            if (e.RowIndex >= 0)
            {
                //obtengo la fila que selecciono el cliente
                DataGridViewRow row = dataGridBuscarCompras.Rows[e.RowIndex];

                _detalleCompraProducto.txtCartDetalleNroVenta.Text = row.Cells["BuscarCompraNroCompra"].Value.ToString();
                // Asigna los valores directamente a los TextBox en _carritoForm
                var dniUsuario = row.Cells["BuscarCompraDniUsuario"].Value.ToString();
                Usuario userEncontrado = userService.getUser(dniUsuario);
                if (userEncontrado != null)
                {
                    _detalleCompraProducto.txtUsuarioCompra.Text = userEncontrado.nombre;
                }
                
                DateTime dateTime = (DateTime)row.Cells["BuscarCompraFecha"].Value;

                _detalleCompraProducto.dateCartDetalleFecha.Value = dateTime;

                this.Close();
            }
        }
    }
}
