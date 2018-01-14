using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AprollSupport
{
    public partial class MainForm : Form
    {
        private static MainForm form = null;
        FileManger fileManger = null;

        private MainForm()
        {
            InitializeComponent();
        }

        private static MainForm getInstance()
        {
            if (form == null)
                form = new MainForm();
            return form;
        }

        public static MainForm getForm()
        {
            return getInstance();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (cboSettingServer.Items.Count == 0) return;
            cboSettingServer.SelectedIndex = cboSettingServer.Items.Count - 1;

            enableUi(false);
            txtSettingPath.Enabled = true;

            txtSettingPath.Focus();
            txtSettingPath.SelectAll();
        }

        private void cboFileList_DropDown(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            if (cbo == null || fileManger == null || fileManger.getFiles() == null) return;

            cbo.Items.Clear();
            cbo.Items.AddRange(fileManger.getFiles());
        }

        private void txtSettingPath_DoubleClick(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtSettingPath.Text = fbd.SelectedPath;
                    fileManger = new FileManger(fbd.SelectedPath);
                    enableUi(true);
                }
            }
        }

        private void cboFileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            if (cbo == null || fileManger == null || cbo.Text.Equals("")) return;

            string filePath = fileManger.getFilePath(cbo.Text);
            Role role = new Role(cbo.Text, filePath);
            txtRoleName.Text = role.getRole();
            txtServer.Text = role.getServer();
            txtScriptName.Text = role.getScript();

            cbo.Tag = role;
        }

        public static void updateRoleList()
        {
            getInstance().updateRoleList_();
        }

        public void updateRoleList_()
        {
            lbxRoles.Items.Clear();

            string[] roleNames = RoleManager.getRoleNames();
            if (roleNames == null) return;

            foreach (string item in roleNames)
                lbxRoles.Items.Add(item);
        }

        private void btnRemvoeRole_Click(object sender, EventArgs e)
        {
            if (lbxRoles.SelectedIndex == -1) return;

            foreach (object selecteditem in lbxRoles.SelectedItems)
            {
                string item = selecteditem as string;
                if (item != null) RoleManager.removeItem(item);
            }

            updateRoleList_();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            addRoleForm.getForm().ShowDialog();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var open = new OpenFileDialog())
            {
                open.Title = "開啟舊檔";
                open.CheckFileExists = true;
                open.InitialDirectory = fileManger.getFolderName();
                open.FileName = (lblSettingFileName.Text.Equals("")) ? "RoleName" : lblSettingFileName.Text;
                open.Filter = "TXT File |*.txt";

                DialogResult result = open.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(open.FileName))
                    {
                        List<string> listData = new List<string>();
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Equals("")) break;
                            listData.Add(line);
                        }

                        RoleManager.clearItem();
                        RoleManager.addItem(listData.ToArray());
                        updateRoleList_();

                        int startIndex = open.FileName.LastIndexOf("\\") + 1;
                        lblSettingFileName.Text = open.FileName.Substring(startIndex, open.FileName.Length - startIndex);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (fileManger.getFolderName().Equals("")) return;
           
            using (var save = new SaveFileDialog())
            {
                save.Title = "另存新檔";
                save.InitialDirectory = fileManger.getFolderName();
                save.FileName = (lblSettingFileName.Text.Equals("")) ? "RoleName" : lblSettingFileName.Text;
                save.Filter = "TXT File |*.txt";

                DialogResult result = save.ShowDialog();
                if (result == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(save.FileName))
                    {
                        string[] roleNames = RoleManager.getRoleNames();
                        if (roleNames == null) return;
                        for(int i = 0; i < roleNames.Length; i++)
                            writer.WriteLine(roleNames[i]);
                    }
                }
            }
        }

        private void btnUpDownRole_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            listBoxUpDown(lbxRoles, (btn.Name.Equals("btnUpRole")));
        }

        private void btnCoverScript_Click(object sender, EventArgs e)
        {
            if (cboFileList.Tag as Role == null ||
                lbxRoles.Items.Count == 0) return;

            List<string> lstRole = new List<string>();
            foreach (string item in lbxRoles.Items)
                lstRole.Add(item);

            Role role = cboFileList.Tag as Role;
            Script script = new Script(role);
            script.ScriptStartEvent += new Script.ScriptStartEventHandler(OnScriptStartEvent);
            script.ScriptFinishEvent += new Script.ScriptFinishEventHandler(OnScriptFinishEvent);
            script.setRoleToWrite(cboSettingServer.Text, lstRole);
            script.create();
        }

        private void OnScriptStartEvent()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Script.ScriptStartEventHandler(OnScriptStartEvent));
                return;
            }

            enableUi(false);
        }

        private void OnScriptFinishEvent()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Script.ScriptStartEventHandler(OnScriptFinishEvent));
                return;
            }

            enableUi(true);

            MessageBox.Show("Finish");
        }

        private void enableUi(bool enable)
        {
            txtSettingPath.Enabled = enable;
            cboFileList.Enabled = enable;
            cboSettingServer.Enabled = enable;
            btnOpen.Enabled = enable;
            btnSave.Enabled = enable;
            btnAddRole.Enabled = enable;
            btnRemvoeRole.Enabled = enable;
            btnUpRole.Enabled = enable;
            btnDownRole.Enabled = enable;
            btnCoverScript.Enabled = enable;
            lbxRoles.Enabled = enable;
        }

        private void listBoxUpDown(object obj, bool isUp)
        {
            ListBox lbx = obj as ListBox;
            if (lbx == null || lbx.SelectedIndex < 0) return;

            int index = lbx.SelectedIndex;
            int tempUpDown = 0;

            if(isUp)
            {
                tempUpDown = index - 1;
                if (tempUpDown < 0) return;
            }
            else
            {
                tempUpDown = index + 1;
                if (tempUpDown >= lbx.Items.Count) return;
            }

            string tmp = lbx.Items[index].ToString();
            lbx.Items.RemoveAt(index);
            lbx.Items.Insert(tempUpDown, tmp);
            lbx.SelectedIndex = tempUpDown;

            List<string> lstRole = new List<string>();
            foreach (string item in lbxRoles.Items)
                lstRole.Add(item);

            RoleManager.clearItem();
            RoleManager.addItem(lstRole.ToArray());
        }

 
    }
}
