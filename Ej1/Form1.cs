using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        static double anual;
        static double lineal;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Moto miMoto;
        private void bCalcular_Click(object sender, EventArgs e)
        {
            string marca = tBmarca.Text;
            int modelo = Convert.ToInt32(nModelo.Text);
            double valor = Convert.ToDouble(tBvalor.Text);
            miMoto = new Moto(marca, modelo, valor);
            int año = Convert.ToInt32(nAño.Text);
            double tasa = Convert.ToDouble(tBtasa.Text);
            int vida = Convert.ToInt32(tbVida.Text);
            lineal = valor - (valor * (valor / vida));
            anual = valor * Math.Pow((1 - tasa), (año-modelo));
            Resultados ventana = new Resultados();
            ventana.lBresultados.Items.Add(miMoto.VerDescripcion());
            ventana.lBresultados.Items.Add("Depreciación Lineal: $" + lineal);
            ventana.lBresultados.Items.Add("Depreciación Anual: $" + anual);
            ventana.ShowDialog();
        }
    }
}
