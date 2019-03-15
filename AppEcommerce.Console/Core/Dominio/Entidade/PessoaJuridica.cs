using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class PessoaJuridica:Cliente
    {
        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }

    }
}
