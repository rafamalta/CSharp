using System.Globalization;

namespace ExercicioHerancaPolimorfismo.Entidades
{
    internal class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao)
            : base (nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string EtiquetaDePreco()
        {
            return Nome
                + " (usado) "
                + "R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (Data de Fabricação: "
                + DataDeFabricacao.ToString("dd/MM/yyyy")
                + ")";                
        }
    }    
}
