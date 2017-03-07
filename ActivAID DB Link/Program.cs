using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivAID_DB_Link
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivAIDDB aidDatabase = new ActivAIDDB();
            aidDatabase.insertIntoFiles("\\DEVIIX\\Users\\Tony\\Desktop\\Main Help\\New User.html", "new,user,add");
            
        }
    }
}
