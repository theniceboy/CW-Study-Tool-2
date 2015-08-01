using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_Study_Tool_2
{
    public partial class FrmInput : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public FrmInput()
        {
            InitializeComponent();
        }

        private void FrmInput_Load(object sender, EventArgs e)
        {

        }

        private int is_leapyear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                return 1;
            else
                return 0;
        }

        private int convertdate(DateTime date)
        {
            return date.DayOfYear + date.Year * 365 + is_leapyear(date.Year);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (DateInput.Value.Year == 1)
            {
                this.highlighter.SetHighlightColor(this.DateInput,
                    DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                this.errorProvider.SetError(this.DateInput, "«Î—°‘Ò»’∆⁄");
            }
            else
            {
                Gib.checkday = convertdate(DateInput.Value);
                this.Close();
            }
        }
    }
}