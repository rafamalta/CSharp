using System.Globalization;

namespace ExercicioHerancaPolimorfismo.Entidades
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaAlfandegaria { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandegaria)
            : base (nome, preco)
        {
            TaxaAlfandegaria = taxaAlfandegaria;
        }

        public double PrecoTotal()
        {
            return Preco + TaxaAlfandegaria;
        }

        public override string EtiquetaDePreco()
        {
            return Nome
                + " R$ "
                + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " (Taxa Alfandegária: R$ "
                + TaxaAlfandegaria.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }     
    }
}
