using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<ItemPedido> Itens { get; set; }
        public Frete Frete { get; set; }
        public IFormaDePagamento FormaDePagamento { get; set; }

        
    }
}
