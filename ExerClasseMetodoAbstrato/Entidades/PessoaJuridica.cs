namespace ExerClasseMetodoAbstrato.Entidades
{
    internal class PessoaJuridica : Contribuinte
    {
        public int NumeroDeEmpregados { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(int numeroDeEmpregados, string nome, double rendimentoAnual)
            : base(nome, rendimentoAnual)

        {
            NumeroDeEmpregados = numeroDeEmpregados;
        }

        public override double Taxa()
        {
            if (NumeroDeEmpregados > 10)
            {
                return RendimentoAnual * 0.14;
            }
            else
            {
                return RendimentoAnual * 0.16;
            }
        }
    }
}
