
namespace Townbuilder
{
    partial class frm_town
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
            this.lbl_geld = new System.Windows.Forms.Label();
            this.pbx_upgrade = new System.Windows.Forms.PictureBox();
            this.pbx_geld = new System.Windows.Forms.PictureBox();
            this.pb_attacktown = new System.Windows.Forms.PictureBox();
            this.pb_dgn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_upgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_geld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_attacktown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_geld
            // 
            this.lbl_geld.AutoSize = true;
            this.lbl_geld.Location = new System.Drawing.Point(741, 24);
            this.lbl_geld.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_geld.Name = "lbl_geld";
            this.lbl_geld.Size = new System.Drawing.Size(13, 13);
            this.lbl_geld.TabIndex = 3;
            this.lbl_geld.Text = "0";
            // 
            // pbx_upgrade
            // 
            this.pbx_upgrade.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbx_upgrade.Location = new System.Drawing.Point(1118, 385);
            this.pbx_upgrade.Name = "pbx_upgrade";
            this.pbx_upgrade.Size = new System.Drawing.Size(150, 150);
            this.pbx_upgrade.TabIndex = 5;
            this.pbx_upgrade.TabStop = false;
            this.pbx_upgrade.Click += new System.EventHandler(this.pbx_upgrade_Click);
            // 
            // pbx_geld
            // 
            this.pbx_geld.BackColor = System.Drawing.Color.Gold;
            this.pbx_geld.Location = new System.Drawing.Point(707, 11);
            this.pbx_geld.Margin = new System.Windows.Forms.Padding(2);
            this.pbx_geld.Name = "pbx_geld";
            this.pbx_geld.Size = new System.Drawing.Size(206, 41);
            this.pbx_geld.TabIndex = 2;
            this.pbx_geld.TabStop = false;
            // 
            // pb_attacktown
            // 
            this.pb_attacktown.BackColor = System.Drawing.Color.IndianRed;
            this.pb_attacktown.Location = new System.Drawing.Point(12, 558);
            this.pb_attacktown.Name = "pb_attacktown";
            this.pb_attacktown.Size = new System.Drawing.Size(150, 150);
            this.pb_attacktown.TabIndex = 1;
            this.pb_attacktown.TabStop = false;
            this.pb_attacktown.Click += new System.EventHandler(this.pb_attacktown_Click);
            // 
            // pb_dgn
            // 
            this.pb_dgn.BackColor = System.Drawing.Color.Green;
            this.pb_dgn.Location = new System.Drawing.Point(1118, 558);
            this.pb_dgn.Name = "pb_dgn";
            this.pb_dgn.Size = new System.Drawing.Size(150, 150);
            this.pb_dgn.TabIndex = 0;
            this.pb_dgn.TabStop = false;
            this.pb_dgn.Click += new System.EventHandler(this.pb_dgn_Click);
            // 
            // frm_town
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pbx_upgrade);
            this.Controls.Add(this.lbl_geld);
            this.Controls.Add(this.pbx_geld);
            this.Controls.Add(this.pb_attacktown);
            this.Controls.Add(this.pb_dgn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_town";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_town";
            this.Load += new System.EventHandler(this.frm_town_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_upgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_geld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_attacktown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_dgn;
        private System.Windows.Forms.PictureBox pb_attacktown;
        private System.Windows.Forms.PictureBox pbx_geld;
        private System.Windows.Forms.Label lbl_geld;
        private System.Windows.Forms.PictureBox pbx_upgrade;
    }
}