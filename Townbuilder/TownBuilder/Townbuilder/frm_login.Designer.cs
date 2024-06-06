namespace Townbuilder
{
    partial class frm_login
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
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_passwort = new System.Windows.Forms.TextBox();
            this.pb_loginpress = new System.Windows.Forms.PictureBox();
            this.pb_registerpress = new System.Windows.Forms.PictureBox();
            this.pbx_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginpress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registerpress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_back)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Black;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(445, 285);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(390, 31);
            this.tb_username.TabIndex = 0;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // tb_passwort
            // 
            this.tb_passwort.BackColor = System.Drawing.Color.Black;
            this.tb_passwort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_passwort.ForeColor = System.Drawing.Color.White;
            this.tb_passwort.Location = new System.Drawing.Point(445, 390);
            this.tb_passwort.Name = "tb_passwort";
            this.tb_passwort.PasswordChar = '*';
            this.tb_passwort.Size = new System.Drawing.Size(390, 31);
            this.tb_passwort.TabIndex = 1;
            // 
            // pb_loginpress
            // 
            this.pb_loginpress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_loginpress.Image = global::Townbuilder.Properties.Resources.loginbtn;
            this.pb_loginpress.Location = new System.Drawing.Point(436, 445);
            this.pb_loginpress.Name = "pb_loginpress";
            this.pb_loginpress.Size = new System.Drawing.Size(409, 80);
            this.pb_loginpress.TabIndex = 2;
            this.pb_loginpress.TabStop = false;
            this.pb_loginpress.Click += new System.EventHandler(this.pb_loginpress_Click);
            // 
            // pb_registerpress
            // 
            this.pb_registerpress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_registerpress.Image = global::Townbuilder.Properties.Resources.RegisterBtn;
            this.pb_registerpress.Location = new System.Drawing.Point(436, 551);
            this.pb_registerpress.Name = "pb_registerpress";
            this.pb_registerpress.Size = new System.Drawing.Size(409, 80);
            this.pb_registerpress.TabIndex = 3;
            this.pb_registerpress.TabStop = false;
            this.pb_registerpress.Click += new System.EventHandler(this.pb_registerpress_Click);
            // 
            // pbx_back
            // 
            this.pbx_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbx_back.Image = global::Townbuilder.Properties.Resources.Backbtn;
            this.pbx_back.Location = new System.Drawing.Point(12, 12);
            this.pbx_back.Name = "pbx_back";
            this.pbx_back.Size = new System.Drawing.Size(70, 70);
            this.pbx_back.TabIndex = 6;
            this.pbx_back.TabStop = false;
            this.pbx_back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Townbuilder.Properties.Resources.LoginMenu;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pbx_back);
            this.Controls.Add(this.pb_registerpress);
            this.Controls.Add(this.pb_loginpress);
            this.Controls.Add(this.tb_passwort);
            this.Controls.Add(this.tb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginpress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registerpress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_passwort;
        private System.Windows.Forms.PictureBox pb_loginpress;
        private System.Windows.Forms.PictureBox pb_registerpress;
        private System.Windows.Forms.PictureBox pbx_back;
    }
}