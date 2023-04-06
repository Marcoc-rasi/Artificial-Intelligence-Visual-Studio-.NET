using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_en_equilibrio__Con_3_cargas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnResolver_Click(object sender, EventArgs e)
        {
            Carga C1 = new Carga(Convert.ToDouble(txtCx1.Text), Convert.ToDouble(txtCy1.Text), Convert.ToDouble(txtCarga1.Text));
            Carga C2 = new Carga(Convert.ToDouble(txtCx2.Text), Convert.ToDouble(txtCy2.Text), Convert.ToDouble(txtCarga2.Text));
            Carga C3 = new Carga(Convert.ToDouble(txtCx3.Text), Convert.ToDouble(txtCy3.Text), Convert.ToDouble(txtCarga3.Text));
            Carga CP = new Carga(Convert.ToDouble(txtCargaP.Text));

            double k = 9e9;
            double f1 = 0;
            double f2 = 0;
            double f3 = 0;
            double distanciaX = 0;
            double inicioy = 0;
            double distanciaY = 0;

            if (C2.X < C3.X)
            {
                distanciaX = C2.X;
            }
            else
            {
                distanciaX = C3.X;
            }

            if (C2.Y < 0)
            {
                if (C2.Y < C3.Y)
                {
                    inicioy = C2.Y;
                    if (C3.Y < 0)
                    {
                        distanciaY = -C2.Y;
                    }
                    else
                    {
                        distanciaY = -C2.Y + C3.Y;
                    }
                }
            }
            else
            {
                if (C2.Y < C3.Y)
                {
                    inicioy = 0;
                    distanciaY = C3.Y;
                }
                else
                {
                    if (C3.Y < 0)
                    {
                        inicioy = C3.Y;
                        distanciaY = -C3.Y + C2.Y;
                    }
                    else
                    {
                        inicioy = 0;
                        distanciaY = C2.Y;
                    }
                }
            }

            for (double i = 0; i <= distanciaX; i += 0.0001)
            {

                if (C1.C < 0)
                {
                    f1 = k * ((C1.C * CP.C) / (i * i));
                }
                else
                {
                    f1 = -(k * ((C1.C * CP.C) / (i * i)));
                }

                if (C2.C < 0)
                {
                    if (C2.X < i)
                    {
                        f2 = k * ((C2.C * CP.C) / ((i-C2.X) * (i-C2.X)));
                    }
                    else
                    {
                        f1 = -(k * ((C2.C * CP.C) / ((C2.X-i) * (C2.X-i))));
                    }
                }
                else
                {
                    if (C2.X < i)
                    {
                        f2 = k * ((C2.C * CP.C) / ((i - C2.X) * (i - C2.X)));
                    }
                    else
                    {
                        f1 = -(k * ((C2.C * CP.C) / ((C2.X-i) * (C2.X-i))));
                    }
                }

                if (C3.C < 0)
                {
                    if (C3.X < i)
                    {
                        f3 = k * ((C3.C * CP.C) / ((i - C3.X) * (i - C3.X)));
                    }
                    else
                    {
                        f3 = -(k * ((C3.C * CP.C) / ((C3.X - i) * (C3.X - i))));
                    }
                }
                else
                {
                    if (C3.X < i)
                    {
                        f3 = k * ((C3.C * CP.C) / ((i - C3.X) * (i - C3.X)));
                    }
                    else
                    {
                        f3 = -(k * ((C3.C * CP.C) / ((C3.X - i) * (C3.X - i))));
                    }
                }
                if (f1 + f2 + f3 <0.01 || f1 + f2 + f3 < 0.01)
                {
                    txtCxP.Text = Convert.ToString(i);
                }
            }
            for (double i = inicioy; i <= distanciaY; i += 0.0001)
            {
                if (C1.C < 0)
                {
                    if (i < 0)
                    {
                        f1 = k * ((C1.C * CP.C) / (i * i));
                    }
                    else
                    {
                        f1 = -(k * ((C1.C * CP.C) / (i * i)));
                    }
                }
                else
                {
                    if (i < 0)
                    {
                        f1 = k * ((C1.C * CP.C) / (i * i));
                    }
                    else
                    {
                        f1 = -(k * ((C1.C * CP.C) / (i * i)));
                    }
                }
                if (C2.C < 0)
                {
                    if (i < 0 && i<C2.Y)
                    {
                        f2 = k * ((C2.C * CP.C) / ((-i+C2.Y)*(-i + C2.Y)));
                    }
                    else
                    {
                        if(C2.Y<i && i<0)
                        f2 = -(k * ((C2.C * CP.C) / ((-C2.Y+i)*(-C2.Y + i))));
                        else
                        {
                            f2 = -(k * ((C2.C * CP.C) / ((-C2.Y + i) * (-C2.Y + i))));
                        }

                    }
                }
                else
                {
                    if (i < 0 && i < C2.Y)
                    {
                        f2 = k * ((C2.C * CP.C) / ((-i + C2.Y) * (-i + C2.Y)));
                    }
                    else
                    {
                        if (C2.Y < i && i < 0)
                            f2 = -(k * ((C2.C * CP.C) / ((-C2.Y + i) * (-C2.Y + i))));
                        else
                        {
                            f2 = -(k * ((C2.C * CP.C) / ((-C2.Y + i) * (-C2.Y + i))));
                        }

                    }
                }

                if (C3.C < 0)
                {
                    if (i < 0 && i < C3.Y)
                    {
                        f3 = k * ((C3.C * CP.C) / ((-i + C3.Y) * (-i + C3.Y)));
                    }
                    else
                    {
                        if (C3.Y < i && i < 0)
                            f3 = -(k * ((C3.C * CP.C) / ((-C3.Y + i) * (-C3.Y + i))));
                        else
                        {
                            f3 = -(k * ((C3.C * CP.C) / ((-C3.Y + i) * (-C3.Y + i))));
                        }

                    }
                }
                else
                {
                    if (i < 0 && i < C3.Y)
                    {
                        f3 = k * ((C3.C * CP.C) / ((-i + C3.Y) * (-i + C3.Y)));
                    }
                    else
                    {
                        if (C3.Y < i && i < 0)
                            f3 = -(k * ((C3.C * CP.C) / ((-C3.Y + i) * (-C3.Y + i))));
                        else
                        {
                            f3 = -(k * ((C3.C * CP.C) / ((-C3.Y + i) * (-C3.Y + i))));
                        }

                    }
                }
                if (f1 + f2 + f3 < 0.01 || f1 + f2 + f3 < 0.01)
                {
                    txtCyP.Text = Convert.ToString(e);
                }
            }

        }
    }
}

