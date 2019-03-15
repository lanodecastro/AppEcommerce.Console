using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEcommerce.Console.Core.Dominio.Repositorio;
using AppEcommerce.Model;

namespace AppEcommerce.Console.Core.Dominio.Servico
{
    public class RemoverDoEstoque : IAtualizarEstoque
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public RemoverDoEstoque(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public void Executar(List<ItemPedido> items)
        {
            foreach (var item in items)
            {
                var produto = _produtoRepositorio.Recuperar(item.Produto.Id);
                produto.DecrescerQuantidade(item.Quantidade);
            }
        }
    }
}
