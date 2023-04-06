using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrianguloMagico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ValorUsuario = 0;
            List<Numeros> NumerosDisponibles = new List<Numeros>();
            List<Numeros> ResultadoTriangulo = new List<Numeros>();

            bool resultado = Int32.TryParse(cmbNumero.Text, out ValorUsuario);
            if (resultado == false)
            {
                MessageBox.Show("No se ha introducido ningun numero");
            }
            else
            {
                //Se crean las listas de numeros disponibles y la lista modificable  
                //Con el primer valor del usuario en su primera posición
                CrearListaNumeros(ValorUsuario, NumerosDisponibles, ResultadoTriangulo);
                /// Se llena el texto A con el primer element en la lista Resultado triangulo
                txtBoxA.Text = ResultadoTriangulo.ElementAt(0).Numero.ToString();
                //Marcamos el numero seleccionado por el usuario como ocupado
                MarcarNoDisponible(NumerosDisponibles, ValorUsuario);
                ResolverAcertijo(NumerosDisponibles, ResultadoTriangulo);
                
            }
            NumerosDisponibles.RemoveRange(0, NumerosDisponibles.Count);
            ResultadoTriangulo.RemoveRange(0,ResultadoTriangulo.Count);
                    }
        
        void CrearListaNumeros(int numero,List<Numeros> Numero,List<Numeros> Resultado)
        {

            Numero.Add(new Numeros { Numero = 1, Disponible = true });
            Numero.Add(new Numeros { Numero = 2, Disponible = true });
            Numero.Add(new Numeros { Numero = 3, Disponible = true });
            Numero.Add(new Numeros { Numero = 4, Disponible = true });
            Numero.Add(new Numeros { Numero = 5, Disponible = true });
            Numero.Add(new Numeros { Numero = 6, Disponible = true });
            Resultado.Add(new Numeros { Numero = numero, Disponible = false });
        }
        void MarcarNoDisponible(List<Numeros> NumerosDisponibles, int NumeroOcupado)
        {
            foreach (Numeros NumeroD in NumerosDisponibles)
            {
                if(NumeroD.Numero == NumeroOcupado)
                {
                    NumeroD.Disponible = false;
                }
            }
        }
        void MarcarSiDisponible(List<Numeros> NumerosDisponibles, int NumeroDisponible)
        {
            foreach (Numeros NumeroD in NumerosDisponibles)
            {
                if (NumeroD.Numero == NumeroDisponible)
                {
                    NumeroD.Disponible = true;
                }
            }
        }
        bool BuscarDisponibilidad(int ValorABuscar,List<Numeros> NumerosDisponibles) 
        {
            foreach (Numeros numero in NumerosDisponibles)
            {
                if (numero.Numero == ValorABuscar)
                {
                    return numero.Disponible;
                }
            }
            return false;
        }
        int MayorDisponible(List<Numeros> NumerosDisponibles,int NumeroABuscar)
        {
            foreach(Numeros numero in NumerosDisponibles)
            {
                if(numero.Numero > NumeroABuscar && numero.Disponible == true)
                {
                    return numero.Numero;
                }
            }
            return 0;
        }
        int MenorDisponible(List<Numeros> NumerosDisponibles, int NumeroABuscar)
        {
            foreach (Numeros numero in NumerosDisponibles)
            {
                if (numero.Numero < NumeroABuscar && numero.Disponible == true)
                {
                    return numero.Numero;
                }
            }
            return 0;
        }
        int MenorDisponibleMasCercano(List<Numeros> NumerosDisponibles, int NumeroABuscar)
        {
            List<Numeros> numerosAlreves = new List<Numeros>();
            numerosAlreves.Add(NumerosDisponibles.ElementAt(5));
            numerosAlreves.Add(NumerosDisponibles.ElementAt(4));
            numerosAlreves.Add(NumerosDisponibles.ElementAt(3));
            numerosAlreves.Add(NumerosDisponibles.ElementAt(2));
            numerosAlreves.Add(NumerosDisponibles.ElementAt(1));
            numerosAlreves.Add(NumerosDisponibles.ElementAt(0));
            foreach (Numeros numero in numerosAlreves)
            {
                if (numero.Numero < NumeroABuscar && numero.Disponible == true)
                {
                    return numero.Numero;
                }
            }
            return 0;
        }
        int EvaluarSumaLinea(List<Numeros> Resultado,int linea)
        {
            int suma = 0;
            if (linea == 1)
            {
                suma = Resultado.ElementAt(0).Numero + Resultado.ElementAt(1).Numero + Resultado.ElementAt(2).Numero;
            }
            if (linea == 2)
            {
                suma = Resultado.ElementAt(2).Numero + Resultado.ElementAt(3).Numero + Resultado.ElementAt(4).Numero;
            }
            if (linea == 3)
            {
                suma = Resultado.ElementAt(0).Numero + Resultado.ElementAt(5).Numero + Resultado.ElementAt(4).Numero;
            }
            return suma;
        }
         void ResolverAcertijo(List<Numeros> NumeroDisponible, List<Numeros> ResultadoTriangulo)
        {
            for(int i = 0; i < NumeroDisponible.Count; i++)
            {
                ///Codigo posiciones en esquinas
                if (i == 0)
                {
                    int ValorR = ResultadoTriangulo.ElementAt(i).Numero;
                    int MaximoDisponible = MayorDisponible(NumeroDisponible,ValorR);
                    if(MaximoDisponible == 0)
                    {
                        MarcarSiDisponible(NumeroDisponible, ValorR);
                        ResultadoTriangulo.ElementAt(i).Numero = MenorDisponibleMasCercano(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                        MarcarNoDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                        txtBoxA.Text = ResultadoTriangulo.ElementAt(i).Numero.ToString();
                        i--;
                        
                    }
                    else
                    { 
                        ResultadoTriangulo.Add(new Numeros { Numero = MaximoDisponible,Disponible = false});
                        MarcarNoDisponible(NumeroDisponible,MaximoDisponible);
                        txtBoxB.Text = ResultadoTriangulo.ElementAt(i+1).Numero.ToString();
                    }
                }
                if (i == 2)
                {
                    int ValorR = ResultadoTriangulo.ElementAt(i).Numero;
                    int MaximoDisponible = MayorDisponible(NumeroDisponible, ValorR);
                    ResultadoTriangulo.Add(new Numeros { Numero = MaximoDisponible, Disponible = false });
                    MarcarNoDisponible(NumeroDisponible, MaximoDisponible);
                    txtBoxD.Text = ResultadoTriangulo.ElementAt(i + 1).Numero.ToString();
                }
                if (i == 4)
                {
                    int ValorR = ResultadoTriangulo.ElementAt(i).Numero;
                    int MaximoDisponible = MayorDisponible(NumeroDisponible, ValorR);
                    ResultadoTriangulo.Add(new Numeros { Numero = MaximoDisponible, Disponible = false });
                    MarcarNoDisponible(NumeroDisponible, MaximoDisponible);
                    txtBoxF.Text = ResultadoTriangulo.ElementAt(i + 1).Numero.ToString();
                }
                //Codigo posiciones en el centro
                if (i == 1)
                {
                    int ValorR = ResultadoTriangulo.ElementAt(i).Numero;
                    int NumeroMenor = MenorDisponible(NumeroDisponible, ValorR);
                    if (NumeroMenor == 0)
                    {
                        MarcarSiDisponible(NumeroDisponible, ValorR);
                        ResultadoTriangulo.ElementAt(i).Numero = MayorDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                        MarcarNoDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                        txtBoxB.Text = ResultadoTriangulo.ElementAt(i).Numero.ToString();
                        i--;
                    }
                    else
                    {
                        ResultadoTriangulo.Add(new Numeros { Numero = NumeroMenor, Disponible = false });
                        MarcarNoDisponible(NumeroDisponible, NumeroMenor);
                        txtBoxC.Text = ResultadoTriangulo.ElementAt(i + 1).Numero.ToString();
                        while (EvaluarSumaLinea(ResultadoTriangulo,1) != 9)
                        {
                            if(EvaluarSumaLinea(ResultadoTriangulo, 1) < 9)
                            {
                                MarcarSiDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                                ResultadoTriangulo.ElementAt(i).Numero = MayorDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                                MarcarNoDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                                txtBoxB.Text = ResultadoTriangulo.ElementAt(i).Numero.ToString();
                            }
                            if (EvaluarSumaLinea(ResultadoTriangulo, 1) > 9)
                            {
                                if(ResultadoTriangulo.ElementAt(i-1).Numero > ResultadoTriangulo.ElementAt(i + 1).Numero)
                                {
                                    MarcarSiDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i-1).Numero);
                                    ResultadoTriangulo.ElementAt(i - 1).Numero = MenorDisponibleMasCercano(NumeroDisponible, ResultadoTriangulo.ElementAt(i - 1).Numero);
                                    MarcarNoDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i - 1).Numero);
                                    txtBoxA.Text = ResultadoTriangulo.ElementAt(i - 1).Numero.ToString();
                                }
                                else
                                {
                                    MarcarSiDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i + 1).Numero);
                                    ResultadoTriangulo.ElementAt(i + 1).Numero = MenorDisponibleMasCercano(NumeroDisponible, ResultadoTriangulo.ElementAt(i + 1).Numero);
                                    MarcarNoDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i - 1).Numero);
                                    txtBoxC.Text = ResultadoTriangulo.ElementAt(i + 1).Numero.ToString();
                                }
                            }
                        }
                    }
                }
                if (i == 3)
                {
                    int ValorR = ResultadoTriangulo.ElementAt(i).Numero;
                    int NumeroMenor = MenorDisponible(NumeroDisponible, ValorR);
                    if (NumeroMenor == 0)
                    {
                        MarcarSiDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                        ResultadoTriangulo.ElementAt(i).Numero = MayorDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                        MarcarNoDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                        txtBoxD.Text = ResultadoTriangulo.ElementAt(i).Numero.ToString();
                        i--;
                    }
                    else
                    {
                        ResultadoTriangulo.Add(new Numeros { Numero = NumeroMenor, Disponible = false });
                        MarcarNoDisponible(NumeroDisponible, NumeroMenor);
                        txtBoxE.Text = ResultadoTriangulo.ElementAt(i + 1).Numero.ToString();
                        while (EvaluarSumaLinea(ResultadoTriangulo, 2) != 9)
                        {
                            if (EvaluarSumaLinea(ResultadoTriangulo, 2) < 9)
                            {
                                MarcarSiDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                                ResultadoTriangulo.ElementAt(i).Numero = MayorDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                                MarcarNoDisponible(NumeroDisponible, ResultadoTriangulo.ElementAt(i).Numero);
                                txtBoxD.Text = ResultadoTriangulo.ElementAt(i).Numero.ToString();
                            }
                        }
                    }
                }
                if (i == 5)
                {
                    int suma = EvaluarSumaLinea(ResultadoTriangulo, 1) + EvaluarSumaLinea(ResultadoTriangulo, 2) + EvaluarSumaLinea(ResultadoTriangulo, 3);
                    if (suma/3 == 9)
                    {
                        txtPrueba.Text = "Triangulo resuelto Todos los lados suman 9";
                    }
                }
            }
        }
    }
}
