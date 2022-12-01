using ExerEnumComposicao.Entidades.Enums;
using System.Globalization;
using System.Text;

namespace ExerEnumComposicao.Entidades
{
    internal class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemDoPedido> Itens { get; set; } = new List<ItemDoPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime momento, StatusPedido statusPedido, Cliente cliente)
        {
            Momento = momento;
            StatusPedido = statusPedido;
            Cliente = cliente;
        }

        public void AdicionarItemPedido(ItemDoPedido item)
        {
            Itens.Add(item);
        }

        public void RemoverItemPedido(ItemDoPedido item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach (ItemDoPedido item in Itens)
            {
                soma += item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do pedido: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + StatusPedido);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do pedido: ");
            foreach (ItemDoPedido item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço total: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
