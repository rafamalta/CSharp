using ExerClasseMetodoAbstrato.Entidades;
using System.Globalization;

namespace ExerClasseMetodoAbstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lista = new List<Contribuinte>();

            Console.Write("Informe o número de contribuintes: ");
            int numeroDeContribuintes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroDeContribuintes; i++)
            {
                Console.WriteLine($"Dados contribuinte #{i}:");
                Console.Write("Pessoa Física ou Jurídica (F/J)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'F')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Rendimento anual: ");
                    double rendimentoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Despesas de saúde: ");
                    double despesasDeSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(despesasDeSaude, nome, rendimentoAnual));
                }
                else
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Rendimento anual: ");
                    double rendimentoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Número de empregados: ");
                    int numeroDeEmpregados = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(numeroDeEmpregados, nome, rendimentoAnual));
                }
            }

            double soma = 0.0;
            Console.WriteLine();
            Console.WriteLine("Imposto pago:");
            foreach (Contribuinte contribuinte in lista)
            {
                double taxa = contribuinte.Taxa();
                soma += taxa;
                Console.WriteLine(
                    contribuinte.Nome +
                    ": R$ " +
                    taxa.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            Console.Write("Total de taxas: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

