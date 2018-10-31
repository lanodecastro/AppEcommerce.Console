using AppEcommerce.Db;
using AppEcommerce.Model;
using AppEcommerce.Model.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AppEcommerce.Con
{
    class Program
    {
        private static IDataAccesObject<Produto> _produtoDao;
        static void Main(string[] args)
        {
            _produtoDao = new ProdutoDao();

            _produtoDao.GetAll().ToList()
                .ForEach(x => Console.WriteLine(x.Descricao));           

            Console.Read();
        }

        public static void TestarConexao()
        {
           
            
        }
        public static void TestarCadastroProduto(string descricao,double preco)
        {
            Produto produto1 = new Produto(descricao, preco, 0.876);
            _produtoDao.Save(produto1);
            
        }
        public static void TestarAtualizacaoDoProduto()
        {
            Produto obj = new Produto(15297, "Meu Produto Alterado", 100, 0.876, true);
            _produtoDao.Update(obj);
        }
        public static void TestarExclusaoDoProduto()
        {
            int id = 15298;
            _produtoDao.Delete(id);
        }
        public static void ExibirProdutos()
        {
            
        }


    }
}
