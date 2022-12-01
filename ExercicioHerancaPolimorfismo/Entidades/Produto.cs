using System.Globalization;

namespace ExercicioHerancaPolimorfismo.Entidades
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string EtiquetaDePreco()
        {
            return Nome 
                + " R$ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture);            
        }
    }
}
