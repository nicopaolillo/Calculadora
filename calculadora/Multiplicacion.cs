using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Multiplicacion : Operación
    {
        private double multiplicacion;

        public Multiplicacion(double num1, double num2) : base(num1, num2, '*')
        {
            this.multiplicacion = num1 * num2;
        }
        public override void mostrarResultado()
        {
            Console.WriteLine(multiplicacion);
        }
    }
}
