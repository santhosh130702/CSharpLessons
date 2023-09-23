using Microsoft.Data.SqlClient;

namespace AuthorApplication2.Models
{
    public class SqlHelper
    {   
        public static SqlConnection CreateConnection() 
        {
            var connString = @"server=200411LTP2830\SQLEXPRESS;database=testdb1;integrated security=true; Encrypt=false;";
            SqlConnection sqlcn = new SqlConnection(connString);

            return sqlcn; 
        }
    }
}
