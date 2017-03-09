using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ActivAIDDatabaseLoad
{
    public static class DirectoryLoader
    {
        public static List<string> makeFileList(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            List<string> filePaths = new List<string>(files);
            //return AddBackSlashes(filePaths);
            return filePaths;
        }

        public static List<string> makeFileListExtension(string directory, string ext)
        {
            string extension = "*" + ext;
            string[] files = Directory.GetFiles(directory);
            List<string> filePaths = new List<string>(files);
            return filePaths;
        }

        private static List<string> AddBackSlashes(List<string> files)
        {
            List<string> filePaths = new List<string>();
            foreach (string file in files)
            {
                filePaths.Add(file.Replace(@"\", @"\\"));
            }
            return filePaths;
        }

    }
}
