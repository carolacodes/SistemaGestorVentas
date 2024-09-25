namespace SistemaGestorDeVentas.api.Negocio
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNegocioDireccion = new System.Windows.Forms.TextBox();
            this.txtNegocioRUC = new System.Windows.Forms.TextBox();
            this.txtNegocioNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(1, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 76);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 68);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(53, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1018, 433);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.txtNegocioDireccion);
            this.panel4.Controls.Add(this.txtNegocioRUC);
            this.panel4.Controls.Add(this.txtNegocioNombre);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(69, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(874, 326);
            this.panel4.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(438, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "GUARDAR CAMBIOS ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtNegocioDireccion
            // 
            this.txtNegocioDireccion.Location = new System.Drawing.Point(510, 169);
            this.txtNegocioDireccion.Name = "txtNegocioDireccion";
            this.txtNegocioDireccion.Size = new System.Drawing.Size(336, 22);
            this.txtNegocioDireccion.TabIndex = 8;
            this.txtNegocioDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNegocioDireccion_KeyPress);
            this.txtNegocioDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.txtNegocioDireccion_Validating);
            // 
            // txtNegocioRUC
            // 
            this.txtNegocioRUC.Location = new System.Drawing.Point(510, 114);
            this.txtNegocioRUC.Name = "txtNegocioRUC";
            this.txtNegocioRUC.Size = new System.Drawing.Size(336, 22);
            this.txtNegocioRUC.TabIndex = 7;
            this.txtNegocioRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNegocioRUC_KeyPress);
            this.txtNegocioRUC.Validating += new System.ComponentModel.CancelEventHandler(this.txtNegocioRUC_Validating);
            // 
            // txtNegocioNombre
            // 
            this.txtNegocioNombre.Location = new System.Drawing.Point(510, 55);
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
            this.label5.Location = new System.Drawing.Point(316, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "R.U.C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del Negocio:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SistemaGestorDeVentas.Properties.Resources.subir;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(122, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Subir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaGestorDeVentas.Properties.Resources.stats_people_logo_icon_design_vector_229041561;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(52, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // gestionNegocio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "gestionNegocio";
            this.Text = "gestionNegocio";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNegocioDireccion;
        private System.Windows.Forms.TextBox txtNegocioRUC;
        private System.Windows.Forms.TextBox txtNegocioNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}