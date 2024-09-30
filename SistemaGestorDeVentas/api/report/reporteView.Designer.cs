using System.Windows.Forms;

namespace SistemaGestorDeVentas.api.report
{
    partial class reporteView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nroVenta_informe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxReportFiltrar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxReportEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeReportHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReportDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(318, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 471);
            this.panel2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 383);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroVenta_informe,
            this.FechaVenta_reporte,
            this.Cliente_reporte,
            this.Categoria_reporte,
            this.Descripcion_reporte,
            this.Cantidad_reporte,
            this.Precio_reporte,
            this.SubTotal_reporte});
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(766, 225);
            this.dataGridView1.TabIndex = 1;
            // 
            // nroVenta_informe
            // 
            this.nroVenta_informe.HeaderText = "Nro Venta";
            this.nroVenta_informe.MinimumWidth = 6;
            this.nroVenta_informe.Name = "nroVenta_informe";
            this.nroVenta_informe.Width = 125;
            // 
            // FechaVenta_reporte
            // 
            this.FechaVenta_reporte.HeaderText = "Fecha";
            this.FechaVenta_reporte.MinimumWidth = 6;
            this.FechaVenta_reporte.Name = "FechaVenta_reporte";
            this.FechaVenta_reporte.Width = 125;
            // 
            // Cliente_reporte
            // 
            this.Cliente_reporte.HeaderText = "Cliente";
            this.Cliente_reporte.MinimumWidth = 6;
            this.Cliente_reporte.Name = "Cliente_reporte";
            this.Cliente_reporte.Width = 125;
            // 
            // Categoria_reporte
            // 
            this.Categoria_reporte.HeaderText = "Categoria";
            this.Categoria_reporte.MinimumWidth = 6;
            this.Categoria_reporte.Name = "Categoria_reporte";
            this.Categoria_reporte.Width = 125;
            // 
            // Descripcion_reporte
            // 
            this.Descripcion_reporte.HeaderText = "Descripcion";
            this.Descripcion_reporte.MinimumWidth = 6;
            this.Descripcion_reporte.Name = "Descripcion_reporte";
            this.Descripcion_reporte.Width = 125;
            // 
            // Cantidad_reporte
            // 
            this.Cantidad_reporte.HeaderText = "Cantidad";
            this.Cantidad_reporte.MinimumWidth = 6;
            this.Cantidad_reporte.Name = "Cantidad_reporte";
            this.Cantidad_reporte.Width = 125;
            // 
            // Precio_reporte
            // 
            this.Precio_reporte.HeaderText = "Precio";
            this.Precio_reporte.MinimumWidth = 6;
            this.Precio_reporte.Name = "Precio_reporte";
            this.Precio_reporte.Width = 125;
            // 
            // SubTotal_reporte
            // 
            this.SubTotal_reporte.HeaderText = "Sub Total";
            this.SubTotal_reporte.MinimumWidth = 6;
            this.SubTotal_reporte.Name = "SubTotal_reporte";
            this.SubTotal_reporte.Width = 125;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 268);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(309, 170);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboxReportFiltrar);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cboxReportEmpleado);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dateTimeReportHasta);
            this.panel3.Controls.Add(this.dateTimeReportDesde);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 489);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(70, 354);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 313);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Filtrar por";
            // 
            // cboxReportFiltrar
            // 
            this.cboxReportFiltrar.FormattingEnabled = true;
            this.cboxReportFiltrar.Location = new System.Drawing.Point(18, 259);
            this.cboxReportFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.cboxReportFiltrar.Name = "cboxReportFiltrar";
            this.cboxReportFiltrar.Size = new System.Drawing.Size(265, 24);
            this.cboxReportFiltrar.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Empleado";
            // 
            // cboxReportEmpleado
            // 
            this.cboxReportEmpleado.FormattingEnabled = true;
            this.cboxReportEmpleado.Location = new System.Drawing.Point(18, 79);
            this.cboxReportEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cboxReportEmpleado.Name = "cboxReportEmpleado";
            this.cboxReportEmpleado.Size = new System.Drawing.Size(265, 24);
            this.cboxReportEmpleado.TabIndex = 5;
            this.cboxReportEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // dateTimeReportHasta
            // 
            this.dateTimeReportHasta.Location = new System.Drawing.Point(18, 201);
            this.dateTimeReportHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeReportHasta.Name = "dateTimeReportHasta";
            this.dateTimeReportHasta.Size = new System.Drawing.Size(265, 22);
            this.dateTimeReportHasta.TabIndex = 2;
            // 
            // dateTimeReportDesde
            // 
            this.dateTimeReportDesde.Location = new System.Drawing.Point(18, 141);
            this.dateTimeReportDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeReportDesde.Name = "dateTimeReportDesde";
            this.dateTimeReportDesde.Size = new System.Drawing.Size(265, 22);
            this.dateTimeReportDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar informe";
            // 
            // reporteView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reporteView";
            this.Text = "reportes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeReportHasta;
        private System.Windows.Forms.DateTimePicker dateTimeReportDesde;
        private System.Windows.Forms.ComboBox cboxReportEmpleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroVenta_informe;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta_reporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal_reporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxReportFiltrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}