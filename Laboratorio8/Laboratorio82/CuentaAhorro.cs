namespace Laboratorio82
{
    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmIdCuenta) : base(prmIdCuenta) 
        {
        }

        public override void CalcularIntereses()
        {
            System.Console.WriteLine(
        "CuentaCorriente.CalcularIntereses() efectuado pra " +
        "la cuenta {0}", getIdCuenta());
            
        }
    }
}
