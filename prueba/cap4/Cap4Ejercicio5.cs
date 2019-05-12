using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap4Ejercicio5
    {
        static void Main(string[] args)
        {
            int numero = 0, i = 0;
            string dato = "";
            float suma = 0.0f, min = 0.0f, max = 0.0f;

            Console.WriteLine("Cantidad Personas ");
            dato = Console.ReadLine();
            numero = Convert.ToInt32(dato);

            float[] edades = new float[numero];

            for (i=0; i<numero; i++)
            {
                Console.WriteLine("Edades");
                dato = Console.ReadLine();
                edades[i] = Convert.ToSingle(dato);

            }
            for (i=0; i<numero; i++)
            {
                suma = suma + edades[i];
            }
            for (i=0; i<numero; i++)
            {
                if (edades[i] < min)
                    min = edades[i];
            }

            for (i=0; i<numero; i++)
            {
                if (edades[i] > max)
                    max = edades[i];
            }
            Console.WriteLine("Edad Maxima {0}", max);
            Console.WriteLine("Edad Minima {0}", min);
            Console.ReadLine();
        }
    }
}
