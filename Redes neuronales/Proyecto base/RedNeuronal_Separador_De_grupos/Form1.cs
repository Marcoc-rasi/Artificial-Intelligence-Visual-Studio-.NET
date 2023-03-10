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
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace RedNeuronal_Separador_De_grupos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                Entradas_X = new double[9];
                Pesos_Sinapticos_W = new double[9];
                Pesos_Sinapticos_W[0] = DocumentoExcel.GetCellValueAsDouble(11, 6);
                Pesos_Sinapticos_W[1] = DocumentoExcel.GetCellValueAsDouble(13, 6);
                Pesos_Sinapticos_W[2] = DocumentoExcel.GetCellValueAsDouble(15, 6);
                Pesos_Sinapticos_W[3] = DocumentoExcel.GetCellValueAsDouble(17, 6);
                Pesos_Sinapticos_W[4] = DocumentoExcel.GetCellValueAsDouble(19, 6);
                Pesos_Sinapticos_W[5] = DocumentoExcel.GetCellValueAsDouble(21, 6);
                Pesos_Sinapticos_W[6] = DocumentoExcel.GetCellValueAsDouble(23, 6);
                Pesos_Sinapticos_W[7] = DocumentoExcel.GetCellValueAsDouble(25, 6);
                Pesos_Sinapticos_W[8] = DocumentoExcel.GetCellValueAsDouble(27, 6);
                Salida_Y = 0;
                Valor_Esperado_D = 0;
                Coeficiente_De_Aprendisaje_n = DocumentoExcel.GetCellValueAsDouble(18, 10);
                Umbral_Theta = DocumentoExcel.GetCellValueAsDouble(21, 10);
                compuerta = new Compuerta(NombreCompuerta, DocumentoExcel);
                funciones = new Funciones();
            }
            public bool Propagacion()
            {

                Salida_Y = funciones.FuncionTransferencia(Pesos_Sinapticos_W[0], Pesos_Sinapticos_W[1],Pesos_Sinapticos_W[2],
                                                          Pesos_Sinapticos_W[3], Pesos_Sinapticos_W[4], Pesos_Sinapticos_W[5],
                                                          Pesos_Sinapticos_W[6], Pesos_Sinapticos_W[7], Pesos_Sinapticos_W[8],
                                                          Entradas_X[0], Entradas_X[1], Entradas_X[2],
                                                          Entradas_X[3], Entradas_X[4], Entradas_X[5],
                                                          Entradas_X[6], Entradas_X[7], Entradas_X[8], Umbral_Theta);
                double DelthaError = funciones.Error(Salida_Y, Valor_Esperado_D);
                double DelthaPeso_w1 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[0], DelthaError);
                double DelthaPeso_w2 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[1], DelthaError);
                double DelthaPeso_w3 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[2], DelthaError);
                double DelthaPeso_w4 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[3], DelthaError);
                double DelthaPeso_w5 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[4], DelthaError);
                double DelthaPeso_w6 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[5], DelthaError);
                double DelthaPeso_w7 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[6], DelthaError);
                double DelthaPeso_w8 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[7], DelthaError);
                double DelthaPeso_w9 = funciones.VariacionDelPesoSinaptico_DeltaPeso(Coeficiente_De_Aprendisaje_n, Entradas_X[8], DelthaError);
                if (Salida_Y != Valor_Esperado_D)
                {
                    Pesos_Sinapticos_W[0] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[0], DelthaPeso_w1);
                    Pesos_Sinapticos_W[1] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[1], DelthaPeso_w2);
                    Pesos_Sinapticos_W[2] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[2], DelthaPeso_w3);
                    Pesos_Sinapticos_W[3] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[3], DelthaPeso_w4);
                    Pesos_Sinapticos_W[4] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[4], DelthaPeso_w5);
                    Pesos_Sinapticos_W[5] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[5], DelthaPeso_w6);
                    Pesos_Sinapticos_W[6] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[6], DelthaPeso_w7);
                    Pesos_Sinapticos_W[7] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[7], DelthaPeso_w8);
                    Pesos_Sinapticos_W[8] = funciones.ModificacionDelPesoSinaptico(Pesos_Sinapticos_W[8], DelthaPeso_w9);
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
            public int FuncionTransferencia(double w1, double w2,double w3,
                                            double w4, double w5, double w6,
                                            double w7, double w8, double w9, 
                                            double x1, double x2,double x3,
                                            double x4, double x5, double x6,
                                            double x7, double x8, double x9, double theta)
            {
                double resultado = w1 * x1 + w2 * x2 + w3 * x3+ w4 * x4 + w5 * x5 + w6 * x6+ w7 * x7 + w8 * x8 + w9 * x9 - theta;
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
            int columnaEntrada4 = 14;
            int columnaEntrada5 = 15;
            int columnaEntrada6 = 16;
            int columnaEntrada7 = 17;
            int columnaEntrada8 = 18;
            int columnaEntrada9 = 19;
                                 

            int columnaSalida = 20;
            double Edad = 0;
            double peso = 0;
            double altura = 0;
            double Temperatura = 0;
            double Colesterol = 0;
            double Triglicéridos = 0;
            double TensiónArterial = 0;
            double Calcio = 0;
            double magnesio = 0;
            double D = 0;


            PatronDeEntrenamiento.Columns.Add("Edad", typeof(double));
            PatronDeEntrenamiento.Columns.Add("peso", typeof(double));
            PatronDeEntrenamiento.Columns.Add("altura", typeof(double));
            PatronDeEntrenamiento.Columns.Add("Temperatura", typeof(double));
            PatronDeEntrenamiento.Columns.Add("Colesterol", typeof(double));
            PatronDeEntrenamiento.Columns.Add("Trigliceridos", typeof(double));
            PatronDeEntrenamiento.Columns.Add("Tension Arterial", typeof(double));
            PatronDeEntrenamiento.Columns.Add("Calcio", typeof(double));
            PatronDeEntrenamiento.Columns.Add("Magnecio", typeof(double));
            PatronDeEntrenamiento.Columns.Add("D", typeof(double));
            while (!string.IsNullOrEmpty(DocumentoExcel.GetCellValueAsString(renglon, columnaEntrada1)))
            {
                Edad = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada1);
                peso = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada2);
                altura = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada3);
                Temperatura = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada4);
                Colesterol = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada5);
                Triglicéridos = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada6);
                TensiónArterial = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada7);
                Calcio = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada8);
                magnesio = DocumentoExcel.GetCellValueAsDouble(renglon, columnaEntrada9);
                D = DocumentoExcel.GetCellValueAsDouble(renglon, columnaSalida);
                PatronDeEntrenamiento.Rows.Add(Edad, peso,altura,Temperatura, Colesterol, Triglicéridos,TensiónArterial, Calcio,magnesio, D);
                renglon++;
            }
        }
        public static void EntrenarPerceptron(Perceptron perceptron,int NumeroDeIteraciones)
        {
            int ColumnaEntrada_x1 = 0;
            int ColumnaEntrada_x2 = 1;
            int ColumnaEntrada_x3 = 2;
            int ColumnaEntrada_x4 = 3;
            int ColumnaEntrada_x5 = 4;
            int ColumnaEntrada_x6 = 5;
            int ColumnaEntrada_x7 = 6;
            int ColumnaEntrada_x8 = 7;
            int ColumnaEntrada_x9 = 8;
            int ColumnaValorEsperado_D = 9;
            int CuentaParaSalir = 0;

            bool Calibrada = false;
            while (Calibrada == false)
            {
                foreach (DataRow renglonDeDatos in perceptron.red.neurona.compuerta.PatronDeEntrenamiento.Rows)
                {
                    perceptron.red.neurona.Entradas_X[0] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x1]);
                    perceptron.red.neurona.Entradas_X[1] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x2]);
                    perceptron.red.neurona.Entradas_X[2] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x3]);
                    perceptron.red.neurona.Entradas_X[3] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x4]);
                    perceptron.red.neurona.Entradas_X[4] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x5]);
                    perceptron.red.neurona.Entradas_X[5] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x6]);
                    perceptron.red.neurona.Entradas_X[6] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x7]);
                    perceptron.red.neurona.Entradas_X[7] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x8]);
                    perceptron.red.neurona.Entradas_X[8] = Convert.ToDouble(renglonDeDatos[ColumnaEntrada_x9]);
                    perceptron.red.neurona.Valor_Esperado_D = Convert.ToInt32(renglonDeDatos[ColumnaValorEsperado_D]);
                    if (perceptron.red.neurona.Propagacion() == true)
                    {
                        CuentaParaSalir++;
                    }
                }
                if (CuentaParaSalir == NumeroDeIteraciones)
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
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[3]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[4]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[5]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[6]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[7]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Pesos_Sinapticos_W[8]);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Coeficiente_De_Aprendisaje_n);
            DatosPerceptronEntrenado.Rows.Add(perceptron.red.neurona.Umbral_Theta);
            DocumentoExcel.ImportDataTable(23, 8, DatosPerceptronEntrenado, true);
            DocumentoExcel.SaveAs(RutaArchivoExcel);
        }

        
        
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
        string RutaArchivoExcelPerceptronHombres = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\RedNeuronal_Separador_De_grupos\bin\Debug\entrenamientoPerceptronHombres.xlsx";
        SLDocument DocumentoExcelPerceptronHombres = new SLDocument(RutaArchivoExcelPerceptronHombres);
        Perceptron perceptronHombres = new Perceptron(DocumentoExcelPerceptronHombres, "Hombres");

        string RutaArchivoExcelPerceptronMujeres = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\RedNeuronal_Separador_De_grupos\bin\Debug\entrenamientoPerceptronMujeres.xlsx";
        SLDocument DocumentoExcelPerceptronMujeres = new SLDocument(RutaArchivoExcelPerceptronMujeres);
        Perceptron perceptronMujeres = new Perceptron(DocumentoExcelPerceptronMujeres, "Mujeres");

            //aqui se programa la neurona
            int iteracionHombres = DocumentoExcelPerceptronHombres.GetCellValueAsInt32(23,1);
            EntrenarPerceptron(perceptronHombres, iteracionHombres);
            GuardarArchivoExcel(perceptronHombres, RutaArchivoExcelPerceptronHombres, DocumentoExcelPerceptronHombres);

            int iteracionMujeres = DocumentoExcelPerceptronMujeres.GetCellValueAsInt32(23, 1);
            EntrenarPerceptron(perceptronMujeres, iteracionMujeres);
            GuardarArchivoExcel(perceptronMujeres, RutaArchivoExcelPerceptronMujeres, DocumentoExcelPerceptronMujeres);

            //DocumentoCopiado.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Neurona1");
            //DocumentoCopiado.AddWorksheet("Neurona3");
            //DocumentoCopiado.CopyWorksheet("Neurona1", "Neurona2");
            //DocumentoCopiado.SaveAs(RutaArchivoExcelGruposcopiado);
            //DocumentoCopiado.CopyWorksheet("hoja1",);


        }

        private void btnNuevoPunto_Click(object sender, EventArgs e)
        {
            string RutaArchivoExcelPerceptron = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\RedNeuronal_Separador_De_grupos\bin\Debug\entrenamientoPerceptronHombres.xlsx";
            SLDocument DocumentoExcelPerceptron = new SLDocument(RutaArchivoExcelPerceptron);
            Perceptron perceptron = new Perceptron(DocumentoExcelPerceptron, "Hombres");

            double Edad = Convert.ToDouble(txtEdad.Text);
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double Temperatura = Convert.ToDouble(txtTemperatura.Text);
            double Colesterol = Convert.ToDouble(txtColesterol.Text);
            double Triglicéridos = Convert.ToDouble(txtTrigliceridos.Text);
            double TensiónArterial = Convert.ToDouble(txtTensionArterial.Text);
            double Calcio = Convert.ToDouble(txtCalcio.Text);
            double magnesio = Convert.ToDouble(txMagnecio.Text);

            perceptron.red.neurona.Entradas_X[0] = Convert.ToDouble(Edad);
            perceptron.red.neurona.Entradas_X[1] = Convert.ToDouble(peso);
            perceptron.red.neurona.Entradas_X[2] = Convert.ToDouble(altura);
            perceptron.red.neurona.Entradas_X[3] = Convert.ToDouble(Temperatura);
            perceptron.red.neurona.Entradas_X[4] = Convert.ToDouble(Colesterol);
            perceptron.red.neurona.Entradas_X[5] = Convert.ToDouble(Triglicéridos);
            perceptron.red.neurona.Entradas_X[6] = Convert.ToDouble(TensiónArterial);
            perceptron.red.neurona.Entradas_X[7] = Convert.ToDouble(Calcio);
            perceptron.red.neurona.Entradas_X[8] = Convert.ToDouble(magnesio);

            if (true== perceptron.red.neurona.Propagacion())
            {
                txtResultado.Text = "Es un Hombre Enfermo";
            }
            else
            {
                txtResultado.Text = "No es Un Hombre Enfermo";
            }

        }

        private void btnAcomodarDatos_Click(object sender, EventArgs e)
        {
        string RutaArchivoExcelExamenIA = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\RedNeuronal_Separador_De_grupos\bin\Debug\examenIA.xlsx";

        SLDocument DocumentoExcelExamenMujeresSaludables = new SLDocument(RutaArchivoExcelExamenIA, "Mujeres Saludables");
        SLDocument DocumentoExcelExamenMujeresEnfermas = new SLDocument(RutaArchivoExcelExamenIA, "Muejres enfermas");
        SLDocument DocumentoExcelExamenHombresSaludables = new SLDocument(RutaArchivoExcelExamenIA, "Hombres saludables");
        SLDocument DocumentoExcelExamenHombresEnfermos = new SLDocument(RutaArchivoExcelExamenIA, "Hombres enfermos");
        int renglonInicialhombres = 4;
        int ColumnaInicialHombres = 1;
        

        int renglonInicialMujeres = 4;
        int ColumnaInicialMujeres = 2;
        
            DataTable[] TablasHombres = RellenarArregloHombres(DocumentoExcelExamenHombresSaludables, DocumentoExcelExamenHombresEnfermos, renglonInicialhombres, ColumnaInicialHombres);
            DataTable[] TablasMujeres = RellenarArregloMujeres(DocumentoExcelExamenMujeresSaludables, DocumentoExcelExamenMujeresEnfermas, renglonInicialMujeres, ColumnaInicialMujeres);
            string RutaArchivoExcelPerceptronHombres = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\RedNeuronal_Separador_De_grupos\bin\Debug\entrenamientoPerceptronHombres.xlsx";
            SLDocument DocumentoExcelPerceptronHombres = new SLDocument(RutaArchivoExcelPerceptronHombres);
            string RutaArchivoExcelPerceptronMujeres = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\RedNeuronal_Separador_De_grupos\bin\Debug\entrenamientoPerceptronMujeres.xlsx";
            SLDocument DocumentoExcelPerceptronMujeres = new SLDocument(RutaArchivoExcelPerceptronMujeres);
            int Posicion = TablasHombres[0].Rows.Count;
            DocumentoExcelPerceptronHombres.ImportDataTable(Posicion+1, 11, TablasHombres[1], true);
            DocumentoExcelPerceptronHombres.ImportDataTable(1, 11, TablasHombres[0], true);
            Posicion = TablasMujeres[0].Rows.Count;
            DocumentoExcelPerceptronMujeres.ImportDataTable(Posicion + 1, 11, TablasMujeres[1], true);
            DocumentoExcelPerceptronMujeres.ImportDataTable(1, 11, TablasMujeres[0], true);
            DocumentoExcelPerceptronHombres.SaveAs(RutaArchivoExcelPerceptronHombres);
            DocumentoExcelPerceptronMujeres.SaveAs(RutaArchivoExcelPerceptronMujeres);


        }

        private void btnCompararMujeres_Click(object sender, EventArgs e)
        {
            string RutaArchivoExcelPerceptron = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\RedNeuronal_Separador_De_grupos\bin\Debug\entrenamientoPerceptronMujeres.xlsx";
            SLDocument DocumentoExcelPerceptron = new SLDocument(RutaArchivoExcelPerceptron);
            Perceptron perceptron = new Perceptron(DocumentoExcelPerceptron, "Mujeres");

            double Edad = Convert.ToDouble(txtEdad.Text);
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double Temperatura = Convert.ToDouble(txtTemperatura.Text);
            double Colesterol = Convert.ToDouble(txtColesterol.Text);
            double Triglicéridos = Convert.ToDouble(txtTrigliceridos.Text);
            double TensiónArterial = Convert.ToDouble(txtTensionArterial.Text);
            double Calcio = Convert.ToDouble(txtCalcio.Text);
            double magnesio = Convert.ToDouble(txMagnecio.Text);

            perceptron.red.neurona.Entradas_X[0] = Convert.ToDouble(Edad);
            perceptron.red.neurona.Entradas_X[1] = Convert.ToDouble(peso);
            perceptron.red.neurona.Entradas_X[2] = Convert.ToDouble(altura);
            perceptron.red.neurona.Entradas_X[3] = Convert.ToDouble(Temperatura);
            perceptron.red.neurona.Entradas_X[4] = Convert.ToDouble(Colesterol);
            perceptron.red.neurona.Entradas_X[5] = Convert.ToDouble(Triglicéridos);
            perceptron.red.neurona.Entradas_X[6] = Convert.ToDouble(TensiónArterial);
            perceptron.red.neurona.Entradas_X[7] = Convert.ToDouble(Calcio);
            perceptron.red.neurona.Entradas_X[8] = Convert.ToDouble(magnesio);

            if (true == perceptron.red.neurona.Propagacion())
            {
                txtResultado.Text = "Es un Hombre Enfermo";
            }
            else
            {
                txtResultado.Text = "No es Un Hombre Enfermo";
            }
        }
        public static DataTable[] RellenarArregloMujeres(SLDocument DocumentoExcelExamenMujeresSaludables, SLDocument DocumentoExcelExamenMujeresEnfermas, int renglonInicialMujeres, int ColumnaInicialMujeres)
        {
            DataTable TablaSaludables = new DataTable();



            TablaSaludables.Columns.Add("Edad", typeof(double));
            TablaSaludables.Columns.Add("peso", typeof(double));
            TablaSaludables.Columns.Add("altura", typeof(double));
            TablaSaludables.Columns.Add("Temperatura", typeof(double));
            TablaSaludables.Columns.Add("Colesterol", typeof(double));
            TablaSaludables.Columns.Add("Trigliceridos", typeof(double));
            TablaSaludables.Columns.Add("Tension Arterial", typeof(double));
            TablaSaludables.Columns.Add("Calcio", typeof(double));
            TablaSaludables.Columns.Add("Magnecio", typeof(double));
            TablaSaludables.Columns.Add("D", typeof(double));
            while (!string.IsNullOrEmpty(DocumentoExcelExamenMujeresSaludables.GetCellValueAsString(renglonInicialMujeres, ColumnaInicialMujeres)))
            {
                TablaSaludables.Rows.Add();
                for (int i = 0; i < 9; i++)
                {

                    TablaSaludables.Rows[renglonInicialMujeres - 4][i] = DocumentoExcelExamenMujeresSaludables.GetCellValueAsDouble(renglonInicialMujeres, ColumnaInicialMujeres + i);
                }
                TablaSaludables.Rows[renglonInicialMujeres - 4][9] = 1;
                renglonInicialMujeres++;
            }
            renglonInicialMujeres = 4;

            DataTable TablaEnfermos = new DataTable();



            TablaEnfermos.Columns.Add("Edad", typeof(double));
            TablaEnfermos.Columns.Add("peso", typeof(double));
            TablaEnfermos.Columns.Add("altura", typeof(double));
            TablaEnfermos.Columns.Add("Temperatura", typeof(double));
            TablaEnfermos.Columns.Add("Colesterol", typeof(double));
            TablaEnfermos.Columns.Add("Trigliceridos", typeof(double));
            TablaEnfermos.Columns.Add("Tension Arterial", typeof(double));
            TablaEnfermos.Columns.Add("Calcio", typeof(double));
            TablaEnfermos.Columns.Add("Magnecio", typeof(double));
            TablaEnfermos.Columns.Add("D", typeof(double));
            while (!string.IsNullOrEmpty(DocumentoExcelExamenMujeresEnfermas.GetCellValueAsString(renglonInicialMujeres, ColumnaInicialMujeres)))
            {
                TablaEnfermos.Rows.Add();
                for (int i = 0; i < 9; i++)
                {
                    TablaEnfermos.Rows[renglonInicialMujeres - 4][i] = DocumentoExcelExamenMujeresEnfermas.GetCellValueAsDouble(renglonInicialMujeres, ColumnaInicialMujeres + i);
                }

                TablaEnfermos.Rows[renglonInicialMujeres - 4][9] = 0;

                renglonInicialMujeres++;
            }
            renglonInicialMujeres = 4;
            DataTable[] Tablas = new DataTable[2];
            Tablas[0] = new DataTable();
            Tablas[1] = new DataTable();
            Tablas[0] = TablaEnfermos;
            Tablas[1] = TablaSaludables;
            return Tablas;
        }

        public static DataTable[] RellenarArregloHombres(SLDocument DocumentoExcelExamenHombresSaludables,SLDocument DocumentoExcelExamenHombresEnfermos,int renglonInicialhombres, int ColumnaInicialHombres)
        {
            DataTable TablaSaludables = new DataTable();
            


            TablaSaludables.Columns.Add("Edad", typeof(double));
            TablaSaludables.Columns.Add("peso", typeof(double));
            TablaSaludables.Columns.Add("altura", typeof(double));
            TablaSaludables.Columns.Add("Temperatura", typeof(double));
            TablaSaludables.Columns.Add("Colesterol", typeof(double));
            TablaSaludables.Columns.Add("Trigliceridos", typeof(double));
            TablaSaludables.Columns.Add("Tension Arterial", typeof(double));
            TablaSaludables.Columns.Add("Calcio", typeof(double));
            TablaSaludables.Columns.Add("Magnecio", typeof(double));
            TablaSaludables.Columns.Add("D", typeof(double));
            while (!string.IsNullOrEmpty(DocumentoExcelExamenHombresSaludables.GetCellValueAsString(renglonInicialhombres, ColumnaInicialHombres)))
            {
                TablaSaludables.Rows.Add();
                for (int i = 0; i < 9; i++)
                {

                   TablaSaludables.Rows[renglonInicialhombres-4][i] = DocumentoExcelExamenHombresSaludables.GetCellValueAsDouble(renglonInicialhombres, ColumnaInicialHombres + i);
                }
                TablaSaludables.Rows[renglonInicialhombres - 4][9] = 1;
                renglonInicialhombres++;
            }
            renglonInicialhombres = 4;

            DataTable TablaEnfermos = new DataTable();



            TablaEnfermos.Columns.Add("Edad", typeof(double));
            TablaEnfermos.Columns.Add("peso", typeof(double));
            TablaEnfermos.Columns.Add("altura", typeof(double));
            TablaEnfermos.Columns.Add("Temperatura", typeof(double));
            TablaEnfermos.Columns.Add("Colesterol", typeof(double));
            TablaEnfermos.Columns.Add("Trigliceridos", typeof(double));
            TablaEnfermos.Columns.Add("Tension Arterial", typeof(double));
            TablaEnfermos.Columns.Add("Calcio", typeof(double));
            TablaEnfermos.Columns.Add("Magnecio", typeof(double));
            TablaEnfermos.Columns.Add("D", typeof(double));
            while (!string.IsNullOrEmpty(DocumentoExcelExamenHombresEnfermos.GetCellValueAsString(renglonInicialhombres, ColumnaInicialHombres)))
            {
                TablaEnfermos.Rows.Add();
                    for (int i = 0; i < 9; i++)
                    {
                    TablaEnfermos.Rows[renglonInicialhombres - 4][i] = DocumentoExcelExamenHombresEnfermos.GetCellValueAsDouble(renglonInicialhombres, ColumnaInicialHombres + i);
                    }

                TablaEnfermos.Rows[renglonInicialhombres - 4][9] = 0;

                renglonInicialhombres++;
            }
            renglonInicialhombres = 4;
            DataTable[] Tablas = new DataTable[2];
            Tablas[0] = new DataTable();
            Tablas[1] = new DataTable();
            Tablas[0] = TablaEnfermos;
            Tablas[1] = TablaSaludables;
            return Tablas;
        }


    }
}
