using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap2Ejercicio4
    {
        static void Main(string[] args)
        {
            double F, C;
            string dato;
            Console.WriteLine("Celsius ");
            dato = Console.ReadLine();
            C = Convert.ToDouble(dato);

            F = (9 / 5 * C) + 32;
            Console.WriteLine("Fahrenheit ", F);
            Console.Read();
        }
    }
}
