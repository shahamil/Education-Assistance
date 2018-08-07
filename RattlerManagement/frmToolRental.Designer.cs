namespace RattlerManagement
{
    partial class frmToolRental
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
            this.lsb_ItemInventory = new System.Windows.Forms.ListBox();
            this.btn_RentItem = new System.Windows.Forms.Button();
            this.lsb_Day = new System.Windows.Forms.ListBox();
            this.lsb_Time = new System.Windows.Forms.ListBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.edusistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_ItemInventory
            // 
            this.lsb_ItemInventory.FormattingEnabled = true;
            this.lsb_ItemInventory.Location = new System.Drawing.Point(12, 86);
            this.lsb_ItemInventory.Name = "lsb_ItemInventory";
            this.lsb_ItemInventory.Size = new System.Drawing.Size(112, 147);
            this.lsb_ItemInventory.TabIndex = 0;
            this.lsb_ItemInventory.SelectedIndexChanged += new System.EventHandler(this.lsb_ItemInventory_SelectedIndexChanged);
            // 
            // btn_RentItem
            // 
            this.btn_RentItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_RentItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_RentItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_RentItem.Location = new System.Drawing.Point(381, 86);
            this.btn_RentItem.Name = "btn_RentItem";
            this.btn_RentItem.Size = new System.Drawing.Size(107, 29);
            this.btn_RentItem.TabIndex = 2;
            this.btn_RentItem.Text = "Rent Item";
            this.btn_RentItem.UseVisualStyleBackColor = false;
            this.btn_RentItem.Click += new System.EventHandler(this.btn_RentItem_Click);
            // 
            // lsb_Day
            // 
            this.lsb_Day.FormattingEnabled = true;
            this.lsb_Day.Location = new System.Drawing.Point(130, 86);
            this.lsb_Day.Name = "lsb_Day";
            this.lsb_Day.Size = new System.Drawing.Size(110, 147);
            this.lsb_Day.TabIndex = 4;
            this.lsb_Day.SelectedIndexChanged += new System.EventHandler(this.lsb_Day_SelectedIndexChanged);
            // 
            // lsb_Time
            // 
            this.lsb_Time.FormattingEnabled = true;
            this.lsb_Time.Location = new System.Drawing.Point(246, 86);
            this.lsb_Time.Name = "lsb_Time";
            this.lsb_Time.Size = new System.Drawing.Size(110, 147);
            this.lsb_Time.TabIndex = 5;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.ForestGreen;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edusistToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(510, 24);
            this.mnuMain.TabIndex = 30;
            this.mnuMain.Text = "mnuMain";
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
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
            this.edusistToolStripMenuItem.Click += new System.EventHandler(this.edusistToolStripMenuItem_Click);
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
            // frmToolRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RattlerManagement.Properties.Resources.equipmentpanel;
            this.ClientSize = new System.Drawing.Size(510, 266);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.lsb_Time);
            this.Controls.Add(this.lsb_Day);
            this.Controls.Add(this.btn_RentItem);
            this.Controls.Add(this.lsb_ItemInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmToolRental";
            this.Text = "Edusist: Tool Rental";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmToolRental_FormClosing);
            this.Load += new System.EventHandler(this.frmToolRental_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_ItemInventory;
        private System.Windows.Forms.Button btn_RentItem;
        private System.Windows.Forms.ListBox lsb_Day;
        private System.Windows.Forms.ListBox lsb_Time;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem edusistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}