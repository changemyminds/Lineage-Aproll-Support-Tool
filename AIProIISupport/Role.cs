using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AprollSupport
{
    public class Role : RoleFile
    {
        string role = "";
        string server = "";
        string script = "";
        
        public Role(string fileName, string filePath) : base(fileName, filePath)
        {
            init();
        }

        private void init()
        {
            if (name.Equals("") || path.Equals("") ||
                name.IndexOf('.') == -1)
                return;
 
            try
            {
                IniSetting.setFilePath(path);
                IniSetting.readValue<string>("AutoLogin", "LoginRace", ref role);
                IniSetting.readValue<string>("AutoLogin", "LoginServerName", ref server);

                int startIndex = base.name.IndexOf(' ');
                int endIndex = base.name.IndexOf('.');
                script = (startIndex != -1) ? name.Substring(startIndex, endIndex - startIndex) : "";
            }
            catch (Exception ex)
            { }
        }

        public string getRole()
        {
            return role;
        }

        public string getServer()
        {
            return server;
        }

        public string getScript()
        {
            return script;
        }
    }
}
