using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap3Ejercicio1
    {
        static void Main(String[] args)
        {
            int dato;

            Console.WriteLine("Numero ");
            dato = Convert.ToInt16(Console.ReadLine());

            if ((dato % 2) == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
        }
    }
}
