using AppEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Db
{
    public class ProdutoDao : DbObject, IDataAccesObject<Produto>
    {

        public void Save(Produto produto)
        {
            string cmdInsertProduto = "insert into produto (Descricao,Preco,Peso,Disponivel) values(@Descricao,@Preco,@Peso,@Disponivel)";

            IList<SqlParameter> lstParams = new List<SqlParameter>();

            lstParams.Add(new SqlParameter("@Descricao", produto.Descricao));
            lstParams.Add(new SqlParameter("@Preco", produto.Preco));
            lstParams.Add(new SqlParameter("@Peso", produto.Peso));
            lstParams.Add(new SqlParameter("@Disponivel", produto.Disponivel));

            ExecuteNoQuery(cmdInsertProduto, lstParams);
        }

        public void Update(Produto obj)
        {
            string cmdUpdateProduto = "update Produto set Descricao=@Descricao,Preco=@Preco,Peso=@Peso,Disponivel=@Disponivel where Id=@Id ";

            IList<SqlParameter> lstParams = new List<SqlParameter>();

            lstParams.Add(new SqlParameter("@Id", obj.Id));
            lstParams.Add(new SqlParameter("@Descricao", obj.Descricao));
            lstParams.Add(new SqlParameter("@Preco", obj.Preco));
            lstParams.Add(new SqlParameter("@Peso", obj.Peso));
            lstParams.Add(new SqlParameter("@Disponivel", obj.Disponivel));

            ExecuteNoQuery(cmdUpdateProduto, lstParams);
        }

        public void Delete(object primaryKey)
        {
            string cmdDeleteProduto = "delete from Produto where Id=@Id";

            IList<SqlParameter> lstParameter = new List<SqlParameter>();

            lstParameter.Add(new SqlParameter("@Id", primaryKey));

            ExecuteNoQuery(cmdDeleteProduto, lstParameter);
        }

        public IList<Produto> GetAll()
        {
            string sql = "select id,descricao,preco,peso,disponivel from produto";

            IDataReader dr = this.GetReader(sql, new List<SqlParameter>());
            
            return ReadProducts(dr);
           
        }

        private IList<Produto> ReadProducts(IDataReader dr)
        {
            IList<Produto> lst = new List<Produto>();
            while (dr.Read())
            {
                var produto = new Produto(Convert.ToInt32(dr["Id"]), dr["Descricao"].ToString(), Convert.ToDouble(dr["Preco"]), Convert.ToDouble(dr["Peso"]), Convert.ToBoolean(dr["Disponivel"]));
                lst.Add(produto);
            }
            return lst; 
        }
    }
}
