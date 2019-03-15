using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class Pedido
    {
        public Pedido(Frete frete, IFormaDePagamento formaDePagamento, Cliente cliente)
        {
            Itens = new List<ItemPedido>();
            Frete = frete;
            FormaDePagamento = formaDePagamento;
            Cliente = cliente;
            Data = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<ItemPedido> Itens { get; private set; }
        public Frete Frete { get; set; }
        public IFormaDePagamento FormaDePagamento { get; set; }
        public Cliente Cliente { get; set; }

        public void AddItem(ItemPedido itemPedido)
        {
            Itens.Add(itemPedido);
        }
        
    }
}
