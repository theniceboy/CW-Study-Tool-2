namespace CW_Study_Tool_2
{
    partial class FrmInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInput));
            this.Ok = new DevComponents.DotNetBar.ButtonX();
            this.DateInput = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DateInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Ok.FocusCuesEnabled = false;
            this.Ok.Location = new System.Drawing.Point(155, 45);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(98, 27);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // DateInput
            // 
            this.DateInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateInput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.DateInput.BackgroundStyle.Class = "DateTimeInputBackground";
            this.DateInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateInput.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.DateInput.ButtonDropDown.Visible = true;
            this.DateInput.ForeColor = System.Drawing.Color.Black;
            this.DateInput.IsPopupCalendarOpen = false;
            this.DateInput.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.DateInput.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DateInput.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateInput.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.DateInput.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.DateInput.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.DateInput.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.DateInput.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.DateInput.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.DateInput.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.DateInput.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.DateInput.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateInput.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.DateInput.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.DateInput.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.DateInput.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.DateInput.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.DateInput.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.DateInput.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.DateInput.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DateInput.MonthCalendar.TodayButtonVisible = true;
            this.DateInput.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.DateInput.Name = "DateInput";
            this.DateInput.Size = new System.Drawing.Size(241, 27);
            this.DateInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.DateInput.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // FrmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 84);
            this.Controls.Add(this.DateInput);
            this.Controls.Add(this.Ok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(265, 84);
            this.MinimumSize = new System.Drawing.Size(265, 84);
            this.Name = "FrmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW Study Tool - Input";
            this.Load += new System.EventHandler(this.FrmInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DateInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX Ok;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput DateInput;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}