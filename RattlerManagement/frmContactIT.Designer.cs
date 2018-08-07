namespace RattlerManagement
{
    partial class frmContactIT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxSubject = new System.Windows.Forms.TextBox();
            this.lsbContactList = new System.Windows.Forms.ListBox();
            this.grpBoxPerson = new System.Windows.Forms.GroupBox();
            this.rdb_ITDepartment = new System.Windows.Forms.RadioButton();
            this.rdb_Teacher = new System.Windows.Forms.RadioButton();
            this.rdb_Principal = new System.Windows.Forms.RadioButton();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rchboxMessage = new System.Windows.Forms.RichTextBox();
            this.txtboxCaptcha = new System.Windows.Forms.TextBox();
            this.btnSortTeacher = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxPerson.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxSubject
            // 
            this.txtboxSubject.Location = new System.Drawing.Point(364, 42);
            this.txtboxSubject.Name = "txtboxSubject";
            this.txtboxSubject.Size = new System.Drawing.Size(200, 20);
            this.txtboxSubject.TabIndex = 0;
            // 
            // lsbContactList
            // 
            this.lsbContactList.FormattingEnabled = true;
            this.lsbContactList.Location = new System.Drawing.Point(168, 42);
            this.lsbContactList.Name = "lsbContactList";
            this.lsbContactList.Size = new System.Drawing.Size(131, 108);
            this.lsbContactList.TabIndex = 2;
            // 
            // grpBoxPerson
            // 
            this.grpBoxPerson.Controls.Add(this.rdb_ITDepartment);
            this.grpBoxPerson.Controls.Add(this.rdb_Teacher);
            this.grpBoxPerson.Controls.Add(this.rdb_Principal);
            this.grpBoxPerson.Location = new System.Drawing.Point(12, 42);
            this.grpBoxPerson.Name = "grpBoxPerson";
            this.grpBoxPerson.Size = new System.Drawing.Size(150, 104);
            this.grpBoxPerson.TabIndex = 3;
            this.grpBoxPerson.TabStop = false;
            this.grpBoxPerson.Text = "Select a Contact";
            this.grpBoxPerson.Enter += new System.EventHandler(this.grpBoxPerson_Enter);
            // 
            // rdb_ITDepartment
            // 
            this.rdb_ITDepartment.AutoSize = true;
            this.rdb_ITDepartment.Location = new System.Drawing.Point(6, 65);
            this.rdb_ITDepartment.Name = "rdb_ITDepartment";
            this.rdb_ITDepartment.Size = new System.Drawing.Size(90, 17);
            this.rdb_ITDepartment.TabIndex = 2;
            this.rdb_ITDepartment.TabStop = true;
            this.rdb_ITDepartment.Text = "ITDepartment";
            this.rdb_ITDepartment.UseVisualStyleBackColor = true;
            // 
            // rdb_Teacher
            // 
            this.rdb_Teacher.AutoSize = true;
            this.rdb_Teacher.Location = new System.Drawing.Point(6, 42);
            this.rdb_Teacher.Name = "rdb_Teacher";
            this.rdb_Teacher.Size = new System.Drawing.Size(65, 17);
            this.rdb_Teacher.TabIndex = 1;
            this.rdb_Teacher.TabStop = true;
            this.rdb_Teacher.Text = "Teacher";
            this.rdb_Teacher.UseVisualStyleBackColor = true;
            // 
            // rdb_Principal
            // 
            this.rdb_Principal.AutoSize = true;
            this.rdb_Principal.Location = new System.Drawing.Point(6, 19);
            this.rdb_Principal.Name = "rdb_Principal";
            this.rdb_Principal.Size = new System.Drawing.Size(65, 17);
            this.rdb_Principal.TabIndex = 0;
            this.rdb_Principal.TabStop = true;
            this.rdb_Principal.Text = "Principal";
            this.rdb_Principal.UseVisualStyleBackColor = true;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Location = new System.Drawing.Point(316, 133);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(0, 13);
            this.lblCaptcha.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(579, 45);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 79);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(305, 45);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "Subject:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(305, 81);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Message:";
            // 
            // rchboxMessage
            // 
            this.rchboxMessage.Location = new System.Drawing.Point(364, 81);
            this.rchboxMessage.Name = "rchboxMessage";
            this.rchboxMessage.Size = new System.Drawing.Size(200, 43);
            this.rchboxMessage.TabIndex = 8;
            this.rchboxMessage.Text = "";
            // 
            // txtboxCaptcha
            // 
            this.txtboxCaptcha.Location = new System.Drawing.Point(456, 151);
            this.txtboxCaptcha.Name = "txtboxCaptcha";
            this.txtboxCaptcha.Size = new System.Drawing.Size(107, 20);
            this.txtboxCaptcha.TabIndex = 9;
            // 
            // btnSortTeacher
            // 
            this.btnSortTeacher.Location = new System.Drawing.Point(168, 151);
            this.btnSortTeacher.Name = "btnSortTeacher";
            this.btnSortTeacher.Size = new System.Drawing.Size(130, 20);
            this.btnSortTeacher.TabIndex = 10;
            this.btnSortTeacher.Text = "Sort";
            this.btnSortTeacher.UseVisualStyleBackColor = true;
            this.btnSortTeacher.Click += new System.EventHandler(this.btnSortTeacher_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(693, 24);
            this.mnuMain.TabIndex = 29;
            this.mnuMain.Text = "mnuMain";
            // 
            // edusistToolStripMenuItem
            // 
            this.edusistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToUseToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.edusistToolStripMenuItem.Name = "edusistToolStripMenuItem";
            this.edusistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.edusistToolStripMenuItem.Text = "Edusist";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmContactIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 183);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.btnSortTeacher);
            this.Controls.Add(this.txtboxCaptcha);
            this.Controls.Add(this.rchboxMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.grpBoxPerson);
            this.Controls.Add(this.lsbContactList);
            this.Controls.Add(this.txtboxSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmContactIT";
            this.Text = "Edusist: Contact Someone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContactIT_FormClosing);
            this.Load += new System.EventHandler(this.frmContactIT_Load);
            this.grpBoxPerson.ResumeLayout(false);
            this.grpBoxPerson.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxSubject;
        private System.Windows.Forms.ListBox lsbContactList;
        private System.Windows.Forms.GroupBox grpBoxPerson;
        private System.Windows.Forms.RadioButton rdb_ITDepartment;
        private System.Windows.Forms.RadioButton rdb_Teacher;
        private System.Windows.Forms.RadioButton rdb_Principal;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox rchboxMessage;
        private System.Windows.Forms.TextBox txtboxCaptcha;
        private System.Windows.Forms.Button btnSortTeacher;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
    }
}