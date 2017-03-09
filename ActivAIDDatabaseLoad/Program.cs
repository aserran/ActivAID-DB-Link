using ActivAID_DB_Link;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ActivAIDDatabaseLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Change directory path to your own
            List<string> filePaths = DirectoryLoader.makeFileList("C:\\Users\\Tony\\Desktop\\Main Help\\Help Html");
            ParserWrapper pwrap = new ParserWrapper(filePaths);
        }
    }
}
