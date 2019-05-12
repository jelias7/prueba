using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEjercicios1
{
    class Cap2Eejercicio5
    {
        static void Main(string[] args)
        {
            double dolar, euro;
            double de = 0.89;
            double ed = 1.12;
            string dato;
            Console.WriteLine("Dolares a cambiar ");
            dato = Console.ReadLine();
            dolar = Convert.ToDouble(dato);
            double conversiondolar = dolar * de;

            Console.WriteLine("Euros a cambiar ");
            dato = Console.ReadLine();
            euro = Convert.ToDouble(dato);
            double conversioneuro = euro * ed;

            Console.WriteLine("{0} Dolares = {1} Euros ", dolar, conversiondolar);
            Console.WriteLine("{0} Euros = {1} Dolares ", euro, conversioneuro);

        }
    }
}
