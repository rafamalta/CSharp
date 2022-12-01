using System.Globalization;

namespace ExerClasseMetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Digite o caminho completo do arquivo: ");
                string caminhoArquivoOrigem = Console.ReadLine();


                string[] linhas = File.ReadAllLines(caminhoArquivoOrigem);

                string caminhoPastaOrigem = Path.GetDirectoryName(caminhoArquivoOrigem);
                string caminhoPastaDestino = caminhoPastaOrigem + @"\out";
                string caminhoArquivoDestino = caminhoPastaDestino + @"\summary.csv";

                Directory.CreateDirectory(caminhoPastaDestino);

                using (StreamWriter sw = File.AppendText(caminhoPastaDestino))
                {
                    foreach (string linha in linhas)
                    {

                        string[] campos = linha.Split(',');
                        string nome = campos[0];
                        double preco = double.Parse(campos[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(campos[2]);

                        Produtos prod = new Produtos(nome, preco, quantidade);

                        sw.WriteLine(prod.Nome + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
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

