using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AprollSupport
{
    public class RoleFile
    {
        protected string name = "";
        protected string path = "";

        public RoleFile(string name, string path)
        {
            this.name = name;
            this.path = path;
        }

        public string getFileName()
        {
            return name;
        }

        public string getFilePath()
        {
            return path;
        }


    }
}
