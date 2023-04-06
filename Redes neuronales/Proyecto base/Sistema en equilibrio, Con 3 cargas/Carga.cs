using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_en_equilibrio__Con_3_cargas
{
    public class Carga
    {
        public double X, Y;
        public double C;
        public Carga(double x,double y,double c) {
            this.X = x;
            this.Y = y;
            this.C = c;
        }public Carga(double c)
        {
            this.C = c;
        }
    }
}
