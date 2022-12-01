using System.Globalization;

namespace InterfaceVsHeranca.Entidades
{
    class Circulo : FiguraAbstrata
    {
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

        public override string ToString()
        {
            return "Cor do círculo = "
                + Cor
                + ", raio = "
                + Raio.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
