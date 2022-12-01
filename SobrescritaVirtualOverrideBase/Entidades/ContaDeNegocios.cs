namespace SobrescritaVirtualOverrideBase.Entidades
{
    internal class ContaDeNegocios : Conta
    {
        public double LimiteDeEmprestimo { get; set; }

        public ContaDeNegocios()
        {
        }

        public ContaDeNegocios(int numeroDaConta, string titular, double saldo, double limiteDeEmprestimo)
            : base(numeroDaConta, titular, saldo)
        {
            LimiteDeEmprestimo = limiteDeEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteDeEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
