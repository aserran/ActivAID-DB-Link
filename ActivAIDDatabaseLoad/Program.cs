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
            List<string> filePaths = DirectoryLoader.makeFileList("C:\\Program Files\\ActivATE\\ActivATE 5.x\\ActivAID\\Debug\\Media\\HelpHTML");
            ParserWrapper pwrap = new ParserWrapper(filePaths);
        }
    }
}
