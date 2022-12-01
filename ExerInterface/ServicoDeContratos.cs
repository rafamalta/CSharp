namespace ExerInterface
{
    public class ServicoDeContratos : ServicoPayPal
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ServicoDeContratos(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void GerarContrato(Contratos contrato, int meses)
        {
            double cotaBasica = contrato.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime dataVencimento = contrato.Data.AddMonths(i);
                double atualizarCota = cotaBasica + _servicoPagamentoOnline.Juros(cotaBasica, i);
                double totalDaCota = atualizarCota + _servicoPagamentoOnline.TaxaPagamento(atualizarCota);
                contrato.AdicionarParcelas(new Parcelas(dataVencimento, totalDaCota));
            }
        }
    }
}
