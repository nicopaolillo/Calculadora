using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma suma = new Suma(5, 5);
            suma.mostrarResultado();
            Console.WriteLine("\n");
            Resta resta = new Resta(10, 5);
            resta.mostrarResultado();
            Console.WriteLine("\n");
            Multiplicacion multi = new Multiplicacion(2, 2);
            multi.mostrarResultado();
            Console.WriteLine("\n");
            Division division = new Division(20, 10);
            division.mostrarResultado();
            Console.WriteLine("\n");
            //atrapando exception
            Division divisionException = new Division(5, 0);
        }
    }
}
