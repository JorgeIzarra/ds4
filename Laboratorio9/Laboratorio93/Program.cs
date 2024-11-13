using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario los 3 lados del triángulo
        Console.Write("Ingrese el primer lado: ");
        double lado1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo lado: ");
        double lado2 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el tercer lado: ");
        double lado3 = double.Parse(Console.ReadLine());

        // Determinar si los lados forman un triángulo
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            Console.WriteLine("Los lados ingresados forman un triángulo.");

            // Determinar el tipo de triángulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Es un triángulo isósceles.");
            }
            else
            {
                Console.WriteLine("Es un triángulo escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Los lados ingresados no forman un triángulo.");
        }

        Console.ReadLine();
    }
}
