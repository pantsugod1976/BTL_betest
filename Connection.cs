using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BTL_update
{
    internal class Connection
    {
        private string servername;
        private string database;
        public Connection()
        {
            servername = ConfigurationManager.AppSettings["ServerName"];
            database = ConfigurationManager.AppSettings["DatabaseName"];
        }
        public SqlConnection connectSQL()
        {
            string connect = string.Format("Data Source = {0};Initial Catalog = {1};integrated security = true", servername, database);
            return new SqlConnection(connect);
        }
    }
}
