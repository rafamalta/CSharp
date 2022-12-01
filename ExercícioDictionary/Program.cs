namespace ExercícioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o caminho do arquivo: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> votos = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] linha = sr.ReadLine().Split(',');
                        string nome = linha[0];
                        int quantidade = int.Parse(linha[1]);

                        if (votos.ContainsKey(nome))
                        {
                            votos[nome] += quantidade;
                        }
                        else
                        {
                            votos[nome] = quantidade;
                        }
                    }

                    foreach (var item in votos)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

