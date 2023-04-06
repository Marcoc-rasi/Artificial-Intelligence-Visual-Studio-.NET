using System;
using System.Collections.Generic;
using System.Text;

namespace Exodo
{
    public static class Recta
    {
        public static double[] Plus(double a,double[] input)
        {

            for(int i=0;i<input.Length;i++)
            {
                input[i] = input[i] + a;
            }
            return input;
        }
        public static double[] Minus(double a, double[] input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] - a;
            }
            return input;
        }
        public static double[] Times(double a, double[] input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * a;
            }
            return input;
        }
        public static double[] rDivide(double a, double[] input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] / a;
            }
            return input;
        }
        public static double[] Exp(double[] input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                input[i] =Exodo.EMath.EExp(input[i]);
            }
            return input;
        }
    }
}
