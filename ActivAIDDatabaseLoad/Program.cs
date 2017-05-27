//using ActivAID_DB_Link;
using Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Test;

namespace ActivAID
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change directory path to your own
            List<string> filePaths = DirectoryLoader.makeFileList("C:\\Users\\Matthew\\Desktop\\Main Help\\Main Help\\JUSTHTML"); //args[0]
            ParserWrapper pwrap = new ParserWrapper(filePaths);
            while (true) {; }
        }
    }
}
