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
            this.txtVolver = new System.Windows.Forms.Button();
            this.dataGridBuscarCompras = new System.Windows.Forms.DataGridView();
            this.BuscarCompraNroCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarCompraFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarCompraDniUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarCompras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.txtVolver);
            this.panel2.Controls.Add(this.dataGridBuscarCompras);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 313);
            this.panel2.TabIndex = 3;
            // 
            // txtVolver
            // 
            this.txtVolver.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtVolver.Location = new System.Drawing.Point(588, 244);
            this.txtVolver.Name = "txtVolver";
            this.txtVolver.Size = new System.Drawing.Size(154, 42);
            this.txtVolver.TabIndex = 12;
            this.txtVolver.Text = "Volver";
            this.txtVolver.UseVisualStyleBackColor = true;
            this.txtVolver.Click += new System.EventHandler(this.txtVolver_Click);
            // 
            // dataGridBuscarCompras
            // 
            this.dataGridBuscarCompras.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridBuscarCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscarCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BuscarCompraNroCompra,
            this.BuscarCompraFecha,
            this.BuscarCompraDniUsuario});
            this.dataGridBuscarCompras.Location = new System.Drawing.Point(33, 25);
            this.dataGridBuscarCompras.Name = "dataGridBuscarCompras";
            this.dataGridBuscarCompras.RowHeadersWidth = 51;
            this.dataGridBuscarCompras.RowTemplate.Height = 24;
            this.dataGridBuscarCompras.Size = new System.Drawing.Size(709, 213);
            this.dataGridBuscarCompras.TabIndex = 9;
            this.dataGridBuscarCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscarCompras_CellClick);
            this.dataGridBuscarCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscarCompras_CellContentClick);
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
            // BuscarCompraDniUsuario
            // 
            this.BuscarCompraDniUsuario.HeaderText = "Dni Usuario";
            this.BuscarCompraDniUsuario.MinimumWidth = 6;
            this.BuscarCompraDniUsuario.Name = "BuscarCompraDniUsuario";
            this.BuscarCompraDniUsuario.Width = 125;
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
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(257, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Compras";
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
            this.Load += new System.EventHandler(this.buscarCompra_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarCompras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridBuscarCompras;
        private System.Windows.Forms.Button txtVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarCompraNroCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarCompraFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuscarCompraDniUsuario;
    }
}