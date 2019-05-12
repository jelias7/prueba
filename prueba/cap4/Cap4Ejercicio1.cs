using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap4Ejercicio1
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Numero que se le mostrara la tabla del 1 al 10 ");
            numero = int.Parse(Console.ReadLine());

            for (int i=0; i<11; i++)
            {
                resultado = numero*i;
                Console.WriteLine(numero + "*" + i + "=" + resultado);
            }
            Console.Read();
        }
    }
}
