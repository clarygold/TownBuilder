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
    public partial class frm_town : Form
    {
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

        }

        private void pb_dgn_Click(object sender, EventArgs e)
        {
            frm_dungeon dgn = new frm_dungeon();
            dgn.ShowDialog();
        }

        private void pb_attacktown_Click(object sender, EventArgs e)
        {
            frm_attacktown twn = new frm_attacktown(user);
            twn.ShowDialog();
        }
    }
}
