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
    DarkBlue = Sword = 1
    DarkGreen = Axe = 2
    DarkViolet = Greatsword = 3
    DarkRed = Firesword = 4
     */
    public partial class frm_waffekaufen : Form
    {
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
            if(user.Waffe==1)
            {
                pbx_w1.BackColor = Color.DarkGreen; //2
                pbx_w1.Tag = 2;
                pbx_w2.BackColor = Color.DarkViolet; //3
                pbx_w2.Tag = 3;
                pbx_w3.BackColor = Color.DarkRed; //4
                pbx_w2.Tag = 4;
                //pbx_w2 = 3;
                //pbx_w3 = 4;
            }
        }
    }
}
