namespace SistemaGestorDeVentas.api.cart
{
    partial class metodoPago
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegiVenta = new System.Windows.Forms.Button();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPagoMetodo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 95);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(291, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Pago";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 28);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.btnVolver);
            this.panel3.Controls.Add(this.btnRegiVenta);
            this.panel3.Controls.Add(this.cbMetodoPago);
            this.panel3.Controls.Add(this.txtPago);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtVuelto);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.totalPagoMetodo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 251);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnVolver.Location = new System.Drawing.Point(43, 178);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 40);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegiVenta
            // 
            this.btnRegiVenta.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegiVenta.Location = new System.Drawing.Point(511, 178);
            this.btnRegiVenta.Name = "btnRegiVenta";
            this.btnRegiVenta.Size = new System.Drawing.Size(182, 40);
            this.btnRegiVenta.TabIndex = 31;
            this.btnRegiVenta.Text = "Registrar Venta";
            this.btnRegiVenta.UseVisualStyleBackColor = true;
            this.btnRegiVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(501, 44);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(200, 24);
            this.cbMetodoPago.TabIndex = 30;
            this.cbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cbMetodoPago_SelectedIndexChanged);
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(501, 89);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(200, 22);
            this.txtPago.TabIndex = 29;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pago";
            // 
            // txtVuelto
            // 
            this.txtVuelto.Location = new System.Drawing.Point(501, 129);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.ReadOnly = true;
            this.txtVuelto.Size = new System.Drawing.Size(200, 22);
            this.txtVuelto.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Vuelto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Forma de Pago";
            // 
            // totalPagoMetodo
            // 
            this.totalPagoMetodo.AutoSize = true;
            this.totalPagoMetodo.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPagoMetodo.ForeColor = System.Drawing.Color.Red;
            this.totalPagoMetodo.Location = new System.Drawing.Point(146, 27);
            this.totalPagoMetodo.Name = "totalPagoMetodo";
            this.totalPagoMetodo.Size = new System.Drawing.Size(137, 38);
            this.totalPagoMetodo.TabIndex = 1;
            this.totalPagoMetodo.Text = "$ 000000";
            this.totalPagoMetodo.Click += new System.EventHandler(this.totalPagoMetodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total: ";
            // 
            // metodoPago
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "metodoPago";
            this.Text = "metodoPago";
            this.Load += new System.EventHandler(this.metodoPago_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalPagoMetodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegiVenta;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.Button btnVolver;
    }
}