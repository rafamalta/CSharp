namespace ExercicioSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("Quantos alunos no curso A? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o Nº da matrícula: ");
                int codigo = int.Parse(Console.ReadLine());
                cursoA.Add(codigo);
            }
            Console.WriteLine();

            Console.Write("Quantos alunos no curso B? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o Nº da matrícula: ");
                int codigo = int.Parse(Console.ReadLine());
                cursoB.Add(codigo);
            }
            Console.WriteLine();

            Console.Write("Quantos alunos no curso C? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o Nº da matrícula: ");
                int codigo = int.Parse(Console.ReadLine());
                cursoC.Add(codigo);
            }
            Console.WriteLine();

            HashSet<int> totalDeAlunos = new HashSet<int>(cursoA);
            totalDeAlunos.UnionWith(cursoB);
            totalDeAlunos.UnionWith(cursoC);

            Console.Write("Total de alunos: " + totalDeAlunos.Count);

        }
    }
}