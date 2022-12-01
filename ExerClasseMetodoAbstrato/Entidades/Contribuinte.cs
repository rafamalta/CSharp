namespace ExerClasseMetodoAbstrato.Entidades
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }
        public double RendimentoAnual { get; set; }

        public Contribuinte()
        {
        }

        public Contribuinte(string nome, double rendimentoAnual)
        {
            Nome = nome;
            RendimentoAnual = rendimentoAnual;
        }

        public abstract double Taxa();
    }
}
