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
    public partial class frm_shop : Form
    {
        cls_user user;
        public frm_shop()
        {
            InitializeComponent();
        }
        public frm_shop(cls_user u)
        {
            InitializeComponent();
            user = u;
        }

        private void frm_shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pbx_waffe_Click(object sender, EventArgs e)
        {
            frm_waffekaufen waffe = new frm_waffekaufen(user);
            waffe.ShowDialog();
        }

        private void pbx_ruestung_Click(object sender, EventArgs e)
        {
            frm_ruestungkaufen ruestung = new frm_ruestungkaufen(user);
            ruestung.ShowDialog();
        }

        private void frm_shop_Load(object sender, EventArgs e)
        {
            if (user.Wache == 0)
            {
                pbx_wache.Visible = true;
            }
        }
    }
}
