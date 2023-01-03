using System;
using Pedido.Entidades;
using Pedido.Entidades.Enum;
using System.Globalization;
using Pedido.Entidades.Execao;

namespace sistema_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entrar com os dados do cliente");
                Console.Write("Nome: ");
                string nomeCliente = Console.ReadLine();
                Console.Write("Email: ");
                string emailCliente = Console.ReadLine();
                Console.Write("Data de nascimento (DD/MM/YYYY): ");
                DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("Status do pedido: ");
                Status status = Enum.Parse<Status>(Console.ReadLine());


                Cliente cliente = new Cliente(nomeCliente, emailCliente, dataNascimento);
                Ordem ordem = new Ordem(DateTime.Now, status, cliente);

                Console.Write("Quantos Itens serão comprados: ");
                int quantidadeDeItem = int.Parse(Console.ReadLine());

                for (int i = 1; i <= quantidadeDeItem; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Entre com o pedido #{i}: ");
                    Console.Write("Nome do produto: ");
                    string nomeProduto = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantos produtos: ");
                    int quantidadeProdutos = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Produto produto = new Produto(nomeProduto, precoProduto);
                    Item item = new Item(quantidadeProdutos, precoProduto, produto);

                    ordem.AddItem(item);
                }
                Console.WriteLine();
                Console.WriteLine("Resumo do pedido:");
                Console.WriteLine(ordem);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERRO: Formato de entrada incorreto");
            }
            catch (Exception) 
            {
                Console.WriteLine("Erro inesperado");

            }
        }
    }
}
