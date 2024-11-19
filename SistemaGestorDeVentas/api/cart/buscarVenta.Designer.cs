namespace SistemaGestorDeVentas.api.cart
{
    partial class buscarVenta
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridBuscarVenta = new System.Windows.Forms.DataGridView();
            this.buscarVentaNroVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarVentaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarVentaDniUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarVentaDniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarVentaIdPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateBuscarVenta = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarVenta = new System.Windows.Forms.TextBox();
            this.cbBuscarVenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarVenta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.dataGridBuscarVenta);
            this.panel2.Location = new System.Drawing.Point(12, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 313);
            this.panel2.TabIndex = 7;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(657, 222);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 35);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridBuscarVenta
            // 
            this.dataGridBuscarVenta.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridBuscarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuscarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buscarVentaNroVenta,
            this.buscarVentaFecha,
            this.buscarVentaDniUsuario,
            this.buscarVentaDniCliente,
            this.buscarVentaIdPago});
            this.dataGridBuscarVenta.Location = new System.Drawing.Point(34, 35);
            this.dataGridBuscarVenta.Name = "dataGridBuscarVenta";
            this.dataGridBuscarVenta.RowHeadersWidth = 51;
            this.dataGridBuscarVenta.RowTemplate.Height = 24;
            this.dataGridBuscarVenta.Size = new System.Drawing.Size(709, 181);
            this.dataGridBuscarVenta.TabIndex = 9;
            this.dataGridBuscarVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscarVenta_CellClick);
            this.dataGridBuscarVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBuscarVenta_CellContentClick);
            // 
            // buscarVentaNroVenta
            // 
            this.buscarVentaNroVenta.HeaderText = "Nro Venta";
            this.buscarVentaNroVenta.MinimumWidth = 6;
            this.buscarVentaNroVenta.Name = "buscarVentaNroVenta";
            this.buscarVentaNroVenta.Width = 125;
            // 
            // buscarVentaFecha
            // 
            this.buscarVentaFecha.HeaderText = "Fecha";
            this.buscarVentaFecha.MinimumWidth = 6;
            this.buscarVentaFecha.Name = "buscarVentaFecha";
            this.buscarVentaFecha.Width = 125;
            // 
            // buscarVentaDniUsuario
            // 
            this.buscarVentaDniUsuario.HeaderText = "DNI USUARIO";
            this.buscarVentaDniUsuario.MinimumWidth = 6;
            this.buscarVentaDniUsuario.Name = "buscarVentaDniUsuario";
            this.buscarVentaDniUsuario.Width = 125;
            // 
            // buscarVentaDniCliente
            // 
            this.buscarVentaDniCliente.HeaderText = "DNI CLIENTE";
            this.buscarVentaDniCliente.MinimumWidth = 6;
            this.buscarVentaDniCliente.Name = "buscarVentaDniCliente";
            this.buscarVentaDniCliente.Width = 125;
            // 
            // buscarVentaIdPago
            // 
            this.buscarVentaIdPago.HeaderText = "Id Pago";
            this.buscarVentaIdPago.MinimumWidth = 6;
            this.buscarVentaIdPago.Name = "buscarVentaIdPago";
            this.buscarVentaIdPago.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dateBuscarVenta);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscarVenta);
            this.panel1.Controls.Add(this.cbBuscarVenta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 6;
            // 
            // dateBuscarVenta
            // 
            this.dateBuscarVenta.Location = new System.Drawing.Point(34, 58);
            this.dateBuscarVenta.Name = "dateBuscarVenta";
            this.dateBuscarVenta.Size = new System.Drawing.Size(200, 22);
            this.dateBuscarVenta.TabIndex = 26;
            this.dateBuscarVenta.Visible = false;
            this.dateBuscarVenta.ValueChanged += new System.EventHandler(this.dateBuscarVenta_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Image = global::SistemaGestorDeVentas.Properties.Resources.limpiar;
            this.btnClear.Location = new System.Drawing.Point(627, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 44);
            this.btnClear.TabIndex = 25;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(576, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 44);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarVenta
            // 
            this.txtBuscarVenta.Location = new System.Drawing.Point(384, 59);
            this.txtBuscarVenta.Name = "txtBuscarVenta";
            this.txtBuscarVenta.Size = new System.Drawing.Size(177, 22);
            this.txtBuscarVenta.TabIndex = 3;
            // 
            // cbBuscarVenta
            // 
            this.cbBuscarVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarVenta.FormattingEnabled = true;
            this.cbBuscarVenta.Items.AddRange(new object[] {
            "Nro Venta",
            "Fecha Venta"});
            this.cbBuscarVenta.Location = new System.Drawing.Point(250, 56);
            this.cbBuscarVenta.Name = "cbBuscarVenta";
            this.cbBuscarVenta.Size = new System.Drawing.Size(121, 24);
            this.cbBuscarVenta.TabIndex = 2;
            this.cbBuscarVenta.SelectedIndexChanged += new System.EventHandler(this.cbBuscarVenta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 28);
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
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Ventas";
            // 
            // buscarVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "buscarVenta";
            this.Text = "buscarVenta";
            this.Load += new System.EventHandler(this.buscarVenta_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuscarVenta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarVenta;
        private System.Windows.Forms.ComboBox cbBuscarVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridBuscarVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn buscarVentaNroVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn buscarVentaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn buscarVentaDniUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn buscarVentaDniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn buscarVentaIdPago;
        private System.Windows.Forms.DateTimePicker dateBuscarVenta;
    }
}