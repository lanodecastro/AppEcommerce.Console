using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class ItemPedido
    {
        public ItemPedido(Pedido pedido, Produto produto, int quantidade)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
        }

        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

    }
}
