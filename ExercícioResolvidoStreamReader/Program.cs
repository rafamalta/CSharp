using System.Globalization;

namespace ExercícioResolvidoLinqLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o caminho do arquivo: ");
            string caminho = Console.ReadLine();

            List<Produto> lista = new List<Produto>();

            StreamReader sr = new StreamReader(caminho);
            while (!sr.EndOfStream)
            {
                string[] campos = sr.ReadLine().Split(',');
                string nome = campos[0];
                double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                lista.Add(new Produto(nome, preco));
            }

            var media = lista.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Preço médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

            var nomes = lista.Where(p => p.Preco < media).OrderByDescending(p => p.Nome).Select(p => p.Nome);
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}

