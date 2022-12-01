using System.Globalization;

namespace ExerInterface
{
    public class Parcelas
    {
        public DateTime DataDeVencimento { get; set; }
        public double ValorParcela { get; set; }

        public Parcelas()
        {
        }
        
        public Parcelas(DateTime dataDeVencimento, double valorParcela)
        {
            DataDeVencimento = dataDeVencimento;
            ValorParcela = valorParcela;
        }
        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy")
                + " - "
                + ValorParcela.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
