using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Peaje
    {
        private int promCantVehiculoMes;
        public int PromCantVehiculoMes
        {
            get { return promCantVehiculoMes; }
            set {  promCantVehiculoMes = value;}
        }
        public int[] Cantidades = new int[31];

        public void RegistrarResumenDia(int dia, int cantVehiculos)
        {
            Cantidades[dia] = cantVehiculos;

        }
        public int MayorMovimiento()
        {
            int mayorMovimiento = -1;
            for (int i = 0; i < Cantidades.Length; i++)
            {
                if (Cantidades[i] > mayorMovimiento)
                {
                    mayorMovimiento = i;
                }
            }
            return mayorMovimiento;
        }
        public int[] LosDiasMayoresAlPromedio(out int cantDias)
        {
            cantDias = 0;
            double prom;
            int acum = 0;
            int[] mayoresAlProm = new int[31];
            for (int i = 0; i<Cantidades.Length; i++)
            {
                acum += Cantidades[i];
            }
            prom = acum / Cantidades.Length;
            for (int i = 0; i < Cantidades.Length; i++)
            {
                if (Cantidades[i] > prom)
                {
                    mayoresAlProm[cantDias] = i;
                    cantDias++;
                }
            }
            return mayoresAlProm;
        }
        public int TercioDelMesMayor()
        {
            int acum1 = 0, acum2 = 0, acum3 = 0, retorno = 0;
            for (int i = 0; i < 11; i++)
            {
                acum1 += Cantidades[i];
            }
            for (int i = 10; i < 21; i++)
            {
                acum2 += Cantidades[i];
            }
            for (int i = 20; i < 31; i++)
            {
                acum3 += Cantidades[i];
            }
            if (acum1 > acum2)
            {
                if (acum1 > acum3)
                {
                    retorno = 1;
                }
            }
            if (acum2 > acum3)
            {
                if (acum2 > acum1)
                {
                        retorno = 2;
                }
            }
            if(acum3 > acum1)
            {
                if(acum3 > acum2)
                {
                    retorno = 3;
                }
            }
            return retorno;          
        }
    }
}
