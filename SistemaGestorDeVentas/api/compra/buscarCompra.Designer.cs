namespace SistemaGestorDeVentas.api.compra
{
    partial class buscarCompra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BuscarCompraNroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarCompraFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarCompraProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarCompraTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarCompraEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarCompraSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 313);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuscarCompraNroCompra,
            this.BuscarCompraFecha,
            this.BuscarCompraProveedor,
            this.BuscarCompraTotal,
            this.buscarCompraEstado,
            this.BuscarCompraSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(33, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 213);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Compras";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(612, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ver en Detalle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BuscarCompraNroCompra
            // 
            this.BuscarCompraNroCompra.HeaderText = "Nro Compra";
            this.BuscarCompraNroCompra.MinimumWidth = 6;
            this.BuscarCompraNroCompra.Name = "BuscarCompraNroCompra";
            this.BuscarCompraNroCompra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BuscarCompraNroCompra.Width = 125;
            // 
            // BuscarCompraFecha
            // 
            this.BuscarCompraFecha.HeaderText = "Fecha";
            this.BuscarCompraFecha.MinimumWidth = 6;
            this.BuscarCompraFecha.Name = "BuscarCompraFecha";
            this.BuscarCompraFecha.Width = 125;
            // 
            // BuscarCompraProveedor
            // 
            this.BuscarCompraProveedor.HeaderText = "Proveedor";
            this.BuscarCompraProveedor.MinimumWidth = 6;
            this.BuscarCompraProveedor.Name = "BuscarCompraProveedor";
            this.BuscarCompraProveedor.Width = 125;
            // 
            // BuscarCompraTotal
            // 
            this.BuscarCompraTotal.HeaderText = "Total";
            this.BuscarCompraTotal.MinimumWidth = 6;
            this.BuscarCompraTotal.Name = "BuscarCompraTotal";
            this.BuscarCompraTotal.Width = 125;
            // 
            // buscarCompraEstado
            // 
            this.buscarCompraEstado.HeaderText = "Estado";
            this.buscarCompraEstado.MinimumWidth = 6;
            this.buscarCompraEstado.Name = "buscarCompraEstado";
            this.buscarCompraEstado.Width = 125;
            // 
            // BuscarCompraSeleccionar
            // 
            this.BuscarCompraSeleccionar.HeaderText = "Seleccionar";
            this.BuscarCompraSeleccionar.MinimumWidth = 6;
            this.BuscarCompraSeleccionar.Name = "BuscarCompraSeleccionar";
            this.BuscarCompraSeleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BuscarCompraSeleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BuscarCompraSeleccionar.Width = 125;
            // 
            // buscarCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buscarCompra";
            this.Text = "buscarCompra";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarCompraNroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarCompraFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarCompraProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarCompraTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn buscarCompraEstado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BuscarCompraSeleccionar;
    }
}