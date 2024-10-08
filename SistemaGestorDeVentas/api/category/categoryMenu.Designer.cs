﻿using System.Windows.Forms;

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
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnLimpiarCategoria = new System.Windows.Forms.Button();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.cbCategoriaEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoriaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtCategoriaBuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.detalleCategoriaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCategoriaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEliminarCategoria);
            this.panel3.Controls.Add(this.btnLimpiarCategoria);
            this.panel3.Controls.Add(this.btnGuardarCategoria);
            this.panel3.Controls.Add(this.cbCategoriaEstado);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCategoriaNombre);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 474);
            this.panel3.TabIndex = 0;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(61, 402);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(152, 36);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
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
            // cbCategoriaEstado
            // 
            this.cbCategoriaEstado.FormattingEnabled = true;
            this.cbCategoriaEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbCategoriaEstado.Location = new System.Drawing.Point(16, 229);
            this.cbCategoriaEstado.Name = "cbCategoriaEstado";
            this.cbCategoriaEstado.Size = new System.Drawing.Size(264, 24);
            this.cbCategoriaEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado";
            // 
            // txtCategoriaNombre
            // 
            this.txtCategoriaNombre.Location = new System.Drawing.Point(14, 131);
            this.txtCategoriaNombre.Name = "txtCategoriaNombre";
            this.txtCategoriaNombre.Size = new System.Drawing.Size(266, 22);
            this.txtCategoriaNombre.TabIndex = 2;
            this.txtCategoriaNombre.TextChanged += new System.EventHandler(this.txtCategoriaNombre_TextChanged);
            this.txtCategoriaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoriaNombre_KeyPress);
            this.txtCategoriaNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategoriaNombre_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Categoria";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.txtCategoriaBuscar);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(314, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 64);
            this.panel4.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 33);
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nombre"});
            this.comboBox2.Location = new System.Drawing.Point(402, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Nombre";
            // 
            // txtCategoriaBuscar
            // 
            this.txtCategoriaBuscar.Location = new System.Drawing.Point(529, 23);
            this.txtCategoriaBuscar.Name = "txtCategoriaBuscar";
            this.txtCategoriaBuscar.Size = new System.Drawing.Size(169, 22);
            this.txtCategoriaBuscar.TabIndex = 2;
            this.txtCategoriaBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoriaBuscar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar Por: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lista de Categorias";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(317, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 370);
            this.panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleCategoriaNombre,
            this.detalleCategoriaEstado});
            this.dataGridView1.Location = new System.Drawing.Point(16, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // detalleCategoriaNombre
            // 
            this.detalleCategoriaNombre.HeaderText = "Nombre";
            this.detalleCategoriaNombre.MinimumWidth = 6;
            this.detalleCategoriaNombre.Name = "detalleCategoriaNombre";
            this.detalleCategoriaNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleCategoriaNombre.Width = 125;
            // 
            // detalleCategoriaEstado
            // 
            this.detalleCategoriaEstado.HeaderText = "Estado";
            this.detalleCategoriaEstado.MinimumWidth = 6;
            this.detalleCategoriaEstado.Name = "detalleCategoriaEstado";
            this.detalleCategoriaEstado.Width = 125;
            // 
            // categoryMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 473);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryMenu";
            this.Text = "categoryMenu";
            this.Load += new System.EventHandler(this.categoryMenu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoriaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoriaEstado;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnLimpiarCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtCategoriaBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button button6;
        private DataGridViewTextBoxColumn detalleCategoriaNombre;
        private DataGridViewTextBoxColumn detalleCategoriaEstado;
    }
}