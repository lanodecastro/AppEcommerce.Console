using AppEcommerce.Console.Core;
using AppEcommerce.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class PessoaFisica:Cliente
    {
        public PessoaFisica(string cpf, string nome, DateTime dataNascimento, Sexo sexo,string email)
            :base(email)
        {
            CPF = cpf;
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }

        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
    }
}
