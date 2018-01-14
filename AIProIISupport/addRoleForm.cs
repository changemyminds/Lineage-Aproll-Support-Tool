using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AprollSupport
{
    public partial class addRoleForm : Form
    {
        private static addRoleForm form = null;

        private addRoleForm()
        {
            InitializeComponent();
        }

        private static addRoleForm getInstance()
        {
            if (form == null)
            {
                form = new addRoleForm();
                FormSetting.setForm(form);
                FormSetting.addWindowMouseListener();
            }
            return form;
        }

        public static addRoleForm getForm()
        {
            return getInstance();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(!txtName.Text.Trim().Equals(""))
            {
                RoleManager.addItem(txtName.Text.Trim());
                txtName.Text = "";
                MainForm.updateRoleList();
            }

            this.Hide();
        }

        private void addRoleForm_Activated(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btnEnter_Click(null, null);
            }
        }
    }
}
