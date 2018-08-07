namespace RattlerManagement
{
    partial class frmCreateTeacher
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
            this.txt_tNumber = new System.Windows.Forms.TextBox();
            this.txt_tPass = new System.Windows.Forms.TextBox();
            this.txt_tLastName = new System.Windows.Forms.TextBox();
            this.txt_tFirstName = new System.Windows.Forms.TextBox();
            this.bttn_NewTeacher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tEmail = new System.Windows.Forms.TextBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_tNumber
            // 
            this.txt_tNumber.Location = new System.Drawing.Point(9, 104);
            this.txt_tNumber.Name = "txt_tNumber";
            this.txt_tNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_tNumber.TabIndex = 0;
            this.txt_tNumber.TextChanged += new System.EventHandler(this.txt_tNumber_TextChanged);
            // 
            // txt_tPass
            // 
            this.txt_tPass.Location = new System.Drawing.Point(12, 151);
            this.txt_tPass.Name = "txt_tPass";
            this.txt_tPass.Size = new System.Drawing.Size(100, 20);
            this.txt_tPass.TabIndex = 1;
            this.txt_tPass.TextChanged += new System.EventHandler(this.txt_tPass_TextChanged);
            // 
            // txt_tLastName
            // 
            this.txt_tLastName.Location = new System.Drawing.Point(182, 103);
            this.txt_tLastName.Name = "txt_tLastName";
            this.txt_tLastName.Size = new System.Drawing.Size(100, 20);
            this.txt_tLastName.TabIndex = 2;
            this.txt_tLastName.TextChanged += new System.EventHandler(this.txt_tLastName_TextChanged);
            // 
            // txt_tFirstName
            // 
            this.txt_tFirstName.Location = new System.Drawing.Point(182, 59);
            this.txt_tFirstName.Name = "txt_tFirstName";
            this.txt_tFirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_tFirstName.TabIndex = 3;
            this.txt_tFirstName.TextChanged += new System.EventHandler(this.txt_tFirstName_TextChanged);
            // 
            // bttn_NewTeacher
            // 
            this.bttn_NewTeacher.BackColor = System.Drawing.Color.ForestGreen;
            this.bttn_NewTeacher.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_NewTeacher.ForeColor = System.Drawing.Color.White;
            this.bttn_NewTeacher.Location = new System.Drawing.Point(9, 32);
            this.bttn_NewTeacher.Name = "bttn_NewTeacher";
            this.bttn_NewTeacher.Size = new System.Drawing.Size(100, 47);
            this.bttn_NewTeacher.TabIndex = 4;
            this.bttn_NewTeacher.Text = "Create New Teacher";
            this.bttn_NewTeacher.UseVisualStyleBackColor = false;
            this.bttn_NewTeacher.Click += new System.EventHandler(this.bttn_NewTeacher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teacher Number";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(9, 135);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 15);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(177, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teacher Email";
            // 
            // txt_tEmail
            // 
            this.txt_tEmail.Location = new System.Drawing.Point(180, 151);
            this.txt_tEmail.Name = "txt_tEmail";
            this.txt_tEmail.Size = new System.Drawing.Size(100, 20);
            this.txt_tEmail.TabIndex = 10;
            this.txt_tEmail.TextChanged += new System.EventHandler(this.txt_tEmail_TextChanged);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(294, 24);
            this.mnuMain.TabIndex = 30;
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
            // frmCreateTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.loginBackground;
            this.ClientSize = new System.Drawing.Size(294, 198);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_NewTeacher);
            this.Controls.Add(this.txt_tFirstName);
            this.Controls.Add(this.txt_tLastName);
            this.Controls.Add(this.txt_tPass);
            this.Controls.Add(this.txt_tNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCreateTeacher";
            this.Text = "Create New Teacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreateTeacher_FormClosing);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tNumber;
        private System.Windows.Forms.TextBox txt_tPass;
        private System.Windows.Forms.TextBox txt_tLastName;
        private System.Windows.Forms.TextBox txt_tFirstName;
        private System.Windows.Forms.Button bttn_NewTeacher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tEmail;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}