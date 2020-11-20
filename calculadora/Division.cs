using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Division : Operación
    {
        private double division;

        public Division(double num1, double num2) : base(num1, num2, '/')
        {
            this.division = num1 / num2;
            try
            {
                if (num2 == 0) throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede dividir por 0");
            }
        }
        public override void mostrarResultado()
        {
            Console.WriteLine(division);
        }
    }
}
