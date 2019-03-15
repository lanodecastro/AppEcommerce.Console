using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Console.Core.Dominio.Repositorio
{
    public interface IRepositorio<TEntity>
    {
        void Salvar(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(object id);
        TEntity Recuperar(object id);
    }
}
