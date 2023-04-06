using System;
using System.Collections.Generic;
using System.Text;

namespace Exodo
{
    public class Gauss
    {
        #region Variables
        private double mean, var, std;
        private double xmax, xmin;
        #endregion

        #region Constructor
        public Gauss()
        {
            this.mean = 0;
            this.var = 1;
            this.std = 1;
            MaxMin(mean, std, out this.xmin, out this.xmax);
        }

        public Gauss(double mean, double std)
        {
            if (std == 0)
            {
                this.mean = mean;
                this.std = 1;
                this.var = 1;
                MaxMin(mean, std, out this.xmin, out this.xmax);
            }
            else {
                this.mean = mean;
                this.std = std;
                this.var = Math.Pow(std, 2);
                MaxMin(mean, std, out this.xmin, out this.xmax);
            }
        }
        #endregion

        #region Accesos
        /// <summary>
        /// Retorna la media del objeto
        /// </summary>
        public double Gmean
        {
            get
            {
                return this.mean;
            }
        }
        /// <summary>
        /// Retorna la varianza del objeto
        /// </summary>
        public double Gvar
        {
            get
            {
                return this.var;
            }
        }
        /// <summary>
        /// Retorna la desviacion estandar del objeto
        /// </summary>
        public double Gstd
        {
            get
            {
                return this.std;
            }
        }
        /// <summary>
        /// Retorna el valor  x maximo del objeto
        /// </summary>
        public double Gxmax
        {
            get
            {
                return this.xmax;
            }
        }
        /// <summary>
        /// Retorna el valor x minimo del objeto
        /// </summary>
        public double Gxmin
        {
            get
            {
                return this.xmin;
            }
        }
        #endregion

        #region Metodos Privados
        private void MaxMin(double mean, double std, out double min, out double max)
        {
            min = mean - 4 * std;
            max = mean + 4 * std;
        }
        #endregion

        #region Metodos Publicos
        public double Likelihood(double xValue)
        {
            if (mean == 0 && std == 0)
            {
                return 0;
            }
            else
            {
                return (1 / (this.std * Math.Sqrt(2 * Math.PI))) * Math.Exp(-0.5 * Math.Pow(((xValue - this.mean) / this.std), 2));
            }
        }
        #endregion
    }
}
