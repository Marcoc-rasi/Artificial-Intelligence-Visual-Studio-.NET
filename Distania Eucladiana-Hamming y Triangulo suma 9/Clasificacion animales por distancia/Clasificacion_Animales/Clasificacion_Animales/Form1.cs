using System;
using SpreadsheetLight;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clasificacion_Animales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClasificarAnimales_Click(object sender, EventArgs e)
        {
            int k = 0;
            if (Int32.TryParse(comboBoxK.Text, out k))
            {
                if (checkBoxDistanciaEuclidiana.Checked == false && checkBoxDistanciaHamming.Checked == false)
                {
                    MessageBox.Show("Selecciona una distancia");
                }
                else
                {
                    if (checkBoxDistanciaEuclidiana.Checked == true)
                    {
                        string direccionArchivoAnimalesClasificados = @"F:\Uriel\Inteligencia Artificial\Clasificacion animales\Originales\AnimalesClasificados.xlsx";
                        string direccionArchivoAnimalesSinClasificar = @"F:\Uriel\Inteligencia Artificial\Clasificacion animales\Originales\AnimalesSinClasificar.xlsx";
                        string direccionArchivoAnimalesClasifidosEuclideana = @"F:\Uriel\Inteligencia Artificial\Clasificacion animales\Distancia Euclidiana\AnimalesClasificadosEuclideana.xlsx";


                        SLDocument excelAnimalesClasificados = new SLDocument(direccionArchivoAnimalesClasificados);
                        SLDocument excelAnimalesSinClasificar = new SLDocument(direccionArchivoAnimalesSinClasificar);
                        SLDocument excelAnimalesClasificadosEuclideana = new SLDocument();
                        SLDocument excelAnimalesClasificadosHamming = new SLDocument();



                        DataTable dataTableAnimalesClasificados = new DataTable();
                        DataTable dataTableAnimalesSinClasificar = new DataTable();
                        DataTable dataTableAnimalesClasificadosEuclidiana = new DataTable();
                        DataTable dataTableAnimalesClasificadosHamming = new DataTable();


                        crearDataTable(dataTableAnimalesClasificados);
                        crearDataTable(dataTableAnimalesSinClasificar);
                        crearDataTable(dataTableAnimalesClasificadosEuclidiana);
                        crearDataTable(dataTableAnimalesClasificadosHamming);

                        llenarDataTable(excelAnimalesClasificados, dataTableAnimalesClasificados);
                        llenarDataTable(excelAnimalesSinClasificar, dataTableAnimalesSinClasificar);
                        DistanciaEuclidianaCompleta(dataTableAnimalesClasificados, dataTableAnimalesSinClasificar, k);
                        dataTableAnimalesClasificadosEuclidiana = dataTableAnimalesSinClasificar.Copy();

                        guardarExcel(excelAnimalesClasificadosEuclideana, dataTableAnimalesClasificadosEuclidiana, direccionArchivoAnimalesClasifidosEuclideana);

                        excelAnimalesClasificados.CloseWithoutSaving();
                        excelAnimalesSinClasificar.CloseWithoutSaving();
                        MessageBox.Show("Se completo el metodo knn por distancia Euclidiana\nRevisa los archivos excel que se crearon");
                    }
                    else
                    {
                        if (checkBoxDistanciaHamming.Checked == true)
                        {
                            string direccionArchivoAnimalesClasificados = @"F:\Uriel\Inteligencia Artificial\Clasificacion animales\Originales\AnimalesClasificados.xlsx";
                            string direccionArchivoAnimalesSinClasificar = @"F:\Uriel\Inteligencia Artificial\Clasificacion animales\Originales\AnimalesSinClasificar.xlsx";
                            string direccionArchivoAnimalesClasifidosHamming = @"F:\Uriel\Inteligencia Artificial\Clasificacion animales\Distancia Hamming\AnimalesClasificadosHamming.xlsx";

                            SLDocument excelAnimalesClasificados = new SLDocument(direccionArchivoAnimalesClasificados);
                            SLDocument excelAnimalesSinClasificar = new SLDocument(direccionArchivoAnimalesSinClasificar);
                            SLDocument excelAnimalesClasificadosEuclideana = new SLDocument();
                            SLDocument excelAnimalesClasificadosHamming = new SLDocument();



                            DataTable dataTableAnimalesClasificados = new DataTable();
                            DataTable dataTableAnimalesSinClasificar = new DataTable();
                            DataTable dataTableAnimalesClasificadosEuclidiana = new DataTable();
                            DataTable dataTableAnimalesClasificadosHamming = new DataTable();


                            crearDataTable(dataTableAnimalesClasificados);
                            crearDataTable(dataTableAnimalesSinClasificar);
                            crearDataTable(dataTableAnimalesClasificadosEuclidiana);
                            crearDataTable(dataTableAnimalesClasificadosHamming);

                            llenarDataTable(excelAnimalesClasificados, dataTableAnimalesClasificados);
                            llenarDataTable(excelAnimalesSinClasificar, dataTableAnimalesSinClasificar);
                            DistanciaHammingCompleta(dataTableAnimalesClasificados, dataTableAnimalesSinClasificar, k);
                            dataTableAnimalesClasificadosHamming = dataTableAnimalesSinClasificar.Copy();


                            guardarExcel(excelAnimalesClasificadosHamming, dataTableAnimalesClasificadosHamming, direccionArchivoAnimalesClasifidosHamming);
                            excelAnimalesClasificados.CloseWithoutSaving();
                            excelAnimalesSinClasificar.CloseWithoutSaving();
                            MessageBox.Show("Se completo el metodo knn por distancia Hamming\nRevisa los archivos excel que se crearon");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Escribe un valor correcto para k");
            }
        }
        float distanciaEuclidiana(float suma)
        {
            return (float)(Math.Sqrt(suma));
        }
        float distanciaHamming(int final, int inicio)
        {
            return Math.Abs(final - inicio);
        }
        void DistanciaHammingCompleta(DataTable dataTableAnimalesClasificados, DataTable dataTableAnimalesSinClasificar, int k)
        {
            float Distancia = 0;
            int inicio = 0;
            int final = dataTableAnimalesClasificados.Rows.Count;
            float[,] DistanciasEuclidianas = new float[k, 2];
            for (int e = 0; e < dataTableAnimalesSinClasificar.Rows.Count; e++)
            {
                for (int i = 0; i < dataTableAnimalesClasificados.Rows.Count; i++)
                {
                    DataRow RenglonClasificar = dataTableAnimalesClasificados.Rows[i];
                    DataRow RenglonSinClasificar = dataTableAnimalesSinClasificar.Rows[e];

                    Int32.TryParse(RenglonClasificar["pelo"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["pelo"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["plumas"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["plumas"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["tomaLeche"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["tomaLeche"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["esqueleto"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["esqueleto"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["acuático"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["acuático"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["predador"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["predador"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["dientes"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["dientes"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["columnaVertebral"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["columnaVertebral"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["respira"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["respira"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["venenoso"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["venenoso"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["piernas"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["piernas"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["cola"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["cola"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["domestico"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["domestico"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["tamañoMedio"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["tamañoMedio"].ToString(), out inicio);
                    Distancia += distanciaHamming(final, inicio);

                    Int32.TryParse(RenglonClasificar["clase"].ToString(), out final);


                    if (i < k)
                    {
                        DistanciasEuclidianas[i, 0] = Distancia;
                        DistanciasEuclidianas[i, 1] = final;
                    }
                    else
                    {
                        for (int j = 0; j < k; j++)
                        {
                            if (Distancia < DistanciasEuclidianas[j, 0])
                            {
                                DistanciasEuclidianas[j, 0] = Distancia;
                                DistanciasEuclidianas[j, 1] = final;
                                j = k;
                            }

                        }
                    }
                    Distancia = 0;
                }
                int clase = 0;
                int[] sumas = { 0, 0, 0, 0, 0, 0, 0 };
                for (int j = 0; j < k; j++)
                {
                    switch (DistanciasEuclidianas[j, 1])
                    {
                        case 1:
                            sumas[0]++;
                            break;
                        case 2:
                            sumas[1]++;
                            break;
                        case 3:
                            sumas[2]++;
                            break;
                        case 4:
                            sumas[3]++;
                            break;
                        case 5:
                            sumas[4]++;
                            break;
                        case 6:
                            sumas[5]++;
                            break;
                        case 7:
                            sumas[6]++;
                            break;
                        default:

                            break;
                    }
                    clase = sumas.Max();
                }
                int y = Array.IndexOf(sumas, clase) + 1;
                int v = Array.LastIndexOf(sumas, clase) + 1;
                dataTableAnimalesSinClasificar.Rows[e]["clase"] = v;
            }
        }
        void DistanciaEuclidianaCompleta(DataTable dataTableAnimalesClasificados,DataTable dataTableAnimalesSinClasificar, int k)
        {
            float Distancia = 0;
            int inicio = 0;
            int final = dataTableAnimalesClasificados.Rows.Count;
            float[,] DistanciasEuclidianas = new float[k, 2];
            for (int e = 0; e < dataTableAnimalesSinClasificar.Rows.Count; e++)
            {
                for (int i = 0; i < dataTableAnimalesClasificados.Rows.Count; i++)
                {
                    DataRow RenglonClasificar = dataTableAnimalesClasificados.Rows[i];
                    DataRow RenglonSinClasificar = dataTableAnimalesSinClasificar.Rows[e];

                    Int32.TryParse(RenglonClasificar["pelo"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["pelo"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final-inicio),2));

                    Int32.TryParse(RenglonClasificar["plumas"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["plumas"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["tomaLeche"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["tomaLeche"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["esqueleto"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["esqueleto"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["acuático"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["acuático"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["predador"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["predador"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["dientes"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["dientes"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["columnaVertebral"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["columnaVertebral"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["respira"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["respira"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["venenoso"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["venenoso"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["piernas"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["piernas"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["cola"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["cola"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["domestico"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["domestico"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));

                    Int32.TryParse(RenglonClasificar["tamañoMedio"].ToString(), out final);
                    Int32.TryParse(RenglonSinClasificar["tamañoMedio"].ToString(), out inicio);
                    Distancia += (float)(Math.Pow((final - inicio), 2));
                    Distancia = distanciaEuclidiana(Distancia);

                    Int32.TryParse(RenglonClasificar["clase"].ToString(), out final);


                    if (i < k)
                    {
                        DistanciasEuclidianas[i, 0] = Distancia;
                        DistanciasEuclidianas[i, 1] = final;
                    }
                    else
                    {
                        for (int j = 0; j < k; j++)
                        {
                            if (Distancia < DistanciasEuclidianas[j, 0])
                            {
                                DistanciasEuclidianas[j, 0] = Distancia;
                                DistanciasEuclidianas[j, 1] = final;
                                j = k;
                            }

                        }
                    }
                    Distancia = 0;
                }
                int clase = 0;
                int[] sumas = { 0, 0, 0, 0, 0, 0, 0 };
                for (int j = 0; j < k; j++)
                {
                    switch (DistanciasEuclidianas[j, 1])
                    {
                        case 1:
                            sumas[0]++;
                            break;
                        case 2:
                            sumas[1]++;
                            break;
                        case 3:
                            sumas[2]++;
                            break;
                        case 4:
                            sumas[3]++;
                            break;
                        case 5:
                            sumas[4]++;
                            break;
                        case 6:
                            sumas[5]++;
                            break;
                        case 7:
                            sumas[6]++;
                            break;
                        default:

                            break;
                    }
                    clase = sumas.Max();
                }
                int y = Array.IndexOf(sumas, clase) + 1;
                int v = Array.LastIndexOf(sumas, clase) + 1;
                dataTableAnimalesSinClasificar.Rows[e]["clase"] = v;
            }
        }
        
        void llenarDataTable(SLDocument excelAnimales, DataTable tabla)
        {
            int i = 2;
            while (!string.IsNullOrEmpty(excelAnimales.GetCellValueAsString(i, 1)))
            {
                DataRow Renglon = tabla.NewRow();

                Renglon["nombre_animal"] = excelAnimales.GetCellValueAsString(i, 1);
                Renglon["pelo"] = excelAnimales.GetCellValueAsUInt32(i, 2);
                Renglon["plumas"] = excelAnimales.GetCellValueAsUInt32(i, 3);
                Renglon["tomaLeche"] = excelAnimales.GetCellValueAsUInt32(i, 4);
                Renglon["esqueleto"] = excelAnimales.GetCellValueAsUInt32(i, 5);
                Renglon["acuático"] = excelAnimales.GetCellValueAsUInt32(i, 6);
                Renglon["predador"] = excelAnimales.GetCellValueAsUInt32(i, 7);
                Renglon["dientes"] = excelAnimales.GetCellValueAsUInt32(i, 8);
                Renglon["columnaVertebral"] = excelAnimales.GetCellValueAsUInt32(i, 9);
                Renglon["respira"] = excelAnimales.GetCellValueAsUInt32(i, 10);
                Renglon["venenoso"] = excelAnimales.GetCellValueAsUInt32(i, 11);
                Renglon["piernas"] = excelAnimales.GetCellValueAsUInt32(i, 12);
                Renglon["cola"] = excelAnimales.GetCellValueAsUInt32(i, 13);
                Renglon["domestico"] = excelAnimales.GetCellValueAsUInt32(i, 14);
                Renglon["tamañoMedio"] = excelAnimales.GetCellValueAsUInt32(i, 15);
                Renglon["clase"] = excelAnimales.GetCellValueAsUInt32(i, 16);
                i++;
                tabla.Rows.Add(Renglon);
            }
        }

        void guardarExcel(SLDocument ExcelDestino, DataTable TablaAnimales, string direccion)
        {
            ExcelDestino.ImportDataTable(1,1,TablaAnimales,true);
            ExcelDestino.SaveAs(direccion);
        }
        void crearDataTable(DataTable dataTable)
        {
            dataTable.Columns.Add("nombre_animal",typeof(string));
            dataTable.Columns.Add("pelo", typeof(int));
            dataTable.Columns.Add("plumas",typeof(int));
            dataTable.Columns.Add("tomaLeche", typeof(int));
            dataTable.Columns.Add("esqueleto", typeof(int));
            dataTable.Columns.Add("acuático", typeof(int));
            dataTable.Columns.Add("predador", typeof(int));
            dataTable.Columns.Add("dientes", typeof(int));
            dataTable.Columns.Add("columnaVertebral", typeof(int));
            dataTable.Columns.Add("respira", typeof(int));
            dataTable.Columns.Add("venenoso", typeof(int));
            dataTable.Columns.Add("piernas", typeof(int));
            dataTable.Columns.Add("cola", typeof(int));
            dataTable.Columns.Add("domestico", typeof(int));
            dataTable.Columns.Add("tamañoMedio", typeof(int));
            dataTable.Columns.Add("clase", typeof(int));
        }

        private void checkBoxDistanciaEuclidiana_Click(object sender, EventArgs e)
        {
            if(checkBoxDistanciaHamming.Checked == true)
            {
                checkBoxDistanciaEuclidiana.Checked = false;
                MessageBox.Show("Desmarca la casilla Distancia Hamming para continuar");
            }
        }

        private void checkBoxDistanciaHamming_Click(object sender, EventArgs e)
        {
            if(checkBoxDistanciaEuclidiana.Checked == true)
            {
                checkBoxDistanciaHamming.Checked = false;
                MessageBox.Show("Desmarca la casilla Distancia Euclidiana para continuar");
            }
        }
    }
}
