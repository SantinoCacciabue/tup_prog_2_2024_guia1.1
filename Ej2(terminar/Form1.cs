using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Viaje miViaje;

        private void bIniciar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            if(inicio.ShowDialog() == DialogResult.OK)
            {
                int hInicio = Convert.ToInt32(inicio.tbHinicio.Text);
                int mInicio = Convert.ToInt32(inicio.tbMinicio.Text);
                int asientos = Convert.ToInt32(inicio.tbAsientos.Text);
                miViaje = new Viaje(hInicio, mInicio, asientos);
            }
        }

        private void bParada_Click(object sender, EventArgs e)
        {
            parada parada = new parada();
            if(parada.ShowDialog() == DialogResult.OK)
            {
                int hLlegada = Convert.ToInt32(parada.textBox1.Text);
                int mLlegada = Convert.ToInt32(parada.textBox2.Text);
                int hSalida = Convert.ToInt32(parada.textBox4.Text);
                int mSalida = Convert.ToInt32(parada.textBox3.Text);
                int ascienden = Convert.ToInt32(parada.textBox5.Text);
                int descienden = Convert.ToInt32(parada.textBox6.Text);
                miViaje.RealizarParada(hLlegada, mLlegada, hSalida, mSalida, ascienden, descienden);
            }
        }

        private void bFin_Click(object sender, EventArgs e)
        {
            Informe informe = new Informe();
            int hLlegada = Convert.ToInt32(textBox2.Text);
            int mLlegada = Convert.ToInt32(textBox1.Text);
            miViaje.Finalizar(hLlegada,mLlegada);
            int horas = miViaje.HDuracionViaje / 60;
            int minutos = miViaje.MDuracionViaje%60;
            int hDemora = miViaje.HDemora / 60;
            int mDemora = miViaje.MDemora%60;
            informe.lBinforme.Items.Add("Pasajeros Transportados: " + miViaje.Transportados);
            informe.lBinforme.Items.Add("Duración del viaje: " + horas+":"+minutos);
            informe.lBinforme.Items.Add("Cantidad de paradas: " + miViaje.CantParadas);
            informe.lBinforme.Items.Add("Duracion de todas las paradas: "+ hDemora+":"+mDemora);
            informe.ShowDialog();
        }
    }
}
