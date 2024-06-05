
namespace Townbuilder
{
    partial class frm_waffekaufen
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
            this.lbl_kostenwaffe1 = new System.Windows.Forms.Label();
            this.pbx_w1 = new System.Windows.Forms.PictureBox();
            this.lbl_kostenwaffe2 = new System.Windows.Forms.Label();
            this.pbx_w2 = new System.Windows.Forms.PictureBox();
            this.lbl_kostenwaffe3 = new System.Windows.Forms.Label();
            this.pbx_w3 = new System.Windows.Forms.PictureBox();
            this.lbl_geld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_w1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_w2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_w3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_kostenwaffe1
            // 
            this.lbl_kostenwaffe1.AutoSize = true;
            this.lbl_kostenwaffe1.Location = new System.Drawing.Point(131, 459);
            this.lbl_kostenwaffe1.Name = "lbl_kostenwaffe1";
            this.lbl_kostenwaffe1.Size = new System.Drawing.Size(16, 17);
            this.lbl_kostenwaffe1.TabIndex = 3;
            this.lbl_kostenwaffe1.Text = "0";
            // 
            // pbx_w1
            // 
            this.pbx_w1.BackColor = System.Drawing.Color.DarkRed;
            this.pbx_w1.Location = new System.Drawing.Point(22, 101);
            this.pbx_w1.Name = "pbx_w1";
            this.pbx_w1.Size = new System.Drawing.Size(260, 326);
            this.pbx_w1.TabIndex = 2;
            this.pbx_w1.TabStop = false;
            // 
            // lbl_kostenwaffe2
            // 
            this.lbl_kostenwaffe2.AutoSize = true;
            this.lbl_kostenwaffe2.Location = new System.Drawing.Point(362, 459);
            this.lbl_kostenwaffe2.Name = "lbl_kostenwaffe2";
            this.lbl_kostenwaffe2.Size = new System.Drawing.Size(16, 17);
            this.lbl_kostenwaffe2.TabIndex = 5;
            this.lbl_kostenwaffe2.Text = "0";
            // 
            // pbx_w2
            // 
            this.pbx_w2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pbx_w2.Location = new System.Drawing.Point(288, 101);
            this.pbx_w2.Name = "pbx_w2";
            this.pbx_w2.Size = new System.Drawing.Size(260, 326);
            this.pbx_w2.TabIndex = 4;
            this.pbx_w2.TabStop = false;
            // 
            // lbl_kostenwaffe3
            // 
            this.lbl_kostenwaffe3.AutoSize = true;
            this.lbl_kostenwaffe3.Location = new System.Drawing.Point(634, 459);
            this.lbl_kostenwaffe3.Name = "lbl_kostenwaffe3";
            this.lbl_kostenwaffe3.Size = new System.Drawing.Size(16, 17);
            this.lbl_kostenwaffe3.TabIndex = 7;
            this.lbl_kostenwaffe3.Text = "0";
            // 
            // pbx_w3
            // 
            this.pbx_w3.BackColor = System.Drawing.Color.DarkBlue;
            this.pbx_w3.Location = new System.Drawing.Point(554, 101);
            this.pbx_w3.Name = "pbx_w3";
            this.pbx_w3.Size = new System.Drawing.Size(260, 326);
            this.pbx_w3.TabIndex = 6;
            this.pbx_w3.TabStop = false;
            // 
            // lbl_geld
            // 
            this.lbl_geld.AutoSize = true;
            this.lbl_geld.Location = new System.Drawing.Point(690, 21);
            this.lbl_geld.Name = "lbl_geld";
            this.lbl_geld.Size = new System.Drawing.Size(38, 17);
            this.lbl_geld.TabIndex = 10;
            this.lbl_geld.Text = "Geld";
            // 
            // frm_waffekaufen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 552);
            this.Controls.Add(this.lbl_geld);
            this.Controls.Add(this.lbl_kostenwaffe3);
            this.Controls.Add(this.pbx_w3);
            this.Controls.Add(this.lbl_kostenwaffe2);
            this.Controls.Add(this.pbx_w2);
            this.Controls.Add(this.lbl_kostenwaffe1);
            this.Controls.Add(this.pbx_w1);
            this.Name = "frm_waffekaufen";
            this.Text = "frm_waffekaufen";
            this.Load += new System.EventHandler(this.frm_waffekaufen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_w1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_w2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_w3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kostenwaffe1;
        private System.Windows.Forms.PictureBox pbx_w1;
        private System.Windows.Forms.Label lbl_kostenwaffe2;
        private System.Windows.Forms.PictureBox pbx_w2;
        private System.Windows.Forms.Label lbl_kostenwaffe3;
        private System.Windows.Forms.PictureBox pbx_w3;
        private System.Windows.Forms.Label lbl_geld;
    }
}