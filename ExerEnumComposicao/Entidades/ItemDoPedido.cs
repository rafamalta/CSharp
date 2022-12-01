using System.Globalization;

namespace ExerEnumComposicao.Entidades
{
    internal class ItemDoPedido
    {
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }

        public ItemDoPedido()
        {
        }

        public ItemDoPedido(int quantidade, Produto produto)
        {
            Quantidade = quantidade;
            Produto = produto;
        }

        public double SubTotal()
        {
            return Produto.Preco * Quantidade;
        }

        public override string ToString()
        {
            return Produto.Nome
                + ", R$"
                + Produto.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: R$"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
