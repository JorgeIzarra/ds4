namespace Laboratorio81
{
    class Trabajador : Persona
    {
        public int Sueldo { get; set; }  // Changed to a property with public getter and setter

        public Trabajador(string nombre, int edad, string nif, int sueldo)
            : base(nombre, edad, nif)
        {
            Sueldo = sueldo;
        }
    }
}