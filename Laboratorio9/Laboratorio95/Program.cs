using System;
using System.Collections.Generic;

class Aleatorios
{
    private Random random;

    public Aleatorios()
    {
        random = new Random();
    }

    public int GenerarNumeroEntreDos(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public int[] GenerarArregloAleatorio(int min, int max, int cantidad)
    {
        int[] arreglo = new int[cantidad];
        HashSet<int> numeros = new HashSet<int>();

        while (numeros.Count < cantidad)
        {
            int numero = random.Next(min, max + 1);
            if (!numeros.Contains(numero))
            {
                numeros.Add(numero);
            }
        }

        numeros.CopyTo(arreglo);
        return arreglo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        // Generar un arreglo aleatorio de 10 números entre 1 y 20 sin repetidos
        int[] arregloSinRepetidos = aleatorios.GenerarArregloAleatorio(1, 20, 10);

        Console.WriteLine("Arreglo aleatorio de 10 números entre 1 y 20 sin repetidos:");
        foreach (int num in arregloSinRepetidos)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}
