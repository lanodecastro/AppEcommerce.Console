using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEcommerce.Console.Core.Dominio.Repositorio;
using AppEcommerce.Model;

namespace AppEcommerce.Console.Core.Dominio.Servico
{
    public class RealizarPedido
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        private readonly IAtualizarEstoque _atualizarEstoque;
        private readonly ICalcularFreteService _calcularFrete;
        private readonly ISolicitarEntregaService _solicitarEntrega;

        public void Registrar()
        {
            var cliente = new Cliente("jose@x.com");
            var formaDePagamento = new CartaoDeCredito();

            Pedido pedido = new Pedido(new Frete(),formaDePagamento,cliente);
            pedido.Itens.Add(new ItemPedido(pedido,new Produto("Mouse",10,100),4));

            pedido.AddItem(new ItemPedido(pedido, new Produto("Mouse", 10, 100), 4));
            pedido.AddItem(new ItemPedido(pedido, new Produto("Teclado", 5, 900), 4));

            _pedidoRepositorio.Salvar(pedido);
            _atualizarEstoque.Executar(pedido.Itens);
            _calcularFrete.CalcularFrete(pedido.Frete);
            _solicitarEntrega.SolicitarEntrega(pedido);
        }
    }
}
