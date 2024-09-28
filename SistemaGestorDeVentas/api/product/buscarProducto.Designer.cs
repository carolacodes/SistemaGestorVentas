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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detalleProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 313);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Cod Producto";
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
            // button5
            // 
            this.button5.Image = global::SistemaGestorDeVentas.Properties.Resources.limpiar;
            this.button5.Location = new System.Drawing.Point(627, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 44);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.button4.Location = new System.Drawing.Point(576, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 44);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleProductoNombre,
            this.detalleProductoCodigo,
            this.detalleProductoDescripcion,
            this.detalleProductoCategoria,
            this.detalleProductoPrecio,
            this.detalleProductoStock,
            this.detalleProductoEstado});
            this.dataGridView1.Location = new System.Drawing.Point(18, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 281);
            this.dataGridView1.TabIndex = 1;
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
            // detalleProductoPrecio
            // 
            this.detalleProductoPrecio.HeaderText = "Precio";
            this.detalleProductoPrecio.MinimumWidth = 6;
            this.detalleProductoPrecio.Name = "detalleProductoPrecio";
            this.detalleProductoPrecio.Width = 125;
            // 
            // detalleProductoStock
            // 
            this.detalleProductoStock.HeaderText = "Stock";
            this.detalleProductoStock.MinimumWidth = 6;
            this.detalleProductoStock.Name = "detalleProductoStock";
            this.detalleProductoStock.Width = 125;
            // 
            // detalleProductoEstado
            // 
            this.detalleProductoEstado.HeaderText = "Estado";
            this.detalleProductoEstado.MinimumWidth = 6;
            this.detalleProductoEstado.Name = "detalleProductoEstado";
            this.detalleProductoEstado.Width = 125;
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
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleProductoEstado;
    }
}