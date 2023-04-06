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
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using SpreadsheetLight;

namespace RegrecionCuadratica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void plotm(double[] x, double[] y)
        {
            int conteo = 0;
            plotini();
            chartRectam.Series.Clear();

            // Nombre de los arreglos.
            string[] seriesArray = { "RectaPoints", "RectaAEvaluar" };

            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Agrego por nombre la serie de datos a la grafica
                //series contiene acceso a la tabla de datos de la serie devuelta.
                Series series = chartRectam.Series.Add(seriesArray[i]);
                if (seriesArray[i] == "RectaPoints")
                {
                    // Agrago los puntos a la recta.
                    for (conteo = 0; conteo < x.Length; conteo++)
                    {
                        series.Points.AddXY(x[conteo], y[conteo]);

                    }
                }
                if (seriesArray[i] == "RectaAEvaluar")
                {
                    double[] yRectaEvaluar = { 4, 3, 5, 1, 7, 9, 5, 4, 6, 3, 2 };
                    for (int o = 0; o < yRectaEvaluar.Length; o++)
                    {
                        series.Points.AddXY(o, yRectaEvaluar[o]);
                    }
                }
            }
        }
        private void plotb(double[] x, double[] y)
        {
            int conteo = 0;
            plotini();
            chartRectab.Series.Clear();

            // Nombre de los arreglos.
            string[] seriesArray = { "RectaPoints", "RectaAEvaluar" };

            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Agrego por nombre la serie de datos a la grafica
                //series contiene acceso a la tabla de datos de la serie devuelta.
                Series series = chartRectab.Series.Add(seriesArray[i]);
                if (seriesArray[i] == "RectaPoints")
                {
                    // Agrago los puntos a la recta.
                    for (conteo = 0; conteo < x.Length; conteo++)
                    {
                        series.Points.AddXY(x[conteo], y[conteo]);

                    }
                }
                if (seriesArray[i] == "RectaAEvaluar")
                {
                    double[] yRectaEvaluar = { 4, 3, 5, 1, 7, 9, 5, 4, 6, 3, 2 };
                    for (int o = 0; o < yRectaEvaluar.Length; o++)
                    {
                        series.Points.AddXY(o,yRectaEvaluar[o]);
                    }
                }
            }
        }
        //plot para la funcion de error, usaremos la regunda serie para graficar ECM
        private void plotError(double[] x, double[] y,double ecm,Chart ChartEnviado)
        {
            int conteo = 0;
            plotini();
            ChartEnviado.Series.Clear();

            // Nombre de los arreglos.
            string[] seriesArray = { "ErrorPoints", "ECM" };

            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Agrego por nombre la serie de datos a la grafica
                //series contiene acceso a la tabla de datos de la serie devuelta.
                Series series =ChartEnviado.Series.Add(seriesArray[i]);
                if (seriesArray[i] == "ErrorPoints")
                {
                    // Agrago los puntos a la recta.
                    for (conteo = 0; conteo < x.Length; conteo++)
                    {
                        series.Points.AddXY(x[conteo], y[conteo]);

                    }
                }
                if (seriesArray[i] == "ECM")
                {
                    for (int o = 0; o <x.Length ; o++)
                    {
                        series.Points.AddXY(o,ecm);
                    }
                }
            }
        }
        private void plotECM(double[] x, double[] y)
        {
            int conteo = 0;
            plotini();
            chartECMmb.Series.Clear();

            // Nombre de los arreglos.
            string[] seriesArray = { "CurvaECM"};

            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Agrego por nombre la serie de datos a la grafica
                //series contiene acceso a la tabla de datos de la serie devuelta.
                Series series = chartECMmb.Series.Add(seriesArray[i]);
                if (seriesArray[i] == "CurvaECM")
                {
                    // Agrago los puntos a la recta.
                    for (conteo = 0; conteo < x.Length; conteo++)
                    {
                        series.Points.AddXY(x[conteo], y[conteo]);

                    }
                }
            }
        }
        public double CalcularECMRecta(double[] yCalculada,double[] yEvaluar,double m, double b)
        {
            Exodo.Recta.Times(m, yCalculada);
            Exodo.Recta.Plus(b, yCalculada);
            double ErrorDescenso = 0;
            for (int i = 0; i < yEvaluar.Length; i++)
            {
                ErrorDescenso = ErrorDescenso + Exodo.EMath.EPow(yCalculada[i] - yEvaluar[i], 2);
            }
            return  ErrorDescenso / yEvaluar.Length;
        }
        
        private void plotini()
        {
            chartRectam.Series[0].ChartType = SeriesChartType.Spline;
            chartRectam.Series[0].IsVisibleInLegend = false;

            chartErrorm.Series[0].ChartType = SeriesChartType.Spline;
            chartErrorm.Series[0].IsVisibleInLegend = false;

            chartECMmb.Series[0].ChartType = SeriesChartType.Spline;
            chartECMmb.Series[0].IsVisibleInLegend = false;

            chartRectab.Series[0].ChartType = SeriesChartType.Spline;
            chartRectab.Series[0].IsVisibleInLegend = false;

            chartErrorb.Series[0].ChartType = SeriesChartType.Spline;
            chartErrorb.Series[0].IsVisibleInLegend = false;

        }
        private void BtnGraficar_Click(object sender, EventArgs e)
        {
           /* double b = Convert.ToDouble(numericUpDownb.Value);
            double m = Convert.ToDouble(numericUpDownm.Value);*/
            double b = Convert.ToDouble(txtb.Text);
            double m = Convert.ToDouble(txtm.Text); 
            double[] x = Exodo.Funciones.Linspace(0, 10, 1);
            double[] y= new double[x.Length];
            x.CopyTo(y, 0);
            Exodo.Recta.Times(m, y);
            //Exodo.Recta.Plus(b, y);
            plotm(x, y);
            //hasta aqui se grafica los puntos dados y una recta que puede cambiar
            //su ordenada al origen y la pendiente
            //Lo siguiente es imprimir en el chatError
            //El error al cuadrado y el ECM
            Series SerieRectaAEvaluar=  chartRectam.Series.FindByName("RectaAEvaluar");
            DataPoint[] SerieRectaAEvaluarArreglo = new DataPoint[x.Length];
            SerieRectaAEvaluar.Points.CopyTo(SerieRectaAEvaluarArreglo, 0);
            double[] yRectaAEvaluar = new double[x.Length];
            double[] yErrorm = new double[x.Length];
            double[] yErrorb = new double[x.Length];
            double ECMm = 0;
            for (int i = 0; i < x.Length; i++)
            {
                yRectaAEvaluar[i] = Convert.ToDouble(SerieRectaAEvaluarArreglo[i].YValues[0]);
                yErrorm[i] = Exodo.EMath.EPow(y[i] - yRectaAEvaluar[i], 2);

                ECMm = ECMm + yErrorm[i];
            }
            ECMm = ECMm / yRectaAEvaluar.Length;
            txtECMm.Text = Convert.ToString(ECMm);
            //plotError(x, yErrorm,ECM);
            plotError(x, yErrorm, ECMm, chartErrorm);
            //
            Exodo.Recta.Plus(b, y);
            double ECMb = 0;
            for (int i = 0; i < x.Length; i++)
            {
                
                yErrorb[i] = Exodo.EMath.EPow(y[i] - yRectaAEvaluar[i], 2);

                ECMb = ECMb + yErrorb[i];
            }
            ECMb  = ECMb / yRectaAEvaluar.Length;
            txtECMb.Text = Convert.ToString(ECMb);
            plotb(x, y);
            plotError(x, yErrorb, ECMb, chartErrorb);
            //
            /*Ahora graficaremos la recta de ECM segun como varie la pendiente de la recta*/
            //double[] x = Exodo.Funciones.Linspace(0, 10, 1);
            double ECMFuturob;
            int ContadorPosicionyECMb;
            int ContadorPosicionyECMm = 0;
            double[] yFutura = new double[x.Length];
            double[] yFuturaError = new double[x.Length];
            int TamañoArreglo = Exodo.Funciones.Linspace(-3, 3, 0.1).Length;
            double[,] yEMC = new double[TamañoArreglo,TamañoArreglo];
            double[] yEMCSolucion = new double[TamañoArreglo];
            string pathFile = AppDomain.CurrentDomain.BaseDirectory + "miExcel.xlsx";
            
            SLDocument oSLDocument = new SLDocument();
            DataTable TablaDatos = new DataTable();
            //Columnas
            TablaDatos.Columns.Add("m", typeof(double));
            TablaDatos.Columns.Add("b", typeof(double));
            TablaDatos.Columns.Add("ECM", typeof(double));

            for (double mFutura = -3; mFutura < 3; mFutura+=0.1)
            {
                
                ContadorPosicionyECMb = 0;
                //Exodo.Recta.Plus(b, yFutura);
                
                for (double bFutura = -3; bFutura < 3; bFutura += 0.1)
                {
                    x.CopyTo(yFutura, 0);
                    Exodo.Recta.Times(mFutura, yFutura);
                    ECMFuturob = 0;
                    Exodo.Recta.Plus(bFutura, yFutura);
                    for (int n = 0; n < yFutura.Length; n++)
                    {
                       
                        //yRectaAEvaluar[nodo] = Convert.ToDouble(SerieRectaAEvaluarArreglo[nodo].YValues[0]);
                        yFuturaError[n] = Exodo.EMath.EPow(yFutura[n] - yRectaAEvaluar[n], 2);
                        ECMFuturob = ECMFuturob + yFuturaError[n];
                        
                        
                    }
                    ECMFuturob = ECMFuturob / yRectaAEvaluar.Length;
                    yEMC[ContadorPosicionyECMm, ContadorPosicionyECMb] = ECMFuturob;
                    TablaDatos.Rows.Add(mFutura, bFutura,ECMFuturob);
                    if (m > 0)
                    {
                        if (mFutura > 0.95 * m && mFutura < 1.05 * m)
                        {
                            yEMCSolucion[ContadorPosicionyECMb] = ECMFuturob;
                        }
                    }
                    else
                    {
                        if (mFutura < 0.95 * m && mFutura > 1.05 * m)
                        {
                            yEMCSolucion[ContadorPosicionyECMb] = ECMFuturob;
                        }
                    }

                    ContadorPosicionyECMb = ContadorPosicionyECMb + 1;
                }
                ContadorPosicionyECMm = ContadorPosicionyECMm + 1;
            }
            plotECM(Exodo.Funciones.Linspace(-3, 3, 0.1), yEMCSolucion);
           
            /*En esta parte agregamos las pendientes que probamos y sus errrores cuadraticos medios*/
            int Renglon = dataGridViewRectaYError.Rows.Add();
            //Coloco la informacion
            dataGridViewRectaYError.Rows[Renglon].Cells[0].Value = m;
            dataGridViewRectaYError.Rows[Renglon].Cells[1].Value = ECMm;
            dataGridViewRectaYError.Rows[Renglon].Cells[2].Value = b;
            dataGridViewRectaYError.Rows[Renglon].Cells[3].Value = ECMb;



            /*StreamWriter EscritorDatos = new StreamWriter("Datos_Grafica_Matlab.csv");
            for(double bg = 0; bg < 3; bg++)
            {
                
                   //Aqui va la funcion
                    EscritorDatos.WriteLine(Convert.ToString(bg)+','+ Convert.ToString(bg));
                
            }

            EscritorDatos.Close();*/
            /*oSLDocument.ImportDataTable(1, 1, TablaDatos, true);
            oSLDocument.SaveAs(pathFile);*/
            
            
            double ECMDescenso = 0;
            double ECMDescensoFuturo = 0;
            double ECMminimo = 0;
            double mDescenso = m;
            double bDescenso = b;
            double[] yDescenso= new double[x.Length];
            double[] yFuturaDescenso = new double[x.Length];
            double ErrorDescenso = 0;
            x.CopyTo(yDescenso, 0);
            ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0,10,1), yRectaAEvaluar,mDescenso,bDescenso);


            ///Guardar el recorrido del punto en el plano 3D
            ///
            DataTable TablaDatosRecorrido = new DataTable();
            //Columnas
            TablaDatosRecorrido.Columns.Add("mRecorrido", typeof(double));
            TablaDatosRecorrido.Columns.Add("bRecorrido", typeof(double));
            TablaDatosRecorrido.Columns.Add("ECMRecorrido", typeof(double));
            TablaDatosRecorrido.Rows.Add(mDescenso, bDescenso, ECMDescenso);
            while (ECMminimo == 0)
            {
                
                if (ECMDescenso > CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso + 0.1, bDescenso))
                {
                    mDescenso = mDescenso + 0.1;
                    ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso);
                }
                else
                {
                    if (ECMDescenso > CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso - 0.1, bDescenso))
                    {
                        mDescenso = mDescenso - 0.1;
                        ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso);
                    }
                    else
                    {
                        if (ECMDescenso > CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso + 0.1))
                        {
                            bDescenso = bDescenso + 0.1;
                            ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso);
                        }
                        else
                        {
                            if (ECMDescenso > CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso - 0.1))
                            {
                                bDescenso = bDescenso - 0.1;
                                ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso);
                            }
                            else
                            {
                                if (ECMDescenso > CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso + 0.1, bDescenso + 0.1))
                                {
                                    mDescenso = mDescenso + 0.1;
                                    bDescenso = bDescenso + 0.1;
                                    ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso , bDescenso);
                                }
                                else
                                {
                                    if (ECMDescenso > CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso + 0.1, bDescenso - 0.1))
                                    {
                                        mDescenso = mDescenso + 0.1;
                                        bDescenso = bDescenso - 0.1;
                                        ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso);
                                    }
                                    else
                                    {
                                        if (ECMDescenso > CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso - 0.1, bDescenso + 0.1))
                                        {
                                            mDescenso = mDescenso - 0.1;
                                            bDescenso = bDescenso + 0.1;
                                            ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso);
                                        }
                                        else
                                        {
                                            if (ECMDescenso > CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso - 0.1, bDescenso - 0.1))
                                            {
                                                mDescenso = mDescenso - 0.1;
                                                bDescenso = bDescenso - 0.1;
                                                ECMDescenso = CalcularECMRecta(Exodo.Funciones.Linspace(0, 10, 1), yRectaAEvaluar, mDescenso, bDescenso);
                                            }
                                            else
                                            {
                                                ECMminimo = ECMDescenso;
                                                txtm.Text = Convert.ToString(ECMminimo);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                TablaDatosRecorrido.Rows.Add(mDescenso, bDescenso, ECMDescenso);
            }

            oSLDocument.ImportDataTable(1, 1, TablaDatos, true);
            oSLDocument.ImportDataTable(1, 5, TablaDatosRecorrido, true);
            oSLDocument.SaveAs(pathFile);

        }
    }
}
