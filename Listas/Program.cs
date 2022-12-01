using System.Globalization;
namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> lista = new List<Empregado>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Empregado # " + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Empregado(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Informe o Id do empregado que terá aumento salarial: ");
            int procurarId = int.Parse(Console.ReadLine());

            Empregado empregado = lista.Find(x => x.Id == procurarId);

            if (empregado != null)
            {
                Console.Write("Informe a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregado.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse Id não existe!");
            }

            Console.WriteLine();

            Console.WriteLine("Lista atualizada de empregados:");
            foreach (Empregado obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}




