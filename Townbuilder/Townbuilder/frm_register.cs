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
    public partial class frm_register : Form
    {
        int bild = 1;
        public frm_register()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bild = 1;
        }

        private void pbx_bild2_Click(object sender, EventArgs e)
        {
            bild = 2;
        }

        private void pbx_bild5_Click(object sender, EventArgs e)
        {
            bild = 5;
        }

        private void pbx_bild3_Click(object sender, EventArgs e)
        {
            bild = 3;
        }

        private void pbx_bild6_Click(object sender, EventArgs e)
        {
            bild = 6;
        }

        private void pb_loginpress_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == tb_passwordagain.Text)
            {
                cls_user u = new cls_user(tb_username.Text, tb_password.Text, bild);
                cls_DataProvider.InsertData(u);
                frm_town s = new frm_town(u);
                u.Leveluser = 1;
                u.Waffe = 1;
                u.Levelwaffe = 1;
                u.Ruestung = 1;
                u.Levelruestung = 1;
                u.Wache = 0;
                u.Levelwache = 1;
                u.Levelstadt = 1;
                u.Stadtkaputt = 0;
                u.Leveldungeon = 1;
                u.Geld = 0;
                s.ShowDialog();
            }
            else
            {
                MessageBox.Show("Das Passwort stimmen nicht überein");
            }
        }

        private void pbx_bild4_Click(object sender, EventArgs e)
        {
            bild = 4;
        }

        private void pbx_bild7_Click(object sender, EventArgs e)
        {
            bild = 7;
        }

        private void pbx_bild8_Click(object sender, EventArgs e)
        {
            bild = 8;
        }

        private void pbx_bild9_Click(object sender, EventArgs e)
        {
            bild = 9;
        }
    }
}
