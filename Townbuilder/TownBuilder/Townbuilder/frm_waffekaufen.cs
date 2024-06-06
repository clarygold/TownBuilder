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
    DarkBlue = Sword = 1 = 10000
    DarkGreen = Axe = 2 = 200000
    DarkViolet = Greatsword = 3 =800000
    DarkRed = Firesword = 4 =1000000
     */
    public partial class frm_waffekaufen : Form
    {
        int kw1=0;
        int kw2 = 0;
        int kw3 = 0;
        cls_user user;
        public frm_waffekaufen()
        {
            InitializeComponent();
        }
        public frm_waffekaufen(cls_user u)
        {
            InitializeComponent();
            user = u;
        }

        private void frm_waffekaufen_Load(object sender, EventArgs e)
        {
            PbxAktualisieren();
        }
        public void PbxAktualisieren()
        {
            lbl_geld.Text = Convert.ToString(user.Geld);
            if(user.Waffe==1)
            {
                pbx_w1.BackColor = Color.DarkGreen; //2
                pbx_w1.Tag = 2;
                kw1 = 20000;
                pbx_w2.BackColor = Color.DarkViolet; //3
                pbx_w2.Tag = 3;
                kw2 = 800000;
                pbx_w3.BackColor = Color.DarkRed; //4
                pbx_w3.Tag = 4;
                kw3 = 1000000;
            }
            else if (user.Waffe == 2)
            {
                pbx_w1.BackColor = Color.DarkBlue; //1
                pbx_w1.Tag = 1;
                pbx_w2.BackColor = Color.DarkViolet; //3
                pbx_w2.Tag = 3;
                pbx_w3.BackColor = Color.DarkRed; //4
                pbx_w3.Tag = 4;
                kw1 = 10000;
                kw2 = 800000;
                kw3 = 1000000;
            }
            else if (user.Waffe == 3)
            {
                pbx_w1.BackColor = Color.DarkGreen; //2
                pbx_w1.Tag = 2;
                pbx_w2.BackColor = Color.DarkBlue; //1
                pbx_w2.Tag = 1;
                pbx_w3.BackColor = Color.DarkRed; //4
                pbx_w3.Tag = 4;
                kw1 = 20000;
                kw2 = 10000;
                kw3 = 1000000;
            }
            else if (user.Waffe == 4)
            {
                pbx_w1.BackColor = Color.DarkGreen; //2
                pbx_w1.Tag = 2;
                pbx_w2.BackColor = Color.DarkViolet; //3
                pbx_w2.Tag = 3;
                pbx_w3.BackColor = Color.DarkBlue; //1
                pbx_w3.Tag = 1;
                kw1 = 20000;
                kw2 = 800000;
                kw3 = 10000;
            }
            lbl_kostenwaffe1.Text = Convert.ToString(kw1);
            lbl_kostenwaffe2.Text = Convert.ToString(kw2);
            lbl_kostenwaffe3.Text = Convert.ToString(kw3);
        }

        private void pbx_w1_Click(object sender, EventArgs e)
        {
            if (user.Geld >= kw1)
            {
                user.Geld = user.Geld - kw1;
                user.Waffe = Convert.ToInt32(pbx_w1.Tag);
                PbxAktualisieren();
            }
            else
            {
                MessageBox.Show("You cannot buy this item.");
            }
        }

        private void pbx_w2_Click(object sender, EventArgs e)
        {
            if (user.Geld >= kw2)
            {
                user.Geld = user.Geld - kw2;
                user.Waffe = Convert.ToInt32(pbx_w2.Tag);
                PbxAktualisieren();
            }
            else
            {
                MessageBox.Show("You cannot buy this item.");
            }
        }

        private void pbx_w3_Click(object sender, EventArgs e)
        {
            if (user.Geld >= kw3)
            {
                    user.Geld = user.Geld - kw3;
            user.Waffe = Convert.ToInt32(pbx_w3.Tag);
            PbxAktualisieren();
            }
            else
            {
                MessageBox.Show("You cannot buy this item.");
            }
        }

        private void frm_waffekaufen_FormClosing(object sender, FormClosingEventArgs e)
        {
            cls_DataProvider.UpdateWaffenkauf(user);
            DialogResult = DialogResult.OK;
        }
    }
}
