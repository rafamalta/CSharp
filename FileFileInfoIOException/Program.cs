namespace FileFileInfoIOException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivoDeOrigem = @"c:\testes\arquivo1.txt";
            string arquivoDeDestino = @"c:\testes\arquivo2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(arquivoDeOrigem);
                fileInfo.CopyTo(arquivoDeDestino);
                string[] linhas = File.ReadAllLines(arquivoDeOrigem);
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
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
