using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exodo;
using SpreadsheetLight;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace SeparadorDeGrupos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class EcuacionRecta
        {
            public string nombre;
            public double m;
            public double b;
            public EcuacionRecta(double M,double B,string n)
            {
                m= M;
                b= B;
                nombre = n;
            }
        }
        public class GruposDeDtos
        {
            public string nombre;
            public Color color;
            public List<PointF> PuntosDelGrupo = new List<PointF>();
            public GruposDeDtos(Color c,string n)
            {
                color = c;
                nombre = n;
            }
        }
        public static double EvaluarRecta(EcuacionRecta recta, double x)
        {
            double y = recta.m * x + recta.b;
            return y;
        }
        private static void plotini(Chart chartGraficaGrupos)
        {
            chartGraficaGrupos.Series[0].ChartType = SeriesChartType.Bubble;
            chartGraficaGrupos.Series[0].IsVisibleInLegend = false;
            
            chartGraficaGrupos.Series[1].ChartType = SeriesChartType.Bubble;
            chartGraficaGrupos.Series[1].IsVisibleInLegend = false;

            chartGraficaGrupos.Series[2].ChartType = SeriesChartType.Bubble;
            chartGraficaGrupos.Series[2].IsVisibleInLegend = false;

            chartGraficaGrupos.Series[3].ChartType = SeriesChartType.Bubble;
            chartGraficaGrupos.Series[3].IsVisibleInLegend = false;

            chartGraficaGrupos.Series[4].ChartType = SeriesChartType.Bubble;
            chartGraficaGrupos.Series[4].IsVisibleInLegend = false;

            chartGraficaGrupos.Series[5].ChartType = SeriesChartType.Bubble;
            chartGraficaGrupos.Series[5].IsVisibleInLegend = false;
            ///Estos ultimos son las rectas que dividen a los grupos
            chartGraficaGrupos.Series[6].ChartType = SeriesChartType.Spline;
            chartGraficaGrupos.Series[6].IsVisibleInLegend = false;
            chartGraficaGrupos.Series[6].Color = Color.DarkRed;

            chartGraficaGrupos.Series[7].ChartType = SeriesChartType.Spline;
            chartGraficaGrupos.Series[7].IsVisibleInLegend = false;
            chartGraficaGrupos.Series[7].Color = Color.Red;

            chartGraficaGrupos.Series[8].ChartType = SeriesChartType.Spline;
            chartGraficaGrupos.Series[8].IsVisibleInLegend = false;
            chartGraficaGrupos.Series[8].Color = Color.Orange;


        }
        public static PointF[] ObtenerPuntosASeparar(SLDocument DocumentoExcel)
        {
            int renglonPuntos = 3;
            int columnaPuntos = 7;
            while (!string.IsNullOrEmpty(DocumentoExcel.GetCellValueAsString(renglonPuntos, columnaPuntos)))
            {
                renglonPuntos++;
            }
            PointF[] PuntosASeparar = new PointF[renglonPuntos - 3];
            renglonPuntos = 3;


            while (!string.IsNullOrEmpty(DocumentoExcel.GetCellValueAsString(renglonPuntos, columnaPuntos)))
            {
                PuntosASeparar[renglonPuntos - 3].X = Convert.ToSingle(DocumentoExcel.GetCellValueAsDouble(renglonPuntos, columnaPuntos));
                PuntosASeparar[renglonPuntos - 3].Y = Convert.ToSingle(DocumentoExcel.GetCellValueAsDouble(renglonPuntos, columnaPuntos + 1));

                renglonPuntos++;
            }
            return PuntosASeparar;
        }
        public static EcuacionRecta[] ObtenerEcuacionesRectas(SLDocument DocumentoExcel) 
        {
            EcuacionRecta[] EcuacionesDeLasRectas = new EcuacionRecta[3];
            int renglonEcuaciones = 14;
            int ColumnaEcuaciones = 4;
            int PosicionEcuacionRecta = 0;
            int numeroRecta = 1;
            while (!string.IsNullOrEmpty(DocumentoExcel.GetCellValueAsString(renglonEcuaciones, ColumnaEcuaciones)))
            {
                double m = DocumentoExcel.GetCellValueAsDouble(renglonEcuaciones, ColumnaEcuaciones);
                double b = DocumentoExcel.GetCellValueAsDouble(renglonEcuaciones + 1, ColumnaEcuaciones);
                EcuacionesDeLasRectas[PosicionEcuacionRecta] = new EcuacionRecta(m, b, "recta" + Convert.ToString(numeroRecta));
                PosicionEcuacionRecta++;
                ColumnaEcuaciones++;
                numeroRecta++;
            }
            return EcuacionesDeLasRectas;
        }
        public static List<GruposDeDtos> SepararGrupos(PointF[] PuntosASeparar,EcuacionRecta[] EcuacionesDeLasRectas)
        {
            List<GruposDeDtos> DatosSeparadosPorGrupo = new List<GruposDeDtos>();
            GruposDeDtos GrupoAzul = new GruposDeDtos(Color.Blue, "Azul");
            GruposDeDtos GrupoMorado = new GruposDeDtos(Color.Purple, "Morado");
            GruposDeDtos GrupoVerde = new GruposDeDtos(Color.Green, "Verde");
            GruposDeDtos GrupoMarino = new GruposDeDtos(Color.DarkBlue, "AzulMarino");
            GruposDeDtos GrupoRojo = new GruposDeDtos(Color.Red, "Rojo");
            GruposDeDtos GrupoGris = new GruposDeDtos(Color.Gray, "Gris");
            foreach (PointF Punto in PuntosASeparar)
            {
                if (Punto.Y < EvaluarRecta(EcuacionesDeLasRectas[0], Punto.X))
                {
                    if (Punto.Y < EvaluarRecta(EcuacionesDeLasRectas[1], Punto.X))
                    {
                        //pertenece al morado
                        GrupoMorado.PuntosDelGrupo.Add(Punto);
                    }
                    if (Punto.Y > EvaluarRecta(EcuacionesDeLasRectas[2], Punto.X))
                    {
                        //pertenece al verde
                        GrupoVerde.PuntosDelGrupo.Add(Punto);
                    }
                    if (Punto.Y > EvaluarRecta(EcuacionesDeLasRectas[1], Punto.X) && Punto.Y < EvaluarRecta(EcuacionesDeLasRectas[2], Punto.X))
                    {
                        //pertenece al azul
                        GrupoAzul.PuntosDelGrupo.Add(Punto);
                    }
                }
                else
                {
                    if (Punto.Y < EvaluarRecta(EcuacionesDeLasRectas[1], Punto.X))
                    {
                        //pertenece al marino
                        GrupoMarino.PuntosDelGrupo.Add(Punto);
                    }
                    if (Punto.Y > EvaluarRecta(EcuacionesDeLasRectas[2], Punto.X))
                    {
                        //pertenece al gris
                        GrupoGris.PuntosDelGrupo.Add(Punto);
                    }
                    if (Punto.Y > EvaluarRecta(EcuacionesDeLasRectas[1], Punto.X) && Punto.Y < EvaluarRecta(EcuacionesDeLasRectas[2], Punto.X))
                    {
                        //pertenece al rojo
                        GrupoRojo.PuntosDelGrupo.Add(Punto);
                    }
                }
            }
            DatosSeparadosPorGrupo.Add(GrupoAzul);
            DatosSeparadosPorGrupo.Add(GrupoMorado);
            DatosSeparadosPorGrupo.Add(GrupoVerde);
            DatosSeparadosPorGrupo.Add(GrupoMarino);
            DatosSeparadosPorGrupo.Add(GrupoRojo);
            DatosSeparadosPorGrupo.Add(GrupoGris);
            return DatosSeparadosPorGrupo;
        }
        public static void GraficarGrupos(Chart chartGraficaGrupos, List<GruposDeDtos> DatosSeparadosPorGrupo, EcuacionRecta[] EcuacionesDeLasRectas)
        {
            chartGraficaGrupos.Series.Clear();
            int i = 0;
            Series serie = new Series();
            foreach (GruposDeDtos grupo in DatosSeparadosPorGrupo)
            {
                serie = chartGraficaGrupos.Series.Add(grupo.nombre);
                foreach (PointF punto in grupo.PuntosDelGrupo)
                {
                    serie.Points.AddXY(punto.X, punto.Y);
                    //chartGraficaGrupos.DataBindTable(grupo.PuntosDelGrupo);
                }

                chartGraficaGrupos.Series[i].Color = grupo.color;
                i++;
            }
            foreach (EcuacionRecta recta in EcuacionesDeLasRectas)
            {
                serie = chartGraficaGrupos.Series.Add(recta.nombre);
                double[] xRecta = Exodo.Funciones.Linspace(-10, 10, 1);
                double[] yRecta = new double[xRecta.Length];
                xRecta.CopyTo(yRecta, 0);
                Exodo.Recta.Times(recta.m, yRecta);
                Exodo.Recta.Plus(recta.b, yRecta);
                for (int conta = 0; conta < xRecta.Length; conta++)
                {
                    serie.Points.AddXY(xRecta[conta], yRecta[conta]);

                }
                i++;
            }
            plotini(chartGraficaGrupos);
        }
        public static void GuardarGruposEnExcel(SLDocument DocumentoExcel, List<GruposDeDtos> DatosSeparadosPorGrupo,string RutaArchivoExcel)
        {
            DataTable TablaDatos = new DataTable();
            //Columnas
            TablaDatos.Columns.Add("X", typeof(double));
            TablaDatos.Columns.Add("Y", typeof(double));
            int columnagrupos = 9;
            int renglonGrupos = 2;
            foreach (GruposDeDtos GrupoDATOS in DatosSeparadosPorGrupo)
            {
                foreach (PointF punto in GrupoDATOS.PuntosDelGrupo)
                {
                    TablaDatos.Rows.Add(punto.X, punto.Y);
                }
                DocumentoExcel.ImportDataTable(renglonGrupos, columnagrupos, TablaDatos, true);
                columnagrupos += 2;
                TablaDatos.Clear();
            }
            DocumentoExcel.SaveAs(RutaArchivoExcel);
        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            // Se crea el acceso al documento excel de donde sacaremos y guardaremos los datos
            string RutaArchivoExcel = @"C:\Users\Marcos\Documents\Escuela\Temas Selectos De Programacion\Proyecto base\SeparadorDeGrupos\bin\Debug\ExcelGrupos_de_datos.xlsx";
            SLDocument DocumentoExcel = new SLDocument(RutaArchivoExcel);

            // Se obtienen los puntos a separar del documento excel
            PointF[] PuntosASeparar = ObtenerPuntosASeparar(DocumentoExcel);

            // Se obtienen la informacion de las rectas que separaran los grupos
            EcuacionRecta[] EcuacionesDeLasRectas = ObtenerEcuacionesRectas(DocumentoExcel);
            //Se inicializan los grupos, se les da un color y nombre 
            //Se asigna cada grupo a su grupo correspondiente se guardan en una lista
            List<GruposDeDtos> DatosSeparadosPorGrupo = SepararGrupos(PuntosASeparar,EcuacionesDeLasRectas);
            //Agregamos los Puntos al chart, asi como las rectas que los dividen
            GraficarGrupos(chartGraficaGrupos, DatosSeparadosPorGrupo, EcuacionesDeLasRectas);
            //Voy a salvar la informacion en el archivo separando los puntos por grupo
            GuardarGruposEnExcel(DocumentoExcel, DatosSeparadosPorGrupo, RutaArchivoExcel);
        }
    }
}
