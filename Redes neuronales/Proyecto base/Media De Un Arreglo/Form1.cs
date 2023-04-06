using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_De_Un_Arreglo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

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
            foreach(string dato in Arreglostring)
            {
                ArregloDouble[i] = Convert.ToDouble(dato);
                suma = suma + ArregloDouble[i];
                i++;
            }
           
            txtMedia.Text =Convert.ToString( suma / ArregloDouble.Length);

            List<Datos> ListaDatos = new List<Datos>();
            i = 0;
            foreach(double dato in ArregloDouble)
            {
                i++;
                
                ListaDatos.Add(new Datos { SerieDatos1 =i, DatosEnArreglo = dato,Mediaa = suma / ArregloDouble.Length });
            }
            chart1.Series.Clear();
            chart1.DataBindTable(ListaDatos, "SerieDatos1");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
