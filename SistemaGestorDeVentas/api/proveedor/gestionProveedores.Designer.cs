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

        private SistemaGestorDeVentas.components.navLogo navLogo;
        private SistemaGestorDeVentas.navbar navbar;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navLogo = new SistemaGestorDeVentas.components.navLogo();
            this.navbar = new SistemaGestorDeVentas.navbar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitioWebProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navLogo
            // 
            this.navLogo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.navLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.navLogo.Location = new System.Drawing.Point(0, 0);
            this.navLogo.Margin = new System.Windows.Forms.Padding(4);
            this.navLogo.Name = "navLogo";
            this.navLogo.Size = new System.Drawing.Size(1130, 68);
            this.navLogo.TabIndex = 0;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.SystemColors.Control;
            this.navbar.Location = new System.Drawing.Point(0, 68);
            this.navbar.Margin = new System.Windows.Forms.Padding(4);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1129, 58);
            this.navbar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
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
            this.panel2.Location = new System.Drawing.Point(1, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 489);
            this.panel2.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(61, 431);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 36);
            this.button6.TabIndex = 20;
            this.button6.Text = "Eliminar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button7.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(61, 389);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 36);
            this.button7.TabIndex = 19;
            this.button7.Text = "Limpiar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // cboxProveedorEstado
            // 
            this.cboxProveedorEstado.FormattingEnabled = true;
            this.cboxProveedorEstado.Location = new System.Drawing.Point(12, 318);
            this.cboxProveedorEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cboxProveedorEstado.Name = "cboxProveedorEstado";
            this.cboxProveedorEstado.Size = new System.Drawing.Size(264, 21);
            this.cboxProveedorEstado.TabIndex = 18;
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
            // 
            // txtProveedorNombre
            // 
            this.txtProveedorNombre.Location = new System.Drawing.Point(12, 39);
            this.txtProveedorNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedorNombre.Name = "txtProveedorNombre";
            this.txtProveedorNombre.Size = new System.Drawing.Size(264, 20);
            this.txtProveedorNombre.TabIndex = 5;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(315, 157);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 64);
            this.panel3.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.Image = global::SistemaGestorDeVentas.Properties.Resources.limpiar;
            this.button9.Location = new System.Drawing.Point(744, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 44);
            this.button9.TabIndex = 13;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.button10.Location = new System.Drawing.Point(693, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 44);
            this.button10.TabIndex = 12;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(391, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Nombre";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(518, 23);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(169, 20);
            this.textBox7.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Buscar Por: ";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(18, 31);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Descargar Excel";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1021, 26);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(923, 25);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lista de Proveedores";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(315, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 372);
            this.panel4.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProveedor,
            this.CodigoProveedor,
            this.direccionProveedor,
            this.telefonoProveedor,
            this.emailProveedor,
            this.sitioWebProveedor});
            this.dataGridView1.Location = new System.Drawing.Point(18, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(766, 334);
            this.dataGridView1.TabIndex = 10;
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
            // gestionProveedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 630);
            this.Controls.Add(this.navLogo);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gestionProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.gestionProveedores_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboxProveedorEstado;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sitioWebProveedor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
    }
}