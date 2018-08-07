namespace RattlerManagement
{
    partial class frmSplashPage
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
            this.tmrSplashLoader = new System.Windows.Forms.Timer(this.components);
            this.prgMain = new System.Windows.Forms.ProgressBar();
            this.tmrPBar = new System.Windows.Forms.Timer(this.components);
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.prgBarChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrSplashLoader
            // 
            this.tmrSplashLoader.Enabled = true;
            this.tmrSplashLoader.Interval = 10000;
            this.tmrSplashLoader.Tick += new System.EventHandler(this.tmrSplashLoader_Tick);
            // 
            // prgMain
            // 
            this.prgMain.Location = new System.Drawing.Point(12, 12);
            this.prgMain.Maximum = 10;
            this.prgMain.Name = "prgMain";
            this.prgMain.Size = new System.Drawing.Size(476, 30);
            this.prgMain.TabIndex = 0;
            // 
            // tmrPBar
            // 
            this.tmrPBar.Interval = 1000;
            this.tmrPBar.Tick += new System.EventHandler(this.tmrPBar_Tick);
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBar.ForeColor = System.Drawing.Color.Green;
            this.lblProgressBar.Location = new System.Drawing.Point(162, 45);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(73, 16);
            this.lblProgressBar.TabIndex = 1;
            this.lblProgressBar.Text = "Welcome";
            // 
            // prgBarChecker
            // 
            this.prgBarChecker.Interval = 500;
            this.prgBarChecker.Tick += new System.EventHandler(this.prgBarChecker_Tick);
            // 
            // frmSplashPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.splash;
            this.ClientSize = new System.Drawing.Size(500, 299);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.prgMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSplashPage";
            this.Text = "frmSplashPage";
            this.Load += new System.EventHandler(this.frmSplashPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSplashLoader;
        private System.Windows.Forms.ProgressBar prgMain;
        private System.Windows.Forms.Timer tmrPBar;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.Timer prgBarChecker;
    }
}