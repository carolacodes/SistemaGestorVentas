using System.Windows.Forms;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarCompra = new System.Windows.Forms.Button();
            this.txtCartDetalleNroVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridDetalleCompra = new System.Windows.Forms.DataGridView();
            this.DetalleCompraProvProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCompraProvPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCompraProvCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleCompraProvSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateCartDetalleFecha = new System.Windows.Forms.DateTimePicker();
            this.txtUsuarioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleCompra)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.dataGridDetalleCompra);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 458);
            this.panel3.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMontoTotal);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(734, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 302);
            this.panel1.TabIndex = 22;
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(77, 140);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(211, 22);
            this.txtMontoTotal.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(122, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 28);
            this.label14.TabIndex = 18;
            this.label14.Text = "Monto Total";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Azure;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnLimpiar);
            this.panel6.Controls.Add(this.btnBuscarCompra);
            this.panel6.Controls.Add(this.txtCartDetalleNroVenta);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(734, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(360, 92);
            this.panel6.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::SistemaGestorDeVentas.Properties.Resources.limpiar;
            this.btnLimpiar.Location = new System.Drawing.Point(306, 20);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 44);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscarCompra
            // 
            this.btnBuscarCompra.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.btnBuscarCompra.Location = new System.Drawing.Point(255, 20);
            this.btnBuscarCompra.Name = "btnBuscarCompra";
            this.btnBuscarCompra.Size = new System.Drawing.Size(45, 44);
            this.btnBuscarCompra.TabIndex = 22;
            this.btnBuscarCompra.UseVisualStyleBackColor = true;
            this.btnBuscarCompra.Click += new System.EventHandler(this.btnBuscarCompra_Click);
            // 
            // txtCartDetalleNroVenta
            // 
            this.txtCartDetalleNroVenta.Location = new System.Drawing.Point(127, 32);
            this.txtCartDetalleNroVenta.Name = "txtCartDetalleNroVenta";
            this.txtCartDetalleNroVenta.Size = new System.Drawing.Size(125, 22);
            this.txtCartDetalleNroVenta.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Numero Compra";
            // 
            // dataGridDetalleCompra
            // 
            this.dataGridDetalleCompra.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetalleCompraProvProducto,
            this.DetalleCompraProvPrecio,
            this.DetalleCompraProvCantidad,
            this.DetalleCompraProvSubtotal});
            this.dataGridDetalleCompra.Location = new System.Drawing.Point(19, 143);
            this.dataGridDetalleCompra.Name = "dataGridDetalleCompra";
            this.dataGridDetalleCompra.RowHeadersWidth = 51;
            this.dataGridDetalleCompra.RowTemplate.Height = 24;
            this.dataGridDetalleCompra.Size = new System.Drawing.Size(709, 302);
            this.dataGridDetalleCompra.TabIndex = 8;
            this.dataGridDetalleCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDetalleCompra_CellContentClick);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dateCartDetalleFecha);
            this.panel4.Controls.Add(this.txtUsuarioCompra);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(19, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(709, 92);
            this.panel4.TabIndex = 1;
            // 
            // dateCartDetalleFecha
            // 
            this.dateCartDetalleFecha.Enabled = false;
            this.dateCartDetalleFecha.Location = new System.Drawing.Point(7, 54);
            this.dateCartDetalleFecha.Name = "dateCartDetalleFecha";
            this.dateCartDetalleFecha.Size = new System.Drawing.Size(143, 22);
            this.dateCartDetalleFecha.TabIndex = 7;
            // 
            // txtUsuarioCompra
            // 
            this.txtUsuarioCompra.Location = new System.Drawing.Point(165, 53);
            this.txtUsuarioCompra.Name = "txtUsuarioCompra";
            this.txtUsuarioCompra.ReadOnly = true;
            this.txtUsuarioCompra.Size = new System.Drawing.Size(194, 22);
            this.txtUsuarioCompra.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informacion Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Compra";
            // 
            // detalleCompraProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 503);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detalleCompraProducto";
            this.Text = "detalleCompraProducto";
            this.Load += new System.EventHandler(this.detalleCompraProducto_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleCompra)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscarCompra;
        public System.Windows.Forms.TextBox txtCartDetalleNroVenta;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridDetalleCompra;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DateTimePicker dateCartDetalleFecha;
        public System.Windows.Forms.TextBox txtUsuarioCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridViewTextBoxColumn DetalleCompraProvProducto;
        public System.Windows.Forms.DataGridViewTextBoxColumn DetalleCompraProvPrecio;
        public System.Windows.Forms.DataGridViewTextBoxColumn DetalleCompraProvCantidad;
        public System.Windows.Forms.DataGridViewTextBoxColumn DetalleCompraProvSubtotal;
        public Panel panel1;
    }
}