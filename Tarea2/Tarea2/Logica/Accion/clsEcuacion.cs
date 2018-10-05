using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Accion
{
    public class clsEcuacion
    {
        private int varibleA;
        
        public int _variableA
        {
            get { return varibleA; }
            set { varibleA = value; }
        }

        private int variableB;

        public int _variableB
        {
            get { return variableB; }
            set { variableB = value; }
        }

        private int variableC;

        public int _variableC
        {
            get { return variableC; }
            set { variableC = value; }
        }

        private int resultadoX1;

        public int _resultadoX1
        {
            get { return resultadoX1; }
            set { resultadoX1 = value; }
        }

        private int resultadoX2;

        public int _resultadoX2
        {
            get { return resultadoX2; }
            set { resultadoX2 = value; }
        }

        internal bool calcularEcuacion(int A, int B, int C) {
            var val = new Logica.Validacion.validacionDatos();
            return true;
        }
    }
}