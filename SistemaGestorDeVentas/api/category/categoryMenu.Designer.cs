using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.category
{
    partial class categoryMenu
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
            this.btnLimpiarCategoria = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.txtCategoriaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridCategoria = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtIDCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCategoriaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtIDCategoria);
            this.panel3.Controls.Add(this.btnLimpiarCategoria);
            this.panel3.Controls.Add(this.btnGuardarCategoria);
            this.panel3.Controls.Add(this.txtCategoriaNombre);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 474);
            this.panel3.TabIndex = 0;
            // 
            // btnLimpiarCategoria
            // 
            this.btnLimpiarCategoria.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLimpiarCategoria.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCategoria.Location = new System.Drawing.Point(61, 339);
            this.btnLimpiarCategoria.Name = "btnLimpiarCategoria";
            this.btnLimpiarCategoria.Size = new System.Drawing.Size(152, 36);
            this.btnLimpiarCategoria.TabIndex = 6;
            this.btnLimpiarCategoria.Text = "Limpiar";
            this.btnLimpiarCategoria.UseVisualStyleBackColor = false;
            this.btnLimpiarCategoria.Click += new System.EventHandler(this.btnLimpiarCategoria_Click);
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardarCategoria.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCategoria.Location = new System.Drawing.Point(61, 278);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(152, 36);
            this.btnGuardarCategoria.TabIndex = 5;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = false;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // txtCategoriaNombre
            // 
            this.txtCategoriaNombre.Location = new System.Drawing.Point(11, 172);
            this.txtCategoriaNombre.Name = "txtCategoriaNombre";
            this.txtCategoriaNombre.Size = new System.Drawing.Size(266, 20);
            this.txtCategoriaNombre.TabIndex = 2;
            this.txtCategoriaNombre.TextChanged += new System.EventHandler(this.txtCategoriaNombre_TextChanged);
            this.txtCategoriaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoriaNombre_KeyPress);
            this.txtCategoriaNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategoriaNombre_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Categoria";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridCategoria);
            this.panel5.Location = new System.Drawing.Point(317, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 449);
            this.panel5.TabIndex = 3;
            // 
            // dataGridCategoria
            // 
            this.dataGridCategoria.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_categoria,
            this.detalleCategoriaNombre});
            this.dataGridCategoria.Location = new System.Drawing.Point(17, 21);
            this.dataGridCategoria.Name = "dataGridCategoria";
            this.dataGridCategoria.RowHeadersWidth = 51;
            this.dataGridCategoria.RowTemplate.Height = 24;
            this.dataGridCategoria.Size = new System.Drawing.Size(766, 405);
            this.dataGridCategoria.TabIndex = 0;
            this.dataGridCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCategoria_CellClick);
            this.dataGridCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Nombre";
            this.dataGridViewImageColumn1.Image = global::SistemaGestorDeVentas.Properties.Resources.pngtree_green_check_icon_design_template_vector_png_image_3971423;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // txtIDCategoria
            // 
            this.txtIDCategoria.Location = new System.Drawing.Point(11, 115);
            this.txtIDCategoria.Name = "txtIDCategoria";
            this.txtIDCategoria.Size = new System.Drawing.Size(266, 20);
            this.txtIDCategoria.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID: ";
            // 
            // id_categoria
            // 
            this.id_categoria.HeaderText = "ID";
            this.id_categoria.Name = "id_categoria";
            // 
            // detalleCategoriaNombre
            // 
            this.detalleCategoriaNombre.HeaderText = "Nombre";
            this.detalleCategoriaNombre.MinimumWidth = 6;
            this.detalleCategoriaNombre.Name = "detalleCategoriaNombre";
            this.detalleCategoriaNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleCategoriaNombre.Width = 125;
            // 
            // categoryMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 473);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryMenu";
            this.Text = "categoryMenu";
            this.Load += new System.EventHandler(this.categoryMenu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoriaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridCategoria;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Label label3;
        private TextBox txtIDCategoria;
        private DataGridViewTextBoxColumn id_categoria;
        private DataGridViewTextBoxColumn detalleCategoriaNombre;
    }
}