using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Townbuilder
{
    /*
    DarkBlue = Leather = 1 = 10000
    DarkGreen = Thief = 2 = 50000
    DarkViolet = Tribal = 3 =200000
    DarkRed = Scale = 4 =800000
    Darkorange =Diamond= 5=1000000
     */
    public partial class frm_ruestungkaufen : Form
    {
        int kr1 = 0;
        int kr2 = 0;
        int kr3 = 0;
        int kr4 = 0;
        cls_user user;
        public frm_ruestungkaufen()
        {
            InitializeComponent();
        }
        public frm_ruestungkaufen(cls_user u)
        {
            InitializeComponent();
            user = u;
        }

        private void frm_ruestungkaufen_Load(object sender, EventArgs e)
        {
            PbxAktualisieren();
        }
        public void PbxAktualisieren()
        {
            lbl_geld.Text = Convert.ToString(user.Geld);
            if (user.Ruestung == 1)
            {
                pbx_r1.BackColor = Color.DarkGreen; //2
                pbx_r1.Tag = 2;
                kr1 = 50000;
                pbx_r2.BackColor = Color.DarkViolet; //3
                pbx_r2.Tag = 3;
                kr2 = 200000;
                pbx_r3.BackColor = Color.DarkRed; //4
                pbx_r3.Tag = 4;
                kr3 = 800000;
                pbx_r4.BackColor = Color.DarkOrange; //5
                pbx_r4.Tag = 5;
                kr4 = 1000000;
            }

            else if (user.Ruestung == 2)
            {
                pbx_r1.BackColor = Color.DarkBlue; //1
                pbx_r1.Tag = 1;
                pbx_r2.BackColor = Color.DarkViolet; //3
                pbx_r2.Tag = 3;
                pbx_r3.BackColor = Color.DarkRed; //4
                pbx_r3.Tag = 4;
                pbx_r4.BackColor = Color.DarkOrange; //5
                pbx_r4.Tag = 5;
                kr1 = 10000;
                kr2 = 200000;
                kr3 = 800000;
                kr4 = 1000000;
            }
            else if (user.Ruestung == 3)
            {
                pbx_r1.BackColor = Color.DarkBlue; //1
                pbx_r1.Tag = 1;
                pbx_r2.BackColor = Color.DarkGreen; //2
                pbx_r2.Tag = 2;
                pbx_r3.BackColor = Color.DarkRed; //4
                pbx_r3.Tag = 4;
                pbx_r4.BackColor = Color.DarkOrange; //5
                pbx_r4.Tag = 5;
                kr1 = 10000;
                kr2 = 50000;
                kr3 = 200000;
                kr4 = 1000000;
            }

            else if (user.Ruestung == 4)
            {
                pbx_r1.BackColor = Color.DarkBlue; //1
                pbx_r1.Tag = 1;
                pbx_r2.BackColor = Color.DarkViolet; //3
                pbx_r2.Tag = 3;
                pbx_r3.BackColor = Color.DarkGreen; //2
                pbx_r3.Tag = 2;
                pbx_r4.BackColor = Color.DarkOrange; //5
                pbx_r4.Tag = 5;
                kr1 = 10000;
                kr2 = 200000;
                kr3 = 50000;
                kr4 = 1000000;
            }
            else if (user.Ruestung == 5)
            {
                pbx_r1.BackColor = Color.DarkBlue; //1
                pbx_r1.Tag = 1;
                pbx_r2.BackColor = Color.DarkViolet; //3
                pbx_r2.Tag = 3;
                pbx_r3.BackColor = Color.DarkGreen; //2
                pbx_r3.Tag = 2;
                pbx_r4.BackColor = Color.DarkRed; //4
                pbx_r4.Tag = 4;
                kr1 = 10000;
                kr2 = 200000;
                kr3 = 50000;
                kr4 = 800000;
            }
            lbl_r1.Text = Convert.ToString(kr1);
            lbl_r2.Text = Convert.ToString(kr2);
            lbl_r3.Text = Convert.ToString(kr3);
            lbl_r4.Text = Convert.ToString(kr4);
        }

        private void pbx_r1_Click(object sender, EventArgs e)
        {
            if (user.Geld >= kr1)
            {
                user.Geld = user.Geld - kr1;
                user.Ruestung = Convert.ToInt32(pbx_r1.Tag);
                PbxAktualisieren();
            }
            else
            {
                MessageBox.Show("You cannot buy this item.");
            }
        }

        private void pbx_r2_Click(object sender, EventArgs e)
        {
            if (user.Geld >= kr2)
            {
                user.Geld = user.Geld - kr2;
                user.Ruestung = Convert.ToInt32(pbx_r2.Tag);
                PbxAktualisieren();
            }
            else
            {
                MessageBox.Show("You cannot buy this item.");
            }
        }

        private void pbx_r3_Click(object sender, EventArgs e)
        {
            if (user.Geld >= kr3)
            {
                user.Geld = user.Geld - kr3;
                user.Ruestung = Convert.ToInt32(pbx_r3.Tag);
                PbxAktualisieren();
            }
            else
            {
                MessageBox.Show("You cannot buy this item.");
            }
        }

        private void pbx_r4_Click(object sender, EventArgs e)
        {
            if (user.Geld >= kr4)
            {
                user.Geld = user.Geld - kr4;
                user.Ruestung = Convert.ToInt32(pbx_r4.Tag);
                PbxAktualisieren();
            }
            else
            {
                MessageBox.Show("You cannot buy this item.");
            }
        }

        private void frm_ruestungkaufen_FormClosing(object sender, FormClosingEventArgs e)
        {
            cls_DataProvider.UpdateRuestungkauf(user);
            DialogResult = DialogResult.OK;
        }
    }
}
