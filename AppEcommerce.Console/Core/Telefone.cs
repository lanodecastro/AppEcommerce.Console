using AppEcommerce.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public Cliente Cliente { get; set; }

        public Telefone(int id, string numero, TipoTelefone tipotelefone,Cliente cliente)
        {
            this.Id = id;
            this.Numero = numero;
            this.TipoTelefone = tipotelefone;
            this.Cliente = cliente;
        }

    }
}
