using System;

namespace Calculadora
{
    internal class CalculosMatematicos
    {
        public static int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = CalculosMatematicos.Calcular(num1, num2);

            Console.WriteLine("El resultado de la operación (a + b) * (a - b) es: " + resultado);
        }
    }
}

