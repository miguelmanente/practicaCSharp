using System;

namespace Espar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que que me indique
             *si un numero es par o impar, que muestre
             * un mensaje de salida*/

            Console.WriteLine("Ingrese un numero entero");
            int numero = int.Parse(Console.ReadLine());

            if ((numero % 2) == 0) Console.WriteLine("El numero "+numero+" Es PAR");
            else
            {
                Console.WriteLine("El numero "+numero+" Es IMPAR");
            }
            Console.ReadKey();
        }
    }
}
