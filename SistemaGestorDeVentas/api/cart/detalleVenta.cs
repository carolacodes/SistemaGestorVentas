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
using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.api.user;
using SistemaGestorDeVentas.api.product;
using SistemaGestorDeVentas.api.negocio;


namespace SistemaGestorDeVentas.api.cart
{
    public partial class detalleVenta : Form
    {
        //public static string NombreNegocio { get; set; }
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
            dateCartDetalleFecha.Value = DateTime.Today;
            txtTipoDocumento.Text = "Factura";
            CalcularTotal();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            GenerarPDF();
        }

        public void GenerarPDF()
        {
            // Obtén los datos de la factura usando el DAO

            FacturaService facturaDao = new FacturaService();

            var cod_venta = txtCartDetalleNroVenta.Text;

            if (string.IsNullOrEmpty(cod_venta))
            {
               MessageBox.Show("Debe ingresar un numero de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Intentar convertir a número entero
            if (!int.TryParse(cod_venta, out int codVentaInt))
            {
                MessageBox.Show("El número de venta debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si no se puede convertir
            }

            Factura facturaEncontrada = facturaDao.getFactura(codVentaInt);

            // Validar si se encontró la factura
            if (facturaEncontrada == null)
            {
                MessageBox.Show("No se encontró la factura con el número de venta especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si no se encuentra la factura
            }

            string rutaCarpeta = @"E:\CAROLA\CAROLA FACULTAD\TERCER AÑO\SEGUNDO CUATRIMESTRE\taller\SistemaGestorVentas\facturas_ventas";
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }
            string fechaHoraActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // Define la ruta completa con el nombre del archivo
            string rutaArchivo = Path.Combine(rutaCarpeta, $"Factura_{facturaEncontrada.numero_factura}_{fechaHoraActual}.pdf");

            // Define el nombre y la ruta del archivo PDF
            //string rutaArchivo = $@"C:\Factura_{facturaEncontrada.numero_factura}.pdf";

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
            doc.Add(new Paragraph($"Fecha: {dateCartDetalleFecha.Value} \n", textoNormalFont));
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
            doc.Add(new Paragraph($"Vendedor: {txtUsuario.Text}", textoNormalFont));
            doc.Add(new Paragraph(" "));

            var tituloProductos = new Paragraph("-- Productos Comprados --", subtituloFont);
            tituloProductos.Alignment = Element.ALIGN_LEFT;
            doc.Add(tituloProductos);
            doc.Add(new Paragraph(" "));

            // Tabla de productos
            PdfPTable tabla = new PdfPTable(dataProductosVenta.Columns.Count);
            tabla.WidthPercentage = 100;

            // Agregar el encabezado de la tabla
            foreach (DataGridViewColumn columna in dataProductosVenta.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(columna.HeaderText, encabezadoFont));
                cell.BackgroundColor = BaseColor.Gray; // Cambiar a gris claro o el color deseado
                tabla.AddCell(cell);
            }

            // Agregar las filas de datos a la tabla
            foreach (DataGridViewRow fila in dataProductosVenta.Rows)
            {
                // Verifica si la fila no es una fila nueva para evitar errores
                if (!fila.IsNewRow)
                {
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        tabla.AddCell(new Phrase(celda.Value?.ToString() ?? "", textoNormalFont));
                    }
                }
            }



            // Agrega la tabla al documento
            doc.Add(tabla);

            // Monto total
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Monto Total: {txtMontoTotal.Text}", encabezadoFont));


            NegocioService negocioService = new NegocioService();
            Negocio negocioEncontrado = negocioService.getNegocio(1);

            // Pie de página con datos de la empresa
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Datos de la Empresa:", encabezadoFont));
            doc.Add(new Paragraph($"Empresa: {negocioEncontrado.nombre}", textoNormalFont));
            doc.Add(new Paragraph($"Dirección: {negocioEncontrado.direccion}", textoNormalFont));
            doc.Add(new Paragraph($"R.U.T.: {negocioEncontrado.rut}", textoNormalFont));
            //doc.Add(new Paragraph("Teléfono: +123 456 789", textoNormalFont));
            //doc.Add(new Paragraph("Email: contacto@empresa.com", textoNormalFont));

            // Cierra el documento
            doc.Close();

            VentaService ventaService = new VentaService();
            Venta ventaExiste = ventaService.getVenta(codVentaInt);
            if (ventaExiste != null)
            {
                Factura factura = new Factura
                {
                    cod_venta = ventaExiste.cod_venta,
                    id_negocio = negocioEncontrado.id_negocio,
                };
                facturaDao.crearFactura(factura);
            }
            
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

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            var cod_venta = txtCartDetalleNroVenta.Text;
            if (string.IsNullOrEmpty(cod_venta))
            {
                buscarVenta buscarVenta = new buscarVenta(this);
                buscarVenta.Show();
            }
            else
            {
                try
                {
                    ProductoVentaService prodVentaService = new ProductoVentaService();
                    UserService userServices = new UserService();
                    ClienteService clienteService = new ClienteService();
                    VentaService ventaService = new VentaService();
                    ProductService productService = new ProductService();
                    Venta ventaExiste = ventaService.getVenta(int.Parse(cod_venta));
                    if (ventaExiste != null)
                    {
                        //cargamos la fecha
                        DateTime dateTime = ventaExiste.fecha_venta;
                        dateCartDetalleFecha.Value = dateTime;

                        //BUSCAMOS EL USUARIO
                        var dni_usuario = ventaExiste.DNI_usuario;
                        Usuario usuarioEncontrado = userServices.getUser(dni_usuario);
                        txtUsuario.Text = usuarioEncontrado.nombre;

                        //BUSCAMOS EL CLIENTE
                        var dni_cliente = ventaExiste.DNI_cliente;
                        Cliente clienteEncontrado = clienteService.getCliente(dni_cliente);
                        txtClienteVenta.Text = dni_cliente;
                        txtNombreCliVenta.Text = clienteEncontrado.nombre;

                        //BUSCAMOS EL PRODUCTO-VENTA
                        //lista de productos_venta con el mismo codigo de venta
                        List<Producto_Venta> producto_ventas= prodVentaService.getProductVentaByCodVenta(ventaExiste.cod_venta);

                        foreach(var productVenta in producto_ventas)
                        {
                            Producto productoEncontrado = productService.getProductService(productVenta.id_producto);
                            var subtotal = productoEncontrado.precio_venta * productVenta.cantidad;
                            dataProductosVenta.Rows.Add(productoEncontrado.nombre, productoEncontrado.precio_venta, productVenta.cantidad, subtotal);
                        }

                        CalcularTotal();

                        //NegocioService negocioService = new NegocioService();
                        //Negocio negocioEncontrado = negocioService.getNegocio(1);

                        //FacturaService facturaService = new FacturaService();
                        //Factura factura = new Factura
                        //{
                        //    cod_venta = ventaExiste.cod_venta,
                        //    id_negocio = negocioEncontrado.id_negocio,
                        //};
                        //facturaService.crearFactura(factura);
                        btnClear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Numero de venta no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar obtener el detalle de la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dateCartDetalleFecha.Value = DateTime.Today;
            txtCartDetalleNroVenta.Text = "";
            txtMontoTotal.Text = "";
            txtClienteVenta.Text = "";
            txtNombreCliVenta.Text = "";
            txtUsuario.Text = "";
            dataProductosVenta.Rows.Clear();
        }

        public void CalcularTotal()
        {
            decimal total = 0;

            // Recorre todas las filas del DataGridView
            foreach (DataGridViewRow row in dataProductosVenta.Rows)
            {
                // Verifica que la fila no sea la fila vacía al final del DataGridView
                if (row.Cells["DetalleCardSubtotal"].Value != null)
                {
                    // Intenta convertir el valor de la columna 'cartSubtotal' a decimal y acumularlo
                    decimal subtotal;
                    if (decimal.TryParse(row.Cells["DetalleCardSubtotal"].Value.ToString(), out subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            // Asigna el total calculado al TextBox txtTotal
            txtMontoTotal.Text = total.ToString(); // Formato de dos decimales
        }
    }
}
