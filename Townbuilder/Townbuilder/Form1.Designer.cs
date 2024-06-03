
namespace Townbuilder
{
    partial class frm_menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_leave = new System.Windows.Forms.PictureBox();
            this.pb_register = new System.Windows.Forms.PictureBox();
            this.pb_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_leave
            // 
            this.pb_leave.BackColor = System.Drawing.Color.Transparent;
            this.pb_leave.Image = global::Townbuilder.Properties.Resources.MenuClosenohover2;
            this.pb_leave.Location = new System.Drawing.Point(527, 570);
            this.pb_leave.Name = "pb_leave";
            this.pb_leave.Size = new System.Drawing.Size(228, 50);
            this.pb_leave.TabIndex = 0;
            this.pb_leave.TabStop = false;
            this.pb_leave.Click += new System.EventHandler(this.pb_leave_Click);
            this.pb_leave.MouseLeave += new System.EventHandler(this.pb_leave_MouseLeave);
            this.pb_leave.MouseHover += new System.EventHandler(this.pb_leave_MouseHover);
            // 
            // pb_register
            // 
            this.pb_register.BackColor = System.Drawing.Color.Transparent;
            this.pb_register.Image = global::Townbuilder.Properties.Resources.MenuRegisterNoHover2;
            this.pb_register.Location = new System.Drawing.Point(527, 493);
            this.pb_register.Name = "pb_register";
            this.pb_register.Size = new System.Drawing.Size(228, 50);
            this.pb_register.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_register.TabIndex = 1;
            this.pb_register.TabStop = false;
            this.pb_register.Click += new System.EventHandler(this.pb_register_Click);
            this.pb_register.MouseLeave += new System.EventHandler(this.pb_register_MouseLeave);
            this.pb_register.MouseHover += new System.EventHandler(this.pb_register_MouseHover);
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.Color.Transparent;
            this.pb_login.Image = global::Townbuilder.Properties.Resources.MenuloginNoHover;
            this.pb_login.Location = new System.Drawing.Point(527, 418);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(228, 50);
            this.pb_login.TabIndex = 2;
            this.pb_login.TabStop = false;
            this.pb_login.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pb_login.MouseLeave += new System.EventHandler(this.pb_login_MouseLeave);
            this.pb_login.MouseHover += new System.EventHandler(this.pb_login_MouseHover);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Townbuilder.Properties.Resources.Menu2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.pb_register);
            this.Controls.Add(this.pb_leave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pb_leave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_leave;
        private System.Windows.Forms.PictureBox pb_register;
        private System.Windows.Forms.PictureBox pb_login;
    }
}

