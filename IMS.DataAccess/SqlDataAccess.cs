using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;


namespace IMS.DataAccess
{
    public class SqlDataAccess
    {
        //Get the connection string from appsettings
        private static string GetConnectionString()
        {
            var connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = IMSDatabase; Integrated Security = True;";
            return connectionString;
        }


        public List<T> LoadData<T, U>(string sqlStatement, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement, T parameters)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }
    }
}
