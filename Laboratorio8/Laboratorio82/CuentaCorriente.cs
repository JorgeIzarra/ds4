namespace Laboratorio82
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmIdCuenta) : base(prmIdCuenta)
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine(
                "CuentaCorriente.CalcularIntereses() efectuando para " +
                "la cuenta {0}", getIdCuenta());
        }
    }
}
