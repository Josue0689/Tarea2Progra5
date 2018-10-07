using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Validacion
{
    public class operacionCuadratica
    {
        public bool validarA(double? vaA) {
            if (vaA == 0)
            {
                return false;
            }
            else
                return true;
        }

        public bool validarDiscriminante(double? discriminante)
        {
            if (discriminante < 0)
            {
                return false;
            }
            else
                return true;
        }

        public bool validarNull(double? x)
        {
            if (x != null)
            {
                return true;
            }
            return false;
        }
    }
}