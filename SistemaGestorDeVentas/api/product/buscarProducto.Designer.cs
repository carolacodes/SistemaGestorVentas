namespace SistemaGestorDeVentas.api.product
{
    partial class buscarProducto
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnNewProd = new System.Windows.Forms.Button();
            this.dataGridBuscarProd = new System.Windows.Forms.DataGridView();
            this.detalleProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiarBP = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.cbBuscarProd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarProd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnNewProd);
            this.panel2.Controls.Add(this.dataGridBuscarProd);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 310);
            this.panel2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(600, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 40);
            this.button3.TabIndex = 16;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNewProd
            // 
            this.btnNewProd.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewProd.Location = new System.Drawing.Point(436, 255);
            this.btnNewProd.Name = "btnNewProd";
            this.btnNewProd.Size = new System.Drawing.Size(158, 40);
            this.btnNewProd.TabIndex = 15;
            this.btnNewProd.Text = "Nuevo Producto";
            this.btnNewProd.UseVisualStyleBackColor = true;
            this.btnNewProd.Click += new System.EventHandler(this.btnNewProd_Click);
            // 
            // dataGridBuscarProd
            // 
            this.dataGridBuscarProd.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridBuscarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscarProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleProductoNombre,
            this.detalleProductoCodigo,
            this.detalleProductoDescripcion,
            this.detalleProductoCategoria,
            this.detalleProductoStock,
            this.detalleProductoPrecio});
            this.dataGridBuscarProd.Location = new System.Drawing.Point(18, 17);
            this.dataGridBuscarProd.Name = "dataGridBuscarProd";
            this.dataGridBuscarProd.RowHeadersWidth = 51;
            this.dataGridBuscarProd.RowTemplate.Height = 24;
            this.dataGridBuscarProd.Size = new System.Drawing.Size(740, 221);
            this.dataGridBuscarProd.TabIndex = 1;
            this.dataGridBuscarProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscarProd_CellClick);
            // 
            // detalleProductoNombre
            // 
            this.detalleProductoNombre.HeaderText = "Nombre";
            this.detalleProductoNombre.MinimumWidth = 6;
            this.detalleProductoNombre.Name = "detalleProductoNombre";
            this.detalleProductoNombre.Width = 125;
            // 
            // detalleProductoCodigo
            // 
            this.detalleProductoCodigo.HeaderText = "Codigo";
            this.detalleProductoCodigo.MinimumWidth = 6;
            this.detalleProductoCodigo.Name = "detalleProductoCodigo";
            this.detalleProductoCodigo.Width = 125;
            // 
            // detalleProductoDescripcion
            // 
            this.detalleProductoDescripcion.HeaderText = "Descripcion";
            this.detalleProductoDescripcion.MinimumWidth = 6;
            this.detalleProductoDescripcion.Name = "detalleProductoDescripcion";
            this.detalleProductoDescripcion.Width = 125;
            // 
            // detalleProductoCategoria
            // 
            this.detalleProductoCategoria.HeaderText = "Categoria";
            this.detalleProductoCategoria.MinimumWidth = 6;
            this.detalleProductoCategoria.Name = "detalleProductoCategoria";
            this.detalleProductoCategoria.Width = 125;
            // 
            // detalleProductoStock
            // 
            this.detalleProductoStock.HeaderText = "Stock";
            this.detalleProductoStock.MinimumWidth = 6;
            this.detalleProductoStock.Name = "detalleProductoStock";
            this.detalleProductoStock.Width = 125;
            // 
            // detalleProductoPrecio
            // 
            this.detalleProductoPrecio.HeaderText = "Precio";
            this.detalleProductoPrecio.MinimumWidth = 6;
            this.detalleProductoPrecio.Name = "detalleProductoPrecio";
            this.detalleProductoPrecio.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnLimpiarBP);
            this.panel1.Controls.Add(this.btnBuscarProd);
            this.panel1.Controls.Add(this.txtBuscarProd);
            this.panel1.Controls.Add(this.cbBuscarProd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnLimpiarBP
            // 
            this.btnLimpiarBP.Image = global::SistemaGestorDeVentas.Properties.Resources.limpiar;
            this.btnLimpiarBP.Location = new System.Drawing.Point(627, 37);
            this.btnLimpiarBP.Name = "btnLimpiarBP";
            this.btnLimpiarBP.Size = new System.Drawing.Size(45, 44);
            this.btnLimpiarBP.TabIndex = 25;
            this.btnLimpiarBP.UseVisualStyleBackColor = true;
            this.btnLimpiarBP.Click += new System.EventHandler(this.btnLimpiarBP_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.btnBuscarProd.Location = new System.Drawing.Point(576, 37);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(45, 44);
            this.btnBuscarProd.TabIndex = 24;
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(384, 59);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(177, 22);
            this.txtBuscarProd.TabIndex = 3;
            // 
            // cbBuscarProd
            // 
            this.cbBuscarProd.FormattingEnabled = true;
            this.cbBuscarProd.Items.AddRange(new object[] {
            "Cod Producto",
            "Nombre Producto"});
            this.cbBuscarProd.Location = new System.Drawing.Point(250, 56);
            this.cbBuscarProd.Name = "cbBuscarProd";
            this.cbBuscarProd.Size = new System.Drawing.Size(121, 24);
            this.cbBuscarProd.TabIndex = 2;
            this.cbBuscarProd.Text = "Cod Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Productos";
            // 
            // buscarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buscarProducto";
            this.Text = "buscarProducto";
            this.Load += new System.EventHandler(this.buscarProducto_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarProd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpiarBP;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.ComboBox cbBuscarProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridBuscarProd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNewProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoPrecio;
    }
}