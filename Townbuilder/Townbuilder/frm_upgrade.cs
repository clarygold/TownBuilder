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
    public partial class frm_upgrade : Form
    {
        cls_user user;
        public frm_upgrade()
        {
            InitializeComponent();
        }
        public frm_upgrade(cls_user u)
        {
            InitializeComponent();
            user = u;
        }

        private void frm_upgrade_Load(object sender, EventArgs e)
        {
            if (user.Stadtkaputt != 0)
            {
                pbx_stadtreparieren.Visible = true;
            }
            else if (user.Wache != 0)
            {
                pbx_wacheplus.Visible = true;
                label1.Visible = true;
            }
            lbl_geld.Text = string.Format("Geld: {0}", user.Geld);
        }

        private void pbx_wacheplus_Click(object sender, EventArgs e)
        {
            user.Levelwache++;
            //Geld wird weniger, lbl_Geld aktualisieren + überprüfen, ob man das überhaupt kaufen kann
        }

        private void pbx_stadtplus_Click(object sender, EventArgs e)
        {
            user.Levelstadt++;
            //Geld wird weniger
        }

        private void pbx_ruestungplus_Click(object sender, EventArgs e)
        {
            user.Levelruestung++;
            //Geld wird weniger
        }

        private void pbx_waffeplus_Click(object sender, EventArgs e)
        {
            user.Levelwaffe++;
            //Geld wird weniger
        }

        private void frm_upgrade_FormClosing(object sender, FormClosingEventArgs e)
        {
            cls_DataProvider.UpdateUpgrade(user);
        }
    }
}
