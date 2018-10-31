using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AppEcommerce.Model;

namespace AppEcommerce.Db
{
    public class DbObject
    {
        private readonly string _strConnectionString;
        public IDbConnection _objConnection { get; private set; }
        public DbObject()
        {
            _strConnectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

            _objConnection = new SqlConnection(_strConnectionString);


        }
        public void OpenConnection()
        {
            if (_objConnection.State != ConnectionState.Open)
            {
                _objConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (_objConnection.State != ConnectionState.Closed)
            {
                _objConnection.Close();
            }
        }

        public int InsertProduto(Produto produto)
        {
            string cmdInsertProduto = "insert into produto (Descricao,Preco,Peso,Disponivel) values(@Descricao,@Preco,@Peso,@Disponivel)";

            //instacia o command, definindo a conexão e SQL a ser executado
            using (IDbCommand command = new SqlCommand(cmdInsertProduto, _objConnection as SqlConnection))
            {
                command.Parameters.Add(new SqlParameter("@Descricao", produto.Descricao));
                command.Parameters.Add(new SqlParameter("@Preco", produto.Preco));
                command.Parameters.Add(new SqlParameter("@Peso", produto.Peso));
                command.Parameters.Add(new SqlParameter("@Disponivel", produto.Disponivel));

                OpenConnection();
                var rowsAffecteds = command.ExecuteNonQuery();
                CloseConnection();

                //adiciona os parâmetros

                return rowsAffecteds;
            }



        }
        public int UpdateProduto(Produto produto)
        {
            string cmdUpdateProduto = "update produto set Descricao=@Descricao,Preco=@Preco,Peso=@Peso,Disponivel=@Disponivel where Id=@Id";

            //instacia o command, definindo a conexão e SQL a ser executado

            using (IDbCommand command = new SqlCommand(cmdUpdateProduto, _objConnection as SqlConnection))
            {
                //adiciona os parâmetros
                command.Parameters.Add(new SqlParameter("@Id", produto.Id));
                command.Parameters.Add(new SqlParameter("@Descricao", produto.Descricao));
                command.Parameters.Add(new SqlParameter("@Preco", produto.Preco));
                command.Parameters.Add(new SqlParameter("@Peso", produto.Peso));
                command.Parameters.Add(new SqlParameter("@Disponivel", produto.Disponivel));

                OpenConnection();
                var rowsAffecteds = command.ExecuteNonQuery();
                CloseConnection();

                return rowsAffecteds;
            }

        }
        public int DeleteProduto(int produtoId)
        {
            string cmdDeleteProduto = "delete from produto where Id=@Id";

            //instacia o command, definindo a conexão e SQL a ser executado

            using (IDbCommand command = new SqlCommand(cmdDeleteProduto, _objConnection as SqlConnection))
            {

                //adiciona os parâmetros
                command.Parameters.Add(new SqlParameter("@Id", produtoId));

                OpenConnection();
                var rowsAffecteds = command.ExecuteNonQuery();
                CloseConnection();

                return rowsAffecteds;
            }
        }

        public IList<Produto> GetAllProducts()
        {
            var queryAllProducts = "select Id,Descricao,Preco,Peso,Disponivel from Produto";
            using (IDbCommand command = new SqlCommand(queryAllProducts, _objConnection as SqlConnection))
            {
                OpenConnection();

                IDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);

                IList<Produto>lstProduto=new List<Produto>();                

                while (dr.Read())
                {
                    Produto produto = new Produto(Convert.ToInt32(dr["Id"]), dr["Descricao"].ToString(), Convert.ToDouble(dr["Preco"]), Convert.ToDouble(dr["Peso"]), Convert.ToBoolean(dr["Disponivel"]));

                    lstProduto.Add(produto);
                }

                return lstProduto;
            }
        }
    }
}
