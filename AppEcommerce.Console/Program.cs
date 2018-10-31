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
        static void Main(string[] args)
        {

            ExibirProdutos();

            Console.Read();
        }

        public static void TestarConexao()
        {
            var dbObject = new DbObject();

            dbObject.OpenConnection();

            Console.WriteLine(dbObject._objConnection.State.ToString());

            dbObject.CloseConnection();

            Console.WriteLine(dbObject._objConnection.State.ToString());

            Console.Read();
        }
        public static void TestarCadastroProduto(string descricao,double preco)
        {
            Produto produto1 = new Produto(descricao, preco, 0.876);
            DbObject dbObject = new DbObject();
            var rowsAffecteds = dbObject.InsertProduto(produto1);
            Console.WriteLine(rowsAffecteds);
        }
        public static void TestarAtualizacaoDoProduto()
        {
            Produto produto1 = new Produto(1,"Pen Drive do Aldo", 30, 0.876,false);
            DbObject dbObject = new DbObject();
            var rowsAffecteds = dbObject.UpdateProduto(produto1);
            Console.WriteLine(rowsAffecteds);
        }
        public static void TestarExcluaoDoProduto()
        {
            DbObject dbObject = new DbObject();
            var rowsAffecteds = dbObject.DeleteProduto(1);
            Console.WriteLine(rowsAffecteds);
        }
        public static void ExibirProdutos()
        {
            DbObject dbObject = new DbObject();

            int i = 0;
            foreach (var item in dbObject.GetAllProducts())
            {
                i++;
                Console.WriteLine(String.Format("{0} - Produto: {1} - Preço: {2} R$",i, item.Descricao, item.Preco));
            }
            
        }


    }
}
