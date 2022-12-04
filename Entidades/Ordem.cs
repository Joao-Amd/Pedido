using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Pedido.Entidades.Enum;

namespace Pedido.Entidades  
{
    internal class Ordem
    {
        public DateTime Momento { get; set; }
        public Status StatusOrdem { get; set; }
        public Cliente ClienteOrdem { get; set; }

        public List<Item> Itens { get; set; } = new List<Item> ();

        public Ordem()
        {
        }
        public Ordem(DateTime momento,Status  statusOrdem, Cliente clienteOrdem)
        {
            Momento = momento;
            StatusOrdem = statusOrdem;
            ClienteOrdem = clienteOrdem;
        }

        public void AddItem(Item item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(Item item)
        {
            Itens.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(Item item in Itens)
            {
                sum += item.TotalPagar();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento: " + Momento.ToString("dd/mm/yyyy hh:mm:ss"));
            sb.AppendLine("Status do pedido: " + StatusOrdem);
            sb.AppendLine("Cliente: " + ClienteOrdem);
            sb.AppendLine("Item: ");
            foreach(Item item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
