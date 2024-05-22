using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Townbuilder
{
    public partial class frm_dungeon : Form
    {
        Timer tmr_orchits = new Timer();
        Timer tmr_roll = new Timer();
        Timer tmr_cooldownroll = new Timer();
        Timer tmr_orchitshm = new Timer();

        int orctick = 0;
        int hp = 10;
        int roll = 0;
        int cooldown = 0;

        public frm_dungeon()
        {
            InitializeComponent();
            tmr_orchits.Tick += tmr_orchits_Tick;
            tmr_orchits.Interval = 1000;
            tmr_roll.Tick += tmr_roll_Tick;
            tmr_roll.Interval = 1000;
            tmr_cooldownroll.Tick += tmr_cooldownroll_Tick;
            tmr_cooldownroll.Interval = 3000;
            tmr_orchitshm.Tick += tmr_orchitshm_Tick;
            tmr_orchitshm.Interval = 1000;
            tmr_orchitshm.Start();
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

            tmr_orchits.Start();
            pb_enemy.Image = Properties.Resources.orc;

        }
        public void tmr_orchits_Tick(object sender, EventArgs e)
        {
            orctick++;
            if(orctick == 2) 
            {
                if(roll==0)
                {
                    hp--;
                }
            }
            if(orctick == 3)
            {
                pb_enemy.Image = Properties.Resources.orcstanding;
                orctick = 0;
                tmr_orchitshm.Start();
                tmr_orchits.Stop();
            }

        }
        public void tmr_roll_Tick(object sender, EventArgs e)
        {
            
            pb_player.BackColor = Color.DarkGray;
            roll = 0;

            tmr_roll.Stop();

        }

        private void frm_dungeon_KeyDown(object sender, KeyEventArgs e)
        {
            if(cooldown==0&&roll==0&&e.KeyCode == Keys.Space) 
            {
                roll = 1;
                pb_player.BackColor = Color.White;
                cooldown = 1;
                tmr_cooldownroll.Start();
                tmr_roll.Start();
            }
        }
        public void tmr_cooldownroll_Tick(object sender, EventArgs e)
        {
            cooldown = 0;
            tmr_cooldownroll.Stop();

        }
        private void tmr_hpcheck_Tick(object sender, EventArgs e)
        {
            lbl_hp.Text = hp.ToString();
        }
        public void tmr_orchitshm_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(1,4);
            if (i==3)
            {                
                pb_enemy.Image = Properties.Resources.orc;
                tmr_orchits.Start();
                tmr_orchitshm.Stop();
            }
        }
    }
}
