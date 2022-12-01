
namespace ClasseAbstrata.Entidades
{
    internal class ContaPoupanca : Conta
    {
        public double TaxaDeJuro { get; set; }

        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numeroDaConta, string titular, double saldo, double taxaDeJuro)
            : base(numeroDaConta, titular, saldo)
        {
            TaxaDeJuro = taxaDeJuro;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaDeJuro;
        }

        public override void Sacar(double quantia)
        {
            base.Sacar(quantia);
            Saldo -= 2.0;
        }
    }
}
