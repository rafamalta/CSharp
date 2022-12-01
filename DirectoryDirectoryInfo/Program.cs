namespace DirectoryDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\testes\minhapasta";
            try
            {
                var pastas = Directory.EnumerateDirectories(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in pastas)
                {
                    Console.WriteLine(s);
                }
                var arquivos = Directory.EnumerateFiles(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in arquivos)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(caminho + @"\newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}