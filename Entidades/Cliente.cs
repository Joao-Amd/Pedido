namespace Pedido.Entidades
{
    internal class Cliente
    {
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public DateTime DataNascimentoCliente { get; set; }

        public Cliente()
        {
        }
        public Cliente(string nome, string email, DateTime nascimento)
        {
            NomeCliente = nome;
            EmailCliente = email;
            DataNascimentoCliente = nascimento;
        }
        public override string ToString()
        {
            return $"{NomeCliente}, ({DataNascimentoCliente.ToString("dd/mm/yyyy")}) - {EmailCliente}";
        }
    }
}
