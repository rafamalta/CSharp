using System.Globalization;

namespace ExercícioLinqLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o caminho do arquivo: ");
            string caminho = Console.ReadLine();
            Console.Write("Informe um valor de salário: ");
            double salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            List<Funcionario> lista = new List<Funcionario>();

            try
            {
                using (StreamReader sr = new StreamReader(caminho))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] campos = sr.ReadLine().Split(',');
                        string nome = campos[0];
                        string email = campos[1];
                        double salario = double.Parse(campos[2], CultureInfo.InvariantCulture);
                        lista.Add(new Funcionario(nome, email, salario));
                    }
                }

                var emails = lista.Where(p => p.Salario > salario2).OrderBy(p => p.Email).Select(p => p.Email);

                var soma = lista.Where(p => p.Nome[0] == 'M').Sum(p => p.Salario);

                foreach (var itens in emails)
                {
                    Console.WriteLine("E-mail: " + itens);
                }

                Console.WriteLine();

                Console.WriteLine("Soma dos salários de funcionários que começam com a letra 'M': R$ "
                    + soma.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}

