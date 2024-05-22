namespace Townbuilder
{
    partial class frm_dungeon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_hp = new System.Windows.Forms.PictureBox();
            this.pb_player = new System.Windows.Forms.PictureBox();
            this.pb_weapon = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pb_enemy = new System.Windows.Forms.PictureBox();
            this.lbl_hp = new System.Windows.Forms.Label();
            this.tmr_hpcheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_hp
            // 
            this.pb_hp.BackColor = System.Drawing.Color.Chocolate;
            this.pb_hp.Location = new System.Drawing.Point(751, 632);
            this.pb_hp.Name = "pb_hp";
            this.pb_hp.Size = new System.Drawing.Size(517, 64);
            this.pb_hp.TabIndex = 3;
            this.pb_hp.TabStop = false;
            this.pb_hp.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pb_player
            // 
            this.pb_player.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pb_player.Location = new System.Drawing.Point(117, 341);
            this.pb_player.Name = "pb_player";
            this.pb_player.Size = new System.Drawing.Size(308, 385);
            this.pb_player.TabIndex = 2;
            this.pb_player.TabStop = false;
            // 
            // pb_weapon
            // 
            this.pb_weapon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb_weapon.Location = new System.Drawing.Point(419, 282);
            this.pb_weapon.Name = "pb_weapon";
            this.pb_weapon.Size = new System.Drawing.Size(287, 443);
            this.pb_weapon.TabIndex = 1;
            this.pb_weapon.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(419, 282);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(287, 443);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pb_enemy
            // 
            this.pb_enemy.Image = global::Townbuilder.Properties.Resources.orcstanding;
            this.pb_enemy.Location = new System.Drawing.Point(665, 49);
            this.pb_enemy.Name = "pb_enemy";
            this.pb_enemy.Size = new System.Drawing.Size(447, 458);
            this.pb_enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_enemy.TabIndex = 0;
            this.pb_enemy.TabStop = false;
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hp.Location = new System.Drawing.Point(1117, 653);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(30, 24);
            this.lbl_hp.TabIndex = 4;
            this.lbl_hp.Text = "10";
            // 
            // tmr_hpcheck
            // 
            this.tmr_hpcheck.Enabled = true;
            this.tmr_hpcheck.Tick += new System.EventHandler(this.tmr_hpcheck_Tick);
            // 
            // frm_dungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.pb_hp);
            this.Controls.Add(this.pb_player);
            this.Controls.Add(this.pb_weapon);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pb_enemy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_dungeon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dungeon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_dungeon_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_player;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pb_weapon;
        private System.Windows.Forms.PictureBox pb_hp;
        private System.Windows.Forms.PictureBox pb_enemy;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Timer tmr_hpcheck;
    }
}