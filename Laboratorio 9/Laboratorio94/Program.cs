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
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = random.Next(min, max + 1);
        }
        return arreglo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();

        // Generar un número aleatorio entre 2 y 10
        int numero = aleatorios.GenerarNumeroEntreDos(2, 10);
        Console.WriteLine("Número aleatorio entre 2 y 10: " + numero);

        // Generar un arreglo aleatorio de 5 números entre 1 y 20
        int[] arreglo = aleatorios.GenerarArregloAleatorio(1, 20, 5);
        Console.WriteLine("Arreglo aleatorio de 5 números entre 1 y 20:");
        foreach (int num in arreglo)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}