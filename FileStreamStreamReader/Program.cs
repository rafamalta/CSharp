namespace FileStreamStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivoDeOrigem = @"c:\testes\arquivo1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(arquivoDeOrigem);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }
    }
}
