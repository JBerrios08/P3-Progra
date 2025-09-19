using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        public Form1() //metodo 1
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) //metodo 2
        {
            double[] ventas = ObtenerVentas(); //arreglo 1
            double[] ventasFiltradas = FiltrarVentasAltas(ventas); //arreglo 2
            MostrarResultados(ventasFiltradas);
        }

        private double[] ObtenerVentas() //metodo 3
        {
            string texto = txtVentas.Text;
            string[] partes = texto.Split(new char[] { '\n', '\r', ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries); //arreglo 3
            List<double> lista = new List<double>();

            foreach (string parte in partes)
            {
                if (double.TryParse(parte.Trim(), out double valor))
                {
                    lista.Add(valor);
                }
            }

            return lista.ToArray();
        }

        private double[] FiltrarVentasAltas(double[] ventas) //metodo 4
        {
            return ventas.Where(v => v >= 200).ToArray();
        }

        private void MostrarResultados(double[] ventasFiltradas) //metodo 5
        {
            if (ventasFiltradas.Length == 0)
            {
                lblPromedioValor.Text = "--";
                lblConteoValor.Text = "--";
                lblMaximoValor.Text = "--";
                lblMinimoValor.Text = "--";
                lblAviso.Text = "no encontre ventas de 200 o mas, toca revisar los datos";
                return;
            }

            double promedio = ventasFiltradas.Average();
            double maximo = ventasFiltradas.Max();
            double minimo = ventasFiltradas.Min();

            lblPromedioValor.Text = promedio.ToString("F2");
            lblConteoValor.Text = ventasFiltradas.Length.ToString();
            lblMaximoValor.Text = maximo.ToString("F2");
            lblMinimoValor.Text = minimo.ToString("F2");
            lblAviso.Text = "";
        }

        private void lblInstrucciones_Click(object sender, EventArgs e) //metodo 6
        {

        }
    }
}
