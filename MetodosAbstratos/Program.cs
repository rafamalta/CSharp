using MetodosAbstratos.Entidades;
using MetodosAbstratos.Entidades.Enum;
using System.Globalization;

namespace MetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Forma> lista = new List<Forma>();

            Console.Write("Informe o número de formas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da forma #{i}:");
                Console.Write("Retangulo ou Circulo (r / c) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circulo(raio, cor));
                }
            }

            Console.WriteLine();

            Console.WriteLine("Áreas das formas: ");
            foreach (Forma forma in lista)
            {
                Console.WriteLine(forma.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}