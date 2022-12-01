
namespace ClassesMetodosSelados.Entidades
{
    internal class Conta
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }

        public Conta(int numeroDaConta, string titular, double saldo)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Sacar(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
    }
}
