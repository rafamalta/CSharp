using UpcastingDowncasting.Entidades;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(1001, "Alex", 0.0);
            ContaDeNegocios contaDeNegocios = new(1002, "Rafa", 0.0, 500.0);

            // Upcasting

            Conta conta1 = contaDeNegocios;
            Conta conta2 = new ContaDeNegocios(1003, "Bob", 0.0, 200.0);
            Conta conta3 = new ContaPoupanca(1004, "Ana", 0.0, 0.01);

            // Downcasting

            ContaDeNegocios conta4 = (ContaDeNegocios)conta2;
            conta4.Emprestimo(100.0);

            //ContaDeNegocios conta5 = (ContaDeNegocios)conta3;
            if (conta3 is ContaDeNegocios)
            {
                //ContaDeNegocios conta5 = (ContaDeNegocios)conta3;
                ContaDeNegocios conta5 = conta3 as ContaDeNegocios;
                conta5.Emprestimo(200.0);
                Console.WriteLine("Empréstimo!");
            }

            if (conta3 is ContaPoupanca)
            {
                //ContaPoupanca conta5 = (ContaPoupanca)conta3;
                ContaPoupanca conta5 = conta3 as ContaPoupanca;
                conta5.AtualizarSaldo();
                Console.WriteLine("Saldo atualizado!");
            }
        }
    }
}
