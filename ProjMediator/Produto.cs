using System;

namespace ProjMediator
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
        public override string ToString()
        {
            return String.Format("{{Id: {0}, Nome: '{1}', Preco: {2:0.00} }}", Id, Nome, Preco);
        }
    }
}
