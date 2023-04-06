using System;
using System.Collections.Generic;
using System.Text;

namespace Exodo
{
        public static class Funciones
        {
        public static double[] Linspace(double inicio, double fin, double saltos)
        {
            double Carrera = inicio;
            int TamañoArreglo = Convert.ToInt32((Exodo.EMath.EAbs(fin - inicio))/saltos +1);
            double[] aux = new double[TamañoArreglo];
            for(int i = 0; i < TamañoArreglo; i++)
            {
                aux[i] = Carrera;
                Carrera = Carrera + saltos;
            }
            return aux;
        }
        public static double IntegralSim(double[] x, double n, double a, double b)
        {
          
            
                if (n % 2 == 1) n++;    //n es par 
                double h = (b - a) / n;
                double suma = Exodo.Stadistics.NormalDistribution(x,a) + Exodo.Stadistics.NormalDistribution(x, b);
                for (int i = 1; i < n; i += 2)
                {
                    suma += 4 * Exodo.Stadistics.NormalDistribution(x, a + i * h);
                }
                for (int i = 2; i < n; i += 2)
                {
                    suma += 2 * Exodo.Stadistics.NormalDistribution(x, a + i * h);
                }
            return (suma * h / 3);
        }
        public static double Integral(double[] inputX, double[] inputY)
        {
            double output;
            double a = inputX[0];
            double b = inputX[inputX.Length - 1];
            int n = inputX.Length;
            double h = (b - a) / n;
            double I = 0;
            double P = 0;
            double sum = 0;

            for (int i = 0; i < n / 2; i++)
            {
                sum = Math.Abs(inputY[2 * i + 1]);
                I = I + sum;
            }
            sum = 0;
            for (int i = 0; i < (n / 2) - 1; i++)
            {
                sum = Math.Abs(inputY[2 * (i + 1)]);
                P = P + sum;
            }
            output = (h / 3) * (Math.Abs(inputY[0]) + 4 * I + 2 * P + Math.Abs(inputY[inputX.Length - 1]));
            return output;
        }
    }
}
