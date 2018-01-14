using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AprollSupport
{
    public class FileManger
    {
        const string INI = ".ini";
        string folderName = "";
        Dictionary<string, string> dict = new Dictionary<string, string>();

        public FileManger(string folderName)
        {
            this.folderName = folderName;
            init();
        }

        private void init()
        {
            try
            {
                String[] files = Directory.GetFiles(folderName);
                for(int i = 0; i < files.Length; i++)
                {
                    string[] items = (files[i]).Split('\\');
                    if(items != null && items.Length > 0 && 
                        items[items.Length - 1].Contains(INI))
                    {
                        dict.Add(items[items.Length - 1], files[i]);
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        public string[] getFiles()
        {
            return (dict.Count == 0) ? null : dict.Keys.ToArray();
        }

        public string[] getFilesPath()
        {
            return (dict.Count == 0) ? null : dict.Values.ToArray();
        }

        public string getFile(string filePath)
        {
            if (dict.Count == 0 || filePath.Equals(""))
                return null;

            string fileName = "";
            var keys = from entry in dict
                       where entry.Value == filePath
                       select entry.Key;

            foreach (var key in keys)
            {
                fileName = key;
            }

            return fileName;
        }

        public string getFilePath(string file)
        {
            if (dict.Count == 0 || file.Equals(""))
                return null;

            string filePath = "";
            return dict.TryGetValue(file, out filePath) ? filePath : null;
        }

        public string getFolderName()
        {
            return folderName;
        }
    }
}
