using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_update
{
    internal class Connection
    {
        public string default_server = "localhost\\SQLEXPRESS";
        public string default_database = "test";
        private string servername;
        private string database;
        public Connection()
        {
            servername = default_server;
            database = default_database;
        }
        public SqlConnection connectSQL()
        {
            string connect = string.Format("Data Source = {0};Initial Catalog = {1};integrated security = true", servername, database);
            return new SqlConnection(connect);
        }
    }
}
