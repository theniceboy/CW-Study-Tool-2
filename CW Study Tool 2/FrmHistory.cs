using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Study_Tool_2
{
    public partial class FrmHistory : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmHistory()
        {
            InitializeComponent();
        }

        private Color badColor;
        private Color goodColor;

        string getstate(int x)
        {
            if (x == 0)
                return "None";
            if (x == 1)
                return "Good";
            return "Bad";
        }
        Color getcolor(int x)
        {
            if (x == 0)
                return Color.Black;
            if (x == 1)
                return Color.Green;
            return Color.DarkRed;
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            s0.Text = getstate(Gib.his[Gib.nowword, 0]);
            s0.ForeColor = getcolor(Gib.his[Gib.nowword, 0]);

            s1.Text = getstate(Gib.his[Gib.nowword, 1]);
            s1.ForeColor = getcolor(Gib.his[Gib.nowword, 1]);

            s2.Text = getstate(Gib.his[Gib.nowword, 2]);
            s2.ForeColor = getcolor(Gib.his[Gib.nowword, 2]);

            s3.Text = getstate(Gib.his[Gib.nowword, 3]);
            s3.ForeColor = getcolor(Gib.his[Gib.nowword, 3]);

            s4.Text = getstate(Gib.his[Gib.nowword, 4]);
            s4.ForeColor = getcolor(Gib.his[Gib.nowword, 4]);

            s5.Text = getstate(Gib.his[Gib.nowword, 5]);
            s5.ForeColor = getcolor(Gib.his[Gib.nowword, 5]);
        }

        private void FrmHistory_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
