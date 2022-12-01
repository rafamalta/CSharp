using ExerHerancaPolimorfismo.Entidades;
using System.Globalization;

namespace ExerHerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> lista = new List<Empregado>();

            Console.Write("Informe o número de empregados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Empregado #{i} dados: ");
                Console.Write("Terceirizado? (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new EmpregadoTerceirizado(nome, horas, valorPorHora, despesaAdicional));
                }
                else
                {
                    lista.Add(new Empregado(nome, horas, valorPorHora));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");

            foreach (Empregado emp in lista)
            {
                Console.WriteLine(emp.Nome + " - " + "R$ " + emp.Pagamento().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
