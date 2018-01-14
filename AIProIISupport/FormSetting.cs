using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AprollSupport
{
    public class FormSetting
    {
        private static FormSetting formSetting = null;

        Form form = null;
        private Point startPoint;

        private FormSetting(Form form)
        {
            this.form = form;
        }

        public static void setForm(Form form)
        {
            formSetting = new FormSetting(form);
        }

        public static void addWindowMouseListener()
        {
            if (formSetting == null) return;

            formSetting.addWindowMouseListener_();
        }

        public void addWindowMouseListener_()
        {
            form.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            form.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
        }

        public void removeWindowMouseListener()
        {
            form.MouseDown -= new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            form.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            //如果使用者使用的是左鍵按下，意旨使用右鍵拖曳無效
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                //新視窗的位置
                mousePos.Offset(startPoint.X, startPoint.Y);
                //改變視窗位置
                form.Location = mousePos;
            }
        }


    }
}
