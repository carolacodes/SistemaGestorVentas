using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.cart
{
    partial class cartView
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dataGridCartView = new System.Windows.Forms.DataGridView();
            this.cartProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dpCantidad = new System.Windows.Forms.DomainUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCartStock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCartPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregarCartView = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCartProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscarProductVenta = new System.Windows.Forms.Button();
            this.txtCartCodProduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBuscarClienteVenta = new System.Windows.Forms.Button();
            this.txtCartNombreCliente = new System.Windows.Forms.TextBox();
            this.txtCartViewDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.dateCartViewFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartView)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox8);
            this.panel3.Controls.Add(this.dataGridCartView);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1106, 458);
            this.panel3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(841, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 42);
            this.button1.TabIndex = 16;
            this.button1.Text = "Realizar Pago";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(964, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Crear Venta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Azure;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(729, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total a Pagar";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(726, 410);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(106, 22);
            this.textBox8.TabIndex = 9;
            // 
            // dataGridCartView
            // 
            this.dataGridCartView.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridCartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cartProducto,
            this.cartPrecio,
            this.cartCantidad,
            this.cartSubtotal,
            this.cartEliminar});
            this.dataGridCartView.Location = new System.Drawing.Point(19, 252);
            this.dataGridCartView.Name = "dataGridCartView";
            this.dataGridCartView.RowHeadersWidth = 51;
            this.dataGridCartView.RowTemplate.Height = 24;
            this.dataGridCartView.Size = new System.Drawing.Size(1062, 189);
            this.dataGridCartView.TabIndex = 8;
            this.dataGridCartView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cartProducto
            // 
            this.cartProducto.HeaderText = "Producto";
            this.cartProducto.MinimumWidth = 6;
            this.cartProducto.Name = "cartProducto";
            this.cartProducto.Width = 125;
            // 
            // cartPrecio
            // 
            this.cartPrecio.HeaderText = "Precio";
            this.cartPrecio.MinimumWidth = 6;
            this.cartPrecio.Name = "cartPrecio";
            this.cartPrecio.Width = 125;
            // 
            // cartCantidad
            // 
            this.cartCantidad.HeaderText = "Cantidad";
            this.cartCantidad.MinimumWidth = 6;
            this.cartCantidad.Name = "cartCantidad";
            this.cartCantidad.Width = 125;
            // 
            // cartSubtotal
            // 
            this.cartSubtotal.HeaderText = "Subtotal";
            this.cartSubtotal.MinimumWidth = 6;
            this.cartSubtotal.Name = "cartSubtotal";
            this.cartSubtotal.Width = 125;
            // 
            // cartEliminar
            // 
            this.cartEliminar.HeaderText = "Eliminar";
            this.cartEliminar.MinimumWidth = 6;
            this.cartEliminar.Name = "cartEliminar";
            this.cartEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cartEliminar.Text = "Eliminar";
            this.cartEliminar.Width = 125;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dpCantidad);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.txtCartStock);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.txtCartPrecio);
            this.panel6.Controls.Add(this.btnAgregarCartView);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtCartProducto);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.btnBuscarProductVenta);
            this.panel6.Controls.Add(this.txtCartCodProduct);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(19, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1062, 100);
            this.panel6.TabIndex = 6;
            // 
            // dpCantidad
            // 
            this.dpCantidad.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpCantidad.Location = new System.Drawing.Point(740, 64);
            this.dpCantidad.Name = "dpCantidad";
            this.dpCantidad.Size = new System.Drawing.Size(120, 25);
            this.dpCantidad.TabIndex = 16;
            this.dpCantidad.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(736, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cantidad";
            // 
            // txtCartStock
            // 
            this.txtCartStock.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartStock.Location = new System.Drawing.Point(584, 65);
            this.txtCartStock.Name = "txtCartStock";
            this.txtCartStock.ReadOnly = true;
            this.txtCartStock.Size = new System.Drawing.Size(145, 25);
            this.txtCartStock.TabIndex = 13;
            this.txtCartStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartStock_KeyPress);
            this.txtCartStock.Validating += new System.ComponentModel.CancelEventHandler(this.txtCartStock_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(581, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Stock";
            // 
            // txtCartPrecio
            // 
            this.txtCartPrecio.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartPrecio.Location = new System.Drawing.Point(433, 65);
            this.txtCartPrecio.Name = "txtCartPrecio";
            this.txtCartPrecio.ReadOnly = true;
            this.txtCartPrecio.Size = new System.Drawing.Size(145, 25);
            this.txtCartPrecio.TabIndex = 11;
            this.txtCartPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartPrecio_KeyPress);
            this.txtCartPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.txtCartPrecio_Validating);
            // 
            // btnAgregarCartView
            // 
            this.btnAgregarCartView.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCartView.Location = new System.Drawing.Point(870, 61);
            this.btnAgregarCartView.Name = "btnAgregarCartView";
            this.btnAgregarCartView.Size = new System.Drawing.Size(75, 27);
            this.btnAgregarCartView.TabIndex = 7;
            this.btnAgregarCartView.Text = "Agregar";
            this.btnAgregarCartView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarCartView.UseVisualStyleBackColor = true;
            this.btnAgregarCartView.Click += new System.EventHandler(this.btnAgregarCartView_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(430, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Precio";
            // 
            // txtCartProducto
            // 
            this.txtCartProducto.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartProducto.Location = new System.Drawing.Point(225, 65);
            this.txtCartProducto.Name = "txtCartProducto";
            this.txtCartProducto.ReadOnly = true;
            this.txtCartProducto.Size = new System.Drawing.Size(195, 25);
            this.txtCartProducto.TabIndex = 9;
            this.txtCartProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartProducto_KeyPress);
            this.txtCartProducto.Validating += new System.ComponentModel.CancelEventHandler(this.txtCartProducto_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(222, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Producto";
            // 
            // btnBuscarProductVenta
            // 
            this.btnBuscarProductVenta.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.btnBuscarProductVenta.Location = new System.Drawing.Point(13, 45);
            this.btnBuscarProductVenta.Name = "btnBuscarProductVenta";
            this.btnBuscarProductVenta.Size = new System.Drawing.Size(45, 44);
            this.btnBuscarProductVenta.TabIndex = 7;
            this.btnBuscarProductVenta.UseVisualStyleBackColor = true;
            this.btnBuscarProductVenta.Click += new System.EventHandler(this.btnBuscarProductVenta_Click);
            // 
            // txtCartCodProduct
            // 
            this.txtCartCodProduct.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartCodProduct.Location = new System.Drawing.Point(68, 65);
            this.txtCartCodProduct.Name = "txtCartCodProduct";
            this.txtCartCodProduct.Size = new System.Drawing.Size(145, 25);
            this.txtCartCodProduct.TabIndex = 2;
            this.txtCartCodProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartCodProduct_KeyPress);
            this.txtCartCodProduct.Validating += new System.ComponentModel.CancelEventHandler(this.txtCartCodProduct_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cod. Producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Informacion del Producto";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Azure;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnBuscarClienteVenta);
            this.panel5.Controls.Add(this.txtCartNombreCliente);
            this.panel5.Controls.Add(this.txtCartViewDNI);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(465, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(616, 92);
            this.panel5.TabIndex = 5;
            // 
            // btnBuscarClienteVenta
            // 
            this.btnBuscarClienteVenta.Image = global::SistemaGestorDeVentas.Properties.Resources.buscar;
            this.btnBuscarClienteVenta.Location = new System.Drawing.Point(10, 30);
            this.btnBuscarClienteVenta.Name = "btnBuscarClienteVenta";
            this.btnBuscarClienteVenta.Size = new System.Drawing.Size(45, 44);
            this.btnBuscarClienteVenta.TabIndex = 6;
            this.btnBuscarClienteVenta.UseVisualStyleBackColor = true;
            this.btnBuscarClienteVenta.Click += new System.EventHandler(this.btnBuscarClienteVenta_Click);
            // 
            // txtCartNombreCliente
            // 
            this.txtCartNombreCliente.Location = new System.Drawing.Point(253, 52);
            this.txtCartNombreCliente.Name = "txtCartNombreCliente";
            this.txtCartNombreCliente.ReadOnly = true;
            this.txtCartNombreCliente.Size = new System.Drawing.Size(231, 22);
            this.txtCartNombreCliente.TabIndex = 5;
            this.txtCartNombreCliente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtCartNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartNombreCliente_KeyPress);
            this.txtCartNombreCliente.Validating += new System.ComponentModel.CancelEventHandler(this.txtCartNombreCliente_Validating);
            // 
            // txtCartViewDNI
            // 
            this.txtCartViewDNI.Location = new System.Drawing.Point(62, 52);
            this.txtCartViewDNI.Name = "txtCartViewDNI";
            this.txtCartViewDNI.Size = new System.Drawing.Size(185, 22);
            this.txtCartViewDNI.TabIndex = 3;
            this.txtCartViewDNI.TextChanged += new System.EventHandler(this.txtCartViewDNI_TextChanged);
            this.txtCartViewDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCartViewDNI_KeyPress);
            this.txtCartViewDNI.Validating += new System.ComponentModel.CancelEventHandler(this.txtCartViewDNI_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre Completo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nro DNI: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Informacion Cliente";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtTipoDoc);
            this.panel4.Controls.Add(this.dateCartViewFecha);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(19, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 92);
            this.panel4.TabIndex = 1;
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.Location = new System.Drawing.Point(158, 56);
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.ReadOnly = true;
            this.txtTipoDoc.Size = new System.Drawing.Size(130, 22);
            this.txtTipoDoc.TabIndex = 18;
            this.txtTipoDoc.Text = "Factura";
            // 
            // dateCartViewFecha
            // 
            this.dateCartViewFecha.Location = new System.Drawing.Point(9, 54);
            this.dateCartViewFecha.Name = "dateCartViewFecha";
            this.dateCartViewFecha.Size = new System.Drawing.Size(119, 22);
            this.dateCartViewFecha.TabIndex = 17;
            this.dateCartViewFecha.ValueChanged += new System.EventHandler(this.dateCartViewFecha_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Documento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Informacion Venta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Venta";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::SistemaGestorDeVentas.Properties.Resources.eliminar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // cartView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 500);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cartView";
            this.Text = "cartView";
            this.Load += new System.EventHandler(this.cartView_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCartView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox txtCartViewDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCartNombreCliente;
        private System.Windows.Forms.Button btnBuscarClienteVenta;
        private System.Windows.Forms.Button btnAgregarCartView;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox txtCartPrecio;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCartProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscarProductVenta;
        public System.Windows.Forms.TextBox txtCartCodProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown dpCantidad;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtCartStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridCartView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DateTimePicker dateCartViewFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn cartEliminar;
        private TextBox txtTipoDoc;
    }
}