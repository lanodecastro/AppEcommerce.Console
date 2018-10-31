using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class DescontoPessoaJuridica
    {
        public int Id { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public Produto Produto { get; set; }
        public double PercentualDeDesconto { get; set; }
    }
}
