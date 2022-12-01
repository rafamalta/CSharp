using System.Globalization;

namespace InterfaceVsHeranca.Entidades
{
    class Retangulo : FiguraAbstrata
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Cor do Retangulo = "
                + Cor
                + ", largura = "
                + Largura.ToString("F2", CultureInfo.InvariantCulture)
                + ", altura = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
