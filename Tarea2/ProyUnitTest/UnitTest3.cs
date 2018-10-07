using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyUnitTest
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            double? a = 10.0;
            double? b = 10.0;
            double? c = 10.0;
            int valorEsperado = 2;
            int valorReal = 0;

            var ecuacion = new Tarea2.Logica.Especificacion.operacionEcuacion();
            valorReal = ecuacion.ecuacionCuadratica(a, b, c);

            Assert.AreEqual(valorEsperado, valorReal);
        }
    }
}
