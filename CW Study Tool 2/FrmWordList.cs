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
    public partial class FrmWordList : DevComponents.DotNetBar.Metro.MetroForm
    {
        string[] cst1 = Gib.cst1;
        string[] cst2 = Gib.cst2;
        int[] good = new int[10000];
        int[] bad = new int[10000];
        int[] score = new int[10000];
        bool[] ac = new bool[10000];

        public FrmWordList()
        {
            InitializeComponent();
        }

        private int la, lb;
        private bool flag;
        bool find(string a, string b)
        {
            la = a.Length;
            lb = b.Length;
            if (la < lb)
                return false;
            int j;
            for (int i = 0; i < la - lb + 1; ++i)
            {
                flag = true;
                for (j = 0; j < lb; ++j)
                    if (a[i + j] != b[j])
                    {
                        flag = false;
                        break;
                    }
                if (flag)
                    return true;
            }
            return false;
        }

        void load()
        {
            int i, j;
            for ( i = 0; i < Gib.cstn; ++i )
                for (j = 0; j < 6; ++j)
                {
                    good[i] += (Gib.his[i, j] == 1 ? 1 : 0);
                    bad[i] += (Gib.his[i, j] == 2 ? 1 : 0);
                    if (Gib.his[i, j] == 1)
                        ++score[i];
                    else if (Gib.his[i, j] == 2)
                        --score[i];
                }
        }

        void swap(int x, int y)
        {
            string ts;
            int ti;

            ts = cst1[x];
            cst1[x] = cst1[y];
            cst1[y] = ts;

            ts = cst2[x];
            cst2[x] = cst2[y];
            cst2[y] = ts;

            ti = good[x];
            good[x] = good[y];
            good[y] = ti;

            ti = bad[x];
            bad[x] = bad[y];
            bad[y] = ti;

            ti = score[x];
            score[x] = score[y];
            score[y] = ti;
        }

        void sort()
        {
            int i, j;
            for ( i = 0; i < Gib.cstn; ++i )
                for ( j = i + 1; j < Gib.cstn; ++j )
                    if ( score[i] > score[j] )
                        swap(i, j);
        }

        private void print()
        {
            int i;
            for (i = 0; i < Gib.cstn; ++i)
                if (ac[i])
                {
                    ListViewItem word =
                        new System.Windows.Forms.ListViewItem(
                            new string[]
                            {cst1[i], good[i].ToString(), bad[i].ToString(), Gib.cst2[i].Replace('\n', ' ')});
                    WordList.Items.Add(word);
                }
        }

        private void FrmWordList_Load(object sender, EventArgs e)
        {
            load();
            sort();
            if (Gib.dosearch)
                for (int i = 0; i < Gib.cstn; ++i)
                    if (find(Gib.cst2[i], Gib.searchword))
                        ac[i] = true;
                    else
                        ac[i] = false;
            print();
        }
    }
}