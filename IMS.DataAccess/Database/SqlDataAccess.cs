using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace IMS.DataAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            this._config = config;
        }

        //Get the connection string from appsettings
        //private static string GetConnectionString()
        //{
        //    var connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = IMSDatabase; Integrated Security = True;";
        //    return connectionString;
        //}


        public List<T> LoadData<T, U>(string sqlStatement, U parameters)
        {
            string ConnectionString = _config.GetConnectionString("SqlServer");

            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement, T parameters)
        {
            string ConnectionString = _config.GetConnectionString("SqlServer");

            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }

        }
    }
}
