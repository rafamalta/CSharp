using Interface.Entidades;

namespace Interface.Servicos
{
    public class ServicoDeAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxaServico _taxaServico;

        public ServicoDeAluguel(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }

        public void ProcessarFatura(AluguelDeCarro aluguelDeCarro)
        {
            TimeSpan duracao = aluguelDeCarro.DataFinal.Subtract(aluguelDeCarro.DataInicial);

            double pagamentoBasico = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaServico.Taxa(pagamentoBasico);

            aluguelDeCarro.Fatura = new Fatura(pagamentoBasico, taxa);
        }
    }
}
