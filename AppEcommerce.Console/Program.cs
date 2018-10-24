using AppEcommerce.Model;
using AppEcommerce.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Con
{
    class Program
    {
      
        static void Main(string[] args)
        {
            NovoProduto();
            NovoCliente();
        }

        public static void NovoProduto()
        {            
            Produto produto = new Produto("Iphone 10",8000,0.3);        

            Console.WriteLine(produto.Descricao);

            Console.Read();

        }
        public static void NovoCliente()
        {
            Console.Read();
           
            Cliente eduardo = new Cliente("aushausha@gmail.com");

            eduardo.AddTelefone("0000-000", TipoTelefone.Movel);

            eduardo.AddEndereco("Conjunto A", "70000-000", "Asa Sul", "Brasília", "Distrito Federal", "Brasil");
          
          
            Console.WriteLine(eduardo.Telefones.First());
            Console.Read();
        }
    }
}
