using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERROR_DE_Pi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double pi = 0;
            double divisor = 1;
            for(int i=0;i<10000;i++)
            {
                pi += (4 / divisor);
                divisor += 2;
                pi -= (4 / divisor);
                divisor += 2;
                txtCalcular.Text = Convert.ToString(pi);
            }
            double error = Math.Abs(Math.PI - pi);
            txtError.Text = Convert.ToString(error);
            //txtCalcular.Text = Convert.ToString(pi);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
