using MetodosAbstratos.Entidades.Enum;

namespace MetodosAbstratos.Entidades
{
    internal class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cor cor) : base (cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
