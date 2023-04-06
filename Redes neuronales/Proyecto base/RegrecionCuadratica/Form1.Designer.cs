namespace RegrecionCuadratica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRectam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartErrorm = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtm = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartECMmb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtECMm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewRectaYError = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtECMb = new System.Windows.Forms.TextBox();
            this.chartErrorb = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECMm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ECMb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartRectab = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRectam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartECMmb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRectaYError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRectab)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRectam
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRectam.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRectam.Legends.Add(legend1);
            this.chartRectam.Location = new System.Drawing.Point(217, 12);
            this.chartRectam.Name = "chartRectam";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRectam.Series.Add(series1);
            this.chartRectam.Size = new System.Drawing.Size(366, 262);
            this.chartRectam.TabIndex = 1;
            this.chartRectam.Text = "chart1";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(81, 130);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 3;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "b";
            // 
            // chartErrorm
            // 
            chartArea2.Name = "ChartArea1";
            this.chartErrorm.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartErrorm.Legends.Add(legend2);
            this.chartErrorm.Location = new System.Drawing.Point(589, 12);
            this.chartErrorm.Name = "chartErrorm";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartErrorm.Series.Add(series2);
            this.chartErrorm.Size = new System.Drawing.Size(356, 276);
            this.chartErrorm.TabIndex = 7;
            this.chartErrorm.Text = "chart1";
            // 
            // txtm
            // 
            this.txtm.Location = new System.Drawing.Point(81, 57);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(100, 20);
            this.txtm.TabIndex = 8;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(81, 104);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pendiente de la recta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ordenada al orige de la recta";
            // 
            // chartECMmb
            // 
            chartArea3.Name = "ChartArea1";
            this.chartECMmb.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartECMmb.Legends.Add(legend3);
            this.chartECMmb.Location = new System.Drawing.Point(589, 294);
            this.chartECMmb.Name = "chartECMmb";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartECMmb.Series.Add(series3);
            this.chartECMmb.Size = new System.Drawing.Size(672, 234);
            this.chartECMmb.TabIndex = 12;
            this.chartECMmb.Text = "chart1";
            // 
            // txtECMm
            // 
            this.txtECMm.Location = new System.Drawing.Point(58, 240);
            this.txtECMm.Name = "txtECMm";
            this.txtECMm.Size = new System.Drawing.Size(100, 20);
            this.txtECMm.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Error Cuadrado medio de m";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ECM ";
            // 
            // dataGridViewRectaYError
            // 
            this.dataGridViewRectaYError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRectaYError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m,
            this.ECMm,
            this.b,
            this.ECMb});
            this.dataGridViewRectaYError.Location = new System.Drawing.Point(3, 297);
            this.dataGridViewRectaYError.Name = "dataGridViewRectaYError";
            this.dataGridViewRectaYError.Size = new System.Drawing.Size(206, 231);
            this.dataGridViewRectaYError.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "ECM ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Error Cuadrado  medio de b";
            // 
            // txtECMb
            // 
            this.txtECMb.Location = new System.Drawing.Point(58, 189);
            this.txtECMb.Name = "txtECMb";
            this.txtECMb.Size = new System.Drawing.Size(100, 20);
            this.txtECMb.TabIndex = 17;
            // 
            // chartErrorb
            // 
            chartArea4.Name = "ChartArea1";
            this.chartErrorb.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartErrorb.Legends.Add(legend4);
            this.chartErrorb.Location = new System.Drawing.Point(951, 12);
            this.chartErrorb.Name = "chartErrorb";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartErrorb.Series.Add(series4);
            this.chartErrorb.Size = new System.Drawing.Size(310, 276);
            this.chartErrorb.TabIndex = 20;
            this.chartErrorb.Text = "chart1";
            // 
            // m
            // 
            this.m.HeaderText = "Pendiente m";
            this.m.Name = "m";
            // 
            // ECMm
            // 
            this.ECMm.HeaderText = "ECMm";
            this.ECMm.Name = "ECMm";
            // 
            // b
            // 
            this.b.HeaderText = "Ordenada al origen b";
            this.b.Name = "b";
            // 
            // ECMb
            // 
            this.ECMb.HeaderText = "ECMb";
            this.ECMb.Name = "ECMb";
            // 
            // chartRectab
            // 
            chartArea5.Name = "ChartArea1";
            this.chartRectab.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartRectab.Legends.Add(legend5);
            this.chartRectab.Location = new System.Drawing.Point(217, 280);
            this.chartRectab.Name = "chartRectab";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartRectab.Series.Add(series5);
            this.chartRectab.Size = new System.Drawing.Size(366, 243);
            this.chartRectab.TabIndex = 21;
            this.chartRectab.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 540);
            this.Controls.Add(this.chartRectab);
            this.Controls.Add(this.chartErrorb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtECMb);
            this.Controls.Add(this.dataGridViewRectaYError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtECMm);
            this.Controls.Add(this.chartECMmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.chartErrorm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.chartRectam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartRectam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartECMmb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRectaYError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartErrorb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRectab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRectam;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartErrorm;
        private System.Windows.Forms.TextBox txtm;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartECMmb;
        private System.Windows.Forms.TextBox txtECMm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewRectaYError;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtECMb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartErrorb;
        private System.Windows.Forms.DataGridViewTextBoxColumn m;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECMm;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn ECMb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRectab;
    }
}

