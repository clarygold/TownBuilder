namespace Townbuilder
{
    partial class frm_attacktown
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
            this.pb_player = new System.Windows.Forms.PictureBox();
            this.pb_weapon = new System.Windows.Forms.PictureBox();
            this.pb_enemy = new System.Windows.Forms.PictureBox();
            this.tmr_hpcheck = new System.Windows.Forms.Timer(this.components);
            this.lbl_hp = new System.Windows.Forms.Label();
            this.pb_hp = new System.Windows.Forms.PictureBox();
            this.lbl_enemyleben = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hp)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_player
            // 
            this.pb_player.BackColor = System.Drawing.Color.Transparent;
            this.pb_player.Image = global::Townbuilder.Properties.Resources.tribalstanding;
            this.pb_player.Location = new System.Drawing.Point(194, 212);
            this.pb_player.Name = "pb_player";
            this.pb_player.Size = new System.Drawing.Size(304, 511);
            this.pb_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_player.TabIndex = 5;
            this.pb_player.TabStop = false;
            // 
            // pb_weapon
            // 
            this.pb_weapon.BackColor = System.Drawing.Color.Transparent;
            this.pb_weapon.Image = global::Townbuilder.Properties.Resources.giantswordstand;
            this.pb_weapon.Location = new System.Drawing.Point(498, 214);
            this.pb_weapon.Name = "pb_weapon";
            this.pb_weapon.Size = new System.Drawing.Size(176, 511);
            this.pb_weapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_weapon.TabIndex = 4;
            this.pb_weapon.TabStop = false;
            // 
            // pb_enemy
            // 
            this.pb_enemy.BackColor = System.Drawing.Color.Transparent;
            this.pb_enemy.Image = global::Townbuilder.Properties.Resources.orcstanding;
            this.pb_enemy.Location = new System.Drawing.Point(638, 53);
            this.pb_enemy.Name = "pb_enemy";
            this.pb_enemy.Size = new System.Drawing.Size(447, 458);
            this.pb_enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_enemy.TabIndex = 3;
            this.pb_enemy.TabStop = false;
            this.pb_enemy.Click += new System.EventHandler(this.pb_enemy_Click);
            // 
            // tmr_hpcheck
            // 
            this.tmr_hpcheck.Enabled = true;
            this.tmr_hpcheck.Tick += new System.EventHandler(this.tmr_hpcheck_Tick_1);
            // 
            // lbl_hp
            // 
            this.lbl_hp.AutoSize = true;
            this.lbl_hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hp.Location = new System.Drawing.Point(1144, 622);
            this.lbl_hp.Name = "lbl_hp";
            this.lbl_hp.Size = new System.Drawing.Size(30, 24);
            this.lbl_hp.TabIndex = 7;
            this.lbl_hp.Text = "10";
            // 
            // pb_hp
            // 
            this.pb_hp.BackColor = System.Drawing.Color.Transparent;
            this.pb_hp.Image = global::Townbuilder.Properties.Resources._100;
            this.pb_hp.Location = new System.Drawing.Point(724, 649);
            this.pb_hp.Name = "pb_hp";
            this.pb_hp.Size = new System.Drawing.Size(473, 35);
            this.pb_hp.TabIndex = 9;
            this.pb_hp.TabStop = false;
            // 
            // lbl_enemyleben
            // 
            this.lbl_enemyleben.AutoSize = true;
            this.lbl_enemyleben.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enemyleben.Location = new System.Drawing.Point(1220, 26);
            this.lbl_enemyleben.Name = "lbl_enemyleben";
            this.lbl_enemyleben.Size = new System.Drawing.Size(30, 24);
            this.lbl_enemyleben.TabIndex = 8;
            this.lbl_enemyleben.Text = "10";
            // 
            // frm_attacktown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Townbuilder.Properties.Resources.Atk1;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lbl_hp);
            this.Controls.Add(this.pb_hp);
            this.Controls.Add(this.lbl_enemyleben);
            this.Controls.Add(this.pb_player);
            this.Controls.Add(this.pb_weapon);
            this.Controls.Add(this.pb_enemy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_attacktown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_attacktown";
            this.Load += new System.EventHandler(this.frm_attacktown_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_attacktown_KeyDown_1);
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
        private System.Windows.Forms.Timer tmr_hpcheck;
        private System.Windows.Forms.Label lbl_hp;
        private System.Windows.Forms.PictureBox pb_hp;
        private System.Windows.Forms.Label lbl_enemyleben;
    }
}