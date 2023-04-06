using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exodo;
using SpreadsheetLight;
using System.IO;

namespace NeuronaArtificialMonocapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public class Perceptron
        {
            public Red red;
            public Perceptron(SLDocument DocumentoExcel,string NombreCompuerta)
            {
                red = new Red(DocumentoExcel, NombreCompuerta);
            }
        }
        public class Red
        {
            public Neurona neurona;
            public Red(SLDocument DocumentoExcel,string NombreCompuerta)
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
            public Neurona(SLDocument DocumentoExcel,string NombreCompuerta)
            {
                Entradas_X = new double[1];
                Pesos_Sinapticos_W = new double[1];
                Pesos_Sinapticos_W[0] = DocumentoExcel.GetCellValueAsDouble(6, 6);
                //Pesos_Sinapticos_W[1] = DocumentoExcel.GetCellValueAsDouble(8, 6);
                Salida_Y = 0;
                Valor_Esperado_D = 0;
                Coeficiente_De_Aprendisaje_n = DocumentoExcel.GetCellValueAsDouble(9, 10); 
                Umbral_Theta = DocumentoExcel.GetCellValueAsDouble(12, 10);
                compuerta = new Compuerta(NombreCompuerta, DocumentoExcel);
                funciones = new Funciones();
            }
            public bool Propagacion()
            {
                
                Salida_Y = funciones.FuncionTransferencia(Pesos_Sinapticos_W[0], Entradas_X[0], Umbral_Theta);
                double DelthaError = funciones.Error(Salida_Y, Valor_Esperado_D);
                double DelthaPeso_w1 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n,Entradas_X[0],DelthaError);
                //double DelthaPeso_w2 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[1], DelthaError);
                if (Salida_Y != Valor_Esperado_D)
                {
                    Pesos_Sinapticos_W[0] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[0], DelthaPeso_w1);
                    //Pesos_Sinapticos_W[1] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[1], DelthaPeso_w2);
                    Umbral_Theta = funciones.ModificacionDelUmbral(Umbral_Theta, Coeficiente_De_Aprendisaje_n, DelthaError);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        
        public class Compuerta
        {
            public string NombreCompuerta;
            public DataTable PatronDeEntrenamiento = new DataTable();
            public Compuerta(string Compuerta,SLDocument DocumentoExcel)
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
            public int FuncionTransferencia(double w1,  double x1, double theta)
            {
                double resultado = w1 * x1  - theta;
                if (resultado < 0)
                {
                    return 0;
                }
                else
                {
                    return  1;
                }
            }
            
            public double Error(double Y, double D)
            {
                double DelthaError = D - Y;
                return DelthaError;
            }
            public double VariacionDelPesoSinaptico_DeltaPeso(double n,double x,double DelthaError)
            {
                double DelthaPeso = n * x * DelthaError;
                return DelthaPeso;
            }
            public double ModificacionDelPesoSinaptico(double w, double Delthapeso)
            {
                double wNueva = w + Delthapeso;
                return wNueva;
            }
            public double ModificacionDelUmbral(double theta,double n, double DelthaError)
            {
                double thetaNueva = theta - n * DelthaError;
                return thetaNueva;
            }

        }
        public static void ObtenerPatronDeEntrenamiento(DataTable PatronDeEntrenamiento,SLDocument DocumentoExcel)
        {
            int renglon = 2;
            int columnaEntrada1 = 12;
            //int columnaEntrada2 = 13;
            int columnaSalida = 16;
            double x1 = 0;
            //double x2 = 0;
            double D = 0;
            
            PatronDeEntrenamiento.Columns.Add("x1", typeof(double));
            //PatronDeEntrenamiento.Columns.Add("x2", typeof(double));
            PatronDeEntrenamiento.Columns.Add("D", typeof(double));
            while (!string.IsNullOrEmpty(DocumentoExcel.GetCellValueAsString(renglon, columnaEntrada1)))
            {
                x1 = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada1);
                //x2 = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada2);
                D = DocumentoExcel.GetCellValueAsDouble(renglon, columnaSalida);
                PatronDeEntrenamiento.Rows.Add(x1, D);
                renglon++;
            }
        }
        public static void EntrenarPerceptron(Perceptron perceptron)
        {
            int ColumnaEntrada_x1 = 0;
            //int ColumnaEntrada_x2 = 1;
            int ColumnaValorEsperado_D = 1;
            int CuentaParaSalir = 0;
            
            bool Calibrada = false;
            while (Calibrada == false) 
            {
                foreach(DataRow renglonDeDatos in perceptron.red.neurona.compuerta.PatronDeEntrenamiento.Rows)
                {
                    perceptron.red.neurona.Entradas_X[0] = Convert.ToInt32(renglonDeDatos[ColumnaEntrada_x1]);
                    //perceptron.red.neurona.Entradas_X[1] = Convert.ToInt32(renglonDeDatos[ColumnaEntrada_x2]);
                    perceptron.red.neurona.Valor_Esperado_D = Convert.ToInt32(renglonDeDatos[ColumnaValorEsperado_D]);
                    if (perceptron.red.neurona.Propagacion() == true)
                    {
                        CuentaParaSalir++;
                    }
                }
                if (CuentaParaSalir == 200)
                {
                    Calibrada = true;
                }
                else
                {
                    CuentaParaSalir = 0;
                }
            }
        }
        public static void GuardarArchivoExcel(Perceptron perceptron,string RutaArchivoExcel,SLDocument DocumentoExcel)
        {
            DataTable DatosPerceptronEntrenado = new DataTable();
            DatosPerceptronEntrenado.Columns.Add("Datos Correctos", typeof(double));
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[0]);
            //DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[1]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Coeficiente_De_Aprendisaje_n);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Umbral_Theta);
            DocumentoExcel.ImportDataTable(19, 9, DatosPerceptronEntrenado, true);
            DocumentoExcel.SaveAs(RutaArchivoExcel);
        }


        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            string RutaArchivoExcelX2vsX4 = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\NeuronaArtificialMonocapa\bin\Debug\entrenamientoPerceptron.xlsx";
            SLDocument DocumentoExcel = new SLDocument(RutaArchivoExcelX2vsX4);
            Perceptron perceptron = new Perceptron(DocumentoExcel, "x2vsx4");
            EntrenarPerceptron(perceptron);
            GuardarArchivoExcel(perceptron, RutaArchivoExcelX2vsX4, DocumentoExcel);

            // aqui se crea la otra neurona
            string RutaArchivoExcelX1vsX3 = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\NeuronaArtificialMonocapa\bin\Debug\entrenamientoPerceptron1.xlsx";
            SLDocument DocumentoExcel1 = new SLDocument(RutaArchivoExcelX1vsX3);
            Perceptron perceptron1 = new Perceptron(DocumentoExcel1, "x1vsx3");
            EntrenarPerceptron(perceptron1);
            GuardarArchivoExcel(perceptron1, RutaArchivoExcelX1vsX3, DocumentoExcel1);


        }
    }
}
