using Laboratorio89;

internal class Program
{
    private static void Main(string[] args)
    {
        Template temp1 = new Template();
        temp1.ponerVariable("var1", "Valor1");
        temp1.ponerVariable("var2", "Valor2");
        temp1.ponerVariable("var3", "Valor3");
        temp1.verHtml("<br>Texto de Prueba</br>");
    }
}