using System;

namespace FomatoDatoSalida
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:C} ",num);    /* Muestra el número entero con dos decimales y el signo de euro */
            Console.WriteLine("{0:D6}",num);    /* Muestra la cantidad ceros adelante del número entero, hasta llegar a 6 digitos */
            Console.WriteLine("{0:E}",num);     /* Muesta el número entero ingresado en formato exponencial*/
            Console.WriteLine("{0:P}",num);     /* Muestra el número entero ingresado en formato tipo porcentaje y con decimales */
            Console.WriteLine("{0:X3}",num);    /* Muestra el número entero ingresado en formato hexadecimal*/
            Console.ReadKey();
        }
    }
}