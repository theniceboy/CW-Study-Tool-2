using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Study_Tool_2
{
    public partial class FrmMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        private string hostpath = "C:\\ProgramData\\CW Soft\\CW Study Tool";
        private string hpath = "C:\\ProgramData\\CW Soft\\CW Study Tool\\";
        private string wordpath = "C:\\ProgramData\\CW Soft\\CW Study Tool\\Words";
        private string wpath = "C:\\ProgramData\\CW Soft\\CW Study Tool\\Words\\";


        public FrmMain()
        {
            InitializeComponent();
        }

        private void LoadFiles()
        {
            Gib.today = convertdate();
            Gib.beginday = Convert.ToInt32(File.ReadAllText(hpath + "BeginDay.txt"));

            DirectoryInfo dinfo = new DirectoryInfo(wordpath);
            FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
            string ftype;
            string[] r;
            int i;

            foreach (FileSystemInfo fsinfo in fsinfos)
                if (fsinfo is FileInfo)
                {
                    ftype = Path.GetExtension(fsinfo.Name);
                    if (ftype == ".cst1")
                        Gib.cst1[Gib.cstn] = Path.GetFileNameWithoutExtension(fsinfo.Name);
                    else if (ftype == ".cst2")
                        Gib.cst2[Gib.cstn] = File.ReadAllText(fsinfo.FullName, Encoding.Default);
                    else if (ftype == ".cst3")
                        Gib.cst3[Gib.cstn] = Convert.ToInt32(File.ReadAllText(fsinfo.FullName));
                    else if (ftype == ".his")
                    {
                        r = File.ReadAllLines(fsinfo.FullName);
                        for (i = 0; i < 6; ++i)
                            Gib.his[Gib.cstn, i] = Convert.ToInt32(r[i]);
                        ++Gib.cstn;
                    }
                }
        }

        private int is_leapyear(int year)
        {
            if ((year%4 == 0 && year%100 != 0) || (year%400 == 0))
                return 1;
            else
                return 0;
        }

        private int convertdate()
        {
            return DateTime.Now.DayOfYear + DateTime.Now.Year*365 + is_leapyear(DateTime.Now.Year);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(hostpath))
                Directory.CreateDirectory(hostpath);
            if (!Directory.Exists(wordpath))
                Directory.CreateDirectory(wordpath);
            if (!Directory.Exists(hpath + "New Words"))
                Directory.CreateDirectory(hpath + "New Words");
            if (!File.Exists(hpath + "BeginDay.txt"))
                File.WriteAllText(hpath + "BeginDay.txt", convertdate().ToString());

            LoadFiles();
        }

        private void LearnNewWords_Click(object sender, EventArgs e)
        {
            Gib.frmlearntext = "CW Study Tool - " + LearnNewWords.Text;
            Gib.studymode = 1;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }

        private void ReviewWords_Click(object sender, EventArgs e)
        {
            Gib.frmlearntext = "CW Study Tool - " + ReviewWords.Text;
            Gib.studymode = 2;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }

        private void ImportWords_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dinfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                FileSystemInfo[] fsinfos = dinfo.GetFileSystemInfos();
                string ftype, temp;
                string[] r;
                int i = 0;

                foreach (FileSystemInfo fsinfo in fsinfos)
                    if (fsinfo is FileInfo)
                    {
                        ftype = Path.GetExtension(fsinfo.Name);
                        if (File.Exists(wpath + fsinfo.Name))
                        {
                            if (ftype == ".cst2")
                            {
                                temp = File.ReadAllText(wpath + fsinfo.Name, Encoding.Default);
                                temp = temp + "\r\n" + File.ReadAllText(fsinfo.FullName, Encoding.Default);

                                File.Delete(wpath + fsinfo.Name);
                                File.WriteAllText(wpath + fsinfo.Name, temp, Encoding.Default);
                                //Encoding.GetEncoding("GB2312"));
                                for (i = 0; i < Gib.cstn; ++i)
                                    if (Path.GetFileNameWithoutExtension(fsinfo.Name) == Gib.cst1[i])
                                        Gib.cst2[i] = temp;
                            }
                            if (ftype == ".cst3")
                            {
                                File.Delete(wpath + fsinfo.Name);
                                File.WriteAllText(wpath + fsinfo.Name, Gib.today.ToString());
                                for (i = 0; i < Gib.cstn; ++i)
                                    if (Path.GetFileNameWithoutExtension(fsinfo.Name) == Gib.cst1[i])
                                        Gib.cst3[i] = Gib.today;
                            }
                        }
                        else
                        {
                            File.Copy(fsinfo.FullName, wpath + fsinfo.Name);
                            if (ftype == ".cst1")
                                Gib.cst1[Gib.cstn] = Path.GetFileNameWithoutExtension(fsinfo.Name);
                            else if (ftype == ".cst2")
                                Gib.cst2[Gib.cstn] = File.ReadAllText(fsinfo.FullName, Encoding.Default);
                            else if (ftype == ".cst3")
                            {
                                Gib.cst3[Gib.cstn] = Gib.today;
                                File.WriteAllText(wpath + fsinfo.Name, Gib.today.ToString());
                            }
                            else if (ftype == ".his")
                            {
                                for (i = 0; i < 6; ++i)
                                    Gib.his[Gib.cstn, i] = 0;
                                ++Gib.cstn;
                            }
                        }
                    }
            }
        }

        private void AddWords_Click(object sender, EventArgs e)
        {
            FrmAddWord frm = new FrmAddWord();
            frm.ShowDialog(this);
        }

        private void LearnHardWords_Click(object sender, EventArgs e)
        {
            Gib.frmlearntext = "CW Study Tool - " + LearnHardWords.Text;
            Gib.studymode = 3;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }

        private void WordList_Click(object sender, EventArgs e)
        {
            Gib.dosearch = false;
            FrmWordList frm = new FrmWordList();
            frm.ShowDialog();
        }

        private void CheckWords_Click(object sender, EventArgs e)
        {
            Gib.frmlearntext = "CW Study Tool - " + CheckWords.Text;
            Gib.studymode = 4;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }

        private void WordGame_Click(object sender, EventArgs e)
        {
            Gib.frmlearntext = "CW Study Tool - " + WordGame.Text;
            Gib.studymode = 5;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }

        private void ReviewGame_Click(object sender, EventArgs e)
        {
            Gib.frmlearntext = "CW Study Tool - " + ReviewGame.Text;
            Gib.studymode = 6;
            FrmStudy frm = new FrmStudy();
            frm.ShowDialog(this);
        }
    }
}
