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
            this.lbl_hp = new System.Windows.Forms.Label();
            this.tmr_hpcheck = new System.Windows.Forms.Timer(this.components);
            this.lbl_orcleben = new System.Windows.Forms.Label();
            this.pb_player = new System.Windows.Forms.PictureBox();
            this.pb_weapon = new System.Windows.Forms.PictureBox();
            this.pb_enemy = new System.Windows.Forms.PictureBox();
            this.pb_hp = new System.Windows.Forms.PictureBox();
            this.tmr_aus = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hp.Location = new System.Drawing.Point(1117, 619);
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
            // lbl_orcleben
            // 
            this.lbl_orcleben.AutoSize = true;
            this.lbl_orcleben.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orcleben.Location = new System.Drawing.Point(1223, 19);
            this.lbl_orcleben.Name = "lbl_orcleben";
            this.lbl_orcleben.Size = new System.Drawing.Size(30, 24);
            this.lbl_orcleben.TabIndex = 5;
            this.lbl_orcleben.Text = "10";
            // 
            // pb_player
            // 
            this.pb_player.BackColor = System.Drawing.Color.Transparent;
            this.pb_player.Image = global::Townbuilder.Properties.Resources.tribalstanding;
            this.pb_player.Location = new System.Drawing.Point(222, 217);
            this.pb_player.Name = "pb_player";
            this.pb_player.Size = new System.Drawing.Size(304, 511);
            this.pb_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_player.TabIndex = 2;
            this.pb_player.TabStop = false;
            // 
            // pb_weapon
            // 
            this.pb_weapon.BackColor = System.Drawing.Color.Transparent;
            this.pb_weapon.Image = global::Townbuilder.Properties.Resources.giantswordstand;
            this.pb_weapon.Location = new System.Drawing.Point(526, 219);
            this.pb_weapon.Name = "pb_weapon";
            this.pb_weapon.Size = new System.Drawing.Size(176, 511);
            this.pb_weapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_weapon.TabIndex = 1;
            this.pb_weapon.TabStop = false;
            // 
            // pb_enemy
            // 
            this.pb_enemy.BackColor = System.Drawing.Color.Transparent;
            this.pb_enemy.Image = global::Townbuilder.Properties.Resources.orcstanding;
            this.pb_enemy.Location = new System.Drawing.Point(665, 49);
            this.pb_enemy.Name = "pb_enemy";
            this.pb_enemy.Size = new System.Drawing.Size(447, 458);
            this.pb_enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_enemy.TabIndex = 0;
            this.pb_enemy.TabStop = false;
            this.pb_enemy.Click += new System.EventHandler(this.pb_enemy_Click);
            // 
            // pb_hp
            // 
            this.pb_hp.BackColor = System.Drawing.Color.Transparent;
            this.pb_hp.Image = global::Townbuilder.Properties.Resources._100;
            this.pb_hp.Location = new System.Drawing.Point(697, 646);
            this.pb_hp.Name = "pb_hp";
            this.pb_hp.Size = new System.Drawing.Size(473, 35);
            this.pb_hp.TabIndex = 6;
            this.pb_hp.TabStop = false;
            // 
            // tmr_aus
            // 
            this.tmr_aus.Interval = 8000;
            this.tmr_aus.Tick += new System.EventHandler(this.tmr_aus_Tick);
            // 
            // frm_dungeon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Townbuilder.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.pb_hp);
            this.Controls.Add(this.lbl_orcleben);
            this.Controls.Add(this.pb_player);
            this.Controls.Add(this.pb_weapon);
            this.Controls.Add(this.pb_enemy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_dungeon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dungeon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_dungeon_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frm_dungeon_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_player;
        private System.Windows.Forms.PictureBox pb_weapon;
        private System.Windows.Forms.PictureBox pb_enemy;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.Timer tmr_hpcheck;
        private System.Windows.Forms.Label lbl_orcleben;
        private System.Windows.Forms.PictureBox pb_hp;
        private System.Windows.Forms.Timer tmr_aus;
    }
}