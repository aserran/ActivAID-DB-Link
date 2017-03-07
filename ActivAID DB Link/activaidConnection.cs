using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivAID_DB_Link
{
    class activaidConnection
    {
        public static SqlConnection GetConnection()
        {
            string dblocation = "Server=.\\SQLEXPRESS;Database=ActivAID DB;Integrated Security=true";

            SqlConnection conn = new SqlConnection(dblocation);
            return conn;
        }
    }
}
