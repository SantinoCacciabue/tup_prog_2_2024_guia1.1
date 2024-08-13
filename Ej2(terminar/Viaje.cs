using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    internal class Viaje
    {
        public int Transportados { get; private set; }
        public int Asientos { get; private set; }
        public int HDemora { get; private set; }
        public int MDemora { get; private set; }
        public int CantParadas { get; private set; }
        public int HDuracionViaje { get; private set; }
        public int MDuracionViaje { get; private set; }
        private int hInicio;
        private int mInicio;

        public Viaje(int hInicio, int mInicio, int asientos)
        {
            this.hInicio = hInicio;
            this.mInicio = mInicio;
            Asientos = asientos;
        }
        public void RealizarParada(int hLlegada, int mLlegada, int hSalida, int mSalida, int ascienden, int descienden)
        {
            CantParadas++;
            Transportados += (ascienden - descienden);
            int mAcumTotalDemora = 0, mTotalDemora;
            mTotalDemora = ((hSalida * 60) + mSalida) - ((hLlegada * 60) + mLlegada);
            mAcumTotalDemora += mTotalDemora;
            HDemora = mAcumTotalDemora / 60;
            MDemora = mAcumTotalDemora % 60;
        }
        public void Finalizar(int hLlegada, int mLLegada)
        {
            int mTotalLlegada, mTotalSalida, mTotalViaje;
            mTotalLlegada = ((hLlegada * 60) + mLLegada);
            mTotalSalida = (hInicio * 60) + mInicio;
            mTotalViaje = mTotalLlegada - mTotalSalida;
            HDuracionViaje = mTotalViaje / 60;
            MDuracionViaje = mTotalViaje % 60;
        }



    }
}
