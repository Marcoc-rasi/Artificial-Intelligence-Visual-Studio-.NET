namespace TrianguloMagico
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
            this.btnResolver = new System.Windows.Forms.Button();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.txtBoxF = new System.Windows.Forms.TextBox();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.txtBoxD = new System.Windows.Forms.TextBox();
            this.txtBoxE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrueba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(90, 150);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(75, 23);
            this.btnResolver.TabIndex = 0;
            this.btnResolver.Text = "Resolver ";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbNumero
            // 
            this.cmbNumero.FormattingEnabled = true;
            this.cmbNumero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbNumero.Location = new System.Drawing.Point(73, 95);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(121, 21);
            this.cmbNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Este es un triangulo magico todos sus lados deben sumar 9 con numeros del 1 al 6";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(510, 72);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(100, 20);
            this.txtBoxA.TabIndex = 3;
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(423, 150);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxB.TabIndex = 4;
            // 
            // txtBoxF
            // 
            this.txtBoxF.Location = new System.Drawing.Point(606, 150);
            this.txtBoxF.Name = "txtBoxF";
            this.txtBoxF.Size = new System.Drawing.Size(100, 20);
            this.txtBoxF.TabIndex = 5;
            // 
            // txtBoxC
            // 
            this.txtBoxC.Location = new System.Drawing.Point(357, 220);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(100, 20);
            this.txtBoxC.TabIndex = 6;
            // 
            // txtBoxD
            // 
            this.txtBoxD.Location = new System.Drawing.Point(510, 220);
            this.txtBoxD.Name = "txtBoxD";
            this.txtBoxD.Size = new System.Drawing.Size(100, 20);
            this.txtBoxD.TabIndex = 7;
            // 
            // txtBoxE
            // 
            this.txtBoxE.Location = new System.Drawing.Point(666, 220);
            this.txtBoxE.Name = "txtBoxE";
            this.txtBoxE.Size = new System.Drawing.Size(100, 20);
            this.txtBoxE.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Para comenzar selecciona el numero con el cual iniciara el calculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "con numeros del 1 al 6 que no pueden repetirse";
            // 
            // txtPrueba
            // 
            this.txtPrueba.Location = new System.Drawing.Point(24, 222);
            this.txtPrueba.Name = "txtPrueba";
            this.txtPrueba.Size = new System.Drawing.Size(220, 20);
            this.txtPrueba.TabIndex = 11;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(777, 288);
            this.Controls.Add(this.txtPrueba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxE);
            this.Controls.Add(this.txtBoxD);
            this.Controls.Add(this.txtBoxC);
            this.Controls.Add(this.txtBoxF);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNumero);
            this.Controls.Add(this.btnResolver);
            this.Name = "Form1";
            this.Text = "Triangulo Magico Martinez Ortiz Marcos Uriel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.ComboBox cmbNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.TextBox txtBoxF;
        private System.Windows.Forms.TextBox txtBoxC;
        private System.Windows.Forms.TextBox txtBoxD;
        private System.Windows.Forms.TextBox txtBoxE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrueba;
    }
}

