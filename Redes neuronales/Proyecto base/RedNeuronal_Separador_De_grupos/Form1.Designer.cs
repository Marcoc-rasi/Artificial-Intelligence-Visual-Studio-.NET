namespace RedNeuronal_Separador_De_grupos
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
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.btnNuevoPunto = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnAcomodarDatos = new System.Windows.Forms.Button();
            this.btnCompararMujeres = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrigliceridos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColesterol = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txMagnecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCalcio = new System.Windows.Forms.TextBox();
            this.txtTensionArterial = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(27, 231);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(87, 35);
            this.btnEmpezar.TabIndex = 0;
            this.btnEmpezar.Text = "Entrenar Perceptrones";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // btnNuevoPunto
            // 
            this.btnNuevoPunto.Location = new System.Drawing.Point(27, 156);
            this.btnNuevoPunto.Name = "btnNuevoPunto";
            this.btnNuevoPunto.Size = new System.Drawing.Size(102, 45);
            this.btnNuevoPunto.TabIndex = 2;
            this.btnNuevoPunto.Text = "Comparar Con Hombres";
            this.btnNuevoPunto.UseVisualStyleBackColor = true;
            this.btnNuevoPunto.Click += new System.EventHandler(this.btnNuevoPunto_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(29, 34);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(29, 71);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(29, 116);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 7;
            // 
            // btnAcomodarDatos
            // 
            this.btnAcomodarDatos.Location = new System.Drawing.Point(27, 288);
            this.btnAcomodarDatos.Name = "btnAcomodarDatos";
            this.btnAcomodarDatos.Size = new System.Drawing.Size(87, 42);
            this.btnAcomodarDatos.TabIndex = 9;
            this.btnAcomodarDatos.Text = "Separar Datos";
            this.btnAcomodarDatos.UseVisualStyleBackColor = true;
            this.btnAcomodarDatos.Click += new System.EventHandler(this.btnAcomodarDatos_Click);
            // 
            // btnCompararMujeres
            // 
            this.btnCompararMujeres.Location = new System.Drawing.Point(183, 156);
            this.btnCompararMujeres.Name = "btnCompararMujeres";
            this.btnCompararMujeres.Size = new System.Drawing.Size(110, 45);
            this.btnCompararMujeres.TabIndex = 10;
            this.btnCompararMujeres.Text = "Comparar Con Mujeres";
            this.btnCompararMujeres.UseVisualStyleBackColor = true;
            this.btnCompararMujeres.Click += new System.EventHandler(this.btnCompararMujeres_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Trigliceridos";
            // 
            // txtTrigliceridos
            // 
            this.txtTrigliceridos.Location = new System.Drawing.Point(204, 116);
            this.txtTrigliceridos.Name = "txtTrigliceridos";
            this.txtTrigliceridos.Size = new System.Drawing.Size(100, 20);
            this.txtTrigliceridos.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Temperatura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Colesterol";
            // 
            // txtColesterol
            // 
            this.txtColesterol.Location = new System.Drawing.Point(204, 71);
            this.txtColesterol.Name = "txtColesterol";
            this.txtColesterol.Size = new System.Drawing.Size(100, 20);
            this.txtColesterol.TabIndex = 12;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(204, 34);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Magnecio";
            // 
            // txMagnecio
            // 
            this.txMagnecio.Location = new System.Drawing.Point(359, 116);
            this.txMagnecio.Name = "txMagnecio";
            this.txMagnecio.Size = new System.Drawing.Size(100, 20);
            this.txMagnecio.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "TensionArterial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Calcio";
            // 
            // txtCalcio
            // 
            this.txtCalcio.Location = new System.Drawing.Point(359, 71);
            this.txtCalcio.Name = "txtCalcio";
            this.txtCalcio.Size = new System.Drawing.Size(100, 20);
            this.txtCalcio.TabIndex = 18;
            // 
            // txtTensionArterial
            // 
            this.txtTensionArterial.Location = new System.Drawing.Point(359, 34);
            this.txtTensionArterial.Name = "txtTensionArterial";
            this.txtTensionArterial.Size = new System.Drawing.Size(100, 20);
            this.txtTensionArterial.TabIndex = 17;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(575, 39);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(202, 52);
            this.txtResultado.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(588, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txMagnecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCalcio);
            this.Controls.Add(this.txtTensionArterial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrigliceridos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColesterol);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.btnCompararMujeres);
            this.Controls.Add(this.btnAcomodarDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.btnNuevoPunto);
            this.Controls.Add(this.btnEmpezar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button btnNuevoPunto;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnAcomodarDatos;
        private System.Windows.Forms.Button btnCompararMujeres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrigliceridos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtColesterol;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txMagnecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCalcio;
        private System.Windows.Forms.TextBox txtTensionArterial;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label10;
    }
}

