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
            this.dateCartViewFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCartPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAgregarCartView = new System.Windows.Forms.Button();
            this.txtCartProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCartCodProduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridCartView = new System.Windows.Forms.DataGridView();
            this.CompraProdutProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraProdutPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraProdutCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraProdutSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompraProdutEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Compra";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateCartViewFecha);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(19, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 92);
            this.panel4.TabIndex = 1;
            // 
            // dateCartViewFecha
            // 
            this.dateCartViewFecha.Location = new System.Drawing.Point(9, 54);
            this.dateCartViewFecha.Name = "dateCartViewFecha";
            this.dateCartViewFecha.Size = new System.Drawing.Size(119, 22);
            this.dateCartViewFecha.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.comboBox1.Location = new System.Drawing.Point(158, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Documento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informacion Venta";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(465, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(616, 92);
            this.panel5.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Informacion Proveedor";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.domainUpDown1);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txtCartPrecio);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.btnAgregarCartView);
            this.panel6.Controls.Add(this.txtCartProducto);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.txtCartCodProduct);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(19, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(970, 100);
            this.panel6.TabIndex = 6;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown1.Location = new System.Drawing.Point(590, 66);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 25);
            this.domainUpDown1.TabIndex = 16;
            this.domainUpDown1.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(586, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cantidad";
            // 
            // txtCartPrecio
            // 
            this.txtCartPrecio.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartPrecio.Location = new System.Drawing.Point(433, 65);
            this.txtCartPrecio.Name = "txtCartPrecio";
            this.txtCartPrecio.Size = new System.Drawing.Size(145, 25);
            this.txtCartPrecio.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(430, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Precio Compra";
            // 
            // btnAgregarCartView
            // 
            this.btnAgregarCartView.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCartView.Location = new System.Drawing.Point(725, 61);
            this.btnAgregarCartView.Name = "btnAgregarCartView";
            this.btnAgregarCartView.Size = new System.Drawing.Size(75, 31);
            this.btnAgregarCartView.TabIndex = 7;
            this.btnAgregarCartView.Text = "Agregar";
            this.btnAgregarCartView.UseVisualStyleBackColor = true;
            // 
            // txtCartProducto
            // 
            this.txtCartProducto.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartProducto.Location = new System.Drawing.Point(225, 65);
            this.txtCartProducto.Name = "txtCartProducto";
            this.txtCartProducto.Size = new System.Drawing.Size(195, 25);
            this.txtCartProducto.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(222, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Producto";
            // 
            // button2
            // 
            this.button2.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.button2.Location = new System.Drawing.Point(168, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 44);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtCartCodProduct
            // 
            this.txtCartCodProduct.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartCodProduct.Location = new System.Drawing.Point(10, 65);
            this.txtCartCodProduct.Name = "txtCartCodProduct";
            this.txtCartCodProduct.Size = new System.Drawing.Size(145, 25);
            this.txtCartCodProduct.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cod. Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
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
            this.dataGridCartView.Size = new System.Drawing.Size(970, 189);
            this.dataGridCartView.TabIndex = 8;
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
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(995, 325);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(106, 22);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(995, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total a Pagar";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(994, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox8);
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
            // compraProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 507);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "compraProducto";
            this.Text = "compraProducto";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateCartViewFecha;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCartPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCartProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCartCodProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarCartView;
        private System.Windows.Forms.DataGridView dataGridCartView;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraProdutProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraProdutPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraProdutCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompraProdutSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn CompraProdutEliminar;
    }
}