﻿using SistemaGestorDeVentas.api.pago;
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

namespace SistemaGestorDeVentas.api.cart
{
    public partial class metodoPago : Form
    {
        private cartView _carritoForm;
        public metodoPago(cartView cartViewForm)
        {
            InitializeComponent();
            _carritoForm = cartViewForm;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaService ventaService = new VentaService();

            PagoService pagoService = new PagoService();

            MetodoPagoServices metodoService = new MetodoPagoServices();

            UserService userService = new UserService();


            //var totalPago = totalPagoMetodo.Text;
            var metodoElegido = cbMetodoPago.Text;
            
            var metodoObtenido = metodoService.getMetodoPagoByName(metodoElegido);


            // Define una variable para almacenar el total después de la conversión
            decimal totalPago;

            // Intenta convertir el texto a decimal
            string totalPagoText = totalPagoMetodo.Text.Replace("$", "").Trim();
            bool conversionExitosa = decimal.TryParse(totalPagoText, out totalPago);

            // Verifica si la conversión fue exitosa
            if (!conversionExitosa)
            {
                //MessageBox.Show("El total de pago no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("El total de pago no tiene un formato valido");
                return;
            }


            //DNI_usuario VARCHAR(200) NOT NULL,
            //nombre VARCHAR(200) NOT NULL,
            //email VARCHAR(200) NOT NULL,
            //pass VARCHAR(200) NOT NULL,
            //fecha_nacimiento DATE NOT NULL,
            //imagen_usuario VARCHAR(200) NOT NULL,
            //id_rol INT NOT NULL,
            //id_estado INT NOT NULL,

            //busco usuario por el email

            var email = "juanperez";

            Usuario usuarioEncontrado = userService.getUserByEmail(email);

            Usuario usuario = new Usuario
            {
                DNI_usuario = usuarioEncontrado.DNI_usuario,
                nombre = usuarioEncontrado.nombre,
                email = usuarioEncontrado.email,
                fecha_nacimiento = usuarioEncontrado.fecha_nacimiento,
                imagen_usuario = usuarioEncontrado.imagen_usuario, //agregar un varchar vacio
                id_rol = usuarioEncontrado.id_rol,
                id_estado = usuarioEncontrado.id_estado
            };

            Pago pago = new Pago
            {
                total = totalPago,
                id_metodo = metodoObtenido.id_metodo,
            };

            var venta = new Venta
            {
                fecha_venta = _carritoForm.dateCartViewFecha.Value,
                DNI_usuario = usuario.DNI_usuario,
                DNI_cliente = _carritoForm.txtCartViewDNI.Text,
                id_pago = pago.id_pago,
            };

            ventaService.crearVenta(venta);

            MessageBox.Show("La venta se registro exitosamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamations);


        }

        private void cbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadMetodosPago()
        {

            MetodoPagoServices metodoPagoServices = new MetodoPagoServices();

            // Suponiendo que getMetodosPago() devuelve una lista de strings con los nombres de métodos de pago
            List<Metodo_Pago> metodosPago = metodoPagoServices.getMetodosPago();

            // Limpiar cualquier ítem existente en el ComboBox
            cbMetodoPago.Items.Clear();

            // Añadir cada método de pago al ComboBox
            foreach (Metodo_Pago metodo in metodosPago)
            {
                cbMetodoPago.Items.Add(metodo.nombre);
            }
        }

        private void metodoPago_Load(object sender, EventArgs e)
        {
            LoadMetodosPago();
            totalPagoMetodo_Click(sender, e);

            // Suscribe el método txtPago_TextChanged al evento TextChanged de txtPago
            txtPago.TextChanged += txtPago_TextChanged;

            // Muestra un mensaje indicando que se debe ingresar el pago
            //if (string.IsNullOrEmpty(txtPago.Text))
            //{
            //    MessageBox.Show("Por favor ingrese el valor del pago: ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void totalPagoMetodo_Click(object sender, EventArgs e)
        {
            // Verifica que el total tenga un valor numérico antes de asignarlo
            if (float.TryParse(_carritoForm.txtTotal.Text, out float total))
            {
                totalPagoMetodo.Text = "$ " + total.ToString("F2");
            }
            else
            {
                totalPagoMetodo.Text = "$ 0.00"; // Valor predeterminado si el total no es válido
            }
        }

        //private void txtVuelto_TextChanged(object sender, EventArgs e)
        //{
        //    // Obtén los valores de los campos, y asegúrate de que no estén vacíos
        //    var pagoClienteText = txtPago.Text;
        //    var totalPagarText = _carritoForm.txtTotal.Text;

        //        // Verifica si ambos valores son válidos y pueden ser parseados como flotantes
        //        if (float.TryParse(totalPagarText, out float totalPagar) && float.TryParse(pagoClienteText, out float pagoCliente))
        //        {
        //            // Realiza el cálculo y asigna el valor al TextBox txtVuelto
        //            var vuelto = totalPagar - pagoCliente;
        //            txtVuelto.Text = vuelto.ToString("F2"); // Formato con dos decimales
        //        }
        //        else
        //        {
        //            // En caso de que alguno de los valores no sea numérico, muestra un mensaje o maneja el error
        //            txtVuelto.Text = "0.00"; // Opcional: valor predeterminado si hay un error de formato
        //        }
        //}

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            CalcularVuelto();
        }

        private void CalcularVuelto()
        {
            // Obtén los valores de los campos, y asegúrate de que no estén vacíos
            var pagoClienteText = txtPago.Text;
            var totalPagarText = _carritoForm.txtTotal.Text;

            // Verifica si ambos valores son válidos y pueden ser parseados como flotantes
            if (float.TryParse(totalPagarText, out float totalPagar) && float.TryParse(pagoClienteText, out float pagoCliente))
            {
                if(float.Parse(pagoClienteText) < float.Parse(totalPagarText))
                {
                    txtVuelto.Text = "0.00";
                }
                else
                {
                    // Realiza el cálculo y asigna el valor al TextBox txtVuelto
                    var vuelto = Math.Abs(totalPagar - pagoCliente);
                    txtVuelto.Text = vuelto.ToString(); // Formato con dos decimales
                }
            }
            else
            {
                // En caso de que alguno de los valores no sea numérico, muestra un mensaje o maneja el error
                txtVuelto.Text = "0.00"; // Valor predeterminado si hay un error de formato
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
