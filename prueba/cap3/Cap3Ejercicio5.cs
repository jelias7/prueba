using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap3Ejercicio5
    {
        public static void Main(string[] args)
        {
            float r = 0.0f, lados, Apotema;
            string dato;
            int choice, cant;

            Console.WriteLine("(1) Perimetro o Area (2) ");
            dato = Console.ReadLine();
            choice = Convert.ToInt16(dato);

            Console.Write("Valor de los lados ");
            dato = Console.ReadLine();
            lados = Convert.ToSingle(dato);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Cantidad Lados ");
                    cant = int.Parse(Console.ReadLine());

                    r = lados * cant;
                    break;
                case 2:
                    Console.WriteLine("Apotema ");
                    Apotema = float.Parse(Console.ReadLine());

                    r = (lados * Apotema) / 2;

                    break;
                default:
                    Console.WriteLine("No.");
                    break;
            }
            Console.Write(r);

            Console.ReadKey();
        }
    }
}
