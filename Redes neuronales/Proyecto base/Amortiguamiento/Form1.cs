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

namespace Amortiguamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void plotm(double[] xRealPlot, double[] yRealPlot,double[] xPropuestaPlot,double[] yPropuestaPlot)
        {
            int conteo = 0;
            plotini();
            chartGraficaAmortiguamiento.Series.Clear();

            // Nombre de los arreglos.
            string[] seriesArray = { "RectaReal", "RectaPropuesta" };

            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Agrego por nombre la serie de datos a la grafica
                //series contiene acceso a la tabla de datos de la serie devuelta.
                Series series = chartGraficaAmortiguamiento .Series.Add(seriesArray[i]);
                if (seriesArray[i] == "RectaReal")
                {
                    // Agrago los puntos a la recta.
                    for (conteo = 0; conteo < xRealPlot.Length; conteo++)
                    {
                        series.Points.AddXY(xRealPlot[conteo], yRealPlot[conteo]);

                    }
                }
                if (seriesArray[i] == "RectaPropuesta")
                {
                    for (int o = 0; o < yPropuestaPlot.Length; o++)
                    {
                        series.Points.AddXY(xPropuestaPlot, yPropuestaPlot[o]);
                    }
                }
            }
        }
        public double CalcularECMRecta(double[] yCalculada, double[] yEvaluar,double A, double ConstanteAmortiguamiento)
        {
            double[] yCalculadaSinModificar = new double[yCalculada.Length];
            yCalculada.CopyTo(yCalculadaSinModificar, 0);
            Exodo.Recta.Times(-ConstanteAmortiguamiento, yCalculadaSinModificar);
            Exodo.Recta.Exp(yCalculadaSinModificar);
            Exodo.Recta.Times(A, yCalculadaSinModificar);
            double ErrorDescenso = 0;
            for (int i = 0; i < yEvaluar.Length; i++)
            {
                if (yEvaluar[i] > 0)
                {
                    ErrorDescenso = ErrorDescenso + Exodo.EMath.EPow(yCalculadaSinModificar[i] - yEvaluar[i], 2);
                }
                else
                {
                    ErrorDescenso = ErrorDescenso + Exodo.EMath.EPow(yCalculadaSinModificar[i] + yEvaluar[i], 2);
                }
            }
            return ErrorDescenso / yEvaluar.Length;
        }
        private void plotini()
        {
            chartGraficaAmortiguamiento.Series[0].ChartType = SeriesChartType.Spline;
            chartGraficaAmortiguamiento.Series[0].IsVisibleInLegend = false;
            chartGraficaAmortiguamiento.Series[1].ChartType = SeriesChartType.Spline;
            chartGraficaAmortiguamiento.Series[1].IsVisibleInLegend = false;
            chartGraficaAmortiguamiento.Series[1].Color = 

        }
        private void AproximarRecta_Click(object sender, EventArgs e)
        {
            string RutaArchivoExcel = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\Amortiguamiento\bin\Debug\ExcelAmortiguamiento.xlsx";
            SLDocument DocumentoExcel = new SLDocument(RutaArchivoExcel);
            int renglon = 2;
            int tamañoXReal = 0;
            while (!string.IsNullOrEmpty(DocumentoExcel.GetCellValueAsString(renglon, 1)))
            {
                renglon++;
                tamañoXReal++;
            }
            renglon = 2;
            double[] xReal = new double[tamañoXReal];
            double[] yReal = new double[tamañoXReal];

            double[] xPropuesta = new double[tamañoXReal];
            double[] yPropuesta = new double[tamañoXReal];

            while (!string.IsNullOrEmpty(DocumentoExcel.GetCellValueAsString(renglon, 1)))
            {
                xReal[renglon - 2] = DocumentoExcel.GetCellValueAsDouble(renglon, 1);
                yReal[renglon - 2] = DocumentoExcel.GetCellValueAsDouble(renglon, 3);
                xPropuesta[renglon - 2] = DocumentoExcel.GetCellValueAsDouble(renglon, 1);
                yPropuesta[renglon - 2] = DocumentoExcel.GetCellValueAsDouble(renglon, 2);
                renglon++;
            }
            //Calculare la constante de amortiguamiento  la amplitud
            double A = DocumentoExcel.GetCellValueAsDouble(2, 10);
            double ConstanteAmortiguamiento = DocumentoExcel.GetCellValueAsDouble(3, 10);
            double ECMminimo = 0;
            double ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
            while (ECMminimo == 0)
            {

                if (ECMDescenso > CalcularECMRecta(xPropuesta, yReal, A + 0.01, ConstanteAmortiguamiento))
                {
                    A = A + 0.01;
                    ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
                }
                else
                {
                    if (ECMDescenso > CalcularECMRecta(xPropuesta, yReal, A - 0.01, ConstanteAmortiguamiento))
                    {
                        A = A - 0.01;
                        ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
                    }
                    else
                    {
                        if (ECMDescenso > CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento + 0.01))
                        {
                            ConstanteAmortiguamiento = ConstanteAmortiguamiento + 0.01;
                            ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
                        }
                        else
                        {
                            if (ECMDescenso > CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento - 0.01))
                            {
                                ConstanteAmortiguamiento = ConstanteAmortiguamiento - 0.01;
                                ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
                            }
                            else
                            {
                                if (ECMDescenso > CalcularECMRecta(xPropuesta, yReal, A + 0.01, ConstanteAmortiguamiento + 0.01))
                                {
                                    A = A + 0.01;
                                    ConstanteAmortiguamiento = ConstanteAmortiguamiento + 0.01;
                                    ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
                                }
                                else
                                {
                                    if (ECMDescenso > CalcularECMRecta(xPropuesta, yReal, A + 0.01, ConstanteAmortiguamiento - 0.01))
                                    {
                                        A = A + 0.01;
                                        ConstanteAmortiguamiento = ConstanteAmortiguamiento - 0.01;
                                        ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
                                    }
                                    else
                                    {
                                        if (ECMDescenso > CalcularECMRecta(xPropuesta, yReal, A - 0.01, ConstanteAmortiguamiento + 0.01))
                                        {
                                            A = A - 0.01;
                                            ConstanteAmortiguamiento = ConstanteAmortiguamiento + 0.01;
                                            ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
                                        }
                                        else
                                        {
                                            if (ECMDescenso > CalcularECMRecta(xPropuesta, yReal, A - 0.01, ConstanteAmortiguamiento - 0.01))
                                            {
                                                A = A - 0.01;
                                                ConstanteAmortiguamiento = ConstanteAmortiguamiento - 0.01;
                                                ECMDescenso = CalcularECMRecta(xPropuesta, yReal, A, ConstanteAmortiguamiento);
                                            }
                                            else
                                            {
                                                ECMminimo = ECMDescenso;
                                                txtA.Text = Convert.ToString(A);
                                                txtV0.Text = Convert.ToString(ConstanteAmortiguamiento);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
