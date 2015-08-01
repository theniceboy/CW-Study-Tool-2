namespace CW_Study_Tool_2
{
    partial class FrmStudy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "spr")]
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudy));
            this.Word = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.trans = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Next = new DevComponents.DotNetBar.ButtonX();
            this.ShowTraslation = new DevComponents.DotNetBar.ButtonX();
            this.Previous = new DevComponents.DotNetBar.ButtonX();
            this.Good = new DevComponents.DotNetBar.ButtonX();
            this.Bad = new DevComponents.DotNetBar.ButtonX();
            this.History = new DevComponents.DotNetBar.ButtonX();
            this.Replay = new DevComponents.DotNetBar.ButtonX();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
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
            this.Word.Font = new System.Drawing.Font("Segoe UI", 48F);
            this.Word.ForeColor = System.Drawing.Color.Black;
            this.Word.Location = new System.Drawing.Point(12, 12);
            this.Word.Name = "Word";
            this.Word.PreventEnterBeep = true;
            this.Word.Size = new System.Drawing.Size(988, 114);
            this.Word.TabIndex = 0;
            this.Word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Word.TextChanged += new System.EventHandler(this.Word_TextChanged);
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
            this.trans.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.trans.ForeColor = System.Drawing.Color.Black;
            this.trans.Location = new System.Drawing.Point(12, 132);
            this.trans.MaxLength = 2147483647;
            this.trans.Multiline = true;
            this.trans.Name = "trans";
            this.trans.PreventEnterBeep = true;
            this.trans.Size = new System.Drawing.Size(988, 434);
            this.trans.TabIndex = 1;
            // 
            // Next
            // 
            this.Next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Next.FocusCuesEnabled = false;
            this.Next.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Next.Location = new System.Drawing.Point(702, 572);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(130, 32);
            this.Next.Symbol = "";
            this.Next.SymbolSize = 12F;
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ShowTraslation
            // 
            this.ShowTraslation.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ShowTraslation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowTraslation.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ShowTraslation.FocusCuesEnabled = false;
            this.ShowTraslation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShowTraslation.Location = new System.Drawing.Point(838, 572);
            this.ShowTraslation.Name = "ShowTraslation";
            this.ShowTraslation.Size = new System.Drawing.Size(162, 32);
            this.ShowTraslation.Symbol = "";
            this.ShowTraslation.SymbolSize = 12F;
            this.ShowTraslation.TabIndex = 2;
            this.ShowTraslation.Text = "Show Traslation";
            this.ShowTraslation.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowTraslation.Click += new System.EventHandler(this.ShowTraslation_Click);
            // 
            // Previous
            // 
            this.Previous.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Previous.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Previous.FocusCuesEnabled = false;
            this.Previous.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Previous.Location = new System.Drawing.Point(12, 572);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(130, 32);
            this.Previous.Symbol = "";
            this.Previous.SymbolSize = 12F;
            this.Previous.TabIndex = 2;
            this.Previous.Text = "Previous";
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Good
            // 
            this.Good.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Good.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Good.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Good.FocusCuesEnabled = false;
            this.Good.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Good.Location = new System.Drawing.Point(561, 572);
            this.Good.Name = "Good";
            this.Good.Size = new System.Drawing.Size(135, 32);
            this.Good.Symbol = "";
            this.Good.SymbolSize = 12F;
            this.Good.TabIndex = 2;
            this.Good.Text = "Good ( 0 )";
            this.Good.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Good.Click += new System.EventHandler(this.Good_Click);
            // 
            // Bad
            // 
            this.Bad.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Bad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bad.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Bad.FocusCuesEnabled = false;
            this.Bad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Bad.Location = new System.Drawing.Point(420, 572);
            this.Bad.Name = "Bad";
            this.Bad.Size = new System.Drawing.Size(135, 32);
            this.Bad.Symbol = "";
            this.Bad.SymbolSize = 12F;
            this.Bad.TabIndex = 2;
            this.Bad.Text = "Bad ( 0 )";
            this.Bad.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Bad.Click += new System.EventHandler(this.Bad_Click);
            // 
            // History
            // 
            this.History.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.History.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.History.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.History.FocusCuesEnabled = false;
            this.History.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.History.Location = new System.Drawing.Point(148, 572);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(130, 32);
            this.History.Symbol = "";
            this.History.SymbolSize = 12F;
            this.History.TabIndex = 2;
            this.History.Text = "History";
            this.History.TextColor = System.Drawing.Color.Black;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Replay
            // 
            this.Replay.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Replay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Replay.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Replay.FocusCuesEnabled = false;
            this.Replay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Replay.Location = new System.Drawing.Point(284, 572);
            this.Replay.Name = "Replay";
            this.Replay.Size = new System.Drawing.Size(130, 32);
            this.Replay.Symbol = "";
            this.Replay.SymbolSize = 12F;
            this.Replay.TabIndex = 2;
            this.Replay.Text = "Replay";
            this.Replay.TextColor = System.Drawing.Color.Black;
            this.Replay.Click += new System.EventHandler(this.Replay_Click);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Player.Enabled = true;
            this.Player.ForeColor = System.Drawing.Color.Black;
            this.Player.Location = new System.Drawing.Point(242, 306);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(234, 57);
            this.Player.TabIndex = 3;
            this.Player.Visible = false;
            // 
            // FrmStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 616);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Replay);
            this.Controls.Add(this.History);
            this.Controls.Add(this.ShowTraslation);
            this.Controls.Add(this.Bad);
            this.Controls.Add(this.Good);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.Word);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1030, 663);
            this.Name = "FrmStudy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStudy_FormClosing);
            this.Load += new System.EventHandler(this.FrmStudy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX Word;
        private DevComponents.DotNetBar.Controls.TextBoxX trans;
        private DevComponents.DotNetBar.ButtonX Next;
        private DevComponents.DotNetBar.ButtonX ShowTraslation;
        private DevComponents.DotNetBar.ButtonX Previous;
        private DevComponents.DotNetBar.ButtonX Good;
        private DevComponents.DotNetBar.ButtonX Bad;
        private DevComponents.DotNetBar.ButtonX History;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private DevComponents.DotNetBar.ButtonX Replay;
    }
}