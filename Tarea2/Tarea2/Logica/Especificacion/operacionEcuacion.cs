using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Especificacion
{
    public class operacionEcuacion
    {
        public int ecuacionCuadratica (double? varA, double? varB, double? varC)
        {
            var laAccion = new Accion.clsEcuacion();
            return laAccion.calcularEcuacion(varA, varB, varC);
        }
    }
}