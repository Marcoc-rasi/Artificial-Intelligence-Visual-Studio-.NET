namespace ClasificadorDeColoresPorEstadisticaClasica
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreObjeto = new System.Windows.Forms.TextBox();
            this.btnGuardarColor = new System.Windows.Forms.Button();
            this.txtRecaudarDatos5 = new System.Windows.Forms.TextBox();
            this.btnRecaudarDatos5 = new System.Windows.Forms.Button();
            this.txtRecaudarDatos4 = new System.Windows.Forms.TextBox();
            this.btnRecaudarDatos4 = new System.Windows.Forms.Button();
            this.txtRecaudarDatos3 = new System.Windows.Forms.TextBox();
            this.btnRecaudarDatos3 = new System.Windows.Forms.Button();
            this.txtRecaudarDatos2 = new System.Windows.Forms.TextBox();
            this.btnRecaudarDatos2 = new System.Windows.Forms.Button();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.txtRecibidos = new System.Windows.Forms.TextBox();
            this.txtRecaudarDatos1 = new System.Windows.Forms.TextBox();
            this.btnRecaudarDatos1 = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnActPuertos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PuertoSerialArduino = new System.IO.Ports.SerialPort(this.components);
            this.tmrActDatos = new System.Windows.Forms.Timer(this.components);
            this.btnReconocer = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(55, 379);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 23);
            this.btnLimpiar.TabIndex = 67;
            this.btnLimpiar.Text = "LimpiarDatos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "NombreDelObjeto";
            // 
            // txtNombreObjeto
            // 
            this.txtNombreObjeto.Location = new System.Drawing.Point(95, 285);
            this.txtNombreObjeto.Multiline = true;
            this.txtNombreObjeto.Name = "txtNombreObjeto";
            this.txtNombreObjeto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNombreObjeto.Size = new System.Drawing.Size(88, 20);
            this.txtNombreObjeto.TabIndex = 65;
            // 
            // btnGuardarColor
            // 
            this.btnGuardarColor.Location = new System.Drawing.Point(176, 379);
            this.btnGuardarColor.Name = "btnGuardarColor";
            this.btnGuardarColor.Size = new System.Drawing.Size(106, 23);
            this.btnGuardarColor.TabIndex = 64;
            this.btnGuardarColor.Text = "Guardar Color";
            this.btnGuardarColor.UseVisualStyleBackColor = true;
            this.btnGuardarColor.Click += new System.EventHandler(this.btnGuardarColor_Click);
            // 
            // txtRecaudarDatos5
            // 
            this.txtRecaudarDatos5.Location = new System.Drawing.Point(9, 254);
            this.txtRecaudarDatos5.Multiline = true;
            this.txtRecaudarDatos5.Name = "txtRecaudarDatos5";
            this.txtRecaudarDatos5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecaudarDatos5.Size = new System.Drawing.Size(121, 20);
            this.txtRecaudarDatos5.TabIndex = 63;
            // 
            // btnRecaudarDatos5
            // 
            this.btnRecaudarDatos5.Location = new System.Drawing.Point(163, 251);
            this.btnRecaudarDatos5.Name = "btnRecaudarDatos5";
            this.btnRecaudarDatos5.Size = new System.Drawing.Size(119, 23);
            this.btnRecaudarDatos5.TabIndex = 62;
            this.btnRecaudarDatos5.Text = "Recaudar Datos";
            this.btnRecaudarDatos5.UseVisualStyleBackColor = true;
            this.btnRecaudarDatos5.Click += new System.EventHandler(this.btnRecaudarDatos5_Click);
            // 
            // txtRecaudarDatos4
            // 
            this.txtRecaudarDatos4.Location = new System.Drawing.Point(9, 228);
            this.txtRecaudarDatos4.Multiline = true;
            this.txtRecaudarDatos4.Name = "txtRecaudarDatos4";
            this.txtRecaudarDatos4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecaudarDatos4.Size = new System.Drawing.Size(121, 20);
            this.txtRecaudarDatos4.TabIndex = 61;
            // 
            // btnRecaudarDatos4
            // 
            this.btnRecaudarDatos4.Location = new System.Drawing.Point(163, 225);
            this.btnRecaudarDatos4.Name = "btnRecaudarDatos4";
            this.btnRecaudarDatos4.Size = new System.Drawing.Size(119, 23);
            this.btnRecaudarDatos4.TabIndex = 60;
            this.btnRecaudarDatos4.Text = "Recaudar Datos";
            this.btnRecaudarDatos4.UseVisualStyleBackColor = true;
            this.btnRecaudarDatos4.Click += new System.EventHandler(this.btnRecaudarDatos4_Click);
            // 
            // txtRecaudarDatos3
            // 
            this.txtRecaudarDatos3.Location = new System.Drawing.Point(9, 195);
            this.txtRecaudarDatos3.Multiline = true;
            this.txtRecaudarDatos3.Name = "txtRecaudarDatos3";
            this.txtRecaudarDatos3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecaudarDatos3.Size = new System.Drawing.Size(121, 20);
            this.txtRecaudarDatos3.TabIndex = 59;
            // 
            // btnRecaudarDatos3
            // 
            this.btnRecaudarDatos3.Location = new System.Drawing.Point(163, 192);
            this.btnRecaudarDatos3.Name = "btnRecaudarDatos3";
            this.btnRecaudarDatos3.Size = new System.Drawing.Size(119, 23);
            this.btnRecaudarDatos3.TabIndex = 58;
            this.btnRecaudarDatos3.Text = "Recaudar Datos";
            this.btnRecaudarDatos3.UseVisualStyleBackColor = true;
            this.btnRecaudarDatos3.Click += new System.EventHandler(this.btnRecaudarDatos3_Click);
            // 
            // txtRecaudarDatos2
            // 
            this.txtRecaudarDatos2.Location = new System.Drawing.Point(9, 169);
            this.txtRecaudarDatos2.Multiline = true;
            this.txtRecaudarDatos2.Name = "txtRecaudarDatos2";
            this.txtRecaudarDatos2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecaudarDatos2.Size = new System.Drawing.Size(121, 20);
            this.txtRecaudarDatos2.TabIndex = 57;
            // 
            // btnRecaudarDatos2
            // 
            this.btnRecaudarDatos2.Location = new System.Drawing.Point(163, 166);
            this.btnRecaudarDatos2.Name = "btnRecaudarDatos2";
            this.btnRecaudarDatos2.Size = new System.Drawing.Size(119, 23);
            this.btnRecaudarDatos2.TabIndex = 56;
            this.btnRecaudarDatos2.Text = "Recaudar Datos";
            this.btnRecaudarDatos2.UseVisualStyleBackColor = true;
            this.btnRecaudarDatos2.Click += new System.EventHandler(this.btnRecaudarDatos2_Click);
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(62, 40);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(121, 21);
            this.cmbPuertos.TabIndex = 55;
            this.cmbPuertos.Text = "Seleccione puerto";
            this.cmbPuertos.SelectedIndexChanged += new System.EventHandler(this.cmbCambio_En_El_Indice_Del_Puerto);
            // 
            // txtRecibidos
            // 
            this.txtRecibidos.Location = new System.Drawing.Point(9, 318);
            this.txtRecibidos.Multiline = true;
            this.txtRecibidos.Name = "txtRecibidos";
            this.txtRecibidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecibidos.Size = new System.Drawing.Size(273, 55);
            this.txtRecibidos.TabIndex = 54;
            // 
            // txtRecaudarDatos1
            // 
            this.txtRecaudarDatos1.Location = new System.Drawing.Point(9, 143);
            this.txtRecaudarDatos1.Multiline = true;
            this.txtRecaudarDatos1.Name = "txtRecaudarDatos1";
            this.txtRecaudarDatos1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecaudarDatos1.Size = new System.Drawing.Size(121, 20);
            this.txtRecaudarDatos1.TabIndex = 53;
            // 
            // btnRecaudarDatos1
            // 
            this.btnRecaudarDatos1.Location = new System.Drawing.Point(163, 143);
            this.btnRecaudarDatos1.Name = "btnRecaudarDatos1";
            this.btnRecaudarDatos1.Size = new System.Drawing.Size(119, 23);
            this.btnRecaudarDatos1.TabIndex = 52;
            this.btnRecaudarDatos1.Text = "Recaudar Datos";
            this.btnRecaudarDatos1.UseVisualStyleBackColor = true;
            this.btnRecaudarDatos1.Click += new System.EventHandler(this.btnRecaudarDatos1_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(176, 88);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(109, 23);
            this.btnDesconectar.TabIndex = 51;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(17, 88);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(116, 23);
            this.btnConectar.TabIndex = 50;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnActPuertos
            // 
            this.btnActPuertos.Location = new System.Drawing.Point(188, 37);
            this.btnActPuertos.Name = "btnActPuertos";
            this.btnActPuertos.Size = new System.Drawing.Size(97, 23);
            this.btnActPuertos.TabIndex = 49;
            this.btnActPuertos.Text = "Actualizar";
            this.btnActPuertos.UseVisualStyleBackColor = true;
            this.btnActPuertos.Click += new System.EventHandler(this.btnActPuertos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Datos recibidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Comunicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Puerto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Selección del puerto";
            // 
            // PuertoSerialArduino
            // 
            this.PuertoSerialArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerial_RecepcionDatos);
            // 
            // tmrActDatos
            // 
            this.tmrActDatos.Tick += new System.EventHandler(this.tmrActDatos_Tick);
            // 
            // btnReconocer
            // 
            this.btnReconocer.Location = new System.Drawing.Point(529, 285);
            this.btnReconocer.Name = "btnReconocer";
            this.btnReconocer.Size = new System.Drawing.Size(75, 35);
            this.btnReconocer.TabIndex = 68;
            this.btnReconocer.Text = "Reconocer Objeto ";
            this.btnReconocer.UseVisualStyleBackColor = true;
            this.btnReconocer.Click += new System.EventHandler(this.btnReconocer_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(475, 23);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(195, 142);
            this.txtResultado.TabIndex = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnReconocer);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreObjeto);
            this.Controls.Add(this.btnGuardarColor);
            this.Controls.Add(this.txtRecaudarDatos5);
            this.Controls.Add(this.btnRecaudarDatos5);
            this.Controls.Add(this.txtRecaudarDatos4);
            this.Controls.Add(this.btnRecaudarDatos4);
            this.Controls.Add(this.txtRecaudarDatos3);
            this.Controls.Add(this.btnRecaudarDatos3);
            this.Controls.Add(this.txtRecaudarDatos2);
            this.Controls.Add(this.btnRecaudarDatos2);
            this.Controls.Add(this.cmbPuertos);
            this.Controls.Add(this.txtRecibidos);
            this.Controls.Add(this.txtRecaudarDatos1);
            this.Controls.Add(this.btnRecaudarDatos1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.btnActPuertos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreObjeto;
        private System.Windows.Forms.Button btnGuardarColor;
        private System.Windows.Forms.TextBox txtRecaudarDatos5;
        private System.Windows.Forms.Button btnRecaudarDatos5;
        private System.Windows.Forms.TextBox txtRecaudarDatos4;
        private System.Windows.Forms.Button btnRecaudarDatos4;
        private System.Windows.Forms.TextBox txtRecaudarDatos3;
        private System.Windows.Forms.Button btnRecaudarDatos3;
        private System.Windows.Forms.TextBox txtRecaudarDatos2;
        private System.Windows.Forms.Button btnRecaudarDatos2;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.TextBox txtRecibidos;
        private System.Windows.Forms.TextBox txtRecaudarDatos1;
        private System.Windows.Forms.Button btnRecaudarDatos1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnActPuertos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort PuertoSerialArduino;
        private System.Windows.Forms.Timer tmrActDatos;
        private System.Windows.Forms.Button btnReconocer;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

