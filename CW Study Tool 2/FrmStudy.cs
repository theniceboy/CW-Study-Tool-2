using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Speech.Synthesis;

namespace CW_Study_Tool_2
{
    public partial class FrmStudy : DevComponents.DotNetBar.Metro.MetroForm
    {
        private const int MAXN = 200;
        private bool dochoose, IsDone;
        private int js = 0, rn = 1, last = -1;
        private int[] ls = new int[MAXN];
        private int[] lst = new int[MAXN];

        public FrmStudy()
        {
            InitializeComponent();
        }

        SpeechSynthesizer spr = new SpeechSynthesizer();

        Thread tsp;

        private void refstate()
        {
            try
            {
                tsp.Abort();
            }
            catch
            {
            }

            if (Gib.nowword >= Gib.cstn)
                if (Gib.studymode == 5 || Gib.studymode == 6)
                {
                    IsDone = true;
                    for (int i = 0; i < MAXN; ++i)
                        if (ls[i] == 2)
                        {
                            IsDone = false;
                            break;
                        }
                    if ((Gib.studymode != 5 && Gib.studymode != 6) || IsDone)
                        this.Close();
                    else
                    {
                        lst = ls;
                        ++rn;
                        MessageBoxEx.Show(this, "Round " + rn.ToString(), "Hint", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Gib.nowword = -1;
                        js = 0;
                        next();
                    }
                }
                else if (
                    MessageBoxEx.Show(this,
                        "Study finished. Do you want to start the Word Game right now (continue now state)",
                        "Question?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
                    DialogResult.Yes)
                {
                    Gib.studymode += 4;
                    lst = ls;
                    MessageBoxEx.Show(this, "Round " + rn.ToString(), "Hint", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Gib.nowword = -1;
                    js = 0;
                    next();
                }
                else
                    this.Close();

            this.Text = Gib.frmlearntext + " ( No." + js.ToString() + " )";
            Word.Text = Gib.cst1[Gib.nowword];

            tsp = new Thread(new ThreadStart(ReadWord));
            tsp.IsBackground = true;
            tsp.Name = "tsp";
            tsp.Priority = ThreadPriority.Highest;
            tsp.Start();

            trans.Text = "";

            dochoose = Good.Checked = Bad.Checked = false;
            if (Gib.studymode == 1)
            {
                if (Gib.his[Gib.nowword, 0] != 0)
                {
                    dochoose = true;
                    if (Gib.his[Gib.nowword, 0] == 1)
                    {
                        Good.Checked = true;
                        ls[js] = 1;
                    }
                    else
                    {
                        Bad.Checked = true;
                        ls[js] = 2;
                    }
                }
            }
            else if (Gib.studymode == 2)
            {
                if (Gib.his[Gib.nowword, gethisi()] != 0)
                {
                    dochoose = true;
                    if (Gib.his[Gib.nowword, gethisi()] == 1)
                    {
                        Good.Checked = true;
                        ls[js] = 1;
                    }
                    else
                    {
                        Bad.Checked = true;
                        ls[js] = 2;
                    }
                }
            }
            else if (Gib.studymode == 3)
            {
                if (ls[js] != 0)
                {
                    dochoose = true;
                    if (ls[js] == 1)
                        Good.Checked = true;
                    else
                        Bad.Checked = true;
                }
            }
            else if (Gib.studymode == 4)
            {
                if (Gib.today - Gib.cst3[Gib.nowword] < 6 &&
                    Gib.his[Gib.nowword, Gib.today - Gib.cst3[Gib.nowword]] != 0)
                {
                    dochoose = true;
                    if (Gib.his[Gib.nowword, Gib.today - Gib.cst3[Gib.nowword]] == 1)
                    {
                        Good.Checked = true;
                        ls[js] = 1;
                    }
                    else
                    {
                        Bad.Checked = true;
                        ls[js] = 2;
                    }
                }
            }
            else if (Gib.studymode == 5 || Gib.studymode == 6)
            {
                if (ls[js] != 0)
                {
                    dochoose = true;
                    if (ls[js] == 1)
                        Good.Checked = true;
                    else
                        Bad.Checked = true;
                }
            }

            Good.Text = "Good ( " + goodcount() + " )";
            Bad.Text = "Bad ( " + badcount() + " )";

            if (js == 1)
                Previous.Enabled = false;
            else
                Previous.Enabled = true;
        }
        
        private void FrmStudy_Load(object sender, EventArgs e)
        {
            if (Gib.studymode == 4)
            {
                FrmInput frm = new FrmInput();
                frm.ShowDialog(this);
            }
            Previous.Enabled = false;
            Gib.nowword = -1;
            this.Text = Gib.frmlearntext;
            next();
            refstate();
        }

        bool isHardWord(int x)
        {
            if (Gib.his[x, 0] == 0)
                return false;
            for ( int i = 0; i < 6; ++i )
                if (Gib.his[x, i] == 1)
                    return false;
            return true;
        }

        private void next()
        {
            ++js;
            int i;
            bool bj = true;
            if (Gib.studymode == 1)
                while (++Gib.nowword < Gib.cstn && Gib.today != Gib.cst3[Gib.nowword])
                {
                }
            else if (Gib.studymode == 2)
                while (bj)
                {
                    ++Gib.nowword;
                    if (Gib.nowword >= Gib.cstn)
                        break;
                    bj = true;
                    for (i = 0; i < 5; ++i)
                        if (Gib.today == Gib.cst3[Gib.nowword] + Gib.mem[i])
                        {
                            bj = false;
                            break;
                        }
                }
            else if (Gib.studymode == 3)
                while (++Gib.nowword < Gib.cstn && !isHardWord(Gib.nowword))
                {
                }
            else if (Gib.studymode == 4)
                while (++Gib.nowword < Gib.cstn && Gib.checkday != Gib.cst3[Gib.nowword])
                {
                }
            else if (Gib.studymode == 5)
                while (++Gib.nowword < Gib.cstn)
                {
                    if (Gib.today == Gib.cst3[Gib.nowword])
                    {
                        if (ls[js] == 0 || ls[js] == 2)
                            break;
                        ++js;
                    }
                }
            else
                while (++Gib.nowword < Gib.cstn)
                {
                    bj = false;
                    for (i = 0; i < 5; ++i)
                        if (Gib.today == Gib.cst3[Gib.nowword] + Gib.mem[i])
                        {
                            bj = true;
                            break;
                        }
                    if (bj)
                    {
                        if (ls[js] == 0 || ls[js] == 2)
                            break;
                        ++js;
                    }
                }
        }

        private void prev()
        {
            --js;
            int i;
            bool bj = true;
            if (Gib.studymode == 1)
                while (--Gib.nowword >= 0 && Gib.today != Gib.cst3[Gib.nowword])
                {
                }
            else if (Gib.studymode == 2)
                while (bj)
                {
                    --Gib.nowword;
                    bj = true;
                    for (i = 0; i < 5; ++i)
                        if (Gib.today == Gib.cst3[Gib.nowword] + Gib.mem[i])
                        {
                            bj = false;
                            break;
                        }
                }
            else if (Gib.studymode == 3)
                while (--Gib.nowword >= 0 && !isHardWord(Gib.nowword))
                {
                }
            else if (Gib.studymode == 4)
                while (--Gib.nowword >= 0 && Gib.checkday != Gib.cst3[Gib.nowword])
                {
                }
            else if (Gib.studymode == 5)
                while (--Gib.nowword >= 0 && Gib.today != Gib.cst3[Gib.nowword])
                {
                }
            else
                while (--Gib.nowword >= 0)
                {
                    bj = false;
                    for (i = 0; i < 5; ++i)
                        if (Gib.today == Gib.cst3[Gib.nowword] + Gib.mem[i])
                        {
                            bj = true;
                            break;
                        }
                    if (bj)
                        break;
                }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (dochoose)
            {
                if (Gib.nowword >= Gib.cstn - 1)
                    if (Gib.studymode == 5 || Gib.studymode == 6)
                    {
                        IsDone = true;
                        for (int i = 0; i < MAXN; ++i)
                            if (ls[i] == 2)
                            {
                                IsDone = false;
                                break;
                            }
                        if ((Gib.studymode != 5 && Gib.studymode != 6) || IsDone)
                            this.Close();
                        else
                        {
                            lst = ls;
                            ++rn;
                            MessageBoxEx.Show(this, "Round " + rn.ToString(), "Hint", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            Gib.nowword = -1;
                            js = 0;
                        }
                    }
                    else if (
                        MessageBoxEx.Show(this,
                            "Study finished. Do you want to start the Word Game right now (continue now state)",
                            "Question?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) ==
                        DialogResult.Yes)
                    {
                        Gib.studymode += 4;
                        lst = ls;
                        MessageBoxEx.Show(this, "Round " + rn.ToString(), "Hint", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Gib.nowword = -1;
                        js = 0;
                        next();
                    }
                    else
                        this.Close();

                next();
                refstate();
            }
            else
                MessageBoxEx.Show(this, "You must choose \"Good\" or \"Bad\".", "Hint", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            prev();
            refstate();
        }

        private void ShowTraslation_Click(object sender, EventArgs e)
        {
            trans.Text = Gib.cst2[Gib.nowword];
        }

        private int gethisi()
        {
            for (int i = 0; i < 5; ++i)
                if (Gib.today == Gib.cst3[Gib.nowword] + Gib.mem[i])
                    return i + 1;
            return -1;
        }

        private int goodcount()
        {
            int i, ans = 0;
            for (i = 1; i < MAXN; ++i)
                if (ls[i] == 1)
                    ++ans;
            return ans;
        }
        private int badcount()
        {
            int i, ans = 0;
            for (i = 1; i < MAXN; ++i)
                if (ls[i] == 2)
                    ++ans;
            return ans;
        }

        private void Good_Click(object sender, EventArgs e)
        {
            dochoose = true;
            ls[js] = 1;
            Good.Text = "Good ( " + goodcount() + " )";
            Bad.Text = "Bad ( " + badcount() + " )";
            if (Gib.studymode == 1)
                Gib.his[Gib.nowword, 0] = 1;
            else if (Gib.studymode == 2)
                Gib.his[Gib.nowword, gethisi()] = 1;
            else if (Gib.studymode == 4 && Gib.today - Gib.cst3[Gib.nowword] < 6)
                Gib.his[Gib.nowword, Gib.today - Gib.cst3[Gib.nowword]] = 1;
            Good.Checked = true;
            Bad.Checked = false;
        }

        private void Bad_Click(object sender, EventArgs e)
        {
            dochoose = true;
            ls[js] = 2;
            Good.Text = "Good ( " + goodcount() + " )";
            Bad.Text = "Bad ( " + badcount() + " )";
            if (Gib.studymode == 1)
                Gib.his[Gib.nowword, 0] = 2;
            else if (Gib.studymode == 2)
                Gib.his[Gib.nowword, gethisi()] = 2;
            else if (Gib.studymode == 4 && Gib.today - Gib.cst3[Gib.nowword] < 6)
                Gib.his[Gib.nowword, Gib.today - Gib.cst3[Gib.nowword]] = 2;
            Good.Checked = false;
            Bad.Checked = true;
        }

        private void History_Click(object sender, EventArgs e)
        {
            FrmHistory frm = new FrmHistory();
            frm.ShowDialog();
        }

        private void Word_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmStudy_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] temp = new string[6];
            int i, j;
            for (i = 0; i < Gib.cstn; ++i)
            {
                File.Delete("C:\\ProgramData\\CW Soft\\CW Study Tool\\Words\\" + Gib.cst1[i] + ".his");
                for (j = 0; j < 6; ++j)
                    temp[j] = Gib.his[i, j].ToString();
                File.WriteAllLines("C:\\ProgramData\\CW Soft\\CW Study Tool\\Words\\" + Gib.cst1[i] + ".his", temp);
            }
            try
            {
                File.Delete("C:\\ProgramData\\CW Soft\\CW Study Tool\\Words\\.his");
            }
            catch
            { }
            e.Cancel = false;
            //this.FormClosing -= System.Windows.Forms.FormClosedEventHandler(FrmStudy_FormClosing);
            //this.Close();
        }

        private void ReadWord()
        {
            try
            {
                if (File.Exists("C:\\ProgramData\\CW Soft\\Speech\\" + Word.Text.Trim() + ".mp3"))
                    Player.URL = "C:\\ProgramData\\CW Soft\\Speech\\" + Word.Text.Trim() + ".mp3";
                else
                    spr.Speak(Word.Text);
            }
            catch { }
        }

        private void Replay_Click(object sender, EventArgs e)
        {
            tsp = new Thread(ReadWord) { IsBackground = true, Name = "tsp", Priority = ThreadPriority.Highest };
            tsp.Start();
        }

        private void FrmKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.G)
                Good_Click(null, null);
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.B)
                Bad_Click(null, null);
            else if (e.KeyCode == Keys.Left && js > 1)
                Previous_Click(null, null);
            else if (e.KeyCode == Keys.Right)
                Next_Click(null, null);
            else if (e.Control || e.KeyCode == Keys.S)
                ShowTraslation_Click(null, null);
            else if (e.Shift || e.KeyCode == Keys.R)
                Replay_Click(null, null);
            else if (e.KeyCode == Keys.H)
                History_Click(null, null);
        }
    }
}
