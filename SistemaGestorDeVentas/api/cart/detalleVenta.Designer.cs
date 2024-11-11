using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.cart
{
    partial class detalleVenta
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPdfVenta = new System.Windows.Forms.Button();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCartDetalleNroVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataProductosVenta = new System.Windows.Forms.DataGridView();
            this.DetalleCardProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCardPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCardCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCardSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNombreCliVenta = new System.Windows.Forms.TextBox();
            this.txtClienteVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateCartDetalleFecha = new System.Windows.Forms.DateTimePicker();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosVenta)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.dataProductosVenta);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 458);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPdfVenta);
            this.panel1.Controls.Add(this.txtMontoTotal);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(734, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 193);
            this.panel1.TabIndex = 20;
            // 
            // btnPdfVenta
            // 
            this.btnPdfVenta.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPdfVenta.Location = new System.Drawing.Point(96, 117);
            this.btnPdfVenta.Name = "btnPdfVenta";
            this.btnPdfVenta.Size = new System.Drawing.Size(174, 42);
            this.btnPdfVenta.TabIndex = 19;
            this.btnPdfVenta.Text = "Descargar PDF";
            this.btnPdfVenta.UseVisualStyleBackColor = true;
            this.btnPdfVenta.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(86, 74);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(191, 22);
            this.txtMontoTotal.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12.8F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(114, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 30);
            this.label14.TabIndex = 18;
            this.label14.Text = "Monto Total";
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
            this.txtCartDetalleNroVenta.Location = new System.Drawing.Point(124, 32);
            this.txtCartDetalleNroVenta.Name = "txtCartDetalleNroVenta";
            this.txtCartDetalleNroVenta.Size = new System.Drawing.Size(125, 22);
            this.txtCartDetalleNroVenta.TabIndex = 21;
            this.txtCartDetalleNroVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartDetalleNroVenta_KeyPress);
            this.txtCartDetalleNroVenta.Validating += new System.ComponentModel.CancelEventHandler(this.txtCartDetalleNroVenta_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Numero Venta: ";
            // 
            // dataProductosVenta
            // 
            this.dataProductosVenta.BackgroundColor = System.Drawing.Color.Azure;
            this.dataProductosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductosVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleCardProducto,
            this.DetalleCardPrecio,
            this.DetalleCardCantidad,
            this.DetalleCardSubtotal});
            this.dataProductosVenta.Location = new System.Drawing.Point(19, 252);
            this.dataProductosVenta.Name = "dataProductosVenta";
            this.dataProductosVenta.RowHeadersWidth = 51;
            this.dataProductosVenta.RowTemplate.Height = 24;
            this.dataProductosVenta.Size = new System.Drawing.Size(709, 193);
            this.dataProductosVenta.TabIndex = 8;
            // 
            // DetalleCardProducto
            // 
            this.DetalleCardProducto.HeaderText = "Producto";
            this.DetalleCardProducto.MinimumWidth = 6;
            this.DetalleCardProducto.Name = "DetalleCardProducto";
            this.DetalleCardProducto.Width = 125;
            // 
            // DetalleCardPrecio
            // 
            this.DetalleCardPrecio.HeaderText = "Precio";
            this.DetalleCardPrecio.MinimumWidth = 6;
            this.DetalleCardPrecio.Name = "DetalleCardPrecio";
            this.DetalleCardPrecio.Width = 125;
            // 
            // DetalleCardCantidad
            // 
            this.DetalleCardCantidad.HeaderText = "Cantidad";
            this.DetalleCardCantidad.MinimumWidth = 6;
            this.DetalleCardCantidad.Name = "DetalleCardCantidad";
            this.DetalleCardCantidad.Width = 125;
            // 
            // DetalleCardSubtotal
            // 
            this.DetalleCardSubtotal.HeaderText = "Subtotal";
            this.DetalleCardSubtotal.MinimumWidth = 6;
            this.DetalleCardSubtotal.Name = "DetalleCardSubtotal";
            this.DetalleCardSubtotal.Width = 125;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtNombreCliVenta);
            this.panel5.Controls.Add(this.txtClienteVenta);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(19, 148);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(709, 92);
            this.panel5.TabIndex = 5;
            // 
            // txtNombreCliVenta
            // 
            this.txtNombreCliVenta.Location = new System.Drawing.Point(208, 51);
            this.txtNombreCliVenta.Name = "txtNombreCliVenta";
            this.txtNombreCliVenta.Size = new System.Drawing.Size(231, 22);
            this.txtNombreCliVenta.TabIndex = 5;
            // 
            // txtClienteVenta
            // 
            this.txtClienteVenta.Location = new System.Drawing.Point(7, 51);
            this.txtClienteVenta.Name = "txtClienteVenta";
            this.txtClienteVenta.Size = new System.Drawing.Size(185, 22);
            this.txtClienteVenta.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre Completo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nro DNI: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Informacion Cliente";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtTipoDocumento);
            this.panel4.Controls.Add(this.dateCartDetalleFecha);
            this.panel4.Controls.Add(this.txtUsuario);
            this.panel4.Controls.Add(this.label8);
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
            this.dateCartDetalleFecha.Size = new System.Drawing.Size(143, 22);
            this.dateCartDetalleFecha.TabIndex = 7;
            this.dateCartDetalleFecha.ValueChanged += new System.EventHandler(this.dateCartDetalleFecha_ValueChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(354, 54);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(194, 22);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(350, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Usuario: ";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Venta";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::SistemaGestorDeVentas.Properties.Resources.eliminar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(158, 54);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(180, 22);
            this.txtTipoDocumento.TabIndex = 8;
            // 
            // detalleVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 500);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detalleVenta";
            this.Text = "detalleVenta";
            this.Load += new System.EventHandler(this.detalleVenta_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductosVenta)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataProductosVenta;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNombreCliVenta;
        private System.Windows.Forms.TextBox txtClienteVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCartDetalleNroVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateCartDetalleFecha;
        private System.Windows.Forms.Button btnPdfVenta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCardProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCardPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCardCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleCardSubtotal;
        private Panel panel1;
        private TextBox txtTipoDocumento;
    }
}