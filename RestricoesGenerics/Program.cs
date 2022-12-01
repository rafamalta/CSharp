using System.Globalization;

namespace RestricoesGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Informe a quantidade: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(',');
                string nome = vetor[0];
                double preco = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                lista.Add(new Produto(nome, preco));
            }

            ServicoDeCalculo servicoDeCalculo = new ServicoDeCalculo();

            Produto max = servicoDeCalculo.Maximo(lista);

            Console.WriteLine("Maior: ");
            Console.WriteLine(max);
        }
    }
}

