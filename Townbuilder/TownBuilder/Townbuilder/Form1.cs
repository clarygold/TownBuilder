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

        private void pb_login_MouseHover(object sender, EventArgs e)
        {
            pb_login.Image = Properties.Resources.Menulogin3;
        }

        private void pb_login_MouseLeave(object sender, EventArgs e)
        {
            pb_login.Image = Properties.Resources.MenuloginNoHover;
        }

        private void pb_register_MouseHover(object sender, EventArgs e)
        {
            pb_register.Image = Properties.Resources.MenuRegister2;
        }

        private void pb_register_MouseLeave(object sender, EventArgs e)
        {
            pb_register.Image = Properties.Resources.MenuRegisterNoHover2;
        }

        private void pb_leave_MouseHover(object sender, EventArgs e)
        {
            pb_leave.Image = Properties.Resources.MenuClose2;

        }

        private void pb_leave_MouseLeave(object sender, EventArgs e)
        {
            pb_leave.Image = Properties.Resources.MenuClosenohover2;
        }

        private void pb_debug_Click(object sender, EventArgs e)
        {
            frm_town twn = new frm_town();
            twn.ShowDialog();
        }
    }
}
