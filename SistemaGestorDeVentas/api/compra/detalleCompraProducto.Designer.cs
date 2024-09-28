﻿using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.compra
{
    partial class detalleCompraProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private SistemaGestorDeVentas.components.navLogo navLogo;
        private SistemaGestorDeVentas.navbar navbar;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navLogo = new SistemaGestorDeVentas.components.navLogo();
            this.Controls.Add(this.navLogo);
            // Ajustes de posición, tamaño y otras propiedades
            this.navLogo.Location = new System.Drawing.Point(0, 0);
            this.navLogo.Size = new System.Drawing.Size(1129, 68); // Ajusta según sea necesario
            this.navLogo.Dock = DockStyle.Top; // Para que siempre esté en la parte superior

            this.navbar = new SistemaGestorDeVentas.navbar();
            this.Controls.Add(this.navbar);

            // Ajustes de posición, tamaño y otras propiedades
            this.navbar.Location = new System.Drawing.Point(0, 68); // Mueve el navbar 68 píxeles hacia abajo
            this.navbar.Size = new System.Drawing.Size(1129, 58); // Ajusta el tamaño según sea necesario

            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCartDetalleNroVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DetalleCompraProvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCompraProvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCompraProvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCompraProvSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateCartDetalleFecha = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(9, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 458);
            this.panel3.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(857, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Estado Compra";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(845, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(835, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "Descargar PDF";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(869, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Monto Total";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(845, 355);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(142, 20);
            this.textBox8.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Azure;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.txtCartDetalleNroVenta);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(734, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(360, 92);
            this.panel6.TabIndex = 16;
            // 
            // button5
            // 
            this.button5.Image = global::SistemaGestorDeVentas.Properties.Resources.limpiar;
            this.button5.Location = new System.Drawing.Point(306, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 44);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.button4.Location = new System.Drawing.Point(255, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 44);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtCartDetalleNroVenta
            // 
            this.txtCartDetalleNroVenta.Location = new System.Drawing.Point(127, 32);
            this.txtCartDetalleNroVenta.Name = "txtCartDetalleNroVenta";
            this.txtCartDetalleNroVenta.Size = new System.Drawing.Size(125, 20);
            this.txtCartDetalleNroVenta.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Numero Compra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleCompraProvProducto,
            this.DetalleCompraProvPrecio,
            this.DetalleCompraProvCantidad,
            this.DetalleCompraProvSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(19, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 186);
            this.dataGridView1.TabIndex = 8;
            // 
            // DetalleCompraProvProducto
            // 
            this.DetalleCompraProvProducto.HeaderText = "Producto";
            this.DetalleCompraProvProducto.MinimumWidth = 6;
            this.DetalleCompraProvProducto.Name = "DetalleCompraProvProducto";
            this.DetalleCompraProvProducto.Width = 125;
            // 
            // DetalleCompraProvPrecio
            // 
            this.DetalleCompraProvPrecio.HeaderText = "Precio Compra";
            this.DetalleCompraProvPrecio.MinimumWidth = 6;
            this.DetalleCompraProvPrecio.Name = "DetalleCompraProvPrecio";
            this.DetalleCompraProvPrecio.Width = 125;
            // 
            // DetalleCompraProvCantidad
            // 
            this.DetalleCompraProvCantidad.HeaderText = "Cantidad";
            this.DetalleCompraProvCantidad.MinimumWidth = 6;
            this.DetalleCompraProvCantidad.Name = "DetalleCompraProvCantidad";
            this.DetalleCompraProvCantidad.Width = 125;
            // 
            // DetalleCompraProvSubtotal
            // 
            this.DetalleCompraProvSubtotal.HeaderText = "Subtotal";
            this.DetalleCompraProvSubtotal.MinimumWidth = 6;
            this.DetalleCompraProvSubtotal.Name = "DetalleCompraProvSubtotal";
            this.DetalleCompraProvSubtotal.Width = 125;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(19, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(709, 110);
            this.panel5.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(208, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre Completo ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nro Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Informacion Proveedor";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateCartDetalleFecha);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(19, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 92);
            this.panel4.TabIndex = 1;
            // 
            // dateCartDetalleFecha
            // 
            this.dateCartDetalleFecha.Location = new System.Drawing.Point(7, 54);
            this.dateCartDetalleFecha.Name = "dateCartDetalleFecha";
            this.dateCartDetalleFecha.Size = new System.Drawing.Size(143, 20);
            this.dateCartDetalleFecha.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(354, 54);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.comboBox1.Location = new System.Drawing.Point(158, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informacion Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Compra";
            // 
            // detalleCompraProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 630);
            this.Controls.Add(this.panel3);
            this.Name = "detalleCompraProducto";
            this.Text = "detalleCompraProducto";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCartDetalleNroVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateCartDetalleFecha;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCompraProvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCompraProvPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCompraProvCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCompraProvSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}