using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_consolaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Fuerza_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = 9e9;
            double c1 = Convert.ToDouble(Carga1.Text);
            double c2 = Convert.ToDouble(Carga2.Text);
            double di = Convert.ToDouble(Distancia.Text);
            Fuerza.Text = Convert.ToString((c1 * c2 * k) / (di * di));
        }

        private void ResolverDis_Click(object sender, EventArgs e)
        {
            double k = 9e9;
            double c1 = Convert.ToDouble(Carga1.Text);
            double c2 = Convert.ToDouble(Carga2.Text);
            double fu = Convert.ToDouble(FuerzaTxt.Text);
            DistanciaResultado.Text =Convert.ToString( Math.Sqrt((k * c1 * c2) / fu));
        }

        private void Ejercicio3Btn_Click(object sender, EventArgs e)
        {
            double k = 9e9;
            double c1 = Convert.ToDouble(Carga1.Text);
            double c2 = Convert.ToDouble(Carga2.Text);
            double c3 = Convert.ToDouble(Carga3.Text);
            double distancia = Convert.ToDouble(Distancia.Text);
            double ft = ((4 * k) / distancia) * (c1*c3+ c2*c3);
            Ejercicio3txt.Text = Convert.ToString(ft);
        }

        private void TxtEjercicio4_Click(object sender, EventArgs e)
        {
            double c1 = Convert.ToDouble(Carga1.Text);
            double c2 = Convert.ToDouble(Carga2.Text);
            double c3 = Convert.ToDouble(Carga3.Text);
            double distancia = Convert.ToDouble(Distancia.Text);
            double d1 = distancia / (Math.Sqrt((c2 * c3) / (c1 * c3)) + 1);
            txtDistanciaq1.Text = Convert.ToString(d1);
            double d2 = distancia - d1;
            txtDistanciaq2.Text = Convert.ToString(d2);
        }
    }
}
