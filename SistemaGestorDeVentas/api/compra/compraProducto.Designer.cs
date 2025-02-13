using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.compra
{
    partial class compraProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateCartViewFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCorreoUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dmCantidad = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCartPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregarCompraView = new System.Windows.Forms.Button();
            this.txtCartProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCartCodProduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridCartView = new System.Windows.Forms.DataGridView();
            this.CompraProdutProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraProdutPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraProdutCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraProdutSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraProdutEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Compra";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.dateCartViewFecha);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(19, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 92);
            this.panel4.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Factura";
            // 
            // dateCartViewFecha
            // 
            this.dateCartViewFecha.Location = new System.Drawing.Point(17, 59);
            this.dateCartViewFecha.Name = "dateCartViewFecha";
            this.dateCartViewFecha.Size = new System.Drawing.Size(119, 20);
            this.dateCartViewFecha.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(162, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Documento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informacion Venta";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtCorreoUser);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtUser);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(556, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(525, 92);
            this.panel5.TabIndex = 5;
            // 
            // txtCorreoUser
            // 
            this.txtCorreoUser.Location = new System.Drawing.Point(216, 59);
            this.txtCorreoUser.Name = "txtCorreoUser";
            this.txtCorreoUser.ReadOnly = true;
            this.txtCorreoUser.Size = new System.Drawing.Size(189, 20);
            this.txtCorreoUser.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(212, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(14, 59);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(189, 20);
            this.txtUser.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Informacion Usuario";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dmCantidad);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txtCartPrecio);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.btnAgregarCompraView);
            this.panel6.Controls.Add(this.txtCartProducto);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.btnBuscarProducto);
            this.panel6.Controls.Add(this.txtCartCodProduct);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(19, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1062, 100);
            this.panel6.TabIndex = 6;
            // 
            // dmCantidad
            // 
            this.dmCantidad.Location = new System.Drawing.Point(589, 66);
            this.dmCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.dmCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dmCantidad.Name = "dmCantidad";
            this.dmCantidad.Size = new System.Drawing.Size(120, 20);
            this.dmCantidad.TabIndex = 17;
            this.dmCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dmCantidad.ValueChanged += new System.EventHandler(this.dmCantidad_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(586, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cantidad";
            // 
            // txtCartPrecio
            // 
            this.txtCartPrecio.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartPrecio.Location = new System.Drawing.Point(433, 65);
            this.txtCartPrecio.Name = "txtCartPrecio";
            this.txtCartPrecio.ReadOnly = true;
            this.txtCartPrecio.Size = new System.Drawing.Size(145, 21);
            this.txtCartPrecio.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(430, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Precio Compra";
            // 
            // btnAgregarCompraView
            // 
            this.btnAgregarCompraView.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCompraView.Location = new System.Drawing.Point(730, 59);
            this.btnAgregarCompraView.Name = "btnAgregarCompraView";
            this.btnAgregarCompraView.Size = new System.Drawing.Size(114, 31);
            this.btnAgregarCompraView.TabIndex = 7;
            this.btnAgregarCompraView.Text = "Agregar";
            this.btnAgregarCompraView.UseVisualStyleBackColor = true;
            this.btnAgregarCompraView.Click += new System.EventHandler(this.btnAgregarCompraView_Click);
            // 
            // txtCartProducto
            // 
            this.txtCartProducto.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartProducto.Location = new System.Drawing.Point(225, 65);
            this.txtCartProducto.Name = "txtCartProducto";
            this.txtCartProducto.ReadOnly = true;
            this.txtCartProducto.Size = new System.Drawing.Size(195, 21);
            this.txtCartProducto.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(222, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.btnBuscarProducto.Location = new System.Drawing.Point(11, 47);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 44);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCartCodProduct
            // 
            this.txtCartCodProduct.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartCodProduct.Location = new System.Drawing.Point(68, 66);
            this.txtCartCodProduct.Name = "txtCartCodProduct";
            this.txtCartCodProduct.Size = new System.Drawing.Size(145, 21);
            this.txtCartCodProduct.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cod. Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Informacion del Producto";
            // 
            // dataGridCartView
            // 
            this.dataGridCartView.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridCartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompraProdutProducto,
            this.CompraProdutPrecio,
            this.CompraProdutCantidad,
            this.CompraProdutSubtotal,
            this.CompraProdutEliminar});
            this.dataGridCartView.Location = new System.Drawing.Point(19, 252);
            this.dataGridCartView.Name = "dataGridCartView";
            this.dataGridCartView.RowHeadersWidth = 51;
            this.dataGridCartView.RowTemplate.Height = 24;
            this.dataGridCartView.Size = new System.Drawing.Size(1062, 189);
            this.dataGridCartView.TabIndex = 8;
            this.dataGridCartView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCartView_CellContentClick);
            // 
            // CompraProdutProducto
            // 
            this.CompraProdutProducto.HeaderText = "Producto";
            this.CompraProdutProducto.MinimumWidth = 6;
            this.CompraProdutProducto.Name = "CompraProdutProducto";
            this.CompraProdutProducto.Width = 125;
            // 
            // CompraProdutPrecio
            // 
            this.CompraProdutPrecio.HeaderText = "Precio Compra";
            this.CompraProdutPrecio.MinimumWidth = 6;
            this.CompraProdutPrecio.Name = "CompraProdutPrecio";
            this.CompraProdutPrecio.Width = 125;
            // 
            // CompraProdutCantidad
            // 
            this.CompraProdutCantidad.HeaderText = "Cantidad";
            this.CompraProdutCantidad.MinimumWidth = 6;
            this.CompraProdutCantidad.Name = "CompraProdutCantidad";
            this.CompraProdutCantidad.Width = 125;
            // 
            // CompraProdutSubtotal
            // 
            this.CompraProdutSubtotal.HeaderText = "Subtotal";
            this.CompraProdutSubtotal.MinimumWidth = 6;
            this.CompraProdutSubtotal.Name = "CompraProdutSubtotal";
            this.CompraProdutSubtotal.Width = 125;
            // 
            // CompraProdutEliminar
            // 
            this.CompraProdutEliminar.HeaderText = "Eliminar";
            this.CompraProdutEliminar.MinimumWidth = 6;
            this.CompraProdutEliminar.Name = "CompraProdutEliminar";
            this.CompraProdutEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CompraProdutEliminar.Text = "Eliminar";
            this.CompraProdutEliminar.Width = 125;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(787, 406);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(149, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "0";
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Azure;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(799, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total a Pagar";
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarCompra.Location = new System.Drawing.Point(942, 375);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(126, 54);
            this.btnRegistrarCompra.TabIndex = 15;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.UseVisualStyleBackColor = true;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRegistrarCompra);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.dataGridCartView);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 458);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // compraProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 507);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "compraProducto";
            this.Text = "compraProducto";
            this.Load += new System.EventHandler(this.compraProducto_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DateTimePicker dateCartViewFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtCartPrecio;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCartProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarProducto;
        public System.Windows.Forms.TextBox txtCartCodProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarCompraView;
        private System.Windows.Forms.DataGridView dataGridCartView;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridViewTextBoxColumn CompraProdutProducto;
        public System.Windows.Forms.DataGridViewTextBoxColumn CompraProdutPrecio;
        public System.Windows.Forms.DataGridViewTextBoxColumn CompraProdutCantidad;
        public System.Windows.Forms.DataGridViewTextBoxColumn CompraProdutSubtotal;
        public System.Windows.Forms.DataGridViewButtonColumn CompraProdutEliminar;
        public TextBox textBox1;
        private NumericUpDown dmCantidad;
        private TextBox txtUser;
        private Label label5;
        private Label label6;
        private TextBox txtCorreoUser;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}