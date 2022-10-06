using System;

namespace ProjMediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new(100.00M);
            Comprador comprador = new(50.00M);
            ConcreteMediator loja = new(vendedor, comprador);

            vendedor.Estoque.Add(new Produto(1, "banana", 3.00M));
            vendedor.Estoque.Add(new Produto(2, "maçã", 2.00M));

            Console.WriteLine($"Saldo atual do vendedor: R${vendedor.Saldo:0.00}");
            Console.WriteLine($"Estoque atual do vendedor:");
            vendedor.Estoque.ForEach(prod => Console.WriteLine(prod.ToString()));
            Console.WriteLine($"Saldo atual do comprador: R${comprador.Saldo:0.00}");
            loja.Vender(1);
            Console.WriteLine($"Saldo atual do vendedor: R${vendedor.Saldo:0.00}");
            Console.WriteLine($"Estoque atual do vendedor:");
            vendedor.Estoque.ForEach(prod => Console.WriteLine(prod.ToString()));
            Console.WriteLine($"Saldo atual do comprador: R${comprador.Saldo:0.00}");
        }
    }
}
