using ExercicioResolvidoSet.Entities;

namespace ExercicioResolvidoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<RegistroDeLog> set = new HashSet<RegistroDeLog>();

            Console.Write("Informe o caminho do arquivo: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] linha = sr.ReadLine().Split(' ');
                        string nome = linha[0];
                        DateTime momento = DateTime.Parse(linha[1]);
                        set.Add(new RegistroDeLog { NomeDeUsuario = nome, Momento = momento });
                    }
                    Console.WriteLine("Total de usuários: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

