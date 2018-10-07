using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProyUnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            double? a = 0.0;
            double? b = -11.0;
            double? c = -4.0;
            int valorEsperado = 1;
            int valorReal = 0;

            var ecuacion = new Tarea2.Logica.Especificacion.operacionEcuacion();
            valorReal = ecuacion.ecuacionCuadratica(a, b, c);

            Assert.AreEqual(valorEsperado, valorReal);
        }
    }
}
