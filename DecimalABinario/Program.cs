/* Convertir un numero decimal positivo ingresado por teclado a binario */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalABinario
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número decimal positivo");
            int numero = Convert.ToInt32(Console.ReadLine());
            int numero1 = numero;
            string binario ="";

            if(numero > 0)
            {
                while(numero > 0)
                {
                    if(numero % 2 == 0)
                    {
                        binario = "0"+binario;
                    } else {
                        binario = "1"+binario;
                    }
                    numero = (int) numero/2;
                }
            } else if(numero == 0){
                binario = "0";
            } else {
                binario = "No se pudo convertir el Numero. Ingrese solo numeros positivos";
            }
            Console.WriteLine("El numero decimal "+ numero1+" en binario es:  "  + binario);
            Console.ReadKey();
        }

    }
}