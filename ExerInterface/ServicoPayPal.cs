namespace ExerInterface
{
    public class ServicoPayPal : IServicoPagamentoOnline
    {
        private const double TaxaDePagamento = 0.02;
        private const double JurosSimples = 0.01;

        public double Juros(double juros, int meses)
        {
            return juros * JurosSimples * meses;
        }

        public double TaxaPagamento(double taxa)
        {
            return taxa * TaxaDePagamento;
        }
    }
}
