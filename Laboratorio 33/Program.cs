using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la longitud del lado 1: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la longitud del lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        double perimetro = 2 * (lado1 + lado2);

        Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
    }
}