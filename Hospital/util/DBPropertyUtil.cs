using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.util
{
    using System.Configuration;

    namespace util
    {
        public class PropertyUtil
        {
            public static string GetPropertyString()
            {
                // Read connection properties from app.config or a separate properties file
                string hostname = ConfigurationManager.AppSettings["DESKTOP-CN4H436"];
                string dbname = ConfigurationManager.AppSettings["HOSPITAL"];
                string username = ConfigurationManager.AppSettings["username"];
                string password = ConfigurationManager.AppSettings["password"];
                string port = ConfigurationManager.AppSettings["port"];

                // Construct connection string
                string connectionString = $"Server={hostname},{port};Database={dbname};User Id={username};Password={password};";

                return connectionString;
            }
        }
    }

}
