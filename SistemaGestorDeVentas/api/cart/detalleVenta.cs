using SistemaGestorDeVentas.api.factura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemaGestorDeVentas.db;


namespace SistemaGestorDeVentas.api.cart
{
    public partial class detalleVenta : Form
    {
        public detalleVenta()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateCartDetalleFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dateCartDetalleFecha.Value == null || dateCartDetalleFecha.Value == DateTime.MinValue)
            {
                dateCartDetalleFecha.Value = DateTime.Now;
            }
        }

        private void txtCartDetalleNroVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtCartDetalleNroVenta_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtCartDetalleNroVenta.Text))
            //{
            //    MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    e.Cancel = true;
            //}
        }

        private void detalleVenta_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            GenerarPDF();
        }

        public void GenerarPDF()
        {
            // Obtén los datos de la factura usando el DAO

            FacturaService facturaDao = new FacturaService();

            int cod_venta = int.Parse(txtCartDetalleNroVenta.Text);

            Factura facturaEncontrada = facturaDao.getFactura(cod_venta);

            if (facturaEncontrada is null)
            {
                throw new Exception("No se encontró la factura con el numero de venta especificado.");
            }

            // Define el nombre y la ruta del archivo PDF
            string rutaArchivo = $@"C:\Factura_{facturaEncontrada.numero_factura}.pdf";

            // Crea el documento PDF
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            // Estilos de fuente
            var tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.Blue);
            var subtituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.Black);
            var encabezadoFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.Black);
            var textoNormalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.Black);

            // Encabezado: Número de factura y fecha
            doc.Add(new Paragraph($"Factura No. {facturaEncontrada.numero_factura}", encabezadoFont));
            doc.Add(new Paragraph($"Fecha: {dateCartDetalleFecha.Text} \n", textoNormalFont));
            doc.Add(new Paragraph(" ")); // Espacio

            // Título "Factura de Compra"
            var titulo = new Paragraph("Factura de Compra", tituloFont);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(new Paragraph(" "));

            // Información del cliente y usuario
            doc.Add(new Paragraph($"DNI Cliente: {txtClienteVenta.Text}", textoNormalFont));
            doc.Add(new Paragraph($"Nombre Cliente: {txtNombreCliVenta.Text}", textoNormalFont));
            doc.Add(new Paragraph($"Documento: {txtTipoDocumento.Text}", textoNormalFont));
            doc.Add(new Paragraph($"Usuario: {txtUsuario.Text}", textoNormalFont));
            doc.Add(new Paragraph(" "));

            var tituloProductos = new Paragraph("-- Productos Comprados --", subtituloFont);
            tituloProductos.Alignment = Element.ALIGN_RIGHT;
            doc.Add(tituloProductos);
            doc.Add(new Paragraph(" "));

            // Tabla de productos
            PdfPTable tabla = new PdfPTable(dataProductosVenta.Columns.Count);
            tabla.WidthPercentage = 100;

            // Agrega el encabezado de la tabla
            foreach (DataColumn columna in dataProductosVenta.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(columna.ColumnName, encabezadoFont));
                cell.BackgroundColor = BaseColor.Gray; //LIGHT_GRAY
                tabla.AddCell(cell);
            }

            // Agrega las filas de datos a la tabla
            foreach (DataRow fila in dataProductosVenta.Rows)
            {
                foreach (var item in fila.ItemArray)
                {
                    tabla.AddCell(new Phrase(item.ToString(), textoNormalFont));
                }
            }

            // Agrega la tabla al documento
            doc.Add(tabla);

            // Monto total
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Monto Total: {txtMontoTotal.Text}", encabezadoFont));

            // Pie de página con datos de la empresa
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Datos de la Empresa:", encabezadoFont));
            doc.Add(new Paragraph("Empresa XYZ S.A.", textoNormalFont));
            doc.Add(new Paragraph("Dirección: Av. Siempre Viva 123, Ciudad", textoNormalFont));
            doc.Add(new Paragraph("Teléfono: +123 456 789", textoNormalFont));
            doc.Add(new Paragraph("Email: contacto@empresa.com", textoNormalFont));

            // Cierra el documento
            doc.Close();

            MessageBox.Show($"El PDF de la factura {facturaEncontrada.numero_factura} se ha generado correctamente en la ruta: {rutaArchivo}");
        }

        public void GenerarPDF2()
        {
            // Obtiene los datos de la factura usando el DAO
            FacturaDao facturaDao = new FacturaDao();
            int cod_venta;

            // Verifica y convierte el ID de la venta
            if (!int.TryParse(txtCartDetalleNroVenta.Text, out cod_venta))
            {
                MessageBox.Show("Por favor ingresa un número de venta válido.");
                return;
            }

            Factura facturaEncontrada = facturaDao.getFacturaDao(cod_venta);
            if (facturaEncontrada is null)
            {
                MessageBox.Show("No se encontró la factura con el ID especificado.");
                return;
            }

            // Define el nombre y la ruta del archivo PDF
            string rutaArchivo = $"Factura_{facturaEncontrada.numero_factura}.pdf";

            // Crea el documento PDF
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            // Estilos de fuente
            var tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
            var encabezadoFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            var textoNormalFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            // Encabezado: Número de factura y fecha
            doc.Add(new Paragraph($"Factura No. {facturaEncontrada.numero_factura}", encabezadoFont));
            doc.Add(new Paragraph($"Fecha: {dateCartDetalleFecha.Text}", textoNormalFont));
            doc.Add(new Paragraph(" ")); // Espacio

            // Título "Factura de Compra"
            var titulo = new Paragraph("Factura de Compra", tituloFont);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(new Paragraph(" "));

            // Información del cliente y usuario
            doc.Add(new Paragraph($"DNI Cliente: {txtClienteVenta.Text}", textoNormalFont));
            doc.Add(new Paragraph($"Nombre Cliente: {txtNombreCliVenta.Text}", textoNormalFont));
            doc.Add(new Paragraph($"Documento: {txtTipoDocumento.Text}", textoNormalFont));
            doc.Add(new Paragraph($"Usuario: {txtUsuario.Text}", textoNormalFont));
            doc.Add(new Paragraph(" "));

            // Tabla de productos
            PdfPTable tabla = new PdfPTable(dataProductosVenta.Columns.Count);
            tabla.WidthPercentage = 100;

            // Agrega el encabezado de la tabla
            foreach (DataColumn columna in dataProductosVenta.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(columna.ColumnName, encabezadoFont));
                cell.BackgroundColor = BaseColor.Gray; //LIGHT_GRAY
                tabla.AddCell(cell);
            }

            // Agrega las filas de datos a la tabla
            foreach (DataRow fila in dataProductosVenta.Rows)
            {
                foreach (var item in fila.ItemArray)
                {
                    tabla.AddCell(new Phrase(item.ToString(), textoNormalFont));
                }
            }

            // Agrega la tabla al documento
            doc.Add(tabla);

            // Monto total
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Monto Total: {txtMontoTotal.Text}", encabezadoFont));

            // Pie de página con datos de la empresa
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Datos de la Empresa:", encabezadoFont));
            doc.Add(new Paragraph("Empresa XYZ S.A.", textoNormalFont));
            doc.Add(new Paragraph("Dirección: Av. Siempre Viva 123, Ciudad", textoNormalFont));
            doc.Add(new Paragraph("Teléfono: +123 456 789", textoNormalFont));
            doc.Add(new Paragraph("Email: contacto@empresa.com", textoNormalFont));

            // Cierra el documento
            doc.Close();

            MessageBox.Show($"El PDF de la factura {facturaEncontrada.numero_factura} se ha generado correctamente en la ruta: {rutaArchivo}");
        }
    }
}
