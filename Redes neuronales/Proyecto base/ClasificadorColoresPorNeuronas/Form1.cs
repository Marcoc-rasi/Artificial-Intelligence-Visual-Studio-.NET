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

namespace ClasificadorColoresPorNeuronas
{
    public partial class Form1 : Form
    {
        //Atributo
        private string CadenaRecibida;
        public int PrimeraEntrada = 0;
        public List<Perceptron> Perceptrones = new List<Perceptron>();
        private DataTable[] TablasDeDatos= new DataTable[5];
        public static  string RutaArchivoExcelPerceptron = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\ClasificadorColoresPorNeuronas\bin\Debug\entrenamientoPerceptron.xlsx";
        public  static SLDocument DocumentoExcelPerceptron = new SLDocument(RutaArchivoExcelPerceptron,"Hoja1");
        public List<string> NombresObjetos = new List<string>();
        public DataTable TablaLogica = new DataTable();
        //public  Perceptron perceptron = new Perceptron(DocumentoExcelPerceptron, "Separador De grupos");
        


        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        private void btnActPuertos_Click(object sender, EventArgs e)
        {
            BuscarPuertos();
        }
        //Método para buscar los puertos en el equipo
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
        //Método que se genera cuando se cambia el índice del ComboBox cmbPuertos
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
            //Asigna los datos existentes en el búfer al atributo CadenaRecibida
            if (PuertoSerialArduino.IsOpen)
            {
                CadenaRecibida = PuertoSerialArduino.ReadExisting();
            }
        }

        private void tmrActDatos_Tick(object sender, EventArgs e)
        {
            if (CadenaRecibida == null)
            {
                txtRecibidos.Text = "No se esta mandando informacion";
            }
            else
            {
                string[] CadenaDescompuestaRGB = CadenaRecibida.Split(',');
                int R = Convert.ToInt32(CadenaDescompuestaRGB[0]);
                int G = Convert.ToInt32(CadenaDescompuestaRGB[1]);
                int B = Convert.ToInt32(CadenaDescompuestaRGB[2]);
                txtRecibidos.Text = "R " + R + " ,G " + G + " ,B " + B;
            }

        }
        private DataTable RecaudarInformacion()
        {
            DataTable TablaDatosRGB = new DataTable();
            //Columnas
            TablaDatosRGB.Columns.Add("R", typeof(double));
            TablaDatosRGB.Columns.Add("G", typeof(double));
            TablaDatosRGB.Columns.Add("B", typeof(double));
            while (CadenaRecibida == null)
            {
                /*Este while soloe s para esperar hasta cuando el arduino regresa informaciuno verdadera*/
            }

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                string[] CadenaDescompuestaRGB = CadenaRecibida.Split(',');
                int R = Convert.ToInt32(CadenaDescompuestaRGB[0]);
                int G = Convert.ToInt32(CadenaDescompuestaRGB[1]);
                int B = Convert.ToInt32(CadenaDescompuestaRGB[2]);
                TablaDatosRGB.Rows.Add(R, G, B);
            }
            return TablaDatosRGB;
        }
        
        private void btnRecaudarDatos1_Click(object sender, EventArgs e)
        {
            //Si el puerto está abierto
            if (PuertoSerialArduino.IsOpen)
            {
                //Escribe en el puerto la cadena a enviar
                PuertoSerialArduino.WriteLine("e");
                TablasDeDatos[0]= RecaudarInformacion();
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
                TablasDeDatos[1] = RecaudarInformacion();
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
                TablasDeDatos[2] = RecaudarInformacion();
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
                TablasDeDatos[3] = RecaudarInformacion();
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
                TablasDeDatos[4] = RecaudarInformacion();
                txtRecaudarDatos5.Text = "Completado";
            }
            else
                //Enviar mensaje de error si no está abierto el puerto
                MessageBox.Show("Necesita conectarse al puerto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnGuardarColor_Click(object sender, EventArgs e)
        {
            if (TablasDeDatos[0] == null)
            {
                txtRecibidos.Text = "Complete los datos faltantes";
            }
            else
            {
                if (PrimeraEntrada == 0)
                {
                    PrimeraEntrada++;
                    //string RutaArchivoExcelPerceptron = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\ClasificadorColoresPorNeuronas\bin\Debug\entrenamientoPerceptron.xlsx";
                    //SLDocument DocumentoExcelPerceptron = new SLDocument(RutaArchivoExcelPerceptron, "Hoja1");
                    int renglonGrupos = 1;
                    int columnaGrupos = 1;
                    bool a = true;
                    // Se crea el acceso al documento excel de donde sacaremos y guardaremos los datos
                    string RutaArchivoExcel = AppDomain.CurrentDomain.BaseDirectory + "Excel" + txtNombreObjeto.Text + ".xlsx";
                    SLDocument DocumentoExcel = new SLDocument();
                    DataTable PromedioPorTabla = new DataTable();
                   
                    double SumaR = 0;
                    double SumaG = 0;
                    double SumaB = 0;
                   
                    foreach (DataTable Tabla in TablasDeDatos)
                    {
                        PromedioPorTabla = CalcularPromedioTabla(Tabla);
                        DocumentoExcel.ImportDataTable(14, columnaGrupos, PromedioPorTabla, true);
                        DocumentoExcel.ImportDataTable(renglonGrupos, columnaGrupos, Tabla, true);
                        SumaR += Convert.ToDouble(PromedioPorTabla.Rows[0][0].ToString());
                        SumaG += Convert.ToDouble(PromedioPorTabla.Rows[0][1].ToString());
                        SumaB += Convert.ToDouble(PromedioPorTabla.Rows[0][2].ToString());
                        columnaGrupos += 4;
                    }
                    PromedioPorTabla.Rows[0][0] = SumaR / 5;
                    PromedioPorTabla.Rows[0][1] = SumaG / 5;
                    PromedioPorTabla.Rows[0][2] = SumaB / 5;
                    NombresObjetos.Add(txtNombreObjeto.Text);
                    DocumentoExcel.ImportDataTable(20, 5, PromedioPorTabla, true);
                    DocumentoExcel.SetCellValue(20, 1, txtNombreObjeto.Text);
                    DocumentoExcel.SaveAs(RutaArchivoExcel);
                    int ColumnaDatosPerceptron = 11;
                    int RenglonDatosPerceptron = 51;
                    int R = 0;
                    int G = 0;
                    int B = 0;
                    DataTable TablaParaPerceptron = new DataTable();
                    TablaParaPerceptron.Columns.Add("R", typeof(double));
                    TablaParaPerceptron.Columns.Add("G", typeof(double));
                    TablaParaPerceptron.Columns.Add("B", typeof(double));
                    foreach (DataTable tabla in TablasDeDatos)
                    {
                        for (int i = 0; i < tabla.Rows.Count; i++)
                        {
                            R = Convert.ToInt32(tabla.Rows[i][0].ToString());
                            G = Convert.ToInt32(tabla.Rows[i][1].ToString());
                            B = Convert.ToInt32(tabla.Rows[i][2].ToString());
                            TablaParaPerceptron.Rows.Add(R, G, B);
                        }
                    }
                    DocumentoExcelPerceptron.ImportDataTable(RenglonDatosPerceptron, ColumnaDatosPerceptron, TablaParaPerceptron, true);
                    DocumentoExcelPerceptron.SaveAs(RutaArchivoExcelPerceptron);
                }
                else
                {
                    if (DocumentoExcelPerceptron.DocumentProperties == null)
                    {
                        string RutaArchivoExcelPerceptron = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\ClasificadorColoresPorNeuronas\bin\Debug\entrenamientoPerceptron.xlsx";
                        SLDocument DocumentoExcelPerceptron = new SLDocument(RutaArchivoExcelPerceptron, "Hoja1");
                        int renglonGrupos = 1;
                        int columnaGrupos = 1;
                        // Se crea el acceso al documento excel de donde sacaremos y guardaremos los datos
                        string RutaArchivoExcel = AppDomain.CurrentDomain.BaseDirectory + "Excel" + txtNombreObjeto.Text + ".xlsx";
                        SLDocument DocumentoExcel = new SLDocument();
                        DataTable PromedioPorTabla = new DataTable();

                        double SumaR = 0;
                        double SumaG = 0;
                        double SumaB = 0;

                        foreach (DataTable Tabla in TablasDeDatos)
                        {
                            PromedioPorTabla = CalcularPromedioTabla(Tabla);
                            DocumentoExcel.ImportDataTable(14, columnaGrupos, PromedioPorTabla, true);
                            DocumentoExcel.ImportDataTable(renglonGrupos, columnaGrupos, Tabla, true);
                            SumaR += Convert.ToDouble(PromedioPorTabla.Rows[0][0].ToString());
                            SumaG += Convert.ToDouble(PromedioPorTabla.Rows[0][1].ToString());
                            SumaB += Convert.ToDouble(PromedioPorTabla.Rows[0][2].ToString());
                            columnaGrupos += 4;
                        }
                        PromedioPorTabla.Rows[0][0] = SumaR / 5;
                        PromedioPorTabla.Rows[0][1] = SumaG / 5;
                        PromedioPorTabla.Rows[0][2] = SumaB / 5;
                        DocumentoExcel.ImportDataTable(20, 5, PromedioPorTabla, true);
                        DocumentoExcel.SetCellValue(20, 1, txtNombreObjeto.Text);
                        DocumentoExcel.SaveAs(RutaArchivoExcel);
                        DocumentoExcelPerceptron.AddWorksheet(txtNombreObjeto.Text);
                        NombresObjetos.Add(txtNombreObjeto.Text);
                        DocumentoExcelPerceptron.AddWorksheet(txtNombreObjeto.Text + "a");
                        DocumentoExcelPerceptron.CopyWorksheet("Hoja1", txtNombreObjeto.Text);
                        DocumentoExcelPerceptron.SelectWorksheet(txtNombreObjeto.Text);
                        DocumentoExcelPerceptron.DeleteWorksheet(txtNombreObjeto.Text + "a");
                        int ColumnaDatosPerceptron = 11;
                        int RenglonDatosPerceptron = 1;
                        int R = 0;
                        int G = 0;
                        int B = 0;
                        DataTable TablaParaPerceptron = new DataTable();
                        TablaParaPerceptron.Columns.Add("R", typeof(double));
                        TablaParaPerceptron.Columns.Add("G", typeof(double));
                        TablaParaPerceptron.Columns.Add("B", typeof(double));
                        foreach (DataTable tabla in TablasDeDatos)
                        {
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                R = Convert.ToInt32(tabla.Rows[i][0].ToString());
                                G = Convert.ToInt32(tabla.Rows[i][1].ToString());
                                B = Convert.ToInt32(tabla.Rows[i][2].ToString());
                                TablaParaPerceptron.Rows.Add(R, G, B);
                            }
                        }
                        DocumentoExcelPerceptron.ImportDataTable(RenglonDatosPerceptron, ColumnaDatosPerceptron, TablaParaPerceptron, true);
                        Perceptron PerceptronNuevo = new Perceptron(DocumentoExcelPerceptron, txtNombreObjeto.Text);
                        Perceptrones.Add(PerceptronNuevo);
                        DocumentoExcelPerceptron.SaveAs(RutaArchivoExcelPerceptron);
                    }
                    else
                    {
                        int renglonGrupos = 1;
                        int columnaGrupos = 1;
                        //Se crea el acceso al documento excel de donde sacaremos y guardaremos los datos
                        string RutaArchivoExcel = AppDomain.CurrentDomain.BaseDirectory + "Excel" + txtNombreObjeto.Text + ".xlsx";
                        SLDocument DocumentoExcel = new SLDocument();
                        DataTable PromedioPorTabla = new DataTable();

                        double SumaR = 0;
                        double SumaG = 0;
                        double SumaB = 0;

                        foreach (DataTable Tabla in TablasDeDatos)
                        {
                            PromedioPorTabla = CalcularPromedioTabla(Tabla);
                            DocumentoExcel.ImportDataTable(14, columnaGrupos, PromedioPorTabla, true);
                            DocumentoExcel.ImportDataTable(renglonGrupos, columnaGrupos, Tabla, true);
                            SumaR += Convert.ToDouble(PromedioPorTabla.Rows[0][0].ToString());
                            SumaG += Convert.ToDouble(PromedioPorTabla.Rows[0][1].ToString());
                            SumaB += Convert.ToDouble(PromedioPorTabla.Rows[0][2].ToString());
                            columnaGrupos += 4;
                        }
                        PromedioPorTabla.Rows[0][0] = SumaR / 5;
                        PromedioPorTabla.Rows[0][1] = SumaG / 5;
                        PromedioPorTabla.Rows[0][2] = SumaB / 5;
                        DocumentoExcel.ImportDataTable(20, 5, PromedioPorTabla, true);
                        DocumentoExcel.SetCellValue(20, 1, txtNombreObjeto.Text);
                        DocumentoExcel.SaveAs(RutaArchivoExcel);
                        DocumentoExcelPerceptron.AddWorksheet(txtNombreObjeto.Text);
                        NombresObjetos.Add(txtNombreObjeto.Text);
                        DocumentoExcelPerceptron.AddWorksheet(txtNombreObjeto.Text + "a");
                        DocumentoExcelPerceptron.CopyWorksheet("Hoja1", txtNombreObjeto.Text);
                        DocumentoExcelPerceptron.SelectWorksheet(txtNombreObjeto.Text);
                        DocumentoExcelPerceptron.DeleteWorksheet(txtNombreObjeto.Text + "a");
                        int ColumnaDatosPerceptron = 11;
                        int RenglonDatosPerceptron = 1;
                        int R = 0;
                        int G = 0;
                        int B = 0;
                        DataTable TablaParaPerceptron = new DataTable();
                        TablaParaPerceptron.Columns.Add("R", typeof(double));
                        TablaParaPerceptron.Columns.Add("G", typeof(double));
                        TablaParaPerceptron.Columns.Add("B", typeof(double));
                        foreach (DataTable tabla in TablasDeDatos)
                        {
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                R = Convert.ToInt32(tabla.Rows[i][0].ToString());
                                G = Convert.ToInt32(tabla.Rows[i][1].ToString());
                                B = Convert.ToInt32(tabla.Rows[i][2].ToString());
                                TablaParaPerceptron.Rows.Add(R, G, B);
                            }
                        }
                        DocumentoExcelPerceptron.ImportDataTable(RenglonDatosPerceptron, ColumnaDatosPerceptron, TablaParaPerceptron, true);
                        Perceptron PerceptronNuevo = new Perceptron(DocumentoExcelPerceptron, txtNombreObjeto.Text);
                        Perceptrones.Add(PerceptronNuevo);
                        DocumentoExcelPerceptron.SaveAs(RutaArchivoExcelPerceptron);
                    }
                }
            }
        }

        /// inicio metodos para La red neuronal
        /// 
        public class Perceptron
        {
            public Red red;
            public Perceptron(SLDocument DocumentoExcel, string NombreCompuerta)
            {
                red = new Red(DocumentoExcel, NombreCompuerta);
            }
        }
        public class Red
        {
            public Neurona neurona;
            public Red(SLDocument DocumentoExcel, string NombreCompuerta)
            {
                neurona = new Neurona(DocumentoExcel, NombreCompuerta);
            }
        }
        public class Neurona
        {
            public double[] Entradas_X;

            public double[] Pesos_Sinapticos_W;

            public int Salida_Y;
            public int Valor_Esperado_D;
            public double Coeficiente_De_Aprendisaje_n;
            public double Umbral_Theta;
            public Compuerta compuerta;
            public Funciones funciones;
            public Neurona(SLDocument DocumentoExcel, string NombreCompuerta)
            {
                Entradas_X = new double[3];
                Pesos_Sinapticos_W = new double[3];
                Pesos_Sinapticos_W[0] = DocumentoExcel.GetCellValueAsDouble(6, 6);
                Pesos_Sinapticos_W[1] = DocumentoExcel.GetCellValueAsDouble(8, 6);
                Pesos_Sinapticos_W[2] = DocumentoExcel.GetCellValueAsDouble(10, 6);
                Salida_Y = 0;
                Valor_Esperado_D = 0;
                Coeficiente_De_Aprendisaje_n = DocumentoExcel.GetCellValueAsDouble(9, 10);
                Umbral_Theta = DocumentoExcel.GetCellValueAsDouble(12, 10);
                compuerta = new Compuerta(NombreCompuerta, DocumentoExcel);
                funciones = new Funciones();
            }
            public bool Propagacion()
            {

                Salida_Y = funciones.FuncionTransferencia(Pesos_Sinapticos_W[0], Pesos_Sinapticos_W[1], Pesos_Sinapticos_W[2], Entradas_X[0], Entradas_X[1], Entradas_X[2], Umbral_Theta);
                double DelthaError = funciones.Error(Salida_Y, Valor_Esperado_D);
                double DelthaPeso_w1 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[0], DelthaError);
                double DelthaPeso_w2 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[1], DelthaError);
                double DelthaPeso_w3 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[2], DelthaError);
                if (Salida_Y != Valor_Esperado_D)
                {
                    Pesos_Sinapticos_W[0] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[0], DelthaPeso_w1);
                    Pesos_Sinapticos_W[1] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[1], DelthaPeso_w2);
                    Pesos_Sinapticos_W[2] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[2], DelthaPeso_w3);
                    Umbral_Theta = funciones.ModificacionDelUmbral(Umbral_Theta, Coeficiente_De_Aprendisaje_n, DelthaError);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public bool PropagacionPrueba()
            {

                Salida_Y = funciones.FuncionTransferencia(Pesos_Sinapticos_W[0], Pesos_Sinapticos_W[1], Pesos_Sinapticos_W[2], Entradas_X[0], Entradas_X[1], Entradas_X[2], Umbral_Theta);
      
                if (Salida_Y == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Compuerta
        {
            public string NombreCompuerta;
            public DataTable PatronDeEntrenamiento = new DataTable();
            public Compuerta(string Compuerta, SLDocument DocumentoExcel)
            {
                NombreCompuerta = Compuerta;
                ObtenerPatronDeEntrenamiento(PatronDeEntrenamiento, DocumentoExcel);
            }
        }
        public class Funciones
        {
            public Funciones()
            {

            }
            public int FuncionTransferencia(double w1, double w2, double w3, double x1, double x2, double x3, double theta)
            {
                double resultado = w1 * x1 + w2 * x2 + w3 * x3 - theta;
                if (resultado < 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            public double Error(double Y, double D)
            {
                double DelthaError = D - Y;
                return DelthaError;
            }
            public double VariacionDelPesoSinaptico_DeltaPeso(double n, double x, double DelthaError)
            {
                double DelthaPeso = n * x * DelthaError;
                return DelthaPeso;
            }
            public double ModificacionDelPesoSinaptico(double w, double Delthapeso)
            {
                double wNueva = w + Delthapeso;
                return wNueva;
            }
            public double ModificacionDelUmbral(double theta, double n, double DelthaError)
            {
                double thetaNueva = theta - n * DelthaError;
                return thetaNueva;
            }

        }
        public static void ObtenerPatronDeEntrenamiento(DataTable PatronDeEntrenamiento, SLDocument DocumentoExcel)
        {
            int renglon = 2;
            int columnaEntrada1 = 11;
            int columnaEntrada2 = 12;
            int columnaEntrada3 = 13;
            int columnaSalida = 16;
            double R = 0;
            double G = 0;
            double B = 0;
            double D = 0;

            PatronDeEntrenamiento.Columns.Add("R", typeof(double));
            PatronDeEntrenamiento.Columns.Add("G", typeof(double));
            PatronDeEntrenamiento.Columns.Add("B", typeof(double));
            PatronDeEntrenamiento.Columns.Add("D", typeof(double));
            while (!string.IsNullOrEmpty(DocumentoExcel.GetCellValueAsString(renglon, columnaEntrada1)))
            {
                R = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada1);
                G = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada2);
                B = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada3);
                D = DocumentoExcel.GetCellValueAsDouble(renglon, columnaSalida);
                PatronDeEntrenamiento.Rows.Add(R, G, B, D);
                renglon++;
            }
        }
        public static void EntrenarPerceptron(Perceptron perceptron)
        {
            int ColumnaEntrada_x1 = 0;
            int ColumnaEntrada_x2 = 1;
            int ColumnaEntrada_x3 = 2;
            int ColumnaValorEsperado_D = 3;
            int CuentaParaSalir = 0;

            bool Calibrada = false;
            while (Calibrada == false)
            {
                foreach (DataRow renglonDeDatos in perceptron.red.neurona.compuerta.PatronDeEntrenamiento.Rows)
                {
                    perceptron.red.neurona.Entradas_X[0] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x1]);
                    perceptron.red.neurona.Entradas_X[1] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x2]);
                    perceptron.red.neurona.Entradas_X[2] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x3]);
                    perceptron.red.neurona.Valor_Esperado_D = Convert.ToInt32(renglonDeDatos[ColumnaValorEsperado_D]);
                    if (perceptron.red.neurona.Propagacion() == true)
                    {
                        CuentaParaSalir++;
                    }
                }
                if (CuentaParaSalir == 100)
                {
                    Calibrada = true;
                }
                else
                {
                    CuentaParaSalir = 0;
                }
            }
        }
        public static void GuardarArchivoExcel(Perceptron perceptron, string RutaArchivoExcel, SLDocument DocumentoExcel)
        {
            DataTable DatosPerceptronEntrenado = new DataTable();
            DatosPerceptronEntrenado.Columns.Add("Datos Correctos", typeof(double));
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[0]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[1]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[2]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Coeficiente_De_Aprendisaje_n);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Umbral_Theta);
            DocumentoExcel.ImportDataTable(20, 8, DatosPerceptronEntrenado, true);
            DocumentoExcel.SaveAs(RutaArchivoExcel);
        }

        private void btnNuevoPunto_Click(object sender, EventArgs e)
        {
            if (Perceptrones.Count == 0)
            {
                txtR.Text = "No hay objetos registrador";
            }
            //for (int i = 0; i < TablasDeDatos[0].Rows.Count; i++)
            //{
            //    int R = Convert.ToInt32(TablasDeDatos[0].Rows[i][0].ToString());
            //    int G = Convert.ToInt32(TablasDeDatos[0].Rows[i][0].ToString());
            //    int B = Convert.ToInt32(TablasDeDatos[0].Rows[i][0].ToString());
            //    perceptron.red.neurona.Entradas_X[0] = R;
            //    perceptron.red.neurona.Entradas_X[1] = G;
            //    perceptron.red.neurona.Entradas_X[2] = B;
            //    int contador = 0;
            //    double porcentaje = 0;
            //    if (true == perceptron.red.neurona.Propagacion())
            //    {
            //        //contador++;
            //        txtR.Text += "La neurona " + perceptron.red.neurona.compuerta.NombreCompuerta + " dio positivo \r\n";
            //    }
            //    else
            //    {
            //        txtR.Text += "La neurona " + perceptron.red.neurona.compuerta.NombreCompuerta + " dio negativo\r\n";
            //    }
            //}
            else
            {
                DataTable Resultado = new DataTable();
                for (int i = 0; i < Perceptrones.Count; i++)
                {
                    Resultado.Columns.Add("neurona" + NombresObjetos[i], typeof(double));
                }
                Resultado.Columns.Add("Salida", typeof(String));
                Resultado.Rows.Add();
                int cone = 0;
                int contador = 0;
                foreach (Perceptron PER in Perceptrones)
                {
                    int R = 0;
                    int G = 0;
                    int B = 0;
                    for (int i = 0; i < TablasDeDatos[0].Rows.Count; i++)
                    {
                        R += Convert.ToInt32(TablasDeDatos[0].Rows[i][0].ToString());
                        G += Convert.ToInt32(TablasDeDatos[0].Rows[i][1].ToString());
                        B += Convert.ToInt32(TablasDeDatos[0].Rows[i][2].ToString());
                    }

                    PER.red.neurona.Entradas_X[0] = R/ Convert.ToDouble(TablasDeDatos[0].Rows.Count);
                    PER.red.neurona.Entradas_X[1] = G/ Convert.ToDouble(TablasDeDatos[0].Rows.Count);
                    PER.red.neurona.Entradas_X[2] = B/ Convert.ToDouble(TablasDeDatos[0].Rows.Count);

                    if (true == PER.red.neurona.PropagacionPrueba())
                    {
                        Resultado.Rows[0][cone] = 1;
                    }
                    else
                    {
                        Resultado.Rows[0][cone] = 0;
                    }
                    cone++;
                }
                //hasta aqui se Arma el renglon del resultado de evaluar todas las neuronas con el punto muestral
                //Se procede a  buscar el resultado en la tablaLogica e poner en la tabla resultado la salida del mismo
                for(int Renglon = 0; Renglon < TablaLogica.Rows.Count; Renglon++)
                {
                    for(int columna = 0; columna < TablaLogica.Columns.Count-1; columna++)
                    {
                        if(Convert.ToDouble(TablaLogica.Rows[Renglon][columna].ToString())== Convert.ToDouble(Resultado.Rows[0][columna].ToString()))
                        {
                            contador=contador +1;
                            if (contador-1 == TablaLogica.Columns.Count - 2)
                            {
                                Resultado.Rows[0][TablaLogica.Columns.Count - 1] = TablaLogica.Rows[Renglon][TablaLogica.Columns.Count - 1];
                                txtR.Text = Resultado.Rows[0][TablaLogica.Columns.Count - 1].ToString();
                            }
                        }
                    }
                    contador = 0;
                }
                
            }
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (Perceptrones.Count == 0)
            {
                txtR.Text = "no se pueden Entrenar neuronas ya que no hay neuronas hechas";
                //if (DocumentoExcelPerceptron.DocumentProperties == null)
                //{
                //    string RutaArchivoExcelPerceptron = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\ClasificadorColoresPorNeuronas\bin\Debug\entrenamientoPerceptron.xlsx";
                //    SLDocument DocumentoExcelPerceptron = new SLDocument(RutaArchivoExcelPerceptron, "Hoja1");
                //}
                //else
                //{
                //    //aqui se programa la neurona
                //    EntrenarPerceptron(perceptron);
                //    GuardarArchivoExcel(perceptron, RutaArchivoExcelPerceptron, DocumentoExcelPerceptron);
                //    //DocumentoCopiado.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Neurona1");
                //    //DocumentoCopiado.AddWorksheet("Neurona3");
                //    //DocumentoCopiado.CopyWorksheet("Neurona1", "Neurona2");
                //    //DocumentoCopiado.SaveAs(RutaArchivoExcelGruposcopiado);
                //    //DocumentoCopiado.CopyWorksheet("hoja1",);
                //}
            }
            else
            {
                
                foreach (Perceptron percep in Perceptrones)
                {
                    SLDocument DocumentoExcelPerceptron = new SLDocument(RutaArchivoExcelPerceptron, percep.red.neurona.compuerta.NombreCompuerta);
                    EntrenarPerceptron(percep);
                    GuardarArchivoExcel(percep, RutaArchivoExcelPerceptron, DocumentoExcelPerceptron);
                }
               TablaLogica=FormulacionTablaLogica();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (TablasDeDatos[0] == null)
            {
                txtRecibidos.Text = "Los datos ya estan limpios";
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    TablasDeDatos[i].Clear();
                }
                txtRecaudarDatos1.Text = "Limpio";
                txtRecaudarDatos2.Text = "Limpio";
                txtRecaudarDatos3.Text = "Limpio";
                txtRecaudarDatos4.Text = "Limpio";
                txtRecaudarDatos5.Text = "Limpio";
                txtNombreObjeto.Text = "Limpio";
            }
        }

        public DataTable FormulacionTablaLogica()
        {
            double R = 0;
            double G = 0;
            double B = 0;
            DataTable tablaDeLaVerdad = new DataTable();
            for(int i = 0; i < Perceptrones.Count; i++)
            {
                tablaDeLaVerdad.Columns.Add("neurona"+NombresObjetos[i], typeof(double));
            }
            tablaDeLaVerdad.Columns.Add("Salida", typeof(String));
            for (int i = 0; i < NombresObjetos.Count; i++)
            {
                tablaDeLaVerdad.Rows.Add();
                string RutaArchivoExcel = AppDomain.CurrentDomain.BaseDirectory + "Excel" + NombresObjetos[i] + ".xlsx";
                SLDocument DocumentoExcel = new SLDocument(RutaArchivoExcel,"Sheet1");
                R = DocumentoExcel.GetCellValueAsDouble(21, 5);
                G = DocumentoExcel.GetCellValueAsDouble(21, 6);
                B = DocumentoExcel.GetCellValueAsDouble(21, 7);
                int e = 0;
                foreach (Perceptron percep in Perceptrones)
                {
                    percep.red.neurona.Entradas_X[0] = R;
                    percep.red.neurona.Entradas_X[1] = G;
                    percep.red.neurona.Entradas_X[2] = B;
                    if (true == percep.red.neurona.PropagacionPrueba())
                    {
                        tablaDeLaVerdad.Rows[i][e] = 1;
                    }
                    else
                    {
                        tablaDeLaVerdad.Rows[i][e] = 0;
                    }
                    
                    e++;
                    
                }
                tablaDeLaVerdad.Rows[i][e] = NombresObjetos[i];

            }



            return tablaDeLaVerdad; 
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
            TablaParaPromediar.Columns.Add("R", typeof(double));
            TablaParaPromediar.Columns.Add("G", typeof(double));
            TablaParaPromediar.Columns.Add("B", typeof(double));
            TablaParaPromediar.Rows.Add(PromedioR, PromedioG, PromedioB);
            return TablaParaPromediar;
        }
        
       
    }
}
