using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap2Ejercicio3
    {
        static void Main(string[] args)
        {
            string dato;
            double Gr, Rd;

            Console.WriteLine("Grados ");
            dato = Console.ReadLine();
            Gr = Convert.ToDouble(dato);

            Rd = Gr * (180/Math.PI);

            Console.WriteLine("{0} Grados = {1} Radianes ", Gr, Rd);
            Console.Read();
        }
    }
}
