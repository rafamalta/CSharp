using InterfaceVsHeranca.Enums;

namespace InterfaceVsHeranca.Entidades
{
    abstract class FiguraAbstrata : IFigura
    {
        public Cor Cor { get; set; }

        public abstract double Area();
    }
}
