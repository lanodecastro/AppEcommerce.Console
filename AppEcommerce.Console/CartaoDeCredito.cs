using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class CartaoDeCredito:IFormaDePagamento
    {
        public string Numero { get; set; }
        public string Vencimento { get; set; }
        public Cliente Cliente { get; set; }
    }
}
