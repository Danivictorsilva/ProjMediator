namespace ProjMediator
{
    public class Comprador : BaseComponent
    {
        public decimal Saldo { get; set; }

        public Comprador(decimal saldo)
        {
            Saldo = saldo;
        }
    }
}
