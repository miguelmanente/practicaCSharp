/* Hallar el máximo común divisor de dos números ingresados por teclado */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxComunDiv
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Seleccionamos el mayor y el menor para las variables a y b
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);

            //Declaramos la variable que guardará el resultado
            int res;

            //Creamos el ciclo encargado de hacer las iteraciones
            do{
                res = b;  // Guardamos el divisor en el resultado
                b = a % b; // Guardamos el resto en el divisor
                a = res;    //El divisor pasa al dividendo
            }while(b!=0);

            // Mostramos como resultado el último resto no nulo
            Console.WriteLine("El M.C.D. entre "+num1+" y "+num2+" es: "+res);
            Console.ReadKey(true);
        }
    }
}
