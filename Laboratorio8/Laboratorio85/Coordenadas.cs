namespace Laboratorio85
{
    public class Coordenadas
    {
        private int x;
        private int y;

        public Coordenadas(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void VerCoordenadas()
        {
            Console.WriteLine($"Coordenadas: {x}, {y}.");
        }
    }
}
