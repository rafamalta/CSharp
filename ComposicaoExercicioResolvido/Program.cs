using ComposicaoExercicioResolvido.Entidades;
using ComposicaoExercicioResolvido.Entidades.Enums;
using System.Globalization;

namespace ComposicaoExercicoResolvido
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o nome do departamento: ");
            string nomeDepartamento = Console.ReadLine();
            Console.WriteLine("Informe os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível (Júnior/Pleno/Senior): ");
            NivelDoTrabalhador nivelDoTrabalhador = Enum.Parse<NivelDoTrabalhador>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento departamento = new Departamento(nomeDepartamento);
            Trabalhador trabalhador = new Trabalhador(nome, nivelDoTrabalhador, salarioBase, departamento);

            Console.Write("Quantos contratos para esse trabalhador? ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"Informe a data do contrato {i}: ");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int duracaoDeHoras = int.Parse(Console.ReadLine());
                ContratoPorHora contratos = new ContratoPorHora(data, valorPorHora, duracaoDeHoras);
                trabalhador.AdicionarContrato(contratos);
            }

            Console.WriteLine();
            Console.Write("Informe o mês o ano (MM/AAAA) para calcular a renda: ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departamento.Nome);
            Console.WriteLine("Renda para " + monthAndYear + ": " + trabalhador.Rendimento(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

