using System;

namespace ProjMediator
{
    public class ConcreteMediator : IMediator
    {
        private Vendedor _vendedor;
        private Comprador _comprador;

        public ConcreteMediator(Vendedor vendedor, Comprador comprador)
        {
            _vendedor = vendedor;
            _vendedor.SetMediator(this);
            _comprador = comprador;
            _comprador.SetMediator(this);
        }
        public void Vender(int id)
        {
            decimal valorDoProduto;

            valorDoProduto = _vendedor.VenderItemDaLista(id);
            _comprador.Saldo -= valorDoProduto;

            Console.WriteLine($"\nVenda do item '{id}' realizada com sucesso.\n");
        }
    }
}
