namespace Laboratorio82
{
    public class Cuenta
    {
        private string idCuenta;

        public Cuenta(string prmIdCuenta)
        {
            this.idCuenta = prmIdCuenta;
            System.Console.WriteLine(
                "Constructor Clase Base para cuenta {0}", prmIdCuenta);
        }

        public virtual void CalcularIntereses()
        {
            System.Console.WriteLine(
                "Cuenta.CalcularIntereses() para cuenta {0}", 
                this.idCuenta);
        }

        public string getIdCuenta()
        {
            return this.idCuenta;
        }
    }
}
