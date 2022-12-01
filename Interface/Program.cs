using System.Globalization;
using Interface.Entidades;
using Interface.Servicos;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do aluguel: ");
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Entrega (dd/MM/yyyy hh:mm): ");
            DateTime dataInicial = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Devolução (dd/MM/yyyy hh:mm): ");
            DateTime dataFinal = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Informe o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o preço por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelDeCarro aluguelDeCarro = new AluguelDeCarro(dataInicial, dataFinal, new Veiculo(modelo));

            ServicoDeAluguel servicoDeAluguel = new ServicoDeAluguel(hora, dia, new TaxaServicoBrasil());

            servicoDeAluguel.ProcessarFatura(aluguelDeCarro);

            Console.WriteLine("FATURA:");
            Console.WriteLine(aluguelDeCarro.Fatura);
        }
    }
}

