
namespace Pedido.Entidades
{
    internal class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco)
        {
            NomeProduto = nome;
            PrecoProduto = preco;
        }
    }

}
