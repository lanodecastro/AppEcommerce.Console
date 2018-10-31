using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
   public  class DescontoPessoaJuridicaUtilizado
    {
       public DescontoPessoaJuridica DescontoPessoaJuridica { get; set; }
       public Pedido Pedido { get; set; }
    }
}
