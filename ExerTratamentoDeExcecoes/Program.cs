using ExerTratamentoDeExcecoes.ContaBancaria;
//using ExerTratamentoDeExcecoes.ContaBancaria.Excecoes;
using System.Globalization;

namespace ExerTratamentoDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe os dados:");
            Console.Write("Conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Titular: ");
            string titular = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de saque: ");
            double limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta conta = new Conta(numeroDaConta, titular, saldo, limiteDeSaque);

            Console.WriteLine();
            Console.Write("Informe o valor de saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                conta.Sacar(saque);
                Console.WriteLine("Saldo atualizado: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro de saque: " + e.Message);
            }
        }
    }
}


