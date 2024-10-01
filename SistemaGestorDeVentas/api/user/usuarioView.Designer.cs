using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.user
{
    partial class usuarioView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaUsuarioDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaUsuarioNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaUsuarioCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaUsuarioContraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaUsuarioRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaUsuarioEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaUsuarioSeleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboxUsuarioEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuarioConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsuarioContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuarioCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.btnUsuarioEliminar = new System.Windows.Forms.Button();
            this.btnUsuarioLimpiar = new System.Windows.Forms.Button();
            this.btnUsuarioGuardar = new System.Windows.Forms.Button();
            this.cboxUsuarioRol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(317, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 370);
            this.panel5.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listaUsuarioDni,
            this.listaUsuarioNombre,
            this.listaUsuarioCorreo,
            this.listaUsuarioContraseña,
            this.listaUsuarioRol,
            this.listaUsuarioEstado,
            this.listaUsuarioSeleccionar});
            this.dataGridView1.Location = new System.Drawing.Point(16, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // listaUsuarioDni
            // 
            this.listaUsuarioDni.HeaderText = "Nro DNI";
            this.listaUsuarioDni.MinimumWidth = 6;
            this.listaUsuarioDni.Name = "listaUsuarioDni";
            this.listaUsuarioDni.Width = 125;
            // 
            // listaUsuarioNombre
            // 
            this.listaUsuarioNombre.HeaderText = "Nombre Completo";
            this.listaUsuarioNombre.MinimumWidth = 6;
            this.listaUsuarioNombre.Name = "listaUsuarioNombre";
            this.listaUsuarioNombre.Width = 125;
            // 
            // listaUsuarioCorreo
            // 
            this.listaUsuarioCorreo.HeaderText = "Correo";
            this.listaUsuarioCorreo.MinimumWidth = 6;
            this.listaUsuarioCorreo.Name = "listaUsuarioCorreo";
            this.listaUsuarioCorreo.Width = 125;
            // 
            // listaUsuarioContraseña
            // 
            this.listaUsuarioContraseña.HeaderText = "Contraseña";
            this.listaUsuarioContraseña.MinimumWidth = 6;
            this.listaUsuarioContraseña.Name = "listaUsuarioContraseña";
            this.listaUsuarioContraseña.Width = 125;
            // 
            // listaUsuarioRol
            // 
            this.listaUsuarioRol.HeaderText = "Rol";
            this.listaUsuarioRol.MinimumWidth = 6;
            this.listaUsuarioRol.Name = "listaUsuarioRol";
            this.listaUsuarioRol.Width = 125;
            // 
            // listaUsuarioEstado
            // 
            this.listaUsuarioEstado.HeaderText = "Estado";
            this.listaUsuarioEstado.MinimumWidth = 6;
            this.listaUsuarioEstado.Name = "listaUsuarioEstado";
            this.listaUsuarioEstado.Width = 125;
            // 
            // listaUsuarioSeleccionar
            // 
            this.listaUsuarioSeleccionar.HeaderText = "Seleccionar";
            this.listaUsuarioSeleccionar.MinimumWidth = 6;
            this.listaUsuarioSeleccionar.Name = "listaUsuarioSeleccionar";
            this.listaUsuarioSeleccionar.Width = 125;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(314, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(804, 64);
            this.panel4.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(7, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 23);
            this.button6.TabIndex = 6;
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
            this.comboBox2.Location = new System.Drawing.Point(402, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(529, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 2;
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
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lista de Usuarios";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cboxUsuarioEstado);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtUsuarioConfirmarContraseña);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtUsuarioContraseña);
            this.panel3.Controls.Add(this.txtUsuarioCorreo);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtUsuarioNombre);
            this.panel3.Controls.Add(this.btnUsuarioEliminar);
            this.panel3.Controls.Add(this.btnUsuarioLimpiar);
            this.panel3.Controls.Add(this.btnUsuarioGuardar);
            this.panel3.Controls.Add(this.cboxUsuarioRol);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtUsuarioDNI);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 489);
            this.panel3.TabIndex = 4;
            // 
            // cboxUsuarioEstado
            // 
            this.cboxUsuarioEstado.FormattingEnabled = true;
            this.cboxUsuarioEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboxUsuarioEstado.Location = new System.Drawing.Point(10, 338);
            this.cboxUsuarioEstado.Name = "cboxUsuarioEstado";
            this.cboxUsuarioEstado.Size = new System.Drawing.Size(266, 24);
            this.cboxUsuarioEstado.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Estado: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Rol: ";
            // 
            // txtUsuarioConfirmarContraseña
            // 
            this.txtUsuarioConfirmarContraseña.Location = new System.Drawing.Point(10, 240);
            this.txtUsuarioConfirmarContraseña.Name = "txtUsuarioConfirmarContraseña";
            this.txtUsuarioConfirmarContraseña.Size = new System.Drawing.Size(266, 22);
            this.txtUsuarioConfirmarContraseña.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Confirmar Contraseña:";
            // 
            // txtUsuarioContraseña
            // 
            this.txtUsuarioContraseña.Location = new System.Drawing.Point(10, 192);
            this.txtUsuarioContraseña.Name = "txtUsuarioContraseña";
            this.txtUsuarioContraseña.Size = new System.Drawing.Size(266, 22);
            this.txtUsuarioContraseña.TabIndex = 12;
            // 
            // txtUsuarioCorreo
            // 
            this.txtUsuarioCorreo.Location = new System.Drawing.Point(10, 144);
            this.txtUsuarioCorreo.Name = "txtUsuarioCorreo";
            this.txtUsuarioCorreo.Size = new System.Drawing.Size(266, 22);
            this.txtUsuarioCorreo.TabIndex = 11;
            this.txtUsuarioCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioCorreo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Correo:";
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Location = new System.Drawing.Point(10, 96);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(266, 22);
            this.txtUsuarioNombre.TabIndex = 8;
            this.txtUsuarioNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioNombre_KeyPress);
            // 
            // btnUsuarioEliminar
            // 
            this.btnUsuarioEliminar.BackColor = System.Drawing.Color.Red;
            this.btnUsuarioEliminar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioEliminar.Location = new System.Drawing.Point(62, 448);
            this.btnUsuarioEliminar.Name = "btnUsuarioEliminar";
            this.btnUsuarioEliminar.Size = new System.Drawing.Size(152, 36);
            this.btnUsuarioEliminar.TabIndex = 7;
            this.btnUsuarioEliminar.Text = "Eliminar";
            this.btnUsuarioEliminar.UseVisualStyleBackColor = false;
            // 
            // btnUsuarioLimpiar
            // 
            this.btnUsuarioLimpiar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUsuarioLimpiar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioLimpiar.Location = new System.Drawing.Point(62, 406);
            this.btnUsuarioLimpiar.Name = "btnUsuarioLimpiar";
            this.btnUsuarioLimpiar.Size = new System.Drawing.Size(152, 36);
            this.btnUsuarioLimpiar.TabIndex = 6;
            this.btnUsuarioLimpiar.Text = "Limpiar";
            this.btnUsuarioLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnUsuarioGuardar
            // 
            this.btnUsuarioGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnUsuarioGuardar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioGuardar.Location = new System.Drawing.Point(62, 364);
            this.btnUsuarioGuardar.Name = "btnUsuarioGuardar";
            this.btnUsuarioGuardar.Size = new System.Drawing.Size(152, 36);
            this.btnUsuarioGuardar.TabIndex = 5;
            this.btnUsuarioGuardar.Text = "Guardar";
            this.btnUsuarioGuardar.UseVisualStyleBackColor = false;
            this.btnUsuarioGuardar.Click += new System.EventHandler(this.btnUsuarioGuardar_Click);
            // 
            // cboxUsuarioRol
            // 
            this.cboxUsuarioRol.FormattingEnabled = true;
            this.cboxUsuarioRol.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Vendedor"});
            this.cboxUsuarioRol.Location = new System.Drawing.Point(10, 288);
            this.cboxUsuarioRol.Name = "cboxUsuarioRol";
            this.cboxUsuarioRol.Size = new System.Drawing.Size(266, 24);
            this.cboxUsuarioRol.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre Completo:";
            // 
            // txtUsuarioDNI
            // 
            this.txtUsuarioDNI.Location = new System.Drawing.Point(10, 48);
            this.txtUsuarioDNI.Name = "txtUsuarioDNI";
            this.txtUsuarioDNI.Size = new System.Drawing.Size(266, 22);
            this.txtUsuarioDNI.TabIndex = 2;
            this.txtUsuarioDNI.TextChanged += new System.EventHandler(this.txtUsuarioDNI_TextChanged);
            this.txtUsuarioDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioDNI_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro DNI: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Usuario";
            // 
            // usuarioView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 487);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuarioView";
            this.Text = "Usuarios";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUsuarioEliminar;
        private System.Windows.Forms.Button btnUsuarioLimpiar;
        private System.Windows.Forms.Button btnUsuarioGuardar;
        private System.Windows.Forms.ComboBox cboxUsuarioRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.ComboBox cboxUsuarioEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsuarioConfirmarContraseña;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsuarioContraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaUsuarioDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaUsuarioNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaUsuarioCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaUsuarioContraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaUsuarioRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn listaUsuarioEstado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn listaUsuarioSeleccionar;
        private System.Windows.Forms.Button button6;
    }
}