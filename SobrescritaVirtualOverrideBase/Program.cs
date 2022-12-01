using SobrescritaVirtualOverrideBase.Entidades;

namespace SobrescritaVirtualOverrideBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(1001, "Alex", 500.0);
            Conta conta2 = new ContaPoupanca(1002, "Maria", 500.0, 0.01);

            conta1.Sacar(10.0);
            conta2.Sacar(10.0);

            Console.WriteLine(conta1.Saldo);
            Console.WriteLine(conta2.Saldo);
        }
    }
}
