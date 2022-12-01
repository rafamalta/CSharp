using ExercicioHerancaPolimorfismo.Entidades;
using System.Globalization;

namespace ExercicioHerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Informe o número de produtos: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados produto #{i}");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char tipoDeProduto = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipoDeProduto == 'c')
                {
                    lista.Add(new Produto(nome, preco));
                }
                else if (tipoDeProduto == 'u')
                {
                    Console.Write("Data de Fabricação (DD/MM/YYYY): ");
                    DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());
                    lista.Add(new ProdutoUsado(nome, preco, dataDeFabricacao));
                }
                else
                {
                    Console.Write("Taxa alfandegária: ");
                    double taxaAlfandegaria = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new ProdutoImportado(nome, preco, taxaAlfandegaria));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiqueta de Preços:");
            foreach (Produto etiquetas in lista)
            {
                Console.WriteLine(etiquetas.EtiquetaDePreco());
            }
        }
    }
}
