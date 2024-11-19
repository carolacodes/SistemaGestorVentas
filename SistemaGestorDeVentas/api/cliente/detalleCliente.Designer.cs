using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.cliente
{
    partial class detalleCliente
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
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.detalleClienteDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbClienteEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClienteTelefono = new System.Windows.Forms.TextBox();
            this.txtClienteCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridCliente);
            this.panel5.Location = new System.Drawing.Point(317, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 370);
            this.panel5.TabIndex = 13;
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleClienteDni,
            this.detalleClienteNombre,
            this.detalleClienteCorreo,
            this.detalleClienteTelefono,
            this.detalleClienteEstado});
            this.dataGridCliente.Location = new System.Drawing.Point(16, 14);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.RowHeadersWidth = 51;
            this.dataGridCliente.RowTemplate.Height = 24;
            this.dataGridCliente.Size = new System.Drawing.Size(766, 334);
            this.dataGridCliente.TabIndex = 0;
            this.dataGridCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellClick);
            this.dataGridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellContentClick);
            // 
            // detalleClienteDni
            // 
            this.detalleClienteDni.HeaderText = "Nro DNI";
            this.detalleClienteDni.MinimumWidth = 6;
            this.detalleClienteDni.Name = "detalleClienteDni";
            this.detalleClienteDni.Width = 125;
            // 
            // detalleClienteNombre
            // 
            this.detalleClienteNombre.HeaderText = "Nombre Completo";
            this.detalleClienteNombre.MinimumWidth = 6;
            this.detalleClienteNombre.Name = "detalleClienteNombre";
            this.detalleClienteNombre.Width = 125;
            // 
            // detalleClienteCorreo
            // 
            this.detalleClienteCorreo.HeaderText = "Correo";
            this.detalleClienteCorreo.MinimumWidth = 6;
            this.detalleClienteCorreo.Name = "detalleClienteCorreo";
            this.detalleClienteCorreo.Width = 125;
            // 
            // detalleClienteTelefono
            // 
            this.detalleClienteTelefono.HeaderText = "Telefono";
            this.detalleClienteTelefono.MinimumWidth = 6;
            this.detalleClienteTelefono.Name = "detalleClienteTelefono";
            this.detalleClienteTelefono.Width = 125;
            // 
            // detalleClienteEstado
            // 
            this.detalleClienteEstado.HeaderText = "Estado";
            this.detalleClienteEstado.MinimumWidth = 6;
            this.detalleClienteEstado.Name = "detalleClienteEstado";
            this.detalleClienteEstado.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(314, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 64);
            this.panel4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lista de Cliente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbClienteEstado);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtClienteTelefono);
            this.panel3.Controls.Add(this.txtClienteCorreo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtClienteNombre);
            this.panel3.Controls.Add(this.btnEliminarCliente);
            this.panel3.Controls.Add(this.btnLimpiarCliente);
            this.panel3.Controls.Add(this.btnGuardarCliente);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtClienteDni);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 489);
            this.panel3.TabIndex = 9;
            // 
            // cbClienteEstado
            // 
            this.cbClienteEstado.FormattingEnabled = true;
            this.cbClienteEstado.Location = new System.Drawing.Point(10, 287);
            this.cbClienteEstado.Name = "cbClienteEstado";
            this.cbClienteEstado.Size = new System.Drawing.Size(266, 24);
            this.cbClienteEstado.TabIndex = 17;
            this.cbClienteEstado.SelectedIndexChanged += new System.EventHandler(this.cbClienteEstado_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Estado: ";
            // 
            // txtClienteTelefono
            // 
            this.txtClienteTelefono.Location = new System.Drawing.Point(10, 234);
            this.txtClienteTelefono.Name = "txtClienteTelefono";
            this.txtClienteTelefono.Size = new System.Drawing.Size(266, 22);
            this.txtClienteTelefono.TabIndex = 12;
            this.txtClienteTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteTelefono_KeyPress);
            this.txtClienteTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.txtClienteTelefono_Validating);
            // 
            // txtClienteCorreo
            // 
            this.txtClienteCorreo.Location = new System.Drawing.Point(10, 186);
            this.txtClienteCorreo.Name = "txtClienteCorreo";
            this.txtClienteCorreo.Size = new System.Drawing.Size(266, 22);
            this.txtClienteCorreo.TabIndex = 11;
            this.txtClienteCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteCorreo_KeyPress);
            this.txtClienteCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtClienteCorreo_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Correo:";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(10, 138);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(266, 22);
            this.txtClienteNombre.TabIndex = 8;
            this.txtClienteNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteNombre_KeyPress);
            this.txtClienteNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtClienteNombre_Validating);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(71, 439);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(152, 36);
            this.btnEliminarCliente.TabIndex = 7;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLimpiarCliente.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCliente.Location = new System.Drawing.Point(71, 385);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(152, 36);
            this.btnLimpiarCliente.TabIndex = 6;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = false;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Location = new System.Drawing.Point(71, 327);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(152, 36);
            this.btnGuardarCliente.TabIndex = 5;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            this.btnGuardarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Completo:";
            // 
            // txtClienteDni
            // 
            this.txtClienteDni.Location = new System.Drawing.Point(10, 90);
            this.txtClienteDni.Name = "txtClienteDni";
            this.txtClienteDni.Size = new System.Drawing.Size(266, 22);
            this.txtClienteDni.TabIndex = 2;
            this.txtClienteDni.TextChanged += new System.EventHandler(this.txtClienteDni_TextChanged);
            this.txtClienteDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteDni_KeyPress);
            this.txtClienteDni.Validating += new System.ComponentModel.CancelEventHandler(this.txtClienteDni_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro DNI: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Cliente";
            // 
            // detalleCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 488);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "detalleCliente";
            this.Text = "detalleCliente";
            this.Load += new System.EventHandler(this.detalleCliente_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbClienteEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClienteTelefono;
        private System.Windows.Forms.TextBox txtClienteCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClienteDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn detalleClienteDni;
        private DataGridViewTextBoxColumn detalleClienteNombre;
        private DataGridViewTextBoxColumn detalleClienteCorreo;
        private DataGridViewTextBoxColumn detalleClienteTelefono;
        private DataGridViewTextBoxColumn detalleClienteEstado;
    }
}