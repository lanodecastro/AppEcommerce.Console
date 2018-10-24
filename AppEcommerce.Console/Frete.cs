using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppEcommerce.Model.Enum;

namespace AppEcommerce.Model
{
    public class Frete
    {
        public int Id { get; set; }
        public Endereco Endereco { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public double Valor { get; set; }
    }
}
