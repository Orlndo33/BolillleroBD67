using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolillero
{
    public class Bolillero
    {
        Random r;
        List<int> bolillasD { get; set; }
        List<int> bolillasA { get; set; }

        public Bolillero()
        {
            bolillasA = new List<int>();
            bolillasD = new List<int>();
        }

        public int sacarBolilla()
        {
            int s = r.Next(0, bolillasD.Count);
            bolillasD.RemoveAt(s);
            
            return s;
        }

        public int 
    }
}
