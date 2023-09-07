using System;

namespace FuncionMath
{
    class Program
    {
        public static void Main(string[] args)
        {
            long resultado;
            Console.WriteLine("Ingrese un número entero");
            int numero = int.Parse(Console.ReadLine());
            double numero1 = 125.6892; 
            resultado = Math.Abs(numero);
            Console.WriteLine("Valor Absoluto de "+numero+" es: "+resultado);
            Console.WriteLine("Potencia de "+numero+" es: "+Math.Pow(numero,5));
            Console.WriteLine("Raiz Cuadrada de "+numero+" es: "+Math.Sqrt(numero).ToString("0.##"));
            Console.WriteLine("Número Máximo entre "+numero+" y 100 es: "+Math.Max(numero, 100));
            Console.WriteLine("Número Mínimo entre "+numero+" y 100 es: "+Math.Min(numero, 100));
            Console.WriteLine("La parte del numero "+numero1+" es: "+Math.Truncate(numero1));
            Console.WriteLine("La parte del numero "+numero1+" es: "+Math.Round(numero1));
            Console.WriteLine("El seno del numero "+numero+" es: "+Math.Sin(numero*Math.PI/180));
            Console.WriteLine("El coseno del numero "+numero+" es: "+Math.Cos(numero*Math.PI/180));
        }
    }
}
