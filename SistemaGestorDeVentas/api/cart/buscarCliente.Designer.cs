﻿namespace SistemaGestorDeVentas.api.cart
{
    partial class buscarCliente
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detalleClienteDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCartViewDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 313);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(612, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtCartViewDNI);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleClienteDni,
            this.detalleClienteNombre,
            this.detalleClienteEstado,
            this.detalleClienteTelefono,
            this.detalleClienteCorreo,
            this.detalleClienteSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(28, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(714, 223);
            this.dataGridView1.TabIndex = 11;
            // 
            // detalleClienteDni
            // 
            this.detalleClienteDni.HeaderText = "Nro DNI";
            this.detalleClienteDni.MinimumWidth = 6;
            this.detalleClienteDni.Name = "detalleClienteDni";
            this.detalleClienteDni.Width = 125;
            // 
            // detalleClienteNombre
            // 
            this.detalleClienteNombre.HeaderText = "Nombre Completo";
            this.detalleClienteNombre.MinimumWidth = 6;
            this.detalleClienteNombre.Name = "detalleClienteNombre";
            this.detalleClienteNombre.Width = 125;
            // 
            // detalleClienteEstado
            // 
            this.detalleClienteEstado.HeaderText = "Estado";
            this.detalleClienteEstado.MinimumWidth = 6;
            this.detalleClienteEstado.Name = "detalleClienteEstado";
            this.detalleClienteEstado.Width = 125;
            // 
            // detalleClienteTelefono
            // 
            this.detalleClienteTelefono.HeaderText = "Telefono";
            this.detalleClienteTelefono.MinimumWidth = 6;
            this.detalleClienteTelefono.Name = "detalleClienteTelefono";
            this.detalleClienteTelefono.Width = 125;
            // 
            // detalleClienteCorreo
            // 
            this.detalleClienteCorreo.HeaderText = "Correo";
            this.detalleClienteCorreo.MinimumWidth = 6;
            this.detalleClienteCorreo.Name = "detalleClienteCorreo";
            this.detalleClienteCorreo.Width = 125;
            // 
            // detalleClienteSeleccionar
            // 
            this.detalleClienteSeleccionar.HeaderText = "Seleccionar";
            this.detalleClienteSeleccionar.MinimumWidth = 6;
            this.detalleClienteSeleccionar.Name = "detalleClienteSeleccionar";
            this.detalleClienteSeleccionar.Width = 125;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "No soy Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.button4.Location = new System.Drawing.Point(730, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 44);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtCartViewDNI
            // 
            this.txtCartViewDNI.Location = new System.Drawing.Point(539, 60);
            this.txtCartViewDNI.Name = "txtCartViewDNI";
            this.txtCartViewDNI.Size = new System.Drawing.Size(185, 22);
            this.txtCartViewDNI.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nro DNI: ";
            // 
            // buscarCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buscarCliente";
            this.Text = "buscarCliente";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteCorreo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn detalleClienteSeleccionar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCartViewDNI;
        private System.Windows.Forms.Label label6;
    }
}