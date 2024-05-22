using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Nesuko
{
    public class ConfigManager
    {
        private string path;
        private string filePath;

        public ConfigManager(string customPath) {
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\"+customPath;
            filePath = path + "\\players.txt";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                File.Create(filePath);
            } else if (!File.Exists(filePath)) {
                File.Create(filePath);
            }
        }

        public string getPath()
        {
            return path;
        }

        public string getFile()
        {
            String line;
            StreamReader sr = new StreamReader(filePath);
            line = sr.ReadLine();

            return null;
        }
        
    }
}
