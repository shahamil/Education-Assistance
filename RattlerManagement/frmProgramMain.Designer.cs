namespace RattlerManagement
{
    partial class frm_LoginPage
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
            this.components = new System.ComponentModel.Container();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_student = new System.Windows.Forms.RadioButton();
            this.rdb_teacher = new System.Windows.Forms.RadioButton();
            this.rdb_principal = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bttn_ForgotPassword = new System.Windows.Forms.Button();
            this.gbox_RoleSelect = new System.Windows.Forms.GroupBox();
            this.mnuStripmain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prgbarLoadingLogin = new System.Windows.Forms.ProgressBar();
            this.tmrGarbageCollector = new System.Windows.Forms.Timer(this.components);
            this.gbox_RoleSelect.SuspendLayout();
            this.mnuStripmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(195, 114);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(140, 20);
            this.txt_Username.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(195, 161);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(140, 20);
            this.txt_Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(190, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(190, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // rdb_student
            // 
            this.rdb_student.AutoSize = true;
            this.rdb_student.Location = new System.Drawing.Point(9, 27);
            this.rdb_student.Name = "rdb_student";
            this.rdb_student.Size = new System.Drawing.Size(62, 17);
            this.rdb_student.TabIndex = 4;
            this.rdb_student.TabStop = true;
            this.rdb_student.Text = "Student";
            this.rdb_student.UseVisualStyleBackColor = true;
            // 
            // rdb_teacher
            // 
            this.rdb_teacher.AutoSize = true;
            this.rdb_teacher.Location = new System.Drawing.Point(9, 50);
            this.rdb_teacher.Name = "rdb_teacher";
            this.rdb_teacher.Size = new System.Drawing.Size(65, 17);
            this.rdb_teacher.TabIndex = 5;
            this.rdb_teacher.TabStop = true;
            this.rdb_teacher.Text = "Teacher";
            this.rdb_teacher.UseVisualStyleBackColor = true;
            // 
            // rdb_principal
            // 
            this.rdb_principal.AutoSize = true;
            this.rdb_principal.Location = new System.Drawing.Point(9, 73);
            this.rdb_principal.Name = "rdb_principal";
            this.rdb_principal.Size = new System.Drawing.Size(65, 17);
            this.rdb_principal.TabIndex = 6;
            this.rdb_principal.TabStop = true;
            this.rdb_principal.Text = "Principal";
            this.rdb_principal.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Location = new System.Drawing.Point(356, 152);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // bttn_ForgotPassword
            // 
            this.bttn_ForgotPassword.BackColor = System.Drawing.Color.ForestGreen;
            this.bttn_ForgotPassword.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.bttn_ForgotPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bttn_ForgotPassword.Location = new System.Drawing.Point(356, 106);
            this.bttn_ForgotPassword.Name = "bttn_ForgotPassword";
            this.bttn_ForgotPassword.Size = new System.Drawing.Size(105, 33);
            this.bttn_ForgotPassword.TabIndex = 8;
            this.bttn_ForgotPassword.Text = "Forgot Password";
            this.bttn_ForgotPassword.UseVisualStyleBackColor = false;
            this.bttn_ForgotPassword.Click += new System.EventHandler(this.bttn_ForgotPassword_Click);
            // 
            // gbox_RoleSelect
            // 
            this.gbox_RoleSelect.BackColor = System.Drawing.Color.Transparent;
            this.gbox_RoleSelect.Controls.Add(this.rdb_principal);
            this.gbox_RoleSelect.Controls.Add(this.rdb_student);
            this.gbox_RoleSelect.Controls.Add(this.rdb_teacher);
            this.gbox_RoleSelect.Location = new System.Drawing.Point(12, 88);
            this.gbox_RoleSelect.Name = "gbox_RoleSelect";
            this.gbox_RoleSelect.Size = new System.Drawing.Size(170, 100);
            this.gbox_RoleSelect.TabIndex = 9;
            this.gbox_RoleSelect.TabStop = false;
            this.gbox_RoleSelect.Text = "Select Role";
            // 
            // mnuStripmain
            // 
            this.mnuStripmain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuStripmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuStripmain.Location = new System.Drawing.Point(0, 0);
            this.mnuStripmain.Name = "mnuStripmain";
            this.mnuStripmain.Size = new System.Drawing.Size(481, 24);
            this.mnuStripmain.TabIndex = 10;
            this.mnuStripmain.Text = "mnuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactFormToolStripMenuItem,
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contactFormToolStripMenuItem
            // 
            this.contactFormToolStripMenuItem.Name = "contactFormToolStripMenuItem";
            this.contactFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contactFormToolStripMenuItem.Text = "Contact Form";
            this.contactFormToolStripMenuItem.Click += new System.EventHandler(this.contactFormToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // prgbarLoadingLogin
            // 
            this.prgbarLoadingLogin.BackColor = System.Drawing.Color.White;
            this.prgbarLoadingLogin.ForeColor = System.Drawing.Color.ForestGreen;
            this.prgbarLoadingLogin.Location = new System.Drawing.Point(12, 194);
            this.prgbarLoadingLogin.Name = "prgbarLoadingLogin";
            this.prgbarLoadingLogin.Size = new System.Drawing.Size(448, 25);
            this.prgbarLoadingLogin.TabIndex = 11;
            // 
            // tmrGarbageCollector
            // 
            this.tmrGarbageCollector.Enabled = true;
            this.tmrGarbageCollector.Interval = 10000;
            this.tmrGarbageCollector.Tick += new System.EventHandler(this.tmrGarbageCollector_Tick);
            // 
            // frm_LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.form2;
            this.ClientSize = new System.Drawing.Size(481, 232);
            this.Controls.Add(this.prgbarLoadingLogin);
            this.Controls.Add(this.gbox_RoleSelect);
            this.Controls.Add(this.bttn_ForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.mnuStripmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuStripmain;
            this.Name = "frm_LoginPage";
            this.Text = "Edusist: Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_LoginPage_FormClosing);
            this.Load += new System.EventHandler(this.frmProgramMain_Load);
            this.gbox_RoleSelect.ResumeLayout(false);
            this.gbox_RoleSelect.PerformLayout();
            this.mnuStripmain.ResumeLayout(false);
            this.mnuStripmain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_student;
        private System.Windows.Forms.RadioButton rdb_teacher;
        private System.Windows.Forms.RadioButton rdb_principal;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button bttn_ForgotPassword;
        private System.Windows.Forms.GroupBox gbox_RoleSelect;
        private System.Windows.Forms.MenuStrip mnuStripmain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ProgressBar prgbarLoadingLogin;
        private System.Windows.Forms.ToolStripMenuItem contactFormToolStripMenuItem;
        private System.Windows.Forms.Timer tmrGarbageCollector;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;


    }
}

