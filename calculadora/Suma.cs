using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora 
{
    class Suma : Operación
    {
        private double suma;

        public Suma(double num1, double num2) : base(num1, num2,'+')
        {
            this.suma = num1 + num2;
        }
        public override void mostrarResultado()
        {
            Console.WriteLine(suma);
        }
    }
}
