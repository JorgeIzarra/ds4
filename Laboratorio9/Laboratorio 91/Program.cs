class Program
{
    static void Main(string[] args)
    {
        // Pedimos el precio
        Console.Write("Ingrese el precio del producto: ");
        double productPrice = double.Parse(Console.ReadLine());

        // Pedimos el metodo de pago
        Console.Write("Ingrese la forma de pago (1 - Efectivo, 2 - Tarjeta): ");
        int paymentMethod = int.Parse(Console.ReadLine());

        // Proceso para tarjeta
        string cardNumber = "";
        if (paymentMethod == 2)
        {
            Console.Write("Ingrese el número de cuenta (16 dígitos): ");
            cardNumber = Console.ReadLine();
        }

        // Mostrar la información ingresada
        Console.WriteLine("Precio del producto: " + productPrice);
        if (paymentMethod == 1)
        {
            Console.WriteLine("Forma de pago: Efectivo");
        }
        else
        {
            Console.WriteLine("Forma de pago: Tarjeta");
            Console.WriteLine("Número de cuenta: " + cardNumber);
        }

        Console.ReadLine();
    }
}