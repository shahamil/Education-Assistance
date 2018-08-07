namespace RattlerManagement
{
    partial class frmManageTeacher
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
            this.lstboxTeachers = new System.Windows.Forms.ListBox();
            this.btnFireTeacher = new System.Windows.Forms.Button();
            this.prgbarTeacherLoad = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lstboxTeachers
            // 
            this.lstboxTeachers.FormattingEnabled = true;
            this.lstboxTeachers.Location = new System.Drawing.Point(12, 12);
            this.lstboxTeachers.Name = "lstboxTeachers";
            this.lstboxTeachers.Size = new System.Drawing.Size(269, 160);
            this.lstboxTeachers.TabIndex = 0;
            // 
            // btnFireTeacher
            // 
            this.btnFireTeacher.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFireTeacher.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireTeacher.ForeColor = System.Drawing.Color.Transparent;
            this.btnFireTeacher.Location = new System.Drawing.Point(12, 178);
            this.btnFireTeacher.Name = "btnFireTeacher";
            this.btnFireTeacher.Size = new System.Drawing.Size(269, 31);
            this.btnFireTeacher.TabIndex = 1;
            this.btnFireTeacher.Text = "Fire Teacher";
            this.btnFireTeacher.UseVisualStyleBackColor = false;
            this.btnFireTeacher.Click += new System.EventHandler(this.btnFireTeacher_Click);
            // 
            // prgbarTeacherLoad
            // 
            this.prgbarTeacherLoad.Location = new System.Drawing.Point(12, 214);
            this.prgbarTeacherLoad.Name = "prgbarTeacherLoad";
            this.prgbarTeacherLoad.Size = new System.Drawing.Size(268, 23);
            this.prgbarTeacherLoad.TabIndex = 2;
            // 
            // frmManageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.loginBackground;
            this.ClientSize = new System.Drawing.Size(290, 253);
            this.Controls.Add(this.prgbarTeacherLoad);
            this.Controls.Add(this.btnFireTeacher);
            this.Controls.Add(this.lstboxTeachers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmManageTeacher";
            this.Text = "Edusist: frmManageTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageTeacher_FormClosing);
            this.Load += new System.EventHandler(this.frmManageTeacher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxTeachers;
        private System.Windows.Forms.Button btnFireTeacher;
        private System.Windows.Forms.ProgressBar prgbarTeacherLoad;

    }
}