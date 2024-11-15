using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.product
{
    partial class adminGestionProduct
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGrid_productos = new System.Windows.Forms.DataGridView();
            this.detalleProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoPrecio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProductoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProductNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboxProductCategoria = new System.Windows.Forms.ComboBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProductPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProductEliminar = new System.Windows.Forms.Button();
            this.btnProductLimpiar = new System.Windows.Forms.Button();
            this.btnProductGuardar = new System.Windows.Forms.Button();
            this.cboxProductEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_productos)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGrid_productos);
            this.panel5.Location = new System.Drawing.Point(318, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 370);
            this.panel5.TabIndex = 8;
            // 
            // dataGrid_productos
            // 
            this.dataGrid_productos.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGrid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleProductoNombre,
            this.detalleProductoCodigo,
            this.detalleProductoDescripcion,
            this.detalleProductoCategoria,
            this.detalleProductoPrecio_compra,
            this.precio_venta,
            this.detalleProductoStock,
            this.detalleProductoEstado});
            this.dataGrid_productos.Location = new System.Drawing.Point(16, 17);
            this.dataGrid_productos.Name = "dataGrid_productos";
            this.dataGrid_productos.RowHeadersWidth = 51;
            this.dataGrid_productos.RowTemplate.Height = 24;
            this.dataGrid_productos.Size = new System.Drawing.Size(766, 334);
            this.dataGrid_productos.TabIndex = 0;
            this.dataGrid_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_productos_CellClick);
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
            // detalleProductoPrecio_compra
            // 
            this.detalleProductoPrecio_compra.HeaderText = "Precio Compra";
            this.detalleProductoPrecio_compra.MinimumWidth = 6;
            this.detalleProductoPrecio_compra.Name = "detalleProductoPrecio_compra";
            this.detalleProductoPrecio_compra.Width = 125;
            // 
            // precio_venta
            // 
            this.precio_venta.HeaderText = "Precio Venta";
            this.precio_venta.Name = "precio_venta";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(315, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 64);
            this.panel4.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Descargar Excel";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::SistemaGestorDeVentas.Properties.Resources.limpiar;
            this.button5.Location = new System.Drawing.Point(755, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 44);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.button4.Location = new System.Drawing.Point(704, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 44);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lista de Productos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtProductNombre);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cboxProductCategoria);
            this.panel3.Controls.Add(this.txtProductStock);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtProductPrecio);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtProductDescripcion);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnProductEliminar);
            this.panel3.Controls.Add(this.btnProductLimpiar);
            this.panel3.Controls.Add(this.btnProductGuardar);
            this.panel3.Controls.Add(this.cboxProductEstado);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtProductCodigo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 489);
            this.panel3.TabIndex = 4;
            // 
            // txtProductNombre
            // 
            this.txtProductNombre.Location = new System.Drawing.Point(10, 45);
            this.txtProductNombre.Name = "txtProductNombre";
            this.txtProductNombre.Size = new System.Drawing.Size(266, 20);
            this.txtProductNombre.TabIndex = 18;
            this.txtProductNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductNombre_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nombre: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cboxProductCategoria
            // 
            this.cboxProductCategoria.FormattingEnabled = true;
            this.cboxProductCategoria.Location = new System.Drawing.Point(12, 187);
            this.cboxProductCategoria.Name = "cboxProductCategoria";
            this.cboxProductCategoria.Size = new System.Drawing.Size(264, 21);
            this.cboxProductCategoria.TabIndex = 16;
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(12, 285);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(266, 20);
            this.txtProductStock.TabIndex = 15;
            this.txtProductStock.TextChanged += new System.EventHandler(this.txtProductStock_TextChanged);
            this.txtProductStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductStock_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Stock:";
            // 
            // txtProductPrecio
            // 
            this.txtProductPrecio.Location = new System.Drawing.Point(12, 237);
            this.txtProductPrecio.Name = "txtProductPrecio";
            this.txtProductPrecio.Size = new System.Drawing.Size(266, 20);
            this.txtProductPrecio.TabIndex = 13;
            this.txtProductPrecio.TextChanged += new System.EventHandler(this.txtProductPrecio_TextChanged);
            this.txtProductPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrecio_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Categoria: ";
            // 
            // txtProductDescripcion
            // 
            this.txtProductDescripcion.Location = new System.Drawing.Point(10, 139);
            this.txtProductDescripcion.Name = "txtProductDescripcion";
            this.txtProductDescripcion.Size = new System.Drawing.Size(266, 20);
            this.txtProductDescripcion.TabIndex = 9;
            this.txtProductDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductDescripcion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripcion: ";
            // 
            // btnProductEliminar
            // 
            this.btnProductEliminar.BackColor = System.Drawing.Color.Red;
            this.btnProductEliminar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductEliminar.Location = new System.Drawing.Point(61, 448);
            this.btnProductEliminar.Name = "btnProductEliminar";
            this.btnProductEliminar.Size = new System.Drawing.Size(152, 36);
            this.btnProductEliminar.TabIndex = 7;
            this.btnProductEliminar.Text = "Eliminar";
            this.btnProductEliminar.UseVisualStyleBackColor = false;
            // 
            // btnProductLimpiar
            // 
            this.btnProductLimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProductLimpiar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductLimpiar.Location = new System.Drawing.Point(61, 406);
            this.btnProductLimpiar.Name = "btnProductLimpiar";
            this.btnProductLimpiar.Size = new System.Drawing.Size(152, 36);
            this.btnProductLimpiar.TabIndex = 6;
            this.btnProductLimpiar.Text = "Limpiar";
            this.btnProductLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnProductGuardar
            // 
            this.btnProductGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProductGuardar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductGuardar.Location = new System.Drawing.Point(61, 364);
            this.btnProductGuardar.Name = "btnProductGuardar";
            this.btnProductGuardar.Size = new System.Drawing.Size(152, 36);
            this.btnProductGuardar.TabIndex = 5;
            this.btnProductGuardar.Text = "Guardar";
            this.btnProductGuardar.UseVisualStyleBackColor = false;
            this.btnProductGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboxProductEstado
            // 
            this.cboxProductEstado.FormattingEnabled = true;
            this.cboxProductEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxProductEstado.Location = new System.Drawing.Point(14, 333);
            this.cboxProductEstado.Name = "cboxProductEstado";
            this.cboxProductEstado.Size = new System.Drawing.Size(264, 21);
            this.cboxProductEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado:";
            // 
            // txtProductCodigo
            // 
            this.txtProductCodigo.Location = new System.Drawing.Point(10, 90);
            this.txtProductCodigo.Name = "txtProductCodigo";
            this.txtProductCodigo.Size = new System.Drawing.Size(266, 20);
            this.txtProductCodigo.TabIndex = 2;
            this.txtProductCodigo.TextChanged += new System.EventHandler(this.txtProductCodigo_TextChanged);
            this.txtProductCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Producto";
            // 
            // adminGestionProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 489);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminGestionProduct";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.adminGestionProduct_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_productos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGrid_productos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProductEliminar;
        private System.Windows.Forms.Button btnProductLimpiar;
        private System.Windows.Forms.Button btnProductGuardar;
        private System.Windows.Forms.ComboBox cboxProductEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboxProductCategoria;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private DataGridViewTextBoxColumn detalleProductoNombre;
        private DataGridViewTextBoxColumn detalleProductoCodigo;
        private DataGridViewTextBoxColumn detalleProductoDescripcion;
        private DataGridViewTextBoxColumn detalleProductoCategoria;
        private DataGridViewTextBoxColumn detalleProductoPrecio_compra;
        private DataGridViewTextBoxColumn precio_venta;
        private DataGridViewTextBoxColumn detalleProductoStock;
        private DataGridViewTextBoxColumn detalleProductoEstado;
    }
}