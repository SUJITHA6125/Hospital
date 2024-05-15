using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital.util
{
    using System.Data;
    using System.Data.SqlClient;

    namespace util
    {
        public class DBConnection
        {
            private static string connectionString;

            // Initialize connection string from property file
            static DBConnection()
            {
                connectionString = PropertyUtil.GetPropertyString();
            }

            public static IDbConnection GetConnection()
            {
                IDbConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }
    }

}
