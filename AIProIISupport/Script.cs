using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace AprollSupport
{
    public class Script : RoleFile
    {
        Thread thread = null;

        string role = "";
        string roleServer = "";
        List<string> lstRole = null;

        public delegate void ScriptStartEventHandler();
        public event ScriptStartEventHandler ScriptStartEvent;

        public delegate void ScriptFinishEventHandler();
        public event ScriptFinishEventHandler ScriptFinishEvent;

        public Script(Role role) 
            : base(role.getFileName(), role.getFilePath())
        {
            this.role = role.getRole();
            this.roleServer = role.getServer();
            this.thread = new Thread(copyFile);
        }

        public void setRoleToWrite(string roleServer, List<string> lstRole)
        {
            this.roleServer = roleServer;
            this.lstRole = lstRole;
        }

        public void create()
        {
            if(!thread.IsAlive)
            {
                thread = new Thread(copyFile);
                thread.Start();
            }
        }

        private void copyFile()
        {
            if (lstRole == null || lstRole.Count == 0)
                return;

            onScriptStartEvent();

            for (int i = 0; i < lstRole.Count; i++)
            {
                if (role.Equals("")) break;
                if (role.Equals(lstRole[i])) continue;
                string destFileName = path.Replace(role, lstRole[i]);
                File.Copy(path, destFileName, true);
                IniSetting.setFilePath(destFileName);
                IniSetting.writeValue<string>("AutoLogin", "LoginRace", lstRole[i]);
                IniSetting.writeValue<string>("AutoLogin", "LoginServerName", roleServer);

                Thread.Sleep(100);
            }

            onScriptFinishEvent();
        }

        private void onScriptStartEvent()
        {
            ScriptStartEvent?.Invoke();
        }

        private void onScriptFinishEvent()
        {
            ScriptFinishEvent?.Invoke();
        }

    }
}
