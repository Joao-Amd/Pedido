using System.Globalization;
using Pedido.Entidades.Execao;
namespace Pedido.Entidades
{
    internal class Item
    {
        public int QuantidadeItem { get; set; }
        public double PrecoItem { get; set; }
        public Produto Produto { get; set; }

        public Item()
        {
        }
        public Item(int quantidade, double preco, Produto produto)
        {
            QuantidadeItem = quantidade;
            PrecoItem = preco;
            Produto = produto;
        }
        public double TotalPagar()
        {
            return PrecoItem * QuantidadeItem;
        }

        public override string ToString()
        {
            return Produto.NomeProduto +  ", $"  + PrecoItem.ToString("F2", CultureInfo.InvariantCulture) +
                ", Quantidade: " + QuantidadeItem + ", Total para ser pago: $" + TotalPagar().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}

