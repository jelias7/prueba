using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap2Ejercicio1
    {
        static void Main(string[] args)
        {
            float Lados, Valor, Perimetro;
            string dato;

            Console.WriteLine("Cantidad lados ");
            dato = Console.ReadLine();
            Lados = Convert.ToSingle(dato);

            Console.WriteLine("Valor lados");
            dato = Console.ReadLine();
            Valor = Convert.ToSingle(dato);

            Perimetro = Lados * Valor;
            Console.WriteLine("Perimetro de Poligono ", Perimetro);
            Console.Read();
        }
    }
}
