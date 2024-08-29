using System;

namespace Laboratorio2
{
    public class Client
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Age { get; set; } = "";
        public string Id { get; set; } = "";
    }

    public class MyClass
    {
        public static int Valor;
        public string Nombre { get; set; }
        public int Edad {  get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ejemplo 1");
            Client client = new Client
            {
                FirstName = "Jorge",
                LastName = "Izarra",
                Age = "23",
                Id = "20-70-5241",
            };

            Console.WriteLine($"Cliente: {client.FirstName} {client.LastName}, Edad: {client.Age}, ID: {client.Id}");

            Console.WriteLine("\nEjemplo 2");
            MyClass.Valor = 1;
            Console.WriteLine($"Valor estatico: {MyClass.Valor}");

            Console.WriteLine("\nEjemplo 3");
            int valor1 = 28;
            int valor2 = valor1;
            valor2 = 30;
            Console.WriteLine($"valor1: {valor1}");
            Console.WriteLine($"valor2: {valor2}");

            Console.WriteLine("\nEjemplo 4");
            MyClass object1 = new MyClass();
            object1.Nombre = "Yeison";
            object1.Edad = 28;
            MyClass object2 = object1;
            object2.Nombre = "Jose";
            Console.WriteLine($"object1.Nombre: {object1.Nombre}");
            Console.WriteLine($"object2.Nombre: {object2.Nombre}");

            Console.WriteLine("\nEjemplo5:");
            char caracter = 'A';
            string cadena = "Cadena de caracteres";
            bool condicion = true;
            Console.WriteLine($"char: {caracter}");
            Console.WriteLine($"string: {cadena}");
            Console.WriteLine($"bool: {condicion}");
        }
    }
}
