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
            Bolillero_ b1 = new Bolillero_(1);
            Simulacion s1 = new Simulacion();

            List<byte> jugada1 = new List<byte>() {1};
            s1.simularSinHilos(jugada1,25);

            Assert.AreEqual(25, (int)s1.cantidadAciertos);            
        }

        [TestMethod]
        public void testBolliero()
        {
            Bolillero_ b1 = new Bolillero_(1);

            Simulacion s1 = new Simulacion();

            s1.cantidadSimulaciones = 200;
            s1.Bolillero = b1;
            List<byte> j = new List<byte>() { 1 };

            s1.simularConHilos(j, 200, 2);
        }
    }
}
