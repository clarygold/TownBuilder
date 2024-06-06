using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Townbuilder
{
    public partial class frm_town : Form
    {
        bool nachrichtstadt = false;
        Timer stadtupdaten = new Timer();
        cls_user user;
        public frm_town()
        {
            InitializeComponent();
        }

        public frm_town(cls_user u)
        {
            InitializeComponent();
            user = u;
        }
        private void frm_town_Load(object sender, EventArgs e)
        {
            Stadtupdate(sender, e);
            
            stadtupdaten.Interval = 5000;
            stadtupdaten.Tick += Stadtupdate;
            stadtupdaten.Start();
        }

        private void pb_dgn_Click(object sender, EventArgs e)
        {
            frm_dungeon dgn = new frm_dungeon();
            stadtupdaten.Stop();
            DialogResult dr = dgn.ShowDialog();
            if(dr==DialogResult.OK)
            {
                Stadtupdate(sender, e);
                stadtupdaten.Start();
            }
        }

        private void pb_attacktown_Click(object sender, EventArgs e)
        {
            frm_attacktown twn = new frm_attacktown(user);
            twn.ShowDialog();
        }
        public void Stadtupdate(object sender, EventArgs e)
        {
            cls_DataProvider.SelectStadt(user);
            lbl_geld.Text = string.Format("Geld: {0}", user.Geld);
            if(user.Stadtkaputt!=0&&nachrichtstadt==false)
            {
                MessageBox.Show("Ihre Stadt wurde angegriffen!");
                nachrichtstadt = true;
            }
        }

        private void pbx_upgrade_Click(object sender, EventArgs e)
        {
            frm_upgrade upgr = new frm_upgrade(user);
            stadtupdaten.Stop();
            DialogResult dr = upgr.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Stadtupdate(sender, e);
                stadtupdaten.Start();
            }
        }

        private void pbx_shop_Click(object sender, EventArgs e)
        {
            frm_shop shop = new frm_shop(user);
            stadtupdaten.Stop();
            DialogResult dr = shop.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Stadtupdate(sender, e);
                stadtupdaten.Start();
            }
        }
    }
}
