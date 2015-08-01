using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CW_Study_Tool_2
{
    public partial class FrmAddWord : DevComponents.DotNetBar.Metro.MetroForm
    {
        private string nw = "C:\\ProgramData\\CW Soft\\CW Study Tool\\New Words\\";
        private string[] ei = {"0", "0", "0", "0", "0", "0"};
        private string temp;

        public FrmAddWord()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Word.Text = trans.Text = "";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Word.Text = Word.Text.Trim();
            if (File.Exists(nw + Word.Text + ".cst1"))
            {
                temp = File.ReadAllText(nw + Word.Text + ".cst2", Encoding.Default);
                File.WriteAllText(nw + Word.Text + ".cst2", temp + "\r\n" + trans.Text, Encoding.Default);
            }
            else
            {
                File.WriteAllText(nw + Word.Text + ".cst1", Word.Text);
                File.WriteAllText(nw + Word.Text + ".cst2", trans.Text, Encoding.Default);
                File.WriteAllText(nw + Word.Text + ".cst3", Gib.today.ToString());
                File.WriteAllLines(nw + Word.Text + ".his", ei);
            }
            Word.Text = trans.Text = "";
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Gib.dosearch = true;
            Gib.searchword = SearchWord.Text.Trim();
            FrmWordList frm = new FrmWordList();
            frm.Show(this);
        }
    }
}