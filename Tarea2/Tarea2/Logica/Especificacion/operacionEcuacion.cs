using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Especificacion
{
    public class operacionEcuacion
    {
        public bool ecuacionCuadratica (int varA, int varB, int varC)
        {
            var laAccion = new Accion.clsEcuacion();
            return laAccion.calcularEcuacion(varA, varB, varC);
        }
    }
}