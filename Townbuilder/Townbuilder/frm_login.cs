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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pb_loginpress_Click(object sender, EventArgs e)
        {
            cls_user u = new cls_user(tb_username.Text, tb_passwort.Text);
            cls_DataProvider.SelectLogin(u);
            if(u.Geld==null)
            {
                MessageBox.Show("Benutzer existiert nicht");
            }
            else
            {
                frm_town s = new frm_town(u);
                s.ShowDialog();
            }
        }

        private void pb_registerpress_Click(object sender, EventArgs e)
        {
            frm_register reg = new frm_register();
            reg.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
