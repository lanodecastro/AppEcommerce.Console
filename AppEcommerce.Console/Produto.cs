using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double? Preco { get; set; }
        public double Peso { get; set; }
        public bool Disponivel { get; set; }

        public Produto(string descricao,double preco,double peso)
        {
            this.Descricao = descricao;
            this.Preco = preco;
            this.Peso = peso;
            this.Disponivel = true;
        }
    }
}
