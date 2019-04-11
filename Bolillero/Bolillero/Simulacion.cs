using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolillero
{
    public class Simulacion
    {
        public ulong cantidadSimulaciones { get; set; }
        public ulong cantidadAciertos { get;private set; }
        public byte numero { get; set; }
        public Bolillero_ Bolillero { get; set; }

        public ulong simularSinHilos(List<byte> jugada, long simu)
        {
            return Bolillero.jugarSimu(jugada, simu);
        }

        public void simularConHilos(List<byte> jugada, long simu, int cantidadHilos)
        {
            List<Task<ulong>> hilos = new List<Task<ulong>>();
            //List<Bolillero> bolillero = new List<Bolillero>();
            ulong cantidadPorHilo = this.cantidadSimulaciones / (ulong)cantidadHilos;
            for (int i = 0; i < cantidadHilos; i++)
            {
                Bolillero_ bolilleroClon = (Bolillero_)Bolillero.Clone();
                Task<ulong> tarea = new Task<ulong>(() => bolilleroClon.jugarSimu(jugada,simu));
                hilos.Add(tarea);
            }

            hilos.ForEach(hilo => hilo.Start());

            while (!hilos.TrueForAll(hilo => hilo.IsCompleted)) ;

            this.cantidadAciertos = 0;

            hilos.ForEach(hilo => cantidadAciertos += hilo.Result);
        }
    }
}
