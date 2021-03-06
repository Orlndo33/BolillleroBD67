﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolillero
{
    public class Bolillero_ : ICloneable
    {
        Random r = new Random();
        public List<byte> bolillasD { get; set; }
        public List<byte> bolillasA { get; set; }

        public Bolillero_(byte unaCantBolillas)
        {
            bolillasA = new List<byte>();
            bolillasD = new List<byte>();
            agregarbolillasCount(unaCantBolillas);
        }
        public Bolillero_()
        {

        }

        private int indiceAlAzar()
        {
            return r.Next(0,bolillasD.Count()-1);
        }
        public byte sacarBolilla()
        {
            int b = indiceAlAzar();

            var v = bolillasD[b];
            bolillasA.Add(v);
            bolillasD.Remove(v);

            return v;
        }

        public void reingresarBolillas()
        {
            bolillasA.AddRange(bolillasD);
            bolillasA.Clear();
        }

        public void sacarBolilla(byte unaBolilla)
        {
            bolillasA.Add(unaBolilla);
            bolillasD.Remove(unaBolilla);
        }

        public bool jugar(List<byte> unaLista)
        {   
            
            for(byte i=0;i<unaLista.Count;i++ )
            {
                if (unaLista[i] != this.sacarBolilla())
                    return false;
            }
            return true;
        }

        public ulong jugarSimu(List<byte>jugada ,long cantSimu)
        {
            ulong cont = 0;
            for (long i= 0; i < cantSimu; i++)
			{
                if(jugar(jugada))
                {
                    cont++;
                }
                reingresarBolillas();
			}
            return cont;

        }

        public object Clone()
        {
            Bolillero_ clon = new Bolillero_();
            clon.bolillasD = new List<byte>(this.bolillasD);
            clon.bolillasA = new List<byte>(this.bolillasA);

            return clon;
        }

        private void agregarbolillasCount(byte unNumero)
        {
            for(byte i = 0; i<= unNumero; i++)
            {
                bolillasD.Add(i);
            }
        }
    }
}
