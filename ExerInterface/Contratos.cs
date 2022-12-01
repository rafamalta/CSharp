namespace ExerInterface
{
    public class Contratos
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List <Parcelas> Parcelas { get; set; }

        public Contratos()
        {            
        }

        public Contratos(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Parcelas = new List <Parcelas>();
        }

        public void AdicionarParcelas(Parcelas parcelas)
        {
            Parcelas.Add(parcelas);
        }
    }
}
