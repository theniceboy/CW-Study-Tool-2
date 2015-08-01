namespace CW_Study_Tool_2
{
    partial class FrmWordList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWordList));
            this.WordList = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Good = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Translation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // WordList
            // 
            this.WordList.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.WordList.Border.Class = "ListViewBorder";
            this.WordList.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.WordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Good,
            this.Bad,
            this.Translation});
            this.WordList.DisabledBackColor = System.Drawing.Color.Empty;
            this.WordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordList.FocusCuesEnabled = false;
            this.WordList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WordList.ForeColor = System.Drawing.Color.Black;
            this.WordList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.WordList.LabelEdit = true;
            this.WordList.Location = new System.Drawing.Point(0, 0);
            this.WordList.Name = "WordList";
            this.WordList.Size = new System.Drawing.Size(928, 596);
            this.WordList.TabIndex = 0;
            this.WordList.UseCompatibleStateImageBehavior = false;
            this.WordList.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Word";
            this.Word.Width = 132;
            // 
            // Good
            // 
            this.Good.Text = "G";
            this.Good.Width = 50;
            // 
            // Bad
            // 
            this.Bad.Text = "B";
            this.Bad.Width = 50;
            // 
            // Translation
            // 
            this.Translation.Text = "Translation";
            this.Translation.Width = 600;
            // 
            // FrmWordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.WordList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWordList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool - Search";
            this.Load += new System.EventHandler(this.FrmWordList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx WordList;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Good;
        private System.Windows.Forms.ColumnHeader Bad;
        private System.Windows.Forms.ColumnHeader Translation;
    }
}