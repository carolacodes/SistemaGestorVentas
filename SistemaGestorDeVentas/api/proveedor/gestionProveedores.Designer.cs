using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.proveedor
{
    partial class gestionProveedores
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
            this.btn_eliminar_proveedor = new System.Windows.Forms.Button();
            this.cboxProveedorEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProveedorCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProveedorSitioWeb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProveedorGuardar = new System.Windows.Forms.Button();
            this.txtProveedorDireccion = new System.Windows.Forms.TextBox();
            this.txtProveedorTelefono = new System.Windows.Forms.TextBox();
            this.txtProveedorEmail = new System.Windows.Forms.TextBox();
            this.txtProveedorNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloProveedor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGrid_proveedores = new System.Windows.Forms.DataGridView();
            this.nombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitioWebProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleProveedorEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiar_proveedor = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btn_limpiar_proveedor);
            this.panel2.Controls.Add(this.btn_eliminar_proveedor);
            this.panel2.Controls.Add(this.cboxProveedorEstado);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtProveedorCodigo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtProveedorSitioWeb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnProveedorGuardar);
            this.panel2.Controls.Add(this.txtProveedorDireccion);
            this.panel2.Controls.Add(this.txtProveedorTelefono);
            this.panel2.Controls.Add(this.txtProveedorEmail);
            this.panel2.Controls.Add(this.txtProveedorNombre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblTituloProveedor);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 489);
            this.panel2.TabIndex = 8;
            // 
            // btn_eliminar_proveedor
            // 
            this.btn_eliminar_proveedor.BackColor = System.Drawing.Color.Red;
            this.btn_eliminar_proveedor.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_proveedor.Location = new System.Drawing.Point(61, 431);
            this.btn_eliminar_proveedor.Name = "btn_eliminar_proveedor";
            this.btn_eliminar_proveedor.Size = new System.Drawing.Size(152, 36);
            this.btn_eliminar_proveedor.TabIndex = 20;
            this.btn_eliminar_proveedor.Text = "Eliminar";
            this.btn_eliminar_proveedor.UseVisualStyleBackColor = false;
            this.btn_eliminar_proveedor.Click += new System.EventHandler(this.btn_eliminar_proveedor_Click);
            // 
            // cboxProveedorEstado
            // 
            this.cboxProveedorEstado.FormattingEnabled = true;
            this.cboxProveedorEstado.Location = new System.Drawing.Point(12, 318);
            this.cboxProveedorEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboxProveedorEstado.Name = "cboxProveedorEstado";
            this.cboxProveedorEstado.Size = new System.Drawing.Size(264, 21);
            this.cboxProveedorEstado.TabIndex = 18;
            this.cboxProveedorEstado.SelectedIndexChanged += new System.EventHandler(this.cboxProveedorEstado_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 297);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado";
            // 
            // txtProveedorCodigo
            // 
            this.txtProveedorCodigo.Location = new System.Drawing.Point(12, 83);
            this.txtProveedorCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorCodigo.Name = "txtProveedorCodigo";
            this.txtProveedorCodigo.Size = new System.Drawing.Size(264, 20);
            this.txtProveedorCodigo.TabIndex = 15;
            this.txtProveedorCodigo.TextChanged += new System.EventHandler(this.txtProveedorCodigo_TextChanged);
            this.txtProveedorCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedorCodigo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Codigo";
            // 
            // txtProveedorSitioWeb
            // 
            this.txtProveedorSitioWeb.Location = new System.Drawing.Point(12, 271);
            this.txtProveedorSitioWeb.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorSitioWeb.Name = "txtProveedorSitioWeb";
            this.txtProveedorSitioWeb.Size = new System.Drawing.Size(264, 20);
            this.txtProveedorSitioWeb.TabIndex = 13;
            this.txtProveedorSitioWeb.TextChanged += new System.EventHandler(this.txtProveedorSitioWeb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sitio Web";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(91, 544);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(91, 503);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnProveedorGuardar
            // 
            this.btnProveedorGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProveedorGuardar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedorGuardar.Location = new System.Drawing.Point(61, 348);
            this.btnProveedorGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedorGuardar.Name = "btnProveedorGuardar";
            this.btnProveedorGuardar.Size = new System.Drawing.Size(152, 36);
            this.btnProveedorGuardar.TabIndex = 9;
            this.btnProveedorGuardar.Text = "Guardar";
            this.btnProveedorGuardar.UseVisualStyleBackColor = false;
            this.btnProveedorGuardar.Click += new System.EventHandler(this.btnProveedorGuardar_Click);
            // 
            // txtProveedorDireccion
            // 
            this.txtProveedorDireccion.Location = new System.Drawing.Point(13, 130);
            this.txtProveedorDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorDireccion.Name = "txtProveedorDireccion";
            this.txtProveedorDireccion.Size = new System.Drawing.Size(264, 20);
            this.txtProveedorDireccion.TabIndex = 8;
            this.txtProveedorDireccion.TextChanged += new System.EventHandler(this.txtProveedorDireccion_TextChanged);
            // 
            // txtProveedorTelefono
            // 
            this.txtProveedorTelefono.Location = new System.Drawing.Point(13, 177);
            this.txtProveedorTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorTelefono.Name = "txtProveedorTelefono";
            this.txtProveedorTelefono.Size = new System.Drawing.Size(264, 20);
            this.txtProveedorTelefono.TabIndex = 7;
            this.txtProveedorTelefono.TextChanged += new System.EventHandler(this.txtProveedorTelefono_TextChanged);
            this.txtProveedorTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProveedorTelefono_KeyPress);
            // 
            // txtProveedorEmail
            // 
            this.txtProveedorEmail.Location = new System.Drawing.Point(13, 224);
            this.txtProveedorEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorEmail.Name = "txtProveedorEmail";
            this.txtProveedorEmail.Size = new System.Drawing.Size(264, 20);
            this.txtProveedorEmail.TabIndex = 6;
            this.txtProveedorEmail.TextChanged += new System.EventHandler(this.txtProveedorEmail_TextChanged);
            // 
            // txtProveedorNombre
            // 
            this.txtProveedorNombre.Location = new System.Drawing.Point(12, 39);
            this.txtProveedorNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorNombre.Name = "txtProveedorNombre";
            this.txtProveedorNombre.Size = new System.Drawing.Size(264, 20);
            this.txtProveedorNombre.TabIndex = 5;
            this.txtProveedorNombre.TextChanged += new System.EventHandler(this.txtProveedorNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // lblTituloProveedor
            // 
            this.lblTituloProveedor.AutoSize = true;
            this.lblTituloProveedor.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedor.Location = new System.Drawing.Point(66, 2);
            this.lblTituloProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloProveedor.Name = "lblTituloProveedor";
            this.lblTituloProveedor.Size = new System.Drawing.Size(134, 20);
            this.lblTituloProveedor.TabIndex = 0;
            this.lblTituloProveedor.Text = "Detalle Proveedor";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGrid_proveedores);
            this.panel4.Location = new System.Drawing.Point(315, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 372);
            this.panel4.TabIndex = 11;
            // 
            // dataGrid_proveedores
            // 
            this.dataGrid_proveedores.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGrid_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProveedor,
            this.CodigoProveedor,
            this.direccionProveedor,
            this.telefonoProveedor,
            this.emailProveedor,
            this.sitioWebProveedor,
            this.detalleProveedorEstado});
            this.dataGrid_proveedores.Location = new System.Drawing.Point(18, 19);
            this.dataGrid_proveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_proveedores.Name = "dataGrid_proveedores";
            this.dataGrid_proveedores.RowHeadersWidth = 51;
            this.dataGrid_proveedores.Size = new System.Drawing.Size(766, 334);
            this.dataGrid_proveedores.TabIndex = 10;
            this.dataGrid_proveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGrid_proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombreProveedor
            // 
            this.nombreProveedor.HeaderText = "Nombre";
            this.nombreProveedor.MinimumWidth = 6;
            this.nombreProveedor.Name = "nombreProveedor";
            this.nombreProveedor.Width = 125;
            // 
            // CodigoProveedor
            // 
            this.CodigoProveedor.HeaderText = "Codigo";
            this.CodigoProveedor.MinimumWidth = 6;
            this.CodigoProveedor.Name = "CodigoProveedor";
            this.CodigoProveedor.Width = 125;
            // 
            // direccionProveedor
            // 
            this.direccionProveedor.HeaderText = "Direccion";
            this.direccionProveedor.MinimumWidth = 6;
            this.direccionProveedor.Name = "direccionProveedor";
            this.direccionProveedor.Width = 125;
            // 
            // telefonoProveedor
            // 
            this.telefonoProveedor.HeaderText = "Telefono";
            this.telefonoProveedor.MinimumWidth = 6;
            this.telefonoProveedor.Name = "telefonoProveedor";
            this.telefonoProveedor.Width = 125;
            // 
            // emailProveedor
            // 
            this.emailProveedor.HeaderText = "Email";
            this.emailProveedor.MinimumWidth = 6;
            this.emailProveedor.Name = "emailProveedor";
            this.emailProveedor.Width = 125;
            // 
            // sitioWebProveedor
            // 
            this.sitioWebProveedor.HeaderText = "Sitio Web";
            this.sitioWebProveedor.MinimumWidth = 6;
            this.sitioWebProveedor.Name = "sitioWebProveedor";
            this.sitioWebProveedor.Width = 125;
            // 
            // detalleProveedorEstado
            // 
            this.detalleProveedorEstado.HeaderText = "estado";
            this.detalleProveedorEstado.Name = "detalleProveedorEstado";
            // 
            // btn_limpiar_proveedor
            // 
            this.btn_limpiar_proveedor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_limpiar_proveedor.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_proveedor.Location = new System.Drawing.Point(61, 389);
            this.btn_limpiar_proveedor.Name = "btn_limpiar_proveedor";
            this.btn_limpiar_proveedor.Size = new System.Drawing.Size(152, 36);
            this.btn_limpiar_proveedor.TabIndex = 21;
            this.btn_limpiar_proveedor.Text = "Limpiar";
            this.btn_limpiar_proveedor.UseVisualStyleBackColor = false;
            this.btn_limpiar_proveedor.Click += new System.EventHandler(this.btn_limpiar_proveedor_Click);
            // 
            // gestionProveedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 486);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gestionProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.gestionProveedores_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloProveedor;
        private System.Windows.Forms.TextBox txtProveedorNombre;
        private System.Windows.Forms.TextBox txtProveedorDireccion;
        private System.Windows.Forms.TextBox txtProveedorTelefono;
        private System.Windows.Forms.TextBox txtProveedorEmail;
        private System.Windows.Forms.Button btnProveedorGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtProveedorSitioWeb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProveedorCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboxProveedorEstado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGrid_proveedores;
        private System.Windows.Forms.Button btn_eliminar_proveedor;
        private DataGridViewTextBoxColumn nombreProveedor;
        private DataGridViewTextBoxColumn CodigoProveedor;
        private DataGridViewTextBoxColumn direccionProveedor;
        private DataGridViewTextBoxColumn telefonoProveedor;
        private DataGridViewTextBoxColumn emailProveedor;
        private DataGridViewTextBoxColumn sitioWebProveedor;
        private DataGridViewTextBoxColumn detalleProveedorEstado;
        private Button btn_limpiar_proveedor;
    }
}