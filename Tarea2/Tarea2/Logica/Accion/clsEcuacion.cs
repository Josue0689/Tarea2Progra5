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

        private Nullable<double> primeraRaiz;

        public Nullable<double> _primeraRaiz
        {
            get { return primeraRaiz; }
            set { primeraRaiz = value; }
        }

        private Nullable<double> segundaRaiz;

        public Nullable<double> _segundaRaiz
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

        internal int calcularEcuacion(double A, double B, double C) {
            discriminante = calcularDiscriminante(A, B, C);
            if (val.validarA(A))
            {
                if (val.validarDiscriminante(discriminante))
                {
                    primeraRaiz = primerX(discriminante, A, B);
                    segundaRaiz = segundaX(discriminante, A, B);
                    return codigo = 0;
                }
                else
                {
                    primeraRaiz = null;
                    segundaRaiz = null;
                    return codigo = 2;
                }
            }
            else
            {
                primeraRaiz = null;
                segundaRaiz = null;
                return codigo = 1;
            }
                
        }

        internal double calcularDiscriminante(double a,double b, double c)
        {
            var d = (Math.Pow(b, 2) - 4 * a * c);
            return d;
        }

        internal Nullable<double> primerX(double discriminante, double A, double B)
        {
            Nullable<double> raiz;
            try
            {
                return raiz = (-B + Math.Sqrt(discriminante)) / (2 * A);
            }
            catch (Exception)
            {
                return raiz = null;
            }
        }

        internal Nullable<double> segundaX(double discriminante, double A, double B)
        {
            Nullable<double> raiz;
            try
            {
                return raiz = (-B - Math.Sqrt(discriminante)) / (2 * A);
            }
            catch (Exception)
            {
                return raiz = null;
            }
        }
    }
}