using System.Globalization;

namespace ExerInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do contrato: ");
            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor do contrato: ");
            double valorDoContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o número de parcelas: ");
            int numeroDeParcelas = int.Parse(Console.ReadLine());

            Contratos contratos = new Contratos(numero, data, valorDoContrato);

            ServicoDeContratos servicoDeContratos = new ServicoDeContratos(new ServicoPayPal());
            servicoDeContratos.GerarContrato(contratos, numeroDeParcelas);

            Console.WriteLine("Parcelas: ");

            foreach (Parcelas parcelas in contratos.Parcelas)
            {
                Console.WriteLine(parcelas);
            }
        }
    }
}

