
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
            this.pb_dgn = new System.Windows.Forms.PictureBox();
            this.pb_attacktown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_attacktown)).BeginInit();
            this.SuspendLayout();
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
            // frm_town
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pb_attacktown);
            this.Controls.Add(this.pb_dgn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_town";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_town";
            this.Load += new System.EventHandler(this.frm_town_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_dgn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_attacktown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_dgn;
        private System.Windows.Forms.PictureBox pb_attacktown;
    }
}