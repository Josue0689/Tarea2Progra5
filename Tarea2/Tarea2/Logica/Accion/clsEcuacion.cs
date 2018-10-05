using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Accion
{
    public class clsEcuacion
    {
        public double discriminante { get; set; }
        public double primeraRaiz { get; set; }
        public double segundaRaiz { get; set; }
        public int codigo { get; set; }

        internal bool calcularEcuacion(int A, int B, int C) {
            var val = new Logica.Validacion.operacionCuadratica();
            discriminante = (Math.Pow(B, 2) - 4 * A * C);
            if (val.validarValores(A,discriminante))
            {
                primeraRaiz = ((-B + Math.Sqrt(discriminante)) / (2 * A));
                segundaRaiz = ((-B - Math.Sqrt(discriminante)) / (2 * A));
                return true;
            }
            else
                return false;
        }
    }
}