namespace SistemaGestorDeVentas.api.cart
{
    partial class buscarCliente
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridBuscarCliente = new System.Windows.Forms.DataGridView();
            this.detalleClienteDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleClienteCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCartViewDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBuscarCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarCliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dataGridBuscarCliente);
            this.panel2.Location = new System.Drawing.Point(12, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 318);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(624, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(485, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Nuevo Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridBuscarCliente
            // 
            this.dataGridBuscarCliente.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalleClienteDni,
            this.detalleClienteNombre,
            this.detalleClienteEstado,
            this.detalleClienteTelefono,
            this.detalleClienteCorreo});
            this.dataGridBuscarCliente.Location = new System.Drawing.Point(19, 15);
            this.dataGridBuscarCliente.Name = "dataGridBuscarCliente";
            this.dataGridBuscarCliente.RowHeadersWidth = 51;
            this.dataGridBuscarCliente.RowTemplate.Height = 24;
            this.dataGridBuscarCliente.Size = new System.Drawing.Size(734, 223);
            this.dataGridBuscarCliente.TabIndex = 11;
            this.dataGridBuscarCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscarCliente_CellClick);
            this.dataGridBuscarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscarCliente_CellContentClick);
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
            // detalleClienteEstado
            // 
            this.detalleClienteEstado.HeaderText = "Estado";
            this.detalleClienteEstado.MinimumWidth = 6;
            this.detalleClienteEstado.Name = "detalleClienteEstado";
            this.detalleClienteEstado.Width = 125;
            // 
            // detalleClienteTelefono
            // 
            this.detalleClienteTelefono.HeaderText = "Telefono";
            this.detalleClienteTelefono.MinimumWidth = 6;
            this.detalleClienteTelefono.Name = "detalleClienteTelefono";
            this.detalleClienteTelefono.Width = 125;
            // 
            // detalleClienteCorreo
            // 
            this.detalleClienteCorreo.HeaderText = "Correo";
            this.detalleClienteCorreo.MinimumWidth = 6;
            this.detalleClienteCorreo.Name = "detalleClienteCorreo";
            this.detalleClienteCorreo.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbBuscarCliente);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.txtCartViewDNI);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.btnBuscarCliente.Location = new System.Drawing.Point(736, 25);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 44);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCartViewDNI
            // 
            this.txtCartViewDNI.Location = new System.Drawing.Point(545, 45);
            this.txtCartViewDNI.Name = "txtCartViewDNI";
            this.txtCartViewDNI.Size = new System.Drawing.Size(185, 22);
            this.txtCartViewDNI.TabIndex = 8;
            this.txtCartViewDNI.TextChanged += new System.EventHandler(this.txtCartViewDNI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Clientes";
            // 
            // cbBuscarCliente
            // 
            this.cbBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarCliente.FormattingEnabled = true;
            this.cbBuscarCliente.Items.AddRange(new object[] {
            "Nro Dni",
            "Nombre Cliente"});
            this.cbBuscarCliente.Location = new System.Drawing.Point(415, 43);
            this.cbBuscarCliente.Name = "cbBuscarCliente";
            this.cbBuscarCliente.Size = new System.Drawing.Size(121, 24);
            this.cbBuscarCliente.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(411, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buscar Por:";
            // 
            // buscarCliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buscarCliente";
            this.Text = "buscarCliente";
            this.Load += new System.EventHandler(this.buscarCliente_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCartViewDNI;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleClienteCorreo;
        private System.Windows.Forms.ComboBox cbBuscarCliente;
        private System.Windows.Forms.Label label2;
    }
}