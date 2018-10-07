using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea2.Logica.Accion
{
    public class clsEcuacion
    {
        Validacion.operacionCuadratica val = new Validacion.operacionCuadratica();

        private double discriminante;

        public double _discriminante
        {
            get { return discriminante; }
            set { discriminante = value; }
        }

        private double primeraRaiz;

        public double _primeraRaiz
        {
            get { return primeraRaiz; }
            set { primeraRaiz = value; }
        }

        private double segundaRaiz;

        public double _segundaRaiz
        {
            get { return segundaRaiz; }
            set { segundaRaiz = value; }
        }

        private int codigo;

        public int _codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        internal double calcularEcuacion(double A, double B, double C) {
            discriminante = calcularDiscriminante(A, B, C);
            if (val.validarA(A))
            {
                if (val.validarDiscriminante(discriminante))
                {
                    primeraRaiz = ((-B + Math.Sqrt(discriminante)) / (2 * A));
                    segundaRaiz = ((-B - Math.Sqrt(discriminante)) / (2 * A));
                    return codigo = 0;
                }
                else
                    return codigo = 2;         
            }
            else
                return codigo = 1;
        }

        internal double calcularDiscriminante(double a,double b, double c)
        {
            var d = (Math.Pow(b, 2) - 4 * a * c); ;
            return d;
        }


    }
}