﻿using System.Windows.Forms;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartVentasBarras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridReportes = new System.Windows.Forms.DataGridView();
            this.nroVenta_informe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_reporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartTortaReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_generar_reporte = new System.Windows.Forms.Button();
            this.btn_limpiar_reporte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxReportEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeReportHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReportDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_limpiar_grafico = new System.Windows.Forms.Button();
            this.btn_generar_grafico = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_grafico = new System.Windows.Forms.ComboBox();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.dateTimeGraficoHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeGradicoDesde = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTortaReport)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chartVentasBarras);
            this.panel2.Controls.Add(this.dataGridReportes);
            this.panel2.Controls.Add(this.chartTortaReport);
            this.panel2.Location = new System.Drawing.Point(318, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 492);
            this.panel2.TabIndex = 10;
            // 
            // chartVentasBarras
            // 
            chartArea1.Name = "ChartArea1";
            this.chartVentasBarras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVentasBarras.Legends.Add(legend1);
            this.chartVentasBarras.Location = new System.Drawing.Point(432, 291);
            this.chartVentasBarras.Name = "chartVentasBarras";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVentasBarras.Series.Add(series1);
            this.chartVentasBarras.Size = new System.Drawing.Size(350, 185);
            this.chartVentasBarras.TabIndex = 2;
            this.chartVentasBarras.Text = "chart1";
            // 
            // dataGridReportes
            // 
            this.dataGridReportes.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroVenta_informe,
            this.FechaVenta_reporte,
            this.Cliente_reporte,
            this.vendedor_reporte,
            this.total_reporte});
            this.dataGridReportes.Location = new System.Drawing.Point(16, 15);
            this.dataGridReportes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridReportes.Name = "dataGridReportes";
            this.dataGridReportes.RowHeadersWidth = 51;
            this.dataGridReportes.Size = new System.Drawing.Size(766, 263);
            this.dataGridReportes.TabIndex = 1;
            this.dataGridReportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReportes_CellContentClick);
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
            // vendedor_reporte
            // 
            this.vendedor_reporte.HeaderText = "Vendedor";
            this.vendedor_reporte.Name = "vendedor_reporte";
            // 
            // total_reporte
            // 
            this.total_reporte.HeaderText = "Total";
            this.total_reporte.Name = "total_reporte";
            // 
            // chartTortaReport
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTortaReport.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTortaReport.Legends.Add(legend2);
            this.chartTortaReport.Location = new System.Drawing.Point(16, 286);
            this.chartTortaReport.Margin = new System.Windows.Forms.Padding(4);
            this.chartTortaReport.Name = "chartTortaReport";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTortaReport.Series.Add(series2);
            this.chartTortaReport.Size = new System.Drawing.Size(354, 189);
            this.chartTortaReport.TabIndex = 0;
            this.chartTortaReport.Text = "chart1";
            this.chartTortaReport.Click += new System.EventHandler(this.chartTortaReport_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_generar_reporte);
            this.panel3.Controls.Add(this.btn_limpiar_reporte);
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
            this.panel3.Size = new System.Drawing.Size(296, 241);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_generar_reporte
            // 
            this.btn_generar_reporte.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_generar_reporte.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_reporte.Location = new System.Drawing.Point(69, 150);
            this.btn_generar_reporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generar_reporte.Name = "btn_generar_reporte";
            this.btn_generar_reporte.Size = new System.Drawing.Size(152, 36);
            this.btn_generar_reporte.TabIndex = 14;
            this.btn_generar_reporte.Text = "Generar Reporte";
            this.btn_generar_reporte.UseVisualStyleBackColor = false;
            this.btn_generar_reporte.Click += new System.EventHandler(this.btn_generar_reporte_Click);
            // 
            // btn_limpiar_reporte
            // 
            this.btn_limpiar_reporte.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_limpiar_reporte.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_reporte.Location = new System.Drawing.Point(69, 190);
            this.btn_limpiar_reporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar_reporte.Name = "btn_limpiar_reporte";
            this.btn_limpiar_reporte.Size = new System.Drawing.Size(152, 36);
            this.btn_limpiar_reporte.TabIndex = 13;
            this.btn_limpiar_reporte.Text = "Limpiar";
            this.btn_limpiar_reporte.UseVisualStyleBackColor = false;
            this.btn_limpiar_reporte.Click += new System.EventHandler(this.btn_limpiar_reporte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Empleado";
            // 
            // cboxReportEmpleado
            // 
            this.cboxReportEmpleado.FormattingEnabled = true;
            this.cboxReportEmpleado.Location = new System.Drawing.Point(15, 54);
            this.cboxReportEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cboxReportEmpleado.Name = "cboxReportEmpleado";
            this.cboxReportEmpleado.Size = new System.Drawing.Size(265, 21);
            this.cboxReportEmpleado.TabIndex = 5;
            this.cboxReportEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde";
            // 
            // dateTimeReportHasta
            // 
            this.dateTimeReportHasta.Location = new System.Drawing.Point(18, 126);
            this.dateTimeReportHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeReportHasta.Name = "dateTimeReportHasta";
            this.dateTimeReportHasta.Size = new System.Drawing.Size(265, 20);
            this.dateTimeReportHasta.TabIndex = 2;
            // 
            // dateTimeReportDesde
            // 
            this.dateTimeReportDesde.Location = new System.Drawing.Point(17, 90);
            this.dateTimeReportDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeReportDesde.Name = "dateTimeReportDesde";
            this.dateTimeReportDesde.Size = new System.Drawing.Size(265, 20);
            this.dateTimeReportDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar informe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.btn_limpiar_grafico);
            this.panel1.Controls.Add(this.btn_generar_grafico);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbox_grafico);
            this.panel1.Controls.Add(this.lbl_hasta);
            this.panel1.Controls.Add(this.lbl_desde);
            this.panel1.Controls.Add(this.dateTimeGraficoHasta);
            this.panel1.Controls.Add(this.dateTimeGradicoDesde);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 243);
            this.panel1.TabIndex = 14;
            // 
            // btn_limpiar_grafico
            // 
            this.btn_limpiar_grafico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_limpiar_grafico.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar_grafico.Location = new System.Drawing.Point(69, 185);
            this.btn_limpiar_grafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar_grafico.Name = "btn_limpiar_grafico";
            this.btn_limpiar_grafico.Size = new System.Drawing.Size(152, 36);
            this.btn_limpiar_grafico.TabIndex = 13;
            this.btn_limpiar_grafico.Text = "Limpiar";
            this.btn_limpiar_grafico.UseVisualStyleBackColor = false;
            this.btn_limpiar_grafico.Click += new System.EventHandler(this.btn_limpiar_grafico_Click);
            // 
            // btn_generar_grafico
            // 
            this.btn_generar_grafico.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_generar_grafico.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generar_grafico.Location = new System.Drawing.Point(69, 146);
            this.btn_generar_grafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generar_grafico.Name = "btn_generar_grafico";
            this.btn_generar_grafico.Size = new System.Drawing.Size(152, 36);
            this.btn_generar_grafico.TabIndex = 12;
            this.btn_generar_grafico.Text = "Generar Grafico";
            this.btn_generar_grafico.UseVisualStyleBackColor = false;
            this.btn_generar_grafico.Click += new System.EventHandler(this.btn_generar_grafico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Grafico de";
            // 
            // cbox_grafico
            // 
            this.cbox_grafico.FormattingEnabled = true;
            this.cbox_grafico.Location = new System.Drawing.Point(18, 47);
            this.cbox_grafico.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_grafico.Name = "cbox_grafico";
            this.cbox_grafico.Size = new System.Drawing.Size(265, 21);
            this.cbox_grafico.TabIndex = 5;
            this.cbox_grafico.SelectedIndexChanged += new System.EventHandler(this.cbox_grafico_SelectedIndexChanged);
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.Location = new System.Drawing.Point(15, 108);
            this.lbl_hasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(36, 13);
            this.lbl_hasta.TabIndex = 4;
            this.lbl_hasta.Text = "Hasta";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.Location = new System.Drawing.Point(14, 69);
            this.lbl_desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(39, 13);
            this.lbl_desde.TabIndex = 3;
            this.lbl_desde.Text = "Desde";
            // 
            // dateTimeGraficoHasta
            // 
            this.dateTimeGraficoHasta.Location = new System.Drawing.Point(18, 122);
            this.dateTimeGraficoHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeGraficoHasta.Name = "dateTimeGraficoHasta";
            this.dateTimeGraficoHasta.Size = new System.Drawing.Size(265, 20);
            this.dateTimeGraficoHasta.TabIndex = 2;
            // 
            // dateTimeGradicoDesde
            // 
            this.dateTimeGradicoDesde.Location = new System.Drawing.Point(18, 85);
            this.dateTimeGradicoDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeGradicoDesde.Name = "dateTimeGradicoDesde";
            this.dateTimeGradicoDesde.Size = new System.Drawing.Size(265, 20);
            this.dateTimeGradicoDesde.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Generar Grafico";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(18, 85);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(264, 21);
            this.cbYear.TabIndex = 14;
            // 
            // reporteView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reporteView";
            this.Text = "reportes";
            this.Load += new System.EventHandler(this.reporteView_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentasBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTortaReport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTortaReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeReportHasta;
        private System.Windows.Forms.DateTimePicker dateTimeReportDesde;
        private System.Windows.Forms.ComboBox cboxReportEmpleado;
        private System.Windows.Forms.DataGridView dataGridReportes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_limpiar_reporte;
        private Panel panel1;
        private Button btn_limpiar_grafico;
        private Button btn_generar_grafico;
        private Label label5;
        private ComboBox cbox_grafico;
        private Label lbl_hasta;
        private Label lbl_desde;
        private DateTimePicker dateTimeGraficoHasta;
        private DateTimePicker dateTimeGradicoDesde;
        private Label label9;
        private Button btn_generar_reporte;
        private DataGridViewTextBoxColumn nroVenta_informe;
        private DataGridViewTextBoxColumn FechaVenta_reporte;
        private DataGridViewTextBoxColumn Cliente_reporte;
        private DataGridViewTextBoxColumn vendedor_reporte;
        private DataGridViewTextBoxColumn total_reporte;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasBarras;
        private ComboBox cbYear;
    }
}