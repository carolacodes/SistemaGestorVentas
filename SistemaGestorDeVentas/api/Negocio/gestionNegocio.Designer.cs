using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.negocio
{
    partial class gestionNegocio
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guardarNegocio = new System.Windows.Forms.Button();
            this.txtNegocioDireccion = new System.Windows.Forms.TextBox();
            this.txtNegocioRUC = new System.Windows.Forms.TextBox();
            this.txtNegocioNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle del Negocio";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.guardarNegocio);
            this.panel4.Controls.Add(this.txtNegocioDireccion);
            this.panel4.Controls.Add(this.txtNegocioRUC);
            this.panel4.Controls.Add(this.txtNegocioNombre);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(69, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(874, 326);
            this.panel4.TabIndex = 1;
            // 
            // guardarNegocio
            // 
            this.guardarNegocio.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarNegocio.Location = new System.Drawing.Point(288, 248);
            this.guardarNegocio.Name = "guardarNegocio";
            this.guardarNegocio.Size = new System.Drawing.Size(298, 43);
            this.guardarNegocio.TabIndex = 9;
            this.guardarNegocio.Text = "GUARDAR CAMBIOS ";
            this.guardarNegocio.UseVisualStyleBackColor = true;
            this.guardarNegocio.Click += new System.EventHandler(this.guardarNegocio_Click);
            // 
            // txtNegocioDireccion
            // 
            this.txtNegocioDireccion.Location = new System.Drawing.Point(269, 203);
            this.txtNegocioDireccion.Name = "txtNegocioDireccion";
            this.txtNegocioDireccion.Size = new System.Drawing.Size(336, 22);
            this.txtNegocioDireccion.TabIndex = 8;
            this.txtNegocioDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNegocioDireccion_KeyPress);
            this.txtNegocioDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtNegocioDireccion_Validating);
            // 
            // txtNegocioRUC
            // 
            this.txtNegocioRUC.Location = new System.Drawing.Point(269, 138);
            this.txtNegocioRUC.Name = "txtNegocioRUC";
            this.txtNegocioRUC.Size = new System.Drawing.Size(336, 22);
            this.txtNegocioRUC.TabIndex = 7;
            this.txtNegocioRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNegocioRUC_KeyPress);
            this.txtNegocioRUC.Validating += new System.ComponentModel.CancelEventHandler(this.txtNegocioRUC_Validating);
            // 
            // txtNegocioNombre
            // 
            this.txtNegocioNombre.Location = new System.Drawing.Point(269, 82);
            this.txtNegocioNombre.Name = "txtNegocioNombre";
            this.txtNegocioNombre.Size = new System.Drawing.Size(336, 22);
            this.txtNegocioNombre.TabIndex = 6;
            this.txtNegocioNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNegocioNombre_KeyPress);
            this.txtNegocioNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNegocioNombre_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "R.U.T:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(264, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del Negocio:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(54, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 433);
            this.panel3.TabIndex = 4;
            // 
            // gestionNegocio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 506);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gestionNegocio";
            this.Load += new System.EventHandler(this.gestionNegocio_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel4;
        private Button guardarNegocio;
        private TextBox txtNegocioDireccion;
        private TextBox txtNegocioRUC;
        private TextBox txtNegocioNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
    }
}