using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = double.Parse(Console.ReadLine());

        double area = CalculoArea(radio);
        Console.WriteLine($"El área del círculo es: {area}");
    }

    static double CalculoArea(double radio)
    {
        double area = Math.PI * Math.Pow(radio, 2);
        return area;
    }
}