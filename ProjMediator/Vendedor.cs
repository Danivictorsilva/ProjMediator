using System.Collections.Generic;

namespace ProjMediator
{
    public class Vendedor : BaseComponent
    {
        public decimal Saldo { get; set; }
        public List<Produto> Estoque { get; set; }

        public Vendedor(decimal saldo)
        {
            Saldo = saldo;
            Estoque = new List<Produto>();
        }

        public decimal VenderItemDaLista(int id)
        {
            decimal valorDoProduto = 0;

            foreach (Produto p in Estoque)
                if (p.Id == id)
                {
                    valorDoProduto = p.Preco;
                    Estoque.Remove(p);
                    break;
                };
            Saldo += valorDoProduto;
            return valorDoProduto;
        }
    }
}
