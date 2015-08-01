namespace CW_Study_Tool_2
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.LearnNewWords = new DevComponents.DotNetBar.ButtonX();
            this.ImportWords = new DevComponents.DotNetBar.ButtonX();
            this.ReviewWords = new DevComponents.DotNetBar.ButtonX();
            this.AddWords = new DevComponents.DotNetBar.ButtonX();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.LearnHardWords = new DevComponents.DotNetBar.ButtonX();
            this.WordList = new DevComponents.DotNetBar.ButtonX();
            this.CheckWords = new DevComponents.DotNetBar.ButtonX();
            this.WordGame = new DevComponents.DotNetBar.ButtonX();
            this.ReviewGame = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(142)))), ((int)(((byte)(0))))));
            // 
            // LearnNewWords
            // 
            this.LearnNewWords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LearnNewWords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LearnNewWords.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.LearnNewWords.FocusCuesEnabled = false;
            this.LearnNewWords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LearnNewWords.Location = new System.Drawing.Point(18, 66);
            this.LearnNewWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LearnNewWords.Name = "LearnNewWords";
            this.LearnNewWords.Size = new System.Drawing.Size(246, 45);
            this.LearnNewWords.Symbol = "";
            this.LearnNewWords.TabIndex = 0;
            this.LearnNewWords.Text = "Learn New Words";
            this.LearnNewWords.Click += new System.EventHandler(this.LearnNewWords_Click);
            // 
            // ImportWords
            // 
            this.ImportWords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ImportWords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImportWords.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ImportWords.FocusCuesEnabled = false;
            this.ImportWords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ImportWords.Location = new System.Drawing.Point(18, 278);
            this.ImportWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImportWords.Name = "ImportWords";
            this.ImportWords.Size = new System.Drawing.Size(246, 45);
            this.ImportWords.Symbol = "";
            this.ImportWords.TabIndex = 0;
            this.ImportWords.Text = "Import Words";
            this.ImportWords.Click += new System.EventHandler(this.ImportWords_Click);
            // 
            // ReviewWords
            // 
            this.ReviewWords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ReviewWords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReviewWords.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ReviewWords.FocusCuesEnabled = false;
            this.ReviewWords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReviewWords.Location = new System.Drawing.Point(18, 172);
            this.ReviewWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReviewWords.Name = "ReviewWords";
            this.ReviewWords.Size = new System.Drawing.Size(246, 45);
            this.ReviewWords.Symbol = "";
            this.ReviewWords.TabIndex = 0;
            this.ReviewWords.Text = "Review Words";
            this.ReviewWords.Click += new System.EventHandler(this.ReviewWords_Click);
            // 
            // AddWords
            // 
            this.AddWords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AddWords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddWords.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AddWords.FocusCuesEnabled = false;
            this.AddWords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AddWords.Location = new System.Drawing.Point(18, 331);
            this.AddWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddWords.Name = "AddWords";
            this.AddWords.Size = new System.Drawing.Size(246, 45);
            this.AddWords.Symbol = "";
            this.AddWords.TabIndex = 0;
            this.AddWords.Text = "Add Words";
            this.AddWords.Click += new System.EventHandler(this.AddWords_Click);
            // 
            // LearnHardWords
            // 
            this.LearnHardWords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LearnHardWords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LearnHardWords.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.LearnHardWords.FocusCuesEnabled = false;
            this.LearnHardWords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LearnHardWords.Location = new System.Drawing.Point(18, 13);
            this.LearnHardWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LearnHardWords.Name = "LearnHardWords";
            this.LearnHardWords.Size = new System.Drawing.Size(246, 45);
            this.LearnHardWords.Symbol = "";
            this.LearnHardWords.TabIndex = 0;
            this.LearnHardWords.Text = "Learn Hard Words";
            this.LearnHardWords.Click += new System.EventHandler(this.LearnHardWords_Click);
            // 
            // WordList
            // 
            this.WordList.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.WordList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WordList.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.WordList.FocusCuesEnabled = false;
            this.WordList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WordList.Location = new System.Drawing.Point(18, 384);
            this.WordList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(246, 45);
            this.WordList.Symbol = "";
            this.WordList.TabIndex = 0;
            this.WordList.Text = "Word List";
            this.WordList.Click += new System.EventHandler(this.WordList_Click);
            // 
            // CheckWords
            // 
            this.CheckWords.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CheckWords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckWords.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CheckWords.FocusCuesEnabled = false;
            this.CheckWords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CheckWords.Location = new System.Drawing.Point(18, 437);
            this.CheckWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckWords.Name = "CheckWords";
            this.CheckWords.Size = new System.Drawing.Size(246, 45);
            this.CheckWords.Symbol = "";
            this.CheckWords.TabIndex = 0;
            this.CheckWords.Text = "Check Words";
            this.CheckWords.Click += new System.EventHandler(this.CheckWords_Click);
            // 
            // WordGame
            // 
            this.WordGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.WordGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WordGame.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.WordGame.FocusCuesEnabled = false;
            this.WordGame.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WordGame.Location = new System.Drawing.Point(18, 119);
            this.WordGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WordGame.Name = "WordGame";
            this.WordGame.Size = new System.Drawing.Size(246, 45);
            this.WordGame.Symbol = "";
            this.WordGame.TabIndex = 0;
            this.WordGame.Text = "Word Game";
            this.WordGame.Click += new System.EventHandler(this.WordGame_Click);
            // 
            // ReviewGame
            // 
            this.ReviewGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ReviewGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReviewGame.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ReviewGame.FocusCuesEnabled = false;
            this.ReviewGame.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReviewGame.Location = new System.Drawing.Point(18, 225);
            this.ReviewGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReviewGame.Name = "ReviewGame";
            this.ReviewGame.Size = new System.Drawing.Size(246, 45);
            this.ReviewGame.Symbol = "";
            this.ReviewGame.TabIndex = 0;
            this.ReviewGame.Text = "Review Game";
            this.ReviewGame.Click += new System.EventHandler(this.ReviewGame_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 490);
            this.Controls.Add(this.ReviewWords);
            this.Controls.Add(this.ReviewGame);
            this.Controls.Add(this.WordGame);
            this.Controls.Add(this.CheckWords);
            this.Controls.Add(this.WordList);
            this.Controls.Add(this.AddWords);
            this.Controls.Add(this.ImportWords);
            this.Controls.Add(this.LearnHardWords);
            this.Controls.Add(this.LearnNewWords);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 537);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 537);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool 2.3.5";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.ButtonX LearnNewWords;
        private DevComponents.DotNetBar.ButtonX ImportWords;
        private DevComponents.DotNetBar.ButtonX ReviewWords;
        private DevComponents.DotNetBar.ButtonX AddWords;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private DevComponents.DotNetBar.ButtonX LearnHardWords;
        private DevComponents.DotNetBar.ButtonX WordList;
        private DevComponents.DotNetBar.ButtonX CheckWords;
        private DevComponents.DotNetBar.ButtonX WordGame;
        private DevComponents.DotNetBar.ButtonX ReviewGame;

    }
}

