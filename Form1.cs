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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // yo se que deberia validar mejor pero voy con prisita
            double[] ventas = ObtenerVentas();
            double[] ventasFiltradas = FiltrarVentasAltas(ventas);
            MostrarResultados(ventasFiltradas);
        }

        private double[] ObtenerVentas()
        {
            // yo cree este metodo rapido para convertir el texto a numeros sin darme muchas vueltas
            string texto = txtVentas.Text;
            string[] partes = texto.Split(new char[] { '\n', '\r', ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
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

        private double[] FiltrarVentasAltas(double[] ventas)
        {
            // yo filtro aqui solo las ventas que llegan a 200 por que eso me pidieron
            return ventas.Where(v => v >= 200).ToArray();
        }

        private void MostrarResultados(double[] ventasFiltradas)
        {
            // yo actualizo la interfaz segun lo que salio de los calculos
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
    }
}
