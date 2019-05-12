using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap4Ejercicio2
    {
        static void Main(string[] args)
        {
            double resultado, numero;
            int potencia;

            Console.WriteLine("Numero ");
            numero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Potencia ");
            potencia = Convert.ToInt16(Console.ReadLine());

            resultado = Math.Pow(numero, potencia);

            Console.WriteLine("La potencia de " + numero + " elevada a " + potencia + " es " + resultado);
            Console.ReadLine();

        }
    }
}
