
namespace Townbuilder
{
    partial class frm_shop
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
            this.pbx_waffe = new System.Windows.Forms.PictureBox();
            this.pbx_wache = new System.Windows.Forms.PictureBox();
            this.pbx_ruestung = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_waffe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ruestung)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_waffe
            // 
            this.pbx_waffe.BackColor = System.Drawing.Color.DarkOrchid;
            this.pbx_waffe.Location = new System.Drawing.Point(88, 133);
            this.pbx_waffe.Name = "pbx_waffe";
            this.pbx_waffe.Size = new System.Drawing.Size(233, 295);
            this.pbx_waffe.TabIndex = 0;
            this.pbx_waffe.TabStop = false;
            this.pbx_waffe.Click += new System.EventHandler(this.pbx_waffe_Click);
            // 
            // pbx_wache
            // 
            this.pbx_wache.BackColor = System.Drawing.Color.Orchid;
            this.pbx_wache.Location = new System.Drawing.Point(394, 133);
            this.pbx_wache.Name = "pbx_wache";
            this.pbx_wache.Size = new System.Drawing.Size(233, 295);
            this.pbx_wache.TabIndex = 1;
            this.pbx_wache.TabStop = false;
            this.pbx_wache.Visible = false;
            // 
            // pbx_ruestung
            // 
            this.pbx_ruestung.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pbx_ruestung.Location = new System.Drawing.Point(703, 133);
            this.pbx_ruestung.Name = "pbx_ruestung";
            this.pbx_ruestung.Size = new System.Drawing.Size(233, 295);
            this.pbx_ruestung.TabIndex = 2;
            this.pbx_ruestung.TabStop = false;
            this.pbx_ruestung.Click += new System.EventHandler(this.pbx_ruestung_Click);
            // 
            // frm_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 497);
            this.Controls.Add(this.pbx_ruestung);
            this.Controls.Add(this.pbx_wache);
            this.Controls.Add(this.pbx_waffe);
            this.Name = "frm_shop";
            this.Text = "frm_shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_shop_FormClosing);
            this.Load += new System.EventHandler(this.frm_shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_waffe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ruestung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_waffe;
        private System.Windows.Forms.PictureBox pbx_wache;
        private System.Windows.Forms.PictureBox pbx_ruestung;
    }
}