using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Peaje peaje;

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            peaje = new Peaje();
            Cargar_peaje carga = new Cargar_peaje();
            if(carga.ShowDialog() == DialogResult.OK )
            {
                int dia = Convert.ToInt32(carga.nDia.Text);
                int cantidad = Convert.ToInt32(carga.tBcantidad.Text);
                peaje.RegistrarResumenDia(dia, cantidad);
            }

        }

        private void bVer_Click(object sender, EventArgs e)
        {
            lBinforme.Items.Clear();
            int cantDias;
            int diaMayorMov = peaje.MayorMovimiento();
            int[] mayoresAlProm = peaje.LosDiasMayoresAlPromedio(out cantDias);
            int tercioMayor = peaje.TercioDelMesMayor();
            lBinforme.Items.Add("Dia con mayor movimiento: " + diaMayorMov);
            lBinforme.Items.Add("Dias mayores al promedio:");
            for (int i = 0;i<cantDias;i++)
            {
                lBinforme.Items.Add(mayoresAlProm[i]);
            }
            lBinforme.Items.Add("Tercio con mayor movimiento: "+tercioMayor);

        }
    }
}
