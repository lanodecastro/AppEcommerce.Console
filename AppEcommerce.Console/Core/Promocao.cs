using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class Promocao
    {
        public int Id { get; set; }
        public string CodigoPromocional { get; set; }
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
        public double PercentualDesconto { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }

    }
}
