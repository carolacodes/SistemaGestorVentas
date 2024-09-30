﻿using SistemaGestorDeVentas.api.cart;
using SistemaGestorDeVentas.api.category;
using SistemaGestorDeVentas.api.cliente;
using SistemaGestorDeVentas.api.compra;
using SistemaGestorDeVentas.api.Negocio;
using SistemaGestorDeVentas.api.product;
using SistemaGestorDeVentas.api.proveedor;
using SistemaGestorDeVentas.api.report;
using SistemaGestorDeVentas.api.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeVentas.components
{
    public partial class navegador : Form
    {
        public navegador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is cartView);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                cartView cartView = new cartView();
                
                cartView.MdiParent = this;
                cartView.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                cartView.Show();
                
                
                
            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill;
        }

        private void navegador_Load(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is detalleVenta);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                detalleVenta detalleVenta = new detalleVenta();

                detalleVenta.MdiParent = this;
                detalleVenta.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                detalleVenta.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is adminGestionProduct);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                adminGestionProduct producto = new adminGestionProduct();

                producto.MdiParent = this;
                producto.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                producto.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is categoryMenu);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                categoryMenu categoria = new categoryMenu();

                categoria.MdiParent = this;
                categoria.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                categoria.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is detalleCliente);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                detalleCliente cliente = new detalleCliente();

                cliente.MdiParent = this;
                cliente.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                cliente.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is compraProducto);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                compraProducto compra = new compraProducto();

                compra.MdiParent = this;
                compra.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                compra.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void consultarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is detalleCompraProducto);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                detalleCompraProducto detalleCompra = new detalleCompraProducto();

                detalleCompra.MdiParent = this;
                detalleCompra.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                detalleCompra.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is gestionProveedores);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                gestionProveedores proveedor = new gestionProveedores();

                proveedor.MdiParent = this;
                proveedor.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                proveedor.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is reporteView);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                reporteView reportes = new reporteView();

                reportes.MdiParent = this;
                reportes.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                reportes.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void negocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is gestionNegocio);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                gestionNegocio negocio = new gestionNegocio();

                negocio.MdiParent = this;
                negocio.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                negocio.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si el formulario cartView ya está abierto
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(form => form is usuarioView);

            if (existingForm != null)
            {
                // Si ya está abierto, traerlo al frente
                existingForm.BringToFront();
            }
            else
            {
                // Si no está abierto, crear una nueva instancia

                usuarioView usuario = new usuarioView();

                usuario.MdiParent = this;
                usuario.Dock = DockStyle.Fill; // Ajustar al tamaño del contenedor
                usuario.Show();



            }
            //cartView cartView = new cartView();
            //cartView.MdiParent = this;
            //cartView.Show();
            //cartView.Dock = DockStyle.Fill
        }

        private void navegador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

            /*
             DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                //cancelar el cierre
                e.Cancel = true;
            }else
            {
                Application.Exit();
            }*/

        }
    }
}