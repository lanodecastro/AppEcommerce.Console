using AppEcommerce.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Telefone> Telefones { get; private set; }

        public Cliente(string email)
        {
            this.Email = email;          
            this.Telefones =new List<Telefone>();
        }
        public Cliente()
        {

        }
        public void AddTelefone(string numero, TipoTelefone tipoTelefone)
        {
            var telefone = new Telefone(0, numero, tipoTelefone, this);
            this.Telefones.Add(telefone);
        } 
        public void AddEndereco(string logradouro, string cep, string bairro, string cidade,
            string uf, string pais)
        {
            Endereco endereco = new Endereco(logradouro, cep, bairro, cidade, uf, pais,this);
        }
    }
}
