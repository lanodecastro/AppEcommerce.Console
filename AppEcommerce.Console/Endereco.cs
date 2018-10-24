using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }

        public Endereco(string logradouro, string cep, string bairro, string cidade,
            string uf, string pais,Cliente cliente)
        {
            this.Logradouro = logradouro;
            this.CEP = cep;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.UF = uf;
            this.Pais = pais;
            this.Cliente=cliente;
        }
    }
}
