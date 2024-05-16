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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_login log = new frm_login();
            log.ShowDialog();
        }

        private void pb_register_Click(object sender, EventArgs e)
        {
            frm_register reg = new frm_register();
            reg.ShowDialog();
        }

        private void pb_leave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
