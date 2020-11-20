using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    abstract class Operación
    {
        private double num1;
        private double num2;
        private char operacion;
        private double resultado;

        public Operación(double num1, double num2, char operacion)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.operacion = operacion;
        }

        public abstract void mostrarResultado();
    }
}
