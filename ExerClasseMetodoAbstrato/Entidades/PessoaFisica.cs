namespace ExerClasseMetodoAbstrato.Entidades
{
    internal class PessoaFisica : Contribuinte
    {
        public double DespesasDeSaude { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(double despesasDeSaude, string nome, double rendimentoAnual)
            : base(nome, rendimentoAnual)
        {
            DespesasDeSaude = despesasDeSaude;
        }

        public override double Taxa()
        {
            if (RendimentoAnual < 20000.00)
            {
                return RendimentoAnual * 0.15 - DespesasDeSaude * 0.5;
            }
            else
            {
                return RendimentoAnual * 0.25 - DespesasDeSaude * 0.5;
            }
        }
    }
}
