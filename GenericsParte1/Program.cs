namespace GenericsParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServicoDeImpressao<int> servicoDeImpressao = new ServicoDeImpressao<int>();

            Console.Write("Quantos valores serão digitados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse((Console.ReadLine()));
                servicoDeImpressao.AdicionarValor(x);
            }

            servicoDeImpressao.Imprimir();
            Console.WriteLine("Primeiro: " + servicoDeImpressao.Primeiro());
        }
    }
}


