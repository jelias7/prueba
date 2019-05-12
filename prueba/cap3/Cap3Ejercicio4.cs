using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap3Ejercicio4
    {
        static void Main(string[] args)
        {
            int Dia;
            Console.WriteLine("Dia (Numero) ");
            Dia = Convert.ToInt16(Console.Read());

            switch (Dia){
                case 1: Console.WriteLine("Lunes");
                    Console.Read();
                    break;
                case 2: Console.WriteLine("Martes");
                    Console.Read();
                    break;
                case 3: Console.WriteLine("Miercoles");
                    Console.Read();
                    break;
                case 4: Console.WriteLine("Jueves");
                    Console.Read();
                    break;
                case 5: Console.WriteLine("Viernes");
                    Console.Read();
                    break;
                case 6: Console.WriteLine("Sabado");
                    Console.Read();
                    break;
                case 7: Console.WriteLine("Domingo");
                    Console.Read();
                    break;
                default: Console.WriteLine("Escriba un numero del 1 al 7");
                    Console.Read();
                    break;
            }
        }
    }
}
