using System.Globalization;
using ClasseAbstrata.Entidades;

namespace ClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Conta> lista = new List<Conta>();

            lista.Add(new ContaPoupanca(1001, "Alex", 500.00, 0.01));
            lista.Add(new ContaDeNegocios(1002, "Maria", 500.0, 400.0));
            lista.Add(new ContaPoupanca(1004, "Bob", 500.0, 0.01));
            lista.Add(new ContaDeNegocios(1005, "Anna", 500.0, 500.0));

            double soma = 0.0;
            foreach (Conta conta in lista)
            {
                soma += conta.Saldo;
            }

            Console.WriteLine("Saldo total: " + soma.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Conta conta in lista)
            {
                conta.Sacar(10.0);
            }
            foreach (Conta conta in lista)
            {
                Console.WriteLine("Saldo da conta atualizado "
                    + conta.NumeroDaConta
                    + ": "
                    + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

