namespace Interface.Entidades
{
    public class AluguelDeCarro
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public Veiculo Veiculo { get; set; }

        public Fatura Fatura { get; set; }

        public AluguelDeCarro(DateTime dataInicial, DateTime dataFinal, Veiculo veiculo)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;
            Veiculo = veiculo;
        }
    }
}
