using System;
using System.Collections.Generic;
using System.Text;

namespace Exodo
{
    public static class Stadistics
    {
        public static double Mean(double[] input)
        {
            double suma = 0;
            for(int i = 0; i < input.Length; i++)
            {
                suma = suma + input[i];
            }
            double media = suma / input.Length;
            return media;
        }
        public static double Var(double[] input)
        {
            double media = Mean(input);
            double aux = 0; 
            for(int i =0; i < input.Length; i++)
            {
               aux = Exodo.EMath.EPow(input[i]-media, 2) + aux; 
            }
            return aux/input.Length;
        }

        public static double Std(double[] input)
        {
            double output = Exodo.EMath.ESqrt(Var(input));
            return output;
        }
        public static double[] NormalDistribution(double[] input)
        {
            double media = Mean(input);
            double varianza = Var(input);
            double desviacionEstandar = Std(input);
            double[] aux = new double[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                aux[i] = ( Exodo.EMath.EExp( (-1)*( Exodo.EMath.EPow( (input[i]-media),2 )/(2*varianza) )))/(desviacionEstandar*Exodo.EMath.ESqrt(2*Math.PI));
            }
            return aux;
        }
        public static double NormalDistribution(double[] input,double point)
        {
            double media = Mean(input);
            double varianza = Var(input);
            double desviacionEstandar = Std(input);
            double aux = 0;
            aux = (Exodo.EMath.EExp((-1) * (Exodo.EMath.EPow((point - media), 2) / (2 * varianza)))) / (desviacionEstandar * Exodo.EMath.ESqrt(2 * Math.PI));
            return aux;
        }
    }
}
