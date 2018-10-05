using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Validacion
{
    public class operacionCuadratica
    {
        public bool validarValores(int vaA, double discriminante) {
            
            if (vaA == 0 || discriminante < 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}