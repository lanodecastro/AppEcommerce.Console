using AppEcommerce.Console.Core.Dominio.Repositorio;
using AppEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Console.Core.Aplicacao
{
    public class CadastrarClientePF
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public void Executar()
        {
            Cliente cliente = new PessoaFisica("000.000.000-00", "José", Convert.ToDateTime("01/01/1990"), Model.Enum.Sexo.Masculino,"jose.silva@bol.com.br");
            
            _clienteRepositorio.Salvar(cliente);

        }
    }
}
