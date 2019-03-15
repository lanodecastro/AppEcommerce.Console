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
        public int Quantidade { get; private set; }

        public Produto(string descricao,double preco,double peso)
        {
            this.Descricao = descricao;
            this.Preco = preco;
            this.Peso = peso;
            this.Disponivel = true;
        }
        public Produto(int id,string descricao, double preco, double peso,bool disponivel)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Preco = preco;
            this.Peso = peso;
            this.Disponivel = disponivel;
        }
        public void AcrescerQuantidade(int quantidadeAserAcrescida)
        {
            Quantidade += quantidadeAserAcrescida;
        }
        public void DecrescerQuantidade(int quantidadeAserDecrescida)
        {
            Quantidade -= quantidadeAserDecrescida;
        }

    }
}
