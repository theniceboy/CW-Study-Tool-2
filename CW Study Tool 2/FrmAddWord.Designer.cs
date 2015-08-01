namespace CW_Study_Tool_2
{
    partial class FrmAddWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddWord));
            this.Clear = new DevComponents.DotNetBar.ButtonX();
            this.Add = new DevComponents.DotNetBar.ButtonX();
            this.trans = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Word = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Search = new DevComponents.DotNetBar.ButtonX();
            this.SearchWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Clear.FocusCuesEnabled = false;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Clear.Location = new System.Drawing.Point(12, 391);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(150, 44);
            this.Clear.Symbol = "";
            this.Clear.SymbolSize = 12F;
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Clear";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add
            // 
            this.Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Add.FocusCuesEnabled = false;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Add.Location = new System.Drawing.Point(635, 391);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(150, 44);
            this.Add.Symbol = "";
            this.Add.SymbolSize = 12F;
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // trans
            // 
            this.trans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trans.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.trans.Border.Class = "TextBoxBorder";
            this.trans.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.trans.DisabledBackColor = System.Drawing.Color.White;
            this.trans.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.trans.ForeColor = System.Drawing.Color.Black;
            this.trans.Location = new System.Drawing.Point(12, 96);
            this.trans.MaxLength = 2147483647;
            this.trans.Multiline = true;
            this.trans.Name = "trans";
            this.trans.PreventEnterBeep = true;
            this.trans.Size = new System.Drawing.Size(773, 289);
            this.trans.TabIndex = 4;
            // 
            // Word
            // 
            this.Word.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Word.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Word.Border.Class = "TextBoxBorder";
            this.Word.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Word.DisabledBackColor = System.Drawing.Color.White;
            this.Word.Font = new System.Drawing.Font("Segoe UI", 32F);
            this.Word.ForeColor = System.Drawing.Color.Black;
            this.Word.Location = new System.Drawing.Point(12, 12);
            this.Word.Name = "Word";
            this.Word.PreventEnterBeep = true;
            this.Word.Size = new System.Drawing.Size(773, 78);
            this.Word.TabIndex = 3;
            this.Word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Search
            // 
            this.Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Search.FocusCuesEnabled = false;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Search.Location = new System.Drawing.Point(479, 391);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(150, 44);
            this.Search.Symbol = "";
            this.Search.SymbolSize = 12F;
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchWord
            // 
            this.SearchWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchWord.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.SearchWord.Border.Class = "TextBoxBorder";
            this.SearchWord.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.SearchWord.DisabledBackColor = System.Drawing.Color.White;
            this.SearchWord.ForeColor = System.Drawing.Color.Black;
            this.SearchWord.Location = new System.Drawing.Point(168, 401);
            this.SearchWord.Name = "SearchWord";
            this.SearchWord.PreventEnterBeep = true;
            this.SearchWord.Size = new System.Drawing.Size(305, 26);
            this.SearchWord.TabIndex = 7;
            this.SearchWord.WatermarkText = "Search Text";
            // 
            // FrmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 447);
            this.Controls.Add(this.SearchWord);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.Word);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool - Add Word";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX Clear;
        private DevComponents.DotNetBar.ButtonX Add;
        private DevComponents.DotNetBar.Controls.TextBoxX trans;
        private DevComponents.DotNetBar.Controls.TextBoxX Word;
        private DevComponents.DotNetBar.ButtonX Search;
        private DevComponents.DotNetBar.Controls.TextBoxX SearchWord;

    }
}