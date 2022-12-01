namespace StreamWriterr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\testes\arquivo1.txt";
            string targetPath = @"c:\testes\arquivo2.txt";
            try
            {
                string[] linhas = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string linha in linhas)
                    {
                        sw.WriteLine(linha.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
