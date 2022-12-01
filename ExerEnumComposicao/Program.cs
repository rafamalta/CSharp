using ExerEnumComposicao.Entidades;
using ExerEnumComposicao.Entidades.Enums;
using System.Globalization;

namespace ExerEnumComposicao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do cliente: ");
            Console.Write("Nome: ");
            string nomeDoCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de aniversário (DD/MM/YYYY): ");
            DateTime dataAniversario = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe os dados do pedido: ");
            Console.Write("Status: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(nomeDoCliente, email, dataAniversario);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos itens terá esse pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informe os dados do pedido #{i}:");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nomeProduto, precoProduto);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItemDoPedido itemPedido = new ItemDoPedido(quantidade, produto);

                pedido.AdicionarItemPedido(itemPedido);
            }

            Console.WriteLine();
            Console.WriteLine("SUMÁRIO DO PEDIDO:");
            Console.WriteLine(pedido);
        }
    }
}

