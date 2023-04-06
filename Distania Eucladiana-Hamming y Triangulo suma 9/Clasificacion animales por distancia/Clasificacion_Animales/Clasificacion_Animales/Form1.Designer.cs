namespace Clasificacion_Animales
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
            this.btnClasificarAnimales = new System.Windows.Forms.Button();
            this.comboBoxK = new System.Windows.Forms.ComboBox();
            this.checkBoxDistanciaEuclidiana = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDistanciaHamming = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnClasificarAnimales
            // 
            this.btnClasificarAnimales.Location = new System.Drawing.Point(56, 140);
            this.btnClasificarAnimales.Name = "btnClasificarAnimales";
            this.btnClasificarAnimales.Size = new System.Drawing.Size(104, 23);
            this.btnClasificarAnimales.TabIndex = 0;
            this.btnClasificarAnimales.Text = "Clasificar Animales";
            this.btnClasificarAnimales.UseVisualStyleBackColor = true;
            this.btnClasificarAnimales.Click += new System.EventHandler(this.btnClasificarAnimales_Click);
            // 
            // comboBoxK
            // 
            this.comboBoxK.FormattingEnabled = true;
            this.comboBoxK.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxK.Location = new System.Drawing.Point(57, 21);
            this.comboBoxK.Name = "comboBoxK";
            this.comboBoxK.Size = new System.Drawing.Size(121, 21);
            this.comboBoxK.TabIndex = 1;
            // 
            // checkBoxDistanciaEuclidiana
            // 
            this.checkBoxDistanciaEuclidiana.AutoSize = true;
            this.checkBoxDistanciaEuclidiana.Location = new System.Drawing.Point(56, 85);
            this.checkBoxDistanciaEuclidiana.Name = "checkBoxDistanciaEuclidiana";
            this.checkBoxDistanciaEuclidiana.Size = new System.Drawing.Size(122, 17);
            this.checkBoxDistanciaEuclidiana.TabIndex = 2;
            this.checkBoxDistanciaEuclidiana.Text = "Distancia Euclidiana";
            this.checkBoxDistanciaEuclidiana.UseVisualStyleBackColor = true;
            this.checkBoxDistanciaEuclidiana.Click += new System.EventHandler(this.checkBoxDistanciaEuclidiana_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona el metodo a usar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona el valor de K";
            // 
            // checkBoxDistanciaHamming
            // 
            this.checkBoxDistanciaHamming.AutoSize = true;
            this.checkBoxDistanciaHamming.Location = new System.Drawing.Point(56, 108);
            this.checkBoxDistanciaHamming.Name = "checkBoxDistanciaHamming";
            this.checkBoxDistanciaHamming.Size = new System.Drawing.Size(117, 17);
            this.checkBoxDistanciaHamming.TabIndex = 5;
            this.checkBoxDistanciaHamming.Text = "Distancia Hamming";
            this.checkBoxDistanciaHamming.UseVisualStyleBackColor = true;
            this.checkBoxDistanciaHamming.Click += new System.EventHandler(this.checkBoxDistanciaHamming_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 185);
            this.Controls.Add(this.checkBoxDistanciaHamming);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDistanciaEuclidiana);
            this.Controls.Add(this.comboBoxK);
            this.Controls.Add(this.btnClasificarAnimales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClasificarAnimales;
        private System.Windows.Forms.ComboBox comboBoxK;
        private System.Windows.Forms.CheckBox checkBoxDistanciaEuclidiana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDistanciaHamming;
    }
}

