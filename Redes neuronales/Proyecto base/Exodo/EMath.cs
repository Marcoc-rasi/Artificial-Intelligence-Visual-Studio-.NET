using System;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Versioning;
using System.Diagnostics.Contracts;


namespace Exodo
{
    public static class EMath
    {
        ////////////////////////Valor Absoluto///////////////////////
        public static decimal EAbs(decimal value)
        {
            return Math.Abs(value);
        }
        public static decimal[] EAbs(decimal[] value)
        {
            decimal[] aux = new decimal[value.Length];
            for(int i = 0;i<value.Length;i++)
            {
                aux[i] =Math.Abs(value[i]);
            }
            return aux;
        }
        public static decimal[,] EAbs(decimal[,] value)
        {
            decimal[,] aux = new decimal[value.GetLength(0),value.GetLength(1)];
            for(int i = 0;i< value.GetLength(0); i++)
            {
                for(int a=0;a< value.GetLength(1); a++)
                {
                    aux[i, a] =Math.Abs(value[i, a]);
                }
            }
            return aux;
        }
        
        public static double EAbs(double value)
        {
            return Math.Abs(value);
        }
        public static double[] EAbs(double[] value)
        {
            double[] aux = new double[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                aux[i] = Math.Abs(value[i]);
            }
            return aux;
        }
        public static double[,] EAbs(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Abs(value[i, a]);
                }
            }
            return aux;
        }
        public static short EAbs(short value)
        {
            return Math.Abs(value);
        }
        public static short[] EAbs(short[] value)
        {
            short[] aux = new short[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                aux[i] = Math.Abs(value[i]);
            }
            return aux;
        }
        public static short[,] EAbs(short[,] value)
        {
            short[,] aux = new short[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Abs(value[i, a]);
                }
            }
            return aux;
        }
        public static int EAbs(int value)
        {
            return Math.Abs(value);
        }
        public static int[] EAbs(int[] value)
        {
            int[] aux = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                aux[i] = Math.Abs(value[i]);
            }
            return aux;
        }
        public static int[,] EAbs(int[,] value)
        {
            int[,] aux = new int[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Abs(value[i, a]);
                }
            }
            return aux;
        }
        public static long EAbs(long value)
        {
            return Math.Abs(value);
        }
        public static long[] EAbs(long[] value)
        {
            long[] aux = new long[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                aux[i] = Math.Abs(value[i]);
            }
            return aux;
        }
        public static long[,] EAbs(long[,] value)
        {
            long[,] aux = new long[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Abs(value[i, a]);
                }
            }
            return aux;
        }
        public static sbyte EAbs(sbyte value)
        {
            return Math.Abs(value);
        }
        public static sbyte[] EAbs(sbyte[] value)
        {
            sbyte[] aux = new sbyte[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                aux[i] = Math.Abs(value[i]);
            }
            return aux;
        }
        public static sbyte[,] EAbs(sbyte[,] value)
        {
            sbyte[,] aux = new sbyte[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Abs(value[i, a]);
                }
            }
            return aux;
        }
        public static float EAbs(float value)
        {
            return Math.Abs(value);
        }
        public static float[] EAbs(float[] value)
        {
            float[] aux = new float[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                aux[i] = Math.Abs(value[i]);
            }
            return aux;
        }
        public static float[,] EAbs(float[,] value)
        {
            float[,] aux = new float[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Abs(value[i, a]);
                }
            }
            return aux;
        }
        ////////////////////////Valor Absoluto///////////////////////
        ///
        /// 
        /// 
        /// 
        /// 
        ////////////////////////senos y cosenos///////////////////////

        public static double EAcos(double d)
        {
            return Math.Acos(d);
        }
        public static double[] EAcos(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Acos(d[i]);
            }
            return aux;
        }
        public static double[,] EAcos(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Acos(value[i, a]);
                }
            }
            return aux;
        }
        public static double EAsin(double d)
        {
            return Math.Asin(d);
        }
        public static double[] EAsin(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Asin(d[i]);
            }
            return aux;
        }
        public static double[,] EAsin(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Asin(value[i, a]);
                }
            }
            return aux;
        }
        public static double EAtan(double d)
        {
            return Math.Atan(d);
        }
        public static double[] EAtan(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Atan(d[i]);
            }
            return aux;
        }
        public static double[,] EAtan(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Atan(value[i, a]);
                }
            }
            return aux;
        }
        public static double EAtan2(double y, double x)
        {
            return Math.Atan2(y, x);
        }
        public static double[] EAtan2(double[] y,double[]x)
        {
            double[] aux = new double[y.Length];
            if (y.Length == x.Length)
            {
                for (int i = 0; i < y.Length; i++)
                {
                    aux[i] = Math.Atan2(y[i],x[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] EAtan2(double[,] y, double[,] x)
        {
            //Se aplicara la operacion elemento por elemento de cada matriz
            //con las mismas coordenasas para x,y
            //por esta definicion las matrices tienen que ser iguales
            double[,] aux = new double[y.GetLength(0), y.GetLength(1)];
            if (y.GetLength(0) == x.GetLength(0) && y.GetLength(1) == x.GetLength(1))
            {
                for (int i = 0; i < y.GetLength(0); i++)
                {
                    for (int a = 0; a < y.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Atan2(y[i, a], x[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static long EBigMul(int y, int x)
        {
            return Math.BigMul(y, x);
        }
        public static long[] EBigMul(int[] y, int[] x)
        {
            long[] aux = new long[y.Length];
            if (y.Length == x.Length)
            {
                for (int i = 0; i < y.Length; i++)
                {
                    aux[i] = Math.BigMul(y[i], x[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static long[,] EBigMul(int[,] y, int[,] x)
        {
            //Se aplicara la operacion elemento por elemento de cada matriz
            //con las mismas coordenasas para x,y
            //por esta definicion las matrices tienen que ser iguales
            long[,] aux = new long[y.GetLength(0), y.GetLength(1)];
            if (y.GetLength(0) == x.GetLength(0) && y.GetLength(1) == x.GetLength(1))
            {
                for (int i = 0; i < y.GetLength(0); i++)
                {
                    for (int a = 0; a < y.GetLength(1); a++)
                    {
                        aux[i, a] = Math.BigMul(y[i, a], x[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal ECeiling(decimal d)
        {
            return Math.Ceiling(d);
        }
        public static decimal[] ECeiling(decimal[] d)
        {
            decimal[] aux = new decimal[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Ceiling(d[i]);
            }
            return aux;
        }
        public static decimal[,] ECeiling(decimal[,] value)
        {
            decimal[,] aux = new decimal[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Ceiling(value[i,a]);
                }
            }
            return aux;
        }
        public static double ECeiling(double d)
        {
            return Math.Ceiling(d);
        }
        public static double[] ECeiling(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Ceiling(d[i]);
            }
            return aux;
        }
        public static double[,] ECeiling(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Ceiling(value[i, a]);
                }
            }
            return aux;
        }
        public static double ECos(double d)
        {
            return Math.Cos(d);
        }
        public static double[] ECos(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Cos(d[i]);
            }
            return aux;
        }
        public static double[,] ECos(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Cos(value[i, a]);
                }
            }
            return aux;
        }
        public static double ECosh(double d)
        {
            return Math.Cosh(d);
        }
        public static double[] ECosh(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Cosh(d[i]);
            }
            return aux;
        }
        public static double[,] ECosh(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Cosh(value[i, a]);
                }
            }
            return aux;
        }
        public static int EDivRem(int dividendo, int divisor, out int Exceso) 
        {
            return Math.DivRem(dividendo, divisor,out Exceso);
        }
        public static int[] EDivRem(int[] dividendo, int[] divisor,int[] Exceso)
        {
            int[] aux = new int[dividendo.Length];
            if (dividendo.Length == divisor.Length)
            {
                for (int i = 0; i < dividendo.Length; i++)
                {
                    aux[i] = Math.DivRem(dividendo[i], divisor[i], out Exceso[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static int[,] EDivRem(int[,] dividendo, int[,] divisor, int[,] Exceso)
        {
            //exceso va aguardar la cantidad sobrante de las divisiones
            //por lo que resulta indispensable que sea del mismo tamaño que 
            //dividendo y divisor
            int[,] aux = new int[dividendo.GetLength(0),dividendo.GetLength(1)];
            if (dividendo.GetLength(0) == divisor.GetLength(0)&& dividendo.GetLength(1) == divisor.GetLength(1))
            {
                for (int i = 0; i < divisor.GetLength(0); i++)
                {
                    for (int a = 0; a < divisor.GetLength(1); a++)
                    {
                        aux[i, a] = Math.DivRem(dividendo[i, a], divisor[i, a],out Exceso[i,a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static long EDivRem(long dividendo, long divisor, out long Exceso)
        {
            return Math.DivRem(dividendo, divisor, out Exceso);
        }
        public static long[] EDivRem(long[] dividendo, long[] divisor, long[] Exceso)
        {
            long[] aux = new long[dividendo.Length];
            if (dividendo.Length == divisor.Length)
            {
                for (int i = 0; i < dividendo.Length; i++)
                {
                    aux[i] = Math.DivRem(dividendo[i], divisor[i], out Exceso[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static long[,] EDivRem(long[,] dividendo, long[,] divisor, long[,] Exceso)
        {
            //exceso va aguardar la cantidad sobrante de las divisiones
            //por lo que resulta indispensable que sea del mismo tamaño que 
            //dividendo y divisor
            long[,] aux = new long[dividendo.GetLength(0), dividendo.GetLength(1)];
            if (dividendo.GetLength(0) == divisor.GetLength(0) && dividendo.GetLength(1) == divisor.GetLength(1))
            {
                for (int i = 0; i < divisor.GetLength(0); i++)
                {
                    for (int a = 0; a < divisor.GetLength(1); a++)
                    {
                        aux[i, a] = Math.DivRem(dividendo[i, a], divisor[i, a], out Exceso[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }

        public static double EExp(double d)
        {
            return Math.Exp(d);
        }
        public static double[] EExp(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Exp(d[i]);
            }
            return aux;
        }
        public static double[,] EExp(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Exp(value[i, a]);
                }
            }
            return aux;
        }
        public static double EFloor(double d)
        {
            return Math.Floor(d);
        }
        public static double[] EFloor(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Floor(d[i]);
            }
            return aux;
        }
        public static double[,] EFloor(double[,] value)
        {
            double[,] aux = new double[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Floor(value[i, a]);
                }
            }
            return aux;
        }
        public static decimal EFloor(decimal d)
        {
            return Math.Floor(d);
        }
        public static decimal[] EFloor(decimal[] d)
        {
            decimal[] aux = new decimal[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Floor(d[i]);
            }
            return aux;
        }
        public static decimal[,] EFloor(decimal[,] value)
        {
            decimal[,] aux = new decimal[value.GetLength(0), value.GetLength(1)];
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int a = 0; a < value.GetLength(1); a++)
                {
                    aux[i, a] = Math.Floor(value[i, a]);
                }
            }
            return aux;
        }
        public static double EIEEERemainder(double x,double y)
        {
            return Math.IEEERemainder(x,y);
        }
        public static double[] EIEEERemainder(double[] x, double[] y)
        {
            double[] aux = new double[x.Length];
            if (x.Length == y.Length)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    aux[i] = Math.IEEERemainder(x[i], y[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] EIEEERemainder(double[,] x, double[,] y)
        {
            double[,] aux = new double[x.GetLength(0), x.GetLength(1)];
            if (x.GetLength(0) == y.GetLength(0) && x.GetLength(1) == y.GetLength(1))
            {
                for (int i = 0; i < x.GetLength(0); i++)
                {
                    for (int a = 0; a < x.GetLength(1); a++)
                    {
                        aux[i, a] = Math.IEEERemainder(x[i, a], y[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double ELog(double d)
        {
            return Math.Log(d);
        }
        public static double[] ELog(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Log(d[i]);
            }
            return aux;
        }
        public static double[,] ELog(double[,] d)
        {
            double[,] aux = new double[d.GetLength(0), d.GetLength(1)];
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int a = 0; a < d.GetLength(1); a++)
                {
                    aux[i, a] = Math.Log(d[i, a]);
                }
            }
            return aux;
        }
        public static double ELog(double d,double nuevabase)
        {
            return Math.Log(d,nuevabase);
        }
        public static double[] ELog(double[] d, double[] nuevabase)
        {
            double[] aux = new double[d.Length];
            if (d.Length == nuevabase.Length)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    aux[i] = Math.Log(d[i],nuevabase[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] ELog(double[,] d, double[,] nuevabase)
        {
            double[,] aux = new double[d.GetLength(0), d.GetLength(1)];
            if (d.GetLength(0) == nuevabase.GetLength(0) && d.GetLength(1) == nuevabase.GetLength(1))
            {
                for (int i = 0; i < d.GetLength(0); i++)
                {
                    for (int a = 0; a < d.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Log(d[i, a], nuevabase[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double ELog10(double d)
        {
            return Math.Log10(d);
        }
        public static double[] ELog10(double[] d)
        {
            double[] aux = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                aux[i] = Math.Log10(d[i]);
            }
            return aux;
        }
        public static double[,] ELog10(double[,] d)
        {
            double[,] aux = new double[d.GetLength(0), d.GetLength(1)];
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int a = 0; a < d.GetLength(1); a++)
                {
                    aux[i, a] = Math.Log10(d[i, a]);
                }
            }
            return aux;
        }
        public static ulong EMax(ulong val1, ulong val2)
        {
            return Math.Max(val1,val2);
        }
        public static ulong[] EMax (ulong[] val1, ulong[] val2)
        {
            ulong[] aux = new ulong[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static ulong[,] EMax(ulong[,] val1, ulong[,] val2)
        {
            ulong[,] aux = new ulong[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static uint EMax(uint val1, uint val2)
        {
            return Math.Max(val1, val2);
        }
        public static uint[] EMax(uint[] val1, uint[] val2)
        {
            uint[] aux = new uint[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static uint[,] EMax(uint[,] val1, uint[,] val2)
        {
            uint[,] aux = new uint[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static ushort EMax(ushort val1, ushort val2)
        {
            return Math.Max(val1, val2);
        }
        public static ushort[] EMax(ushort[] val1, ushort[] val2)
        {
            ushort[] aux = new ushort[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static ushort[,] EMax(ushort[,] val1, ushort[,] val2)
        {
            ushort[,] aux = new ushort[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static float EMax(float val1, float val2)
        {
            return Math.Max(val1, val2);
        }
        public static float[] EMax(float[] val1, float[] val2)
        {
            float[] aux = new float[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static float[,] EMax(float[,] val1, float[,] val2)
        {
            float[,] aux = new float[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static sbyte EMax(sbyte val1, sbyte val2)
        {
            return Math.Max(val1, val2);
        }
        public static sbyte[] EMax(sbyte[] val1, sbyte[] val2)
        {
            sbyte[] aux = new sbyte[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static sbyte[,] EMax(sbyte[,] val1, sbyte[,] val2)
        {
            sbyte[,] aux = new sbyte[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static byte EMax(byte val1, byte val2)
        {
            return Math.Max(val1, val2);
        }
        public static byte[] EMax(byte[] val1, byte[] val2)
        {
            byte[] aux = new byte[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static byte[,] EMax(byte[,] val1, byte[,] val2)
        {
            byte[,] aux = new byte[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static int EMax(int val1, int val2)
        {
            return Math.Max(val1, val2);
        }
        public static int[] EMax(int[] val1, int[] val2)
        {
            int[] aux = new int[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static int[,] EMax(int[,] val1, int[,] val2)
        {
            int[,] aux = new int[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static short EMax(short val1, short val2)
        {
            return Math.Max(val1, val2);
        }
        public static short[] EMax(short[] val1, short[] val2)
        {
            short[] aux = new short[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static short[,] EMax(short[,] val1, short[,] val2)
        {
            short[,] aux = new short[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double EMax(double val1, double val2)
        {
            return Math.Max(val1, val2);
        }
        public static double[] EMax(double[] val1, double[] val2)
        {
            double[] aux = new double[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] EMax(double[,] val1, double[,] val2)
        {
            double[,] aux = new double[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal EMax(decimal val1, decimal val2)
        {
            return Math.Max(val1, val2);
        }
        public static decimal[] EMax(decimal[] val1, decimal[] val2)
        {
            decimal[] aux = new decimal[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal[,] EMax(decimal[,] val1, decimal[,] val2)
        {
            decimal[,] aux = new decimal[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static long EMax(long val1, long val2)
        {
            return Math.Max(val1, val2);
        }
        public static long[] EMax(long[] val1, long[] val2)
        {
            long[] aux = new long[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Max(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static long[,] EMax(long[,] val1, long[,] val2)
        {
            long[,] aux = new long[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Max(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        //////////////////////
        ///
        public static ulong EMin(ulong val1, ulong val2)
        {
            return Math.Min(val1, val2);
        }
        public static ulong[] EMin(ulong[] val1, ulong[] val2)
        {
            ulong[] aux = new ulong[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static ulong[,] EMin(ulong[,] val1, ulong[,] val2)
        {
            ulong[,] aux = new ulong[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static uint EMin(uint val1, uint val2)
        {
            return Math.Min(val1, val2);
        }
        public static uint[] EMin(uint[] val1, uint[] val2)
        {
            uint[] aux = new uint[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static uint[,] EMin(uint[,] val1, uint[,] val2)
        {
            uint[,] aux = new uint[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static ushort EMin(ushort val1, ushort val2)
        {
            return Math.Min(val1, val2);
        }
        public static ushort[] EMin(ushort[] val1, ushort[] val2)
        {
            ushort[] aux = new ushort[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static ushort[,] EMin(ushort[,] val1, ushort[,] val2)
        {
            ushort[,] aux = new ushort[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static float EMin(float val1, float val2)
        {
            return Math.Min(val1, val2);
        }
        public static float[] EMin(float[] val1, float[] val2)
        {
            float[] aux = new float[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static float[,] EMin(float[,] val1, float[,] val2)
        {
            float[,] aux = new float[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static sbyte EMin(sbyte val1, sbyte val2)
        {
            return Math.Min(val1, val2);
        }
        public static sbyte[] EMin(sbyte[] val1, sbyte[] val2)
        {
            sbyte[] aux = new sbyte[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static sbyte[,] EMin(sbyte[,] val1, sbyte[,] val2)
        {
            sbyte[,] aux = new sbyte[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static byte EMin(byte val1, byte val2)
        {
            return Math.Min(val1, val2);
        }
        public static byte[] EMin(byte[] val1, byte[] val2)
        {
            byte[] aux = new byte[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static byte[,] EMin(byte[,] val1, byte[,] val2)
        {
            byte[,] aux = new byte[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static int EMin(int val1, int val2)
        {
            return Math.Min(val1, val2);
        }
        public static int[] EMin(int[] val1, int[] val2)
        {
            int[] aux = new int[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static int[,] EMin(int[,] val1, int[,] val2)
        {
            int[,] aux = new int[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static short EMin(short val1, short val2)
        {
            return Math.Min(val1, val2);
        }
        public static short[] EMin(short[] val1, short[] val2)
        {
            short[] aux = new short[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static short[,] EMin(short[,] val1, short[,] val2)
        {
            short[,] aux = new short[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double EMin(double val1, double val2)
        {
            return Math.Min(val1, val2);
        }
        public static double[] EMin(double[] val1, double[] val2)
        {
            double[] aux = new double[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] EMin(double[,] val1, double[,] val2)
        {
            double[,] aux = new double[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal EMin(decimal val1, decimal val2)
        {
            return Math.Min(val1, val2);
        }
        public static decimal[] EMin(decimal[] val1, decimal[] val2)
        {
            decimal[] aux = new decimal[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal[,] EMin(decimal[,] val1, decimal[,] val2)
        {
            decimal[,] aux = new decimal[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static long EMin(long val1, long val2)
        {
            return Math.Min(val1, val2);
        }
        public static long[] EMin(long[] val1, long[] val2)
        {
            long[] aux = new long[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Min(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static long[,] EMin(long[,] val1, long[,] val2)
        {
            long[,] aux = new long[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Min(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double EPow(double val1, double val2)
        {
            return Math.Pow(val1, val2);
        }
        public static double[] EPow(double[] val1, double[] val2)
        {
            double[] aux = new double[val1.Length];
            if (val1.Length == val2.Length)
            {
                for (int i = 0; i < val1.Length; i++)
                {
                    aux[i] = Math.Pow(val1[i], val2[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] EPow(double[,] val1, double[,] val2)
        {
            double[,] aux = new double[val1.GetLength(0), val1.GetLength(1)];
            if (val1.GetLength(0) == val2.GetLength(0) && val1.GetLength(1) == val2.GetLength(1))
            {
                for (int i = 0; i < val1.GetLength(0); i++)
                {
                    for (int a = 0; a < val1.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Pow(val1[i, a], val2[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }

        public static decimal ERound(decimal numero, int decimales, MidpointRounding modo)
        {
            return Math.Round(numero,decimales,modo);
        }
        public static decimal[] ERound(decimal[] numero, int[] decimales, MidpointRounding[] modo)
        {
            decimal[] aux = new decimal[numero.Length];
            if (numero.Length == decimales.Length)
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    aux[i] = Math.Round(numero[i],decimales[i],modo[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal[,] ERound(decimal[,] numero, int[,] decimales, MidpointRounding[,] modo)
        {
            decimal[,] aux = new decimal[numero.GetLength(0),numero.GetLength(1)];
            if (numero.GetLength(0) == decimales.GetLength(0) && numero.GetLength(1) == decimales.GetLength(1))
            {
                for (int i = 0; i < numero.GetLength(0); i++)
                {
                    for (int a = 0; a < numero.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Round(numero[i, a], decimales[i, a],modo[i,a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double ERound(double numero, int decimales, MidpointRounding modo)
        {
            return Math.Round(numero, decimales, modo);
        }
        public static double[] ERound(double[] numero, int[] decimales, MidpointRounding[] modo)
        {
            double[] aux = new double[numero.Length];
            if (numero.Length == decimales.Length)
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    aux[i] = Math.Round(numero[i], decimales[i], modo[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] ERound(double[,] numero, int[,] decimales, MidpointRounding[,] modo)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            if (numero.GetLength(0) == decimales.GetLength(0) && numero.GetLength(1) == decimales.GetLength(1))
            {
                for (int i = 0; i < numero.GetLength(0); i++)
                {
                    for (int a = 0; a < numero.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Round(numero[i,a],decimales[i,a],modo[i,a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double ERound(double numero, MidpointRounding modo)
        {
            return Math.Round(numero, modo);
        }
        public static double[] ERound(double[] numero, MidpointRounding[] modo)
        {
            double[] aux = new double[numero.Length];
            if (numero.Length == modo.Length)
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    aux[i] = Math.Round(numero[i], modo[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] ERound(double[,] numero, MidpointRounding[,] modo)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            if (numero.GetLength(0) == modo.GetLength(0) && numero.GetLength(1) == modo.GetLength(1))
            {
                for (int i = 0; i < numero.GetLength(0); i++)
                {
                    for (int a = 0; a < numero.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Round(numero[i, a], modo[i,a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double ERound(double numero, int digitos)
        {
            return Math.Round(numero, digitos);
        }
        public static double[] ERound(double[] numero, int[] digitos)
        {
            double[] aux = new double[numero.Length];
            if (numero.Length == digitos.Length)
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    aux[i] = Math.Round(numero[i], digitos[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static double[,] ERound(double[,] numero, int[,] digitos)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            if (numero.GetLength(0) == digitos.GetLength(0) && numero.GetLength(1) == digitos.GetLength(1))
            {
                for (int i = 0; i < numero.GetLength(0); i++)
                {
                    for (int a = 0; a < numero.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Round(numero[i, a], digitos[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static double ERound(double numero)
        {
            return Math.Round(numero);
        }
        public static double[] ERound(double[] numero)
        {
            double[] aux = new double[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Round(numero[i]);
            }
            return aux;
        }
        public static double[,] ERound(double[,] numero)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Round(numero[i, a]);
                }
            }
            return aux;
        }
        public static decimal ERound(decimal numero, int decimales)
        {
            return Math.Round(numero, decimales);
        }
        public static decimal[] ERound(decimal[] numero, int[] decimales)
        {
            decimal[] aux = new decimal[numero.Length];
            if (numero.Length == decimales.Length)
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    aux[i] = Math.Round(numero[i], decimales[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal[,] ERound(decimal[,] numero, int[,] decimales)
        {
            decimal[,] aux = new decimal[numero.GetLength(0), numero.GetLength(1)];
            if (numero.GetLength(0) == decimales.GetLength(0) && numero.GetLength(1) == decimales.GetLength(1))
            {
                for (int i = 0; i < numero.GetLength(0); i++)
                {
                    for (int a = 0; a < numero.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Round(numero[i, a], decimales[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal ERound(decimal numero)
        {
            return Math.Round(numero);
        }
        public static decimal[] ERound(decimal[] numero)
        {
            decimal[] aux = new decimal[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Round(numero[i]);
            }
            return aux;
        }
        public static decimal[,] ERound(decimal[,] numero)
        {
            decimal[,] aux = new decimal[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Round(numero[i, a]);
                }
            }
            return aux;
        }
        public static decimal ERound(decimal numero, MidpointRounding modo)
        {
            return Math.Round(numero, modo);
        }
        public static decimal[] ERound(decimal[] numero, MidpointRounding[] modo)
        {
            decimal[] aux = new decimal[numero.Length];
            if (numero.Length == modo.Length)
            {
                for (int i = 0; i < numero.Length; i++)
                {
                    aux[i] = Math.Round(numero[i], modo[i]);
                }
                return aux;
            }
            else
                return aux;
        }
        public static decimal[,] ERound(decimal[,] numero, MidpointRounding[,] modo)
        {
            decimal[,] aux = new decimal[numero.GetLength(0), numero.GetLength(1)];
            if (numero.GetLength(0) == modo.GetLength(0) && numero.GetLength(1) == modo.GetLength(1))
            {
                for (int i = 0; i < numero.GetLength(0); i++)
                {
                    for (int a = 0; a < numero.GetLength(1); a++)
                    {
                        aux[i, a] = Math.Round(numero[i, a], modo[i, a]);
                    }
                }
                return aux;
            }
            else
                return aux;
        }
        public static float ESign(float numero)
        {
            return Math.Sign(numero);
        }
        public static float[] ESign(float[] numero)
        {
            float[] aux = new float[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sign(numero[i]);
            }
            return aux;
        }
        public static float[,] ESign(float[,] numero)
        {
            float[,] aux = new float[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sign(numero[i, a]);
                }
            }
            return aux;
        }
        public static int ESign(int numero)
        {
            return Math.Sign(numero);
        }
        public static int[] ESign(int[] numero)
        {
            int[] aux = new int[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sign(numero[i]);
            }
            return aux;
        }
        public static int[,] ESign(int[,] numero)
        {
            int[,] aux = new int[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sign(numero[i, a]);
                }
            }
            return aux;
        }
        public static long ESign(long numero)
        {
            return Math.Sign(numero);
        }
        public static long[] ESign(long[] numero)
        {
            long[] aux = new long[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sign(numero[i]);
            }
            return aux;
        }
        public static long[,] ESign(long[,] numero)
        {
            long[,] aux = new long[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sign(numero[i, a]);
                }
            }
            return aux;
        }
        public static int ESign(double numero)
        {
            return Math.Sign(numero);
        }
        public static int[] ESign(double[] numero)
        {
            int[] aux = new int[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sign(numero[i]);
            }
            return aux;
        }
        public static int[,] ESign(double[,] numero)
        {
            int[,] aux = new int[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sign(numero[i, a]);
                }
            }
            return aux;
        }
        public static int ESign(decimal numero)
        {
            return Math.Sign(numero);
        }
        public static int[] ESign(decimal[] numero)
        {
            int[] aux = new int[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sign(numero[i]);
            }
            return aux;
        }
        public static int[,] ESign(decimal[,] numero)
        {
            int[,] aux = new int[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sign(numero[i, a]);
                }
            }
            return aux;
        }
        public static int ESign(short numero)
        {
            return Math.Sign(numero);
        }
        public static int[] ESign(short[] numero)
        {
            int[] aux = new int[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sign(numero[i]);
            }
            return aux;
        }
        public static int[,] ESign(short[,] numero)
        {
            int[,] aux = new int[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sign(numero[i, a]);
                }
            }
            return aux;
        }

        public static double ESin(double numero)
        {
            return Math.Sin(numero);
        }
        public static double[] ESin(double[] numero)
        {
            double[] aux = new double[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sin(numero[i]);
            }
            return aux;
        }
        public static double[,] ESin(double[,] numero)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sin(numero[i, a]);
                }
            }
            return aux;
        }
        public static double ESinh(double numero)
        {
            return Math.Sinh(numero);
        }
        public static double[] ESinh(double[] numero)
        {
            double[] aux = new double[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sinh(numero[i]);
            }
            return aux;
        }
        public static double[,] ESinh(double[,] numero)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sinh(numero[i, a]);
                }
            }
            return aux;
        }
        public static double ESqrt(double numero)
        {
            return Math.Sqrt(numero);
        }
        public static double[] ESqrt(double[] numero)
        {
            double[] aux = new double[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Sqrt(numero[i]);
            }
            return aux;
        }
        public static double[,] ESqrt(double[,] numero)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Sqrt(numero[i, a]);
                }
            }
            return aux;
        }
        public static double ETan(double numero)
        {
            return Math.Tan(numero);
        }
        public static double[] ETan(double[] numero)
        {
            double[] aux = new double[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Tan(numero[i]);
            }
            return aux;
        }
        public static double[,] ETan(double[,] numero)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Tan(numero[i, a]);
                }
            }
            return aux;
        }
        public static double ETanh(double numero)
        {
            return Math.Tanh(numero);
        }
        public static double[] ETanh(double[] numero)
        {
            double[] aux = new double[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Tanh(numero[i]);
            }
            return aux;
        }
        public static double[,] ETanh(double[,] numero)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Tanh(numero[i, a]);
                }
            }
            return aux;
        }
        public static decimal ETruncate(decimal numero)
        {
            return Math.Truncate(numero);
        }
        public static decimal[] ETruncate(decimal[] numero)
        {
            decimal[] aux = new decimal[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Truncate(numero[i]);
            }
            return aux;
        }
        public static decimal[,] ETruncate(decimal[,] numero)
        {
            decimal[,] aux = new decimal[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Truncate(numero[i, a]);
                }
            }
            return aux;
        }
        public static double ETruncate(double numero)
        {
            return Math.Truncate(numero);
        }
        public static double[] ETruncate(double[] numero)
        {
            double[] aux = new double[numero.Length];
            for (int i = 0; i < numero.Length; i++)
            {
                aux[i] = Math.Truncate(numero[i]);
            }
            return aux;
        }
        public static double[,] ETruncate(double[,] numero)
        {
            double[,] aux = new double[numero.GetLength(0), numero.GetLength(1)];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int a = 0; a < numero.GetLength(1); a++)
                {
                    aux[i, a] = Math.Truncate(numero[i, a]);
                }
            }
            return aux;
        }
    }

}
