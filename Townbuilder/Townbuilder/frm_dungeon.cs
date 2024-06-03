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
        int hpvoll = 10;
        double hpverh = 0;
        
        int roll = 0;
        int cooldown = 0;
        int hit = 0;
        int hitcooldown = 0;
        int orcleben = 10;
        
        int aus = 0;
        
        int orcdmg = 1;
        int playerdmg = 1;

        int armor = 6;
        int weapon = 2;

        public frm_dungeon()
        {
            InitializeComponent();
            tmr_orchits.Tick += tmr_orchits_Tick;
            tmr_orchits.Interval = 600;
            tmr_roll.Tick += tmr_roll_Tick;
            tmr_roll.Interval = 300;
            tmr_cooldownroll.Tick += tmr_cooldownroll_Tick;
            tmr_cooldownroll.Interval = 3000;
            tmr_orchitshm.Tick += tmr_orchitshm_Tick;
            tmr_orchitshm.Interval = 1000;
            tmr_orchitshm.Start();
            tmr_hit.Tick += tmr_hit_Tick;
            tmr_hit.Interval = 2000;
            tmr_hitcooldown.Tick += tmr_hitcooldown_Tick;
            tmr_hitcooldown.Interval = 3000;


            //Rüstungen
            if(armor==1)
            {
                //leder
                pb_player.Image = Properties.Resources.leatherstanding;

            }
            else if (armor == 2)
            {
                //tribal
                pb_player.Image = Properties.Resources.tribalstanding;

            }
            else if (armor == 3)
            {
                //scale
                pb_player.Image = Properties.Resources.scalestand1;

            }
            else if (armor == 4)
            {
                //dia
                pb_player.Image = Properties.Resources.diamondstanding;

            }
            else if (armor == 5)
            {
                //thief
                pb_player.Image = Properties.Resources.thiefstanding;

            }
            else if (armor == 6)
            {
                //secret
                pb_player.Image = Properties.Resources.secretstanding;
            }

            //Waffen
            if(weapon==1) 
            {
                //Schwert
                pb_weapon.Image = Properties.Resources.swordstanding;
            }
            else if(weapon==2) 
            {
                pb_weapon.Image = Properties.Resources.axestanding;
            }
            else if(weapon==3) 
            {
                pb_weapon.Image = Properties.Resources.giantswordstand;
            }
            else if(weapon==4)
            {
                //flammenschwert
            }
            else if(weapon==5)
            {
                //morgenstern
            }
            else if(weapon==6) 
            {
                //hammer
            }
        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

            tmr_orchits.Start();
            pb_enemy.Image = Properties.Resources.orc;

        }
        public void tmr_orchits_Tick(object sender, EventArgs e)
        {
            orctick++;
            if(orctick == 3) 
            {
                if(roll==0)
                {
                    hp -= orcdmg;
                }
            }
            if(orctick == 5)
            {
                pb_enemy.Image = Properties.Resources.orcstanding;
                orctick = 0;
                tmr_orchitshm.Start();
                tmr_orchits.Stop();
            }

        }
        public void tmr_roll_Tick(object sender, EventArgs e)
        {
            //Waffen
            if (weapon == 1)
            {
                //Schwert
                pb_weapon.Image = Properties.Resources.swordstanding;
            }
            else if (weapon == 2)
            {
                pb_weapon.Image = Properties.Resources.axestanding;
            }
            else if (weapon == 3)
            {
                pb_weapon.Image = Properties.Resources.giantswordstand;
            }
            else if (weapon == 4)
            {
                //flammenschwert
            }
            else if (weapon == 5)
            {
                //morgenstern
            }
            else if (weapon == 6)
            {
                //hammer
            }
            if (armor == 1)
            {
                //leder
                pb_player.Image = Properties.Resources.leatherstanding;

            }
            else if (armor == 2)
            {
                //tribal
                pb_player.Image = Properties.Resources.tribalstanding;

            }
            else if (armor == 3)
            {
                //scale
                pb_player.Image = Properties.Resources.scalestand1;

            }
            else if (armor == 4)
            {
                //dia
                pb_player.Image = Properties.Resources.diamondstanding;

            }
            else if (armor == 5)
            {
                //thief
                pb_player.Image = Properties.Resources.thiefstanding;

            }
            else if (armor == 6)
            {
                //secret
                pb_player.Image = Properties.Resources.secretstanding;

            }
            roll = 0;

            tmr_roll.Stop();

        }

        private void frm_dungeon_KeyDown(object sender, KeyEventArgs e)
        {
            if (hit == 0 && cooldown == 0 && roll == 0 && e.KeyCode == Keys.Space)
            {
                roll = 1;
                if (armor == 1)
                {
                    //leder
                    pb_player.Image = Properties.Resources.leatherdodge;

                }
                else if (armor == 2)
                {
                    //tribal
                    pb_player.Image = Properties.Resources.tribaldodge;

                }
                else if (armor == 3)
                {
                    //scale
                    pb_player.Image = Properties.Resources.scaledodge;

                }
                else if (armor == 4)
                {
                    //dia
                    pb_player.Image = Properties.Resources.diamonddodge;

                }
                else if (armor == 5)
                {
                    //thief
                    pb_player.Image = Properties.Resources.thiefdodge;

                }
                else if (armor == 6)
                {
                    //secret
                    pb_player.Image = Properties.Resources.secretdodge;

                }
                //Waffen
                if (weapon == 1)
                {
                    //Schwert
                    pb_weapon.Image = null;
                }
                else if (weapon == 2)
                {
                    pb_weapon.Image = null;
                }
                else if (weapon == 3)
                {
                    pb_weapon.Image = null;
                }
                else if (weapon == 4)
                {
                    //flammenschwert
                    pb_weapon.Image = null;

                }
                else if (weapon == 5)
                {
                    //morgenstern
                    pb_weapon.Image = null;

                }
                else if (weapon == 6)
                {
                    //hammer
                    pb_weapon.Image = null;

                }

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
            if(hp!=0)
            {
                hpverh = hp * 100;
                hpverh /= hpvoll;
            }

                if (hp == hpvoll)
                {
                    pb_hp.Image = Properties.Resources._100;
                }
                else if (hpverh > 80)
                {
                    pb_hp.Image = Properties.Resources._90;
                }
                else if (hpverh > 70)
                {
                    pb_hp.Image = Properties.Resources._80;
                }
                else if (hpverh > 60)
                {
                    pb_hp.Image = Properties.Resources._70;
                }
                else if (hpverh > 50)
                {
                    pb_hp.Image = Properties.Resources._60;
                }
                else if (hpverh > 40)
                {
                    pb_hp.Image = Properties.Resources._50;
                }
                else if (hpverh > 30)
                {
                    pb_hp.Image = Properties.Resources._40;
                }
                else if (hpverh > 20)
                {
                    pb_hp.Image = Properties.Resources._30;
                }
                else if (hpverh > 10)
                {
                    pb_hp.Image = Properties.Resources._20;
                }
                else if(hpverh <= 10)
                {
                    pb_hp.Image = Properties.Resources._10;
                }
            
            lbl_hp.Text = hp.ToString();
            lbl_orcleben.Text = orcleben.ToString();
            if(hp<=0&&aus==0)
            {
                tmr_hpcheck.Stop();

                pb_hp.Image = Properties.Resources._0;
                aus = 1;
                //ENDE
                MessageBox.Show("You died.");
                tmr_orchitshm.Stop();
                DialogResult = DialogResult.OK;
            }
            if(orcleben<=0&&aus==0)
            {
                aus = 1;
                //ENDE (weitergehen/aufhören)
                MessageBox.Show("Enemy slain.");
                tmr_orchitshm.Stop();
                tmr_hpcheck.Stop();
                DialogResult = DialogResult.OK;
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
            if (armor == 1)
            {
                //leder
                pb_player.Image = Properties.Resources.leatherstanding;

            }
            else if (armor == 2)
            {
                //tribal
                pb_player.Image = Properties.Resources.tribalstanding;

            }
            else if (armor == 3)
            {
                //scale
                pb_player.Image = Properties.Resources.scalestand1;

            }
            else if (armor == 4)
            {
                //dia
                pb_player.Image = Properties.Resources.diamondstanding;

            }
            else if (armor == 5)
            {
                //thief
                pb_player.Image = Properties.Resources.thiefstanding;

            }
            else if (armor == 6)
            {
                //secret
                pb_player.Image = Properties.Resources.secretstanding;

            }


            //Waffen
            if (weapon == 1)
            {
                //Schwert
                pb_weapon.Image = Properties.Resources.swordstanding;
            }
            else if (weapon == 2)
            {
                pb_weapon.Image = Properties.Resources.axestanding;
            }
            else if (weapon == 3)
            {
                pb_weapon.Image = Properties.Resources.giantswordstand;
            }
            else if (weapon == 4)
            {
                //flammenschwert
            }
            else if (weapon == 5)
            {
                //morgenstern
            }
            else if (weapon == 6)
            {
                //hammer
            }

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

                //Rüstungenatk
                if (armor == 1)
                {
                    //leder
                    pb_player.Image = Properties.Resources.leather;

                }
                else if (armor == 2)
                {
                    //tribal
                    pb_player.Image = Properties.Resources.tribal;

                }
                else if (armor == 3)
                {
                    //scale
                    pb_player.Image = Properties.Resources.scale;

                }
                else if (armor == 4)
                {
                    //dia
                    pb_player.Image = Properties.Resources.diamond;

                }
                else if (armor == 5)
                {
                    //thief
                    pb_player.Image = Properties.Resources.thief;

                }
                else if (armor == 6)
                {
                    //secret
                    pb_player.Image = Properties.Resources.secret;

                }
                //Waffenatk
                if (weapon == 1)
                {
                    //Schwert
                    pb_weapon.Image = Properties.Resources.sword;
                }
                else if (weapon == 2)
                {
                    pb_weapon.Image = Properties.Resources.axe;
                }
                else if (weapon == 3)
                {
                    pb_weapon.Image = Properties.Resources.giantsword;
                }
                else if (weapon == 4)
                {
                    //flammenschwert
                }
                else if (weapon == 5)
                {
                    //morgenstern
                }
                else if (weapon == 6)
                {
                    //hammer
                }


                orcleben -= playerdmg;

                tmr_hit.Start();
            }
        }
    }
}
