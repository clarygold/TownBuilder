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
        Timer tmr_hit = new Timer();
        Timer tmr_hitcooldown = new Timer();

        int orctick = 0;
        int hp = 10;
        int roll = 0;
        int cooldown = 0;
        int hit = 0;
        int hitcooldown = 0;
        int orcleben = 10;
        int aus = 0;
        int orcdmg = 1;
        int playerdmg = 1;

        int armor = 1;
        int weapon = 1;

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
            tmr_hit.Tick += tmr_hit_Tick;
            tmr_hit.Interval = 2000;
            tmr_hitcooldown.Tick += tmr_hitcooldown_Tick;
            tmr_hitcooldown.Interval = 3000;


            //if abfrage für schwert und rüstungen
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
                    hp -= orcdmg;
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
            if (hit == 0&&cooldown==0&&roll==0&&e.KeyCode == Keys.Space) 
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
            lbl_orcleben.Text = orcleben.ToString();
            if(hp<=0&&aus==0)
            {
                aus = 1;
                //ENDE
                MessageBox.Show("You died.");
                tmr_orchitshm.Stop();
                tmr_hpcheck.Stop();
            }
            if(orcleben<=0&&aus==0)
            {
                aus = 1;
                //ENDE (weitergehen/aufhören)
                MessageBox.Show("Enemy slain.");
                tmr_orchitshm.Stop();
                tmr_hpcheck.Stop();

            }
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

        private void frm_dungeon_MouseClick(object sender, MouseEventArgs e)
        {
            //hintergrundklick (unnötig eigentlich)
        }
        public void tmr_hit_Tick(object sender, EventArgs e)
        {
            hit = 0;
            tmr_hitcooldown.Start();

            //rüstungen
            pb_player.Image = Properties.Resources.scalestand;

            //waffen
            //pb_weapon.Image = Properties.Resources.giantswordstand;
            //pb_weapon.Image = Properties.Resources.swordstanding;
            pb_weapon.Image = Properties.Resources.axestanding;

            tmr_hit.Stop();
        }
        public void tmr_hitcooldown_Tick(object sender, EventArgs e)
        {
            hitcooldown = 0;
            tmr_hitcooldown.Stop();
        }

        private void pb_enemy_Click(object sender, EventArgs e)
        {
            if (hitcooldown == 0 && hit == 0 && roll == 0)
            {
                hit = 1;
                hitcooldown = 1;

                //Rüstungen
                pb_player.Image = Properties.Resources.scale;

                //Waffen
                //pb_weapon.Image = Properties.Resources.giantsword2;
                //pb_weapon.Image = Properties.Resources.sword;
                pb_weapon.Image = Properties.Resources.axe;


                orcleben -= playerdmg;

                tmr_hit.Start();
            }
        }
    }
}
