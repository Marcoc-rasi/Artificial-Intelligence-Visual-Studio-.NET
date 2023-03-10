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

namespace GraficadorSeno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            plotini();
        }
         private void plot(double[] x, double[] y)
        {
            for( int i = 0; i < x.Length; i++)
            {
                chart1.Series[0].Points.AddXY(x[i],y[i]);
            }
        }
        private void plotini()
        {
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightSalmon;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightSalmon;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.ChartAreas[0].AxisX.RoundAxisValues();
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string texto;
            texto = txtArreglo.Text;
            int i = 0;
            double suma = 0;
            double[] ArregloDouble;
            string[] Arreglostring = texto.Split(',');
            ArregloDouble = new double[Arreglostring.Length];
            foreach (string dato in Arreglostring)
            {
                ArregloDouble[i] = Convert.ToDouble(dato);
                suma = suma + ArregloDouble[i];
                i++;
            }

            txtMedia.Text = Convert.ToString(suma / ArregloDouble.Length);

            List<Datos> ListaDatos = new List<Datos>();
            double division = ArregloDouble.Length;
            double saltos = (2 * Math.PI) / division;
            double paso = saltos;
            ListaDatos.Add(new Datos { SerieDatos1 = 0, DatosEnArreglo = 0, Mediaa = suma / ArregloDouble.Length });
            foreach (double dato in ArregloDouble)
            {
                ListaDatos.Add(new Datos { SerieDatos1 = paso, DatosEnArreglo = dato*Math.Sin(paso), Mediaa = suma / ArregloDouble.Length });
                paso = paso + saltos;
            }
            chart1.Series.Clear();
            chart1.DataBindTable(ListaDatos, "SerieDatos1");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }

        private void BtnPreEstablecido_Click(object sender, EventArgs e)
        {
            /*Exodo.Gauss obj1 = new Exodo.gauss();
            gauss obj2 = new gauss(2, 1);
            double min = Min(obj1, obj2);
            double max = Max(obj1, obj2);
            private double Min(gauss obj1,gauss obj2)
            {
                if (obj1.min < obj2.gxmin)
                {
                    return obj1.gxmin;
                }
                else
                    obj1.gxmin;
            }
            private double Max(gauss obj1, gauss obj2)
            {
                if (obj1.max < obj2.gxmax)
                {
                    return obj2.gxmax;
                }
                else
                    obj1.gxmax;
            }*/
            //Agregar los valores minimo y maximo a gauss en el constructor
            //armar la grafica con dos  funciones
            double[] x = Exodo.Funciones.Linspace(-100, 100, 0.1);
            double[] y = Exodo.Stadistics.NormalDistribution(x);
            plot(x, y);
            
            double area = Exodo.Funciones.IntegralSim(x,10,-100,100);
            txtArreglo.Text = Convert.ToString(area);
        }
    }
}
