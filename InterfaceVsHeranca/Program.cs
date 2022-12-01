using InterfaceVsHeranca.Entidades;
using InterfaceVsHeranca.Enums;

namespace InterfaceVsHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigura s1 = new Circulo() { Raio = 2.0, Cor = Cor.Branco };
            IFigura s2 = new Retangulo() { Largura = 3.5, Altura = 4.2, Cor = Cor.Preto };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}

