using DemoHeranca.Entidades;

namespace DemoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new ContaDeNegocios(8010, "Rafa", 250.0, 300.0);

            Console.WriteLine(conta.Saldo);
        }
    }
}

