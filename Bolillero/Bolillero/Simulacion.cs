using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolillero
{
    class Simulacion
    {
        public Bolillero b1 { get; set; }

        public long simularSinHilos(List<byte> jugada, long simu)
        {
            return b1.jugarSimu(jugada, simu);
        }
    }
}
