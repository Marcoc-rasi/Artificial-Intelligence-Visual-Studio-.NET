using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using SpreadsheetLight;
using Exodo;

namespace ClasificadorDeColoresPorEstadisticaClasica
{
    public partial class Form1 : Form
    {
        #region VariablesGlobales
        
        private string CadenaRecibidaDeArduino;  
        private DataTable[] TablasDeDatosDeCadaPrueba = new DataTable[5];
        public List<string> NombresDeLosObjetosRegistrados = new List<string>();

        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        #region Metodos De Comunicacion Con Arduino
        private void btnActPuertos_Click(object sender, EventArgs e)
        {
            BuscarPuertos();
        }
        private void BuscarPuertos()
        {
            //Obtener el nombre de puertos existentes en el equipo
            string[] NombresPuertos = SerialPort.GetPortNames();
            //Eliminar los elementos del control ComboBox
            cmbPuertos.Items.Clear();
            //Ciclo para agregar los nombres de los puertos de los puertos al control ComboBox
            foreach (string Nombre in NombresPuertos)
            {
                cmbPuertos.Items.Add(Nombre);
            }
            //Agregar el mensaje en la propiedad del control
            cmbPuertos.Text = "Seleccione puerto";
        }
        private void cmbCambio_En_El_Indice_Del_Puerto(object sender, EventArgs e)
        {
            //Asignar el nombre actual del ComboBox a la propiedad PortName del puerto
            PuertoSerialArduino.PortName = cmbPuertos.SelectedItem.ToString();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Manejo de excepción
            try
            {
                //Abrir el puerto
                PuertoSerialArduino.Open();
                //Enviar mensaje al usuario del puerto abierto
                MessageBox.Show("Puerto abierto");
                //Inicia el timer
                tmrActDatos.Start();
            }
            catch (Exception error)
            {
                //Si ocurre una excepción, enviar el mensaje al usuario
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //Si el puerto está abierto
            if (PuertoSerialArduino.IsOpen)
            {
                //Cierra el puerto
                PuertoSerialArduino.Close();
                //Envía un mensaje de que se ha cerrado el puerto
                MessageBox.Show("Puerto cerrado");
                //Detener timer
                tmrActDatos.Stop();
            }
            else
            {
                //Enviar mensaje de que el puerto no está abierto
                MessageBox.Show("El puerto está cerrado.");
            }
        }
        private void PuertoSerial_RecepcionDatos(object sender, SerialDataReceivedEventArgs e)
        {
            //Espera 100 ms
            Thread.Sleep(300);
            //Asigna los datos existentes en el búfer al atributo CadenaRecibidaDeArduino
            if (PuertoSerialArduino.IsOpen)
            {
                CadenaRecibidaDeArduino = PuertoSerialArduino.ReadExisting();
            }
        }
        private void tmrActDatos_Tick(object sender, EventArgs e)
        {
            if (CadenaRecibidaDeArduino == null)
            {
                txtRecibidos.Text = "No se esta mandando informacion";
            }
            else
            {
                string[] CadenaDescompuestaRGB = CadenaRecibidaDeArduino.Split(',');
                int R = Convert.ToInt32(CadenaDescompuestaRGB[0]);
                int G = Convert.ToInt32(CadenaDescompuestaRGB[1]);
                int B = Convert.ToInt32(CadenaDescompuestaRGB[2]);
                txtRecibidos.Text = "R " + R + " , G " + G + " , B " + B;
            }

        }
        private DataTable RecaudarInformacion()
        {
            DataTable TablaDatosRGB = new DataTable();
            //Columnas
            TablaDatosRGB.Columns.Add("MediaR", typeof(double));
            TablaDatosRGB.Columns.Add("MediaG", typeof(double));
            TablaDatosRGB.Columns.Add("MediaB", typeof(double));
            while (CadenaRecibidaDeArduino == null)
            {
                /*Este while soloe s para esperar hasta cuando el arduino regresa informaciuno verdadera*/
            }

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                string[] CadenaDescompuestaRGB = CadenaRecibidaDeArduino.Split(',');
                int R = Convert.ToInt32(CadenaDescompuestaRGB[0]);
                int G = Convert.ToInt32(CadenaDescompuestaRGB[1]);
                int B = Convert.ToInt32(CadenaDescompuestaRGB[2]);
                TablaDatosRGB.Rows.Add(R, G, B);
            }
            return TablaDatosRGB;
        }
        #endregion

        #region Metodos de Menu De Recaudo de Informacion
        private void btnRecaudarDatos1_Click(object sender, EventArgs e)
        {
            //Si el puerto está abierto
            if (PuertoSerialArduino.IsOpen)
            {
                //Escribe en el puerto la cadena a enviar
                PuertoSerialArduino.WriteLine("e");
                TablasDeDatosDeCadaPrueba[0] = RecaudarInformacion();
                txtRecaudarDatos1.Text = "Completado";
            }
            else
                //Enviar mensaje de error si no está abierto el puerto
                MessageBox.Show("Necesita conectarse al puerto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRecaudarDatos2_Click(object sender, EventArgs e)
        {
            //Si el puerto está abierto
            if (PuertoSerialArduino.IsOpen)
            {
                //Escribe en el puerto la cadena a enviar
                PuertoSerialArduino.WriteLine("e");
                TablasDeDatosDeCadaPrueba[1] = RecaudarInformacion();
                txtRecaudarDatos2.Text = "Completado";
            }
            else
                //Enviar mensaje de error si no está abierto el puerto
                MessageBox.Show("Necesita conectarse al puerto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRecaudarDatos3_Click(object sender, EventArgs e)
        {
            //Si el puerto está abierto
            if (PuertoSerialArduino.IsOpen)
            {
                //Escribe en el puerto la cadena a enviar
                PuertoSerialArduino.WriteLine("e");
                TablasDeDatosDeCadaPrueba[2] = RecaudarInformacion();
                txtRecaudarDatos3.Text = "Completado";
            }
            else
                //Enviar mensaje de error si no está abierto el puerto
                MessageBox.Show("Necesita conectarse al puerto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRecaudarDatos4_Click(object sender, EventArgs e)
        {
            //Si el puerto está abierto
            if (PuertoSerialArduino.IsOpen)
            {
                //Escribe en el puerto la cadena a enviar
                PuertoSerialArduino.WriteLine("e");
                TablasDeDatosDeCadaPrueba[3] = RecaudarInformacion();
                txtRecaudarDatos4.Text = "Completado";
            }
            else
                //Enviar mensaje de error si no está abierto el puerto
                MessageBox.Show("Necesita conectarse al puerto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRecaudarDatos5_Click(object sender, EventArgs e)
        {
            //Si el puerto está abierto
            if (PuertoSerialArduino.IsOpen)
            {
                //Escribe en el puerto la cadena a enviar
                PuertoSerialArduino.WriteLine("e");
                TablasDeDatosDeCadaPrueba[4] = RecaudarInformacion();
                txtRecaudarDatos5.Text = "Completado";
            }
            else
                //Enviar mensaje de error si no está abierto el puerto
                MessageBox.Show("Necesita conectarse al puerto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (TablasDeDatosDeCadaPrueba[0] == null)
            {
                MessageBox.Show("Los Datos Se Han limpiado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    TablasDeDatosDeCadaPrueba[i].Clear();
                }
                txtRecaudarDatos1.Text = "Limpio";
                txtRecaudarDatos2.Text = "Limpio";
                txtRecaudarDatos3.Text = "Limpio";
                txtRecaudarDatos4.Text = "Limpio";
                txtRecaudarDatos5.Text = "Limpio";
                txtNombreObjeto.Text = "Limpio";
            }
        }

        private void btnGuardarColor_Click(object sender, EventArgs e)
        {
            if (TablasDeDatosDeCadaPrueba[0] == null)
            {
                MessageBox.Show("No Se Ha Registrado ningun Dato por el momento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNombreObjeto.Text != null)
                {
                    // Se crea el acceso al documento excel de donde sacaremos y guardaremos los datos
                    string RutaArchivoExcel = AppDomain.CurrentDomain.BaseDirectory + "Excel" + txtNombreObjeto.Text + ".xlsx";
                    SLDocument DocumentoExcel = new SLDocument();

                    DocumentoExcel.AddWorksheet(txtNombreObjeto.Text);
                    NombresDeLosObjetosRegistrados.Add(txtNombreObjeto.Text);
                    DocumentoExcel.AddWorksheet(txtNombreObjeto.Text + "a");

                    DocumentoExcel.SelectWorksheet(txtNombreObjeto.Text);
                    DocumentoExcel.DeleteWorksheet(txtNombreObjeto.Text + "a");

                    int renglonGruposRGB = 1;
                    int columnaGruposRGB = 1;

                    DataTable PromedioPorTabla = new DataTable();

                    double SumaR = 0;
                    double SumaG = 0;
                    double SumaB = 0;
                    double SumaVarianzaR = 0;
                    double SumaVarianzaG = 0;
                    double SumaVarianzaB = 0;

                    foreach (DataTable Tabla in TablasDeDatosDeCadaPrueba)
                    {
                        PromedioPorTabla = CalcularPromedioTabla(Tabla);
                        DocumentoExcel.ImportDataTable(renglonGruposRGB, columnaGruposRGB, Tabla, true);
                        DocumentoExcel.ImportDataTable(14, columnaGruposRGB, PromedioPorTabla, true);
                        
                        SumaR += Convert.ToDouble(PromedioPorTabla.Rows[0][0].ToString());
                        SumaG += Convert.ToDouble(PromedioPorTabla.Rows[0][1].ToString());
                        SumaB += Convert.ToDouble(PromedioPorTabla.Rows[0][2].ToString());
                        SumaVarianzaR += Convert.ToDouble(PromedioPorTabla.Rows[1][0].ToString());
                        SumaVarianzaG += Convert.ToDouble(PromedioPorTabla.Rows[1][1].ToString());
                        SumaVarianzaB += Convert.ToDouble(PromedioPorTabla.Rows[1][2].ToString());

                        columnaGruposRGB += 4;
                    }
                    PromedioPorTabla.Rows[0][0] = SumaR / 5;
                    PromedioPorTabla.Rows[0][1] = SumaG / 5;
                    PromedioPorTabla.Rows[0][2] = SumaB / 5;

                    PromedioPorTabla.Rows[1][0] = SumaVarianzaR / 5;
                    PromedioPorTabla.Rows[1][1] = SumaVarianzaG / 5;
                    PromedioPorTabla.Rows[1][2] = SumaVarianzaB / 5;

                    
                    DocumentoExcel.ImportDataTable(20, 5, PromedioPorTabla, true);
                    DocumentoExcel.SetCellValue(20, 1, txtNombreObjeto.Text);
                    DocumentoExcel.SaveAs(RutaArchivoExcel);

                    
                }
                else
                {
                    MessageBox.Show("No Se Ha Registrado ningun Dato por el momento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public DataTable CalcularPromedioTabla(DataTable TablaAPromediar)
        {
            double SumaR = 0;
            double SumaG = 0;
            double SumaB = 0;
            double PromedioR = 0;
            double PromedioG = 0;
            double PromedioB = 0;
            for (int i = 0; i < TablaAPromediar.Rows.Count; i++)
            {
                SumaR += Convert.ToDouble(TablaAPromediar.Rows[i][0].ToString());
                SumaG += Convert.ToDouble(TablaAPromediar.Rows[i][1].ToString());
                SumaB += Convert.ToDouble(TablaAPromediar.Rows[i][2].ToString());
            }
            PromedioR = SumaR / TablaAPromediar.Rows.Count;
            PromedioG = SumaG / TablaAPromediar.Rows.Count;
            PromedioB = SumaB / TablaAPromediar.Rows.Count;
            DataTable TablaParaPromediar = new DataTable();
            TablaParaPromediar.Columns.Add("MediaR", typeof(double));
            TablaParaPromediar.Columns.Add("MediaG", typeof(double));
            TablaParaPromediar.Columns.Add("MediaB", typeof(double));
            TablaParaPromediar.Rows.Add(PromedioR, PromedioG, PromedioB);

            double VarianzaR = 0;
            double VarianzaG = 0;
            double VarianzaB = 0;

            for (int i = 0; i < TablaAPromediar.Rows.Count; i++)
            {
                
                VarianzaR = Exodo.EMath.EPow(Convert.ToDouble(TablaAPromediar.Rows[i][0].ToString()) - PromedioR, 2) + VarianzaR;
                VarianzaG = Exodo.EMath.EPow(Convert.ToDouble(TablaAPromediar.Rows[i][1].ToString()) - PromedioG, 2) + VarianzaG;
                VarianzaB = Exodo.EMath.EPow(Convert.ToDouble(TablaAPromediar.Rows[i][2].ToString()) - PromedioB, 2) + VarianzaB;

            }
            VarianzaR = VarianzaR / TablaAPromediar.Rows.Count;
            VarianzaG = VarianzaG / TablaAPromediar.Rows.Count;
            VarianzaB = VarianzaB / TablaAPromediar.Rows.Count;

            TablaParaPromediar.Rows.Add(VarianzaR, VarianzaG, VarianzaB);

            return TablaParaPromediar;
        }
        #endregion

        #region Metodos De Comparacion
        public   string CompararObjetos()
        {
            string ObjetoQueMasSeParece = "";
            if (NombresDeLosObjetosRegistrados.Count == 0)
            {
                MessageBox.Show("No Existen Objetos Registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                #region Se construyen Los tres objetos Gaussianos en R, G, B del objeto de Prueba
                DataTable PromedioAComparar = new DataTable();

                PromedioAComparar = CalcularPromedioTabla(TablasDeDatosDeCadaPrueba[0]);
                
                double MediaRAComparar = Convert.ToDouble(PromedioAComparar.Rows[0][0].ToString());
                double MediaGAComparar = Convert.ToDouble(PromedioAComparar.Rows[0][1].ToString());
                double MediaBAComparar = Convert.ToDouble(PromedioAComparar.Rows[0][2].ToString());

                double DesviacionEstandarRAComparar = Exodo.EMath.ESqrt(Convert.ToDouble(PromedioAComparar.Rows[1][0].ToString()));
                double DesviacionEstandarGAComparar = Exodo.EMath.ESqrt(Convert.ToDouble(PromedioAComparar.Rows[1][1].ToString())); 
                double DesviacionEstandarBAComparar = Exodo.EMath.ESqrt(Convert.ToDouble(PromedioAComparar.Rows[1][2].ToString())); 

                Gauss ObjetoGauseanoRAComparar = new Gauss(MediaRAComparar, DesviacionEstandarRAComparar);
                Gauss ObjetoGauseanoGAComparar = new Gauss(MediaGAComparar, DesviacionEstandarGAComparar);
                Gauss ObjetoGauseanoBAComparar = new Gauss(MediaBAComparar, DesviacionEstandarBAComparar);
                #endregion
                double PorcentajeMayorR = 0;
                double PorcentajeMayorG = 0;
                double PorcentajeMayorB = 0;
                foreach (string NombreDelObjeto in NombresDeLosObjetosRegistrados)
                {
                    #region Se construyen los tres objetos Gaussianos en R, G, B del objeto el la base de datos
                    string RutaArchivoExcel = AppDomain.CurrentDomain.BaseDirectory + "Excel" + NombreDelObjeto + ".xlsx";
                    SLDocument DocumentoExcel = new SLDocument(RutaArchivoExcel, NombreDelObjeto);

                    double MediaObjetoDeLaBaseDeDatosR = DocumentoExcel.GetCellValueAsDouble(21,5);
                    double MediaObjetoDeLaBaseDeDatosG = DocumentoExcel.GetCellValueAsDouble(21,6);
                    double MediaObjetoDeLaBaseDeDatosB = DocumentoExcel.GetCellValueAsDouble(21,7);

                    double VarianzaObjetoDeLaBaseDeDatosR = DocumentoExcel.GetCellValueAsDouble(22, 5);
                    double VarianzaObjetoDeLaBaseDeDatosG = DocumentoExcel.GetCellValueAsDouble(22, 6);
                    double VarianzaObjetoDeLaBaseDeDatosB = DocumentoExcel.GetCellValueAsDouble(22, 7);

                    double DesviacionEstandarBaseDeDatosR = Exodo.EMath.ESqrt(VarianzaObjetoDeLaBaseDeDatosR);
                    double DesviacionEstandarBaseDeDatosG = Exodo.EMath.ESqrt(VarianzaObjetoDeLaBaseDeDatosG);
                    double DesviacionEstandarBaseDeDatosB = Exodo.EMath.ESqrt(VarianzaObjetoDeLaBaseDeDatosB);

                    Gauss ObjetoGauseanoRBaseDeDatos = new Gauss(MediaObjetoDeLaBaseDeDatosR,DesviacionEstandarBaseDeDatosR);
                    Gauss ObjetoGauseanoGBaseDeDatos = new Gauss(MediaObjetoDeLaBaseDeDatosG, DesviacionEstandarBaseDeDatosG);
                    Gauss ObjetoGauseanoBBaseDeDatos = new Gauss(MediaObjetoDeLaBaseDeDatosB, DesviacionEstandarBaseDeDatosB);

                    #endregion
                    #region Se Comparan Los tres objetos Gausianos De Prueba, Con Sus Respectivas Parejas En La Base De Datos
                    double ValorComparacionR = 0;
                    double ValorComparacionG = 0;
                    double ValorComparacionB = 0;
                    

                    ValorComparacionR = CompararObjetosGausianos(ObjetoGauseanoRAComparar, ObjetoGauseanoRBaseDeDatos);
                    ValorComparacionG = CompararObjetosGausianos(ObjetoGauseanoGAComparar, ObjetoGauseanoGBaseDeDatos);
                    ValorComparacionB = CompararObjetosGausianos(ObjetoGauseanoBAComparar, ObjetoGauseanoBBaseDeDatos);
                    if(ValorComparacionR > PorcentajeMayorR && ValorComparacionG > PorcentajeMayorG && ValorComparacionB > PorcentajeMayorB)
                    {
                        PorcentajeMayorR = ValorComparacionR;
                        PorcentajeMayorG = ValorComparacionG;
                        PorcentajeMayorB = ValorComparacionB;
                        ObjetoQueMasSeParece = NombreDelObjeto;
                    }
                    #endregion
                }
            }
            return ObjetoQueMasSeParece;
        }
        public double LikelihoddEnComun(Gauss objP, Gauss objB, double min, double max)
        {
            double likP = 0;
            double likB = 0;
            double LikeelihoodDeseado = 0;
            for(double x = min; x < max; x =x +0.01)
            {
                likP = objP.Likelihood(x);
                likB = objB.Likelihood(x);
                if(likB < 1.05*likP && likB > 0.95 * likP)
                {
                    LikeelihoodDeseado = x;
                }
            }


            return LikeelihoodDeseado;
        }
        public double CalcularIntegral(Gauss obj,double Inicio, double Final)
        {
            int TamañoArreglo = Exodo.Funciones.Linspace(Inicio, Final, 0.1).Length;
            double[] xFuncion = new double[TamañoArreglo];
            xFuncion = Exodo.Funciones.Linspace(Inicio, Final, 0.1);
            double[] yFuncion = new double[xFuncion.Length];
            int i = 0;
            for (double x= Inicio; x < Final; x = x + 0.1)
            {
                yFuncion[i] = obj.Likelihood(x);
                i++;
            }
            
            return Exodo.Funciones.Integral(xFuncion,yFuncion);
        }
        public double CompararObjetosGausianos(Gauss ObjGausianoPrueba, Gauss ObjGausianoBaseDeDatos)
        {
            double PorcentajeComparacion = 0;
            double minPrueba = ObjGausianoPrueba.Gxmin;
            double maxPrueba = ObjGausianoPrueba.Gxmax;
            double minBaseDeDatos = ObjGausianoBaseDeDatos.Gxmin;
            double maxBaseDeDatos = ObjGausianoBaseDeDatos.Gxmax;
            //El Primer caso cuando el objeto de prueba esta dentro del objeto de la base de datos
            if(minPrueba<maxBaseDeDatos && minPrueba > minBaseDeDatos)
            {
                if(maxPrueba<maxBaseDeDatos && maxPrueba > minBaseDeDatos)
                {
                    PorcentajeComparacion = 100;
                }
            }
            //El segundo caso cuando el objeto de la base de datos  esta dentro del objeto de prueba
            if (minBaseDeDatos < maxPrueba && minBaseDeDatos > minPrueba)
            {
                if (maxBaseDeDatos < maxPrueba && maxPrueba > minPrueba)
                {
                    PorcentajeComparacion = 100;
                }
            }
            //El tercer caso cuando El objeto de prueba esta a la derecha del objeto de la base de datos
            if (minPrueba < maxBaseDeDatos && minPrueba > minBaseDeDatos)
            {
                if (maxPrueba > maxBaseDeDatos)
                {
                    double Likelihoodencomun = LikelihoddEnComun(ObjGausianoPrueba, ObjGausianoBaseDeDatos, minPrueba, maxBaseDeDatos);
                    if (Likelihoodencomun == 0)
                    {
                        PorcentajeComparacion = 0;
                    }
                    else
                    {
                        double Probabilidad = CalcularIntegral(ObjGausianoPrueba, minPrueba, Likelihoodencomun);
                        Probabilidad += CalcularIntegral(ObjGausianoBaseDeDatos, Likelihoodencomun, maxBaseDeDatos);
                        PorcentajeComparacion = Probabilidad * 100;
                    }
                }
            }
            //El cuarto caso cuando El objeto de prueba esta a la izquierda del objeto de la base de datos
            if (minPrueba < minBaseDeDatos && maxPrueba> minBaseDeDatos)
            {
                if (maxPrueba < maxBaseDeDatos)
                {
                    double Likelihoodencomun = LikelihoddEnComun(ObjGausianoPrueba, ObjGausianoBaseDeDatos, minBaseDeDatos, maxPrueba);
                    if (Likelihoodencomun == 0)
                    {
                        PorcentajeComparacion = 0;
                    }
                    else
                    {
                        double Probabilidad = CalcularIntegral(ObjGausianoPrueba, minPrueba, Likelihoodencomun);
                        Probabilidad += CalcularIntegral(ObjGausianoBaseDeDatos, Likelihoodencomun, maxBaseDeDatos);
                        PorcentajeComparacion = Probabilidad * 100;
                    }
                }
            }
            //El quinto caso cuando los dos estan Separados la prueba del lado izquierdo
            if (minPrueba < minBaseDeDatos && maxPrueba < minBaseDeDatos)
            {     
                 PorcentajeComparacion = 0; 
            }
            //El sexto caso cuando los dos estan Separados la prueba esta a la derecha
            if (minPrueba > maxBaseDeDatos && maxPrueba >maxBaseDeDatos )
            {
                PorcentajeComparacion = 0;
            }
            return PorcentajeComparacion;
        }
        
        private void btnReconocer_Click(object sender, EventArgs e)
        {
            string ObjetoUbicado= CompararObjetos();
            if(ObjetoUbicado == "")
            {
                txtResultado.Text = "ningun objeto guardado se parace al comparado";
            }
            else
            {
                txtResultado.Text = ObjetoUbicado;            }
        }
        #endregion
    }
}
