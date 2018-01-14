namespace AprollSupport
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cboFileList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSettingFileName = new System.Windows.Forms.Label();
            this.btnUpRole = new System.Windows.Forms.Button();
            this.btnDownRole = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRemvoeRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.cboSettingServer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCoverScript = new System.Windows.Forms.Button();
            this.lbxRoles = new System.Windows.Forms.ListBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScriptName = new System.Windows.Forms.TextBox();
            this.txtSettingPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFileList
            // 
            this.cboFileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileList.FormattingEnabled = true;
            this.cboFileList.Location = new System.Drawing.Point(12, 41);
            this.cboFileList.Name = "cboFileList";
            this.cboFileList.Size = new System.Drawing.Size(225, 20);
            this.cboFileList.TabIndex = 0;
            this.cboFileList.DropDown += new System.EventHandler(this.cboFileList_DropDown);
            this.cboFileList.SelectedIndexChanged += new System.EventHandler(this.cboFileList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSettingFileName);
            this.groupBox1.Controls.Add(this.btnUpRole);
            this.groupBox1.Controls.Add(this.btnDownRole);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnRemvoeRole);
            this.groupBox1.Controls.Add(this.btnAddRole);
            this.groupBox1.Controls.Add(this.cboSettingServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCoverScript);
            this.groupBox1.Controls.Add(this.lbxRoles);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblSettingFileName
            // 
            this.lblSettingFileName.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSettingFileName.Location = new System.Drawing.Point(9, 157);
            this.lblSettingFileName.Name = "lblSettingFileName";
            this.lblSettingFileName.Size = new System.Drawing.Size(95, 20);
            this.lblSettingFileName.TabIndex = 11;
            // 
            // btnUpRole
            // 
            this.btnUpRole.Location = new System.Drawing.Point(197, 46);
            this.btnUpRole.Name = "btnUpRole";
            this.btnUpRole.Size = new System.Drawing.Size(25, 25);
            this.btnUpRole.TabIndex = 18;
            this.btnUpRole.Text = "↑";
            this.btnUpRole.UseVisualStyleBackColor = true;
            this.btnUpRole.Click += new System.EventHandler(this.btnUpDownRole_Click);
            // 
            // btnDownRole
            // 
            this.btnDownRole.Location = new System.Drawing.Point(197, 97);
            this.btnDownRole.Name = "btnDownRole";
            this.btnDownRole.Size = new System.Drawing.Size(25, 25);
            this.btnDownRole.TabIndex = 17;
            this.btnDownRole.Text = "↓";
            this.btnDownRole.UseVisualStyleBackColor = true;
            this.btnDownRole.Click += new System.EventHandler(this.btnUpDownRole_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.ImageKey = "(無)";
            this.btnSave.Location = new System.Drawing.Point(40, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 16;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.ImageKey = "(無)";
            this.btnOpen.Location = new System.Drawing.Point(9, 16);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(25, 25);
            this.btnOpen.TabIndex = 15;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnRemvoeRole
            // 
            this.btnRemvoeRole.Location = new System.Drawing.Point(166, 15);
            this.btnRemvoeRole.Name = "btnRemvoeRole";
            this.btnRemvoeRole.Size = new System.Drawing.Size(25, 25);
            this.btnRemvoeRole.TabIndex = 14;
            this.btnRemvoeRole.Text = "-";
            this.btnRemvoeRole.UseVisualStyleBackColor = true;
            this.btnRemvoeRole.Click += new System.EventHandler(this.btnRemvoeRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(131, 16);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(25, 25);
            this.btnAddRole.TabIndex = 13;
            this.btnAddRole.Text = "+";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // cboSettingServer
            // 
            this.cboSettingServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSettingServer.FormattingEnabled = true;
            this.cboSettingServer.Items.AddRange(new object[] {
            "巴風特"});
            this.cboSettingServer.Location = new System.Drawing.Point(108, 128);
            this.cboSettingServer.Name = "cboSettingServer";
            this.cboSettingServer.Size = new System.Drawing.Size(109, 20);
            this.cboSettingServer.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(4, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "設定伺服器：";
            // 
            // btnCoverScript
            // 
            this.btnCoverScript.Location = new System.Drawing.Point(131, 155);
            this.btnCoverScript.Name = "btnCoverScript";
            this.btnCoverScript.Size = new System.Drawing.Size(86, 22);
            this.btnCoverScript.TabIndex = 2;
            this.btnCoverScript.Text = "建立檔案";
            this.btnCoverScript.UseVisualStyleBackColor = true;
            this.btnCoverScript.Click += new System.EventHandler(this.btnCoverScript_Click);
            // 
            // lbxRoles
            // 
            this.lbxRoles.FormattingEnabled = true;
            this.lbxRoles.ItemHeight = 12;
            this.lbxRoles.Location = new System.Drawing.Point(9, 46);
            this.lbxRoles.Name = "lbxRoles";
            this.lbxRoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxRoles.Size = new System.Drawing.Size(182, 76);
            this.lbxRoles.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(98, 100);
            this.txtServer.Name = "txtServer";
            this.txtServer.ReadOnly = true;
            this.txtServer.Size = new System.Drawing.Size(139, 22);
            this.txtServer.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "伺服器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "角色名稱：";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(120, 69);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.ReadOnly = true;
            this.txtRoleName.Size = new System.Drawing.Size(117, 22);
            this.txtRoleName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "腳本名稱：";
            // 
            // txtScriptName
            // 
            this.txtScriptName.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScriptName.Location = new System.Drawing.Point(98, 130);
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.ReadOnly = true;
            this.txtScriptName.Size = new System.Drawing.Size(139, 21);
            this.txtScriptName.TabIndex = 8;
            // 
            // txtSettingPath
            // 
            this.txtSettingPath.Location = new System.Drawing.Point(12, 12);
            this.txtSettingPath.Multiline = true;
            this.txtSettingPath.Name = "txtSettingPath";
            this.txtSettingPath.ReadOnly = true;
            this.txtSettingPath.Size = new System.Drawing.Size(228, 22);
            this.txtSettingPath.TabIndex = 10;
            this.txtSettingPath.Text = "--------點我設定路徑--------";
            this.txtSettingPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSettingPath.DoubleClick += new System.EventHandler(this.txtSettingPath_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 345);
            this.Controls.Add(this.txtSettingPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScriptName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboFileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "AIProII Support";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFileList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCoverScript;
        private System.Windows.Forms.ListBox lbxRoles;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScriptName;
        private System.Windows.Forms.TextBox txtSettingPath;
        private System.Windows.Forms.ComboBox cboSettingServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRemvoeRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnUpRole;
        private System.Windows.Forms.Button btnDownRole;
        private System.Windows.Forms.Label lblSettingFileName;
    }
}

