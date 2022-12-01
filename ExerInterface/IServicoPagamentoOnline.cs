namespace ExerInterface
{
    public interface IServicoPagamentoOnline
    {
        double TaxaPagamento(double taxa);
        double Juros(double valor, int meses);

    }
}
