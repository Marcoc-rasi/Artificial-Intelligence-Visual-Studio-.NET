namespace Amortiguamiento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AproximarRecta = new System.Windows.Forms.Button();
            this.chartGraficaAmortiguamiento = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtW0 = new System.Windows.Forms.TextBox();
            this.txtV0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficaAmortiguamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // AproximarRecta
            // 
            this.AproximarRecta.Location = new System.Drawing.Point(52, 231);
            this.AproximarRecta.Name = "AproximarRecta";
            this.AproximarRecta.Size = new System.Drawing.Size(123, 34);
            this.AproximarRecta.TabIndex = 0;
            this.AproximarRecta.Text = "AproximarRecta";
            this.AproximarRecta.UseVisualStyleBackColor = true;
            this.AproximarRecta.Click += new System.EventHandler(this.AproximarRecta_Click);
            // 
            // chartGraficaAmortiguamiento
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraficaAmortiguamiento.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraficaAmortiguamiento.Legends.Add(legend1);
            this.chartGraficaAmortiguamiento.Location = new System.Drawing.Point(234, 12);
            this.chartGraficaAmortiguamiento.Name = "chartGraficaAmortiguamiento";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraficaAmortiguamiento.Series.Add(series1);
            this.chartGraficaAmortiguamiento.Size = new System.Drawing.Size(300, 300);
            this.chartGraficaAmortiguamiento.TabIndex = 1;
            this.chartGraficaAmortiguamiento.Text = "chart1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtW0
            // 
            this.txtW0.Location = new System.Drawing.Point(52, 53);
            this.txtW0.Name = "txtW0";
            this.txtW0.Size = new System.Drawing.Size(114, 20);
            this.txtW0.TabIndex = 2;
            // 
            // txtV0
            // 
            this.txtV0.Location = new System.Drawing.Point(52, 101);
            this.txtV0.Name = "txtV0";
            this.txtV0.Size = new System.Drawing.Size(114, 20);
            this.txtV0.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "w0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "v0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "x0";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(52, 185);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(114, 20);
            this.txtA.TabIndex = 7;
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(52, 137);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(114, 20);
            this.txtX0.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtV0);
            this.Controls.Add(this.txtW0);
            this.Controls.Add(this.chartGraficaAmortiguamiento);
            this.Controls.Add(this.AproximarRecta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficaAmortiguamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AproximarRecta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraficaAmortiguamiento;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtW0;
        private System.Windows.Forms.TextBox txtV0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtX0;
    }
}

