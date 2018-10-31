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
    public abstract class DbObject
    {
        private readonly string _strConnectionString;
        public IDbConnection _objConnection { get; private set; }
        public DbObject()
        {
            _strConnectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;

            _objConnection = new SqlConnection(_strConnectionString);


        }
        private void OpenConnection()
        {
            if (_objConnection.State != ConnectionState.Open)
            {
                _objConnection.Open();
            }
        }
        private void CloseConnection()
        {
            if (_objConnection.State != ConnectionState.Closed)
            {
                _objConnection.Close();
            }
        }
        protected int ExecuteNoQuery(string cmdSQL, IList<SqlParameter> parameters)
        {
            using (IDbCommand command = new SqlCommand(cmdSQL, _objConnection as SqlConnection))
            {
                foreach (var item in parameters)
                {
                    command.Parameters.Add(item);
                }

                OpenConnection();
                var rowsAffecteds = command.ExecuteNonQuery();
                CloseConnection();
                return rowsAffecteds;
            }
        }

        protected IDataReader GetReader(string cmdSQL, IList<SqlParameter> parameters)
        {
            using (IDbCommand command = new SqlCommand(cmdSQL, _objConnection as SqlConnection))
            {
                foreach (var item in parameters)
                {
                    command.Parameters.Add(item);
                }
                
                OpenConnection();

                IDataReader objDataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return objDataReader;
            }
        }
    }
}
