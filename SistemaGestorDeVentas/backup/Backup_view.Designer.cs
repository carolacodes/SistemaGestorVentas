namespace SistemaGestorDeVentas.backup
{
    partial class Backup_view
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
            this.dataGrid_Backup = new System.Windows.Forms.DataGridView();
            this.nombre_backup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_backup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_restore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_backup_elegido = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.direccion_backup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_backup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Backup)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGrid_Backup);
            this.panel1.Location = new System.Drawing.Point(113, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 403);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Backups";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGrid_Backup
            // 
            this.dataGrid_Backup.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGrid_Backup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Backup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_backup,
            this.direccion_backup,
            this.fecha_backup});
            this.dataGrid_Backup.Location = new System.Drawing.Point(11, 48);
            this.dataGrid_Backup.Name = "dataGrid_Backup";
            this.dataGrid_Backup.Size = new System.Drawing.Size(504, 344);
            this.dataGrid_Backup.TabIndex = 0;
            this.dataGrid_Backup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Backup_CellClick);
            // 
            // nombre_backup
            // 
            this.nombre_backup.HeaderText = "nombre_backup";
            this.nombre_backup.Name = "nombre_backup";
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(77, 86);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(184, 37);
            this.btn_backup.TabIndex = 2;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btn_restore);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_backup_elegido);
            this.panel2.Location = new System.Drawing.Point(669, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 172);
            this.panel2.TabIndex = 3;
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(77, 104);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(184, 37);
            this.btn_restore.TabIndex = 3;
            this.btn_restore.Text = "Restaurar";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Backup seleccionado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_backup_elegido
            // 
            this.txt_backup_elegido.Location = new System.Drawing.Point(77, 63);
            this.txt_backup_elegido.Name = "txt_backup_elegido";
            this.txt_backup_elegido.Size = new System.Drawing.Size(184, 20);
            this.txt_backup_elegido.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_backup);
            this.panel3.Location = new System.Drawing.Point(669, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 203);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crear Nuevo Backup";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // direccion_backup
            // 
            this.direccion_backup.HeaderText = "direccion";
            this.direccion_backup.Name = "direccion_backup";
            // 
            // fecha_backup
            // 
            this.fecha_backup.HeaderText = "fecha";
            this.fecha_backup.Name = "fecha_backup";
            // 
            // Backup_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Backup_view";
            this.Text = "Backup_view";
            this.Load += new System.EventHandler(this.Backup_view_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Backup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_Backup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_backup_elegido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_backup;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion_backup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_backup;
    }
}