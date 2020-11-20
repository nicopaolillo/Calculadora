using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Resta : Operación
    {
        private double resta;

        public Resta(double num1, double num2) : base(num1, num2, '-')
        {
            this.resta = num1 - num2;
        }
        public override void mostrarResultado()
        {
            Console.WriteLine(resta);
        }
    }
}
