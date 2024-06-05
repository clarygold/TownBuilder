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
        int kostenwache =8000;
        int kostenstadt = 10000;
        int kostenruestung = 5000;
        int kostenwaffe=5000;
        int geldgesamt = 0;
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
            KostenAktualisieren();
            geldgesamt = user.Geld;
        }

        private void pbx_wacheplus_Click(object sender, EventArgs e)
        {
            
            if (geldgesamt >= kostenwache)
            {
                user.Levelwache++;
                geldgesamt = geldgesamt - kostenwache;
                
                lbl_geld.Text = string.Format("Geld: {0}", geldgesamt);
            }
            else
            {
                MessageBox.Show("Die Wache kann nicht geupdatet werden!");
            }
            KostenAktualisieren();
        }

        private void pbx_stadtplus_Click(object sender, EventArgs e)
        {
            
            if (geldgesamt >= kostenstadt)
            {
                user.Levelstadt++;
                geldgesamt = geldgesamt - kostenstadt;
                lbl_geld.Text = string.Format("Geld: {0}", geldgesamt);
            }
            else
            {
                MessageBox.Show("Die Stadt kann nicht geupdatet werden!");
            }
            KostenAktualisieren();
        }

        private void pbx_ruestungplus_Click(object sender, EventArgs e)
        {
            
            if (geldgesamt >= kostenruestung)
            {
                user.Levelruestung++;
                geldgesamt = geldgesamt - kostenruestung;
                lbl_geld.Text = string.Format("Geld: {0}", geldgesamt);
            }
            else
            {
                MessageBox.Show("Die Rüstung kann nicht geupdatet werden!");
            }
            KostenAktualisieren();
        }

        private void pbx_waffeplus_Click(object sender, EventArgs e)
        {
            
            if (geldgesamt >= kostenwaffe)
            {
                user.Levelwaffe++;
                geldgesamt = geldgesamt - kostenwaffe;
                lbl_geld.Text = string.Format("Geld: {0}", geldgesamt);
            }
            else
            {
                MessageBox.Show("Die Waffe kann nicht geupdatet werden!");
            }
            KostenAktualisieren();
        }

        private void frm_upgrade_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.Geld = geldgesamt;
            cls_DataProvider.UpdateUpgrade(user);
            DialogResult = DialogResult.OK;
        }

        private void pbx_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void KostenAktualisieren()
        {
            kostenwache = 8000;
            kostenstadt = 10000;
            kostenruestung = 5000;
            kostenwaffe = 5000;
            for (int i = 1; i <= user.Levelwache; i++)
            {
                kostenwache = kostenwache * 2;
            }
            
            for (int i = 1; i <= user.Levelstadt; i++)
            {
                kostenstadt = kostenstadt * 2;
            }
            
            for (int i = 1; i <= user.Levelruestung; i++)
            {
                kostenruestung = kostenruestung * 2;
            }
            
            for (int i = 1; i <= user.Levelwaffe; i++)
            {
                kostenwaffe = kostenwaffe * 2;
            }
            lbl_wachekosten.Text = Convert.ToString(kostenwache);
            lbl_stadtkosten.Text = Convert.ToString(kostenstadt);
            lbl_ruestungkosten.Text = Convert.ToString(kostenruestung);
            lbl_waffekosten.Text = Convert.ToString(kostenwaffe);
        }
    }
}
