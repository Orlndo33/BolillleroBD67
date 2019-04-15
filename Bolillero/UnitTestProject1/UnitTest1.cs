using System;
using System.Collections.Generic;
using Bolillero;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bolillero_ b1 = new Bolillero_(20);
            Simulacion s1 = new Simulacion();

            s1.cantidadSimulaciones = 25;
            s1.numero = 1;

            List<byte> jugada1 = new List<byte>() { 5, 8, 3 };
            s1.simularSinHilos(jugada1,10);

            Assert.AreEqual(25, (int)s1.cantidadSimulaciones);
            
        }
    }
}
