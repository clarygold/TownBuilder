
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_leave
            // 
            this.pb_leave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_leave.Location = new System.Drawing.Point(527, 606);
            this.pb_leave.Name = "pb_leave";
            this.pb_leave.Size = new System.Drawing.Size(228, 50);
            this.pb_leave.TabIndex = 0;
            this.pb_leave.TabStop = false;
            this.pb_leave.Click += new System.EventHandler(this.pb_leave_Click);
            // 
            // pb_register
            // 
            this.pb_register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_register.Location = new System.Drawing.Point(527, 529);
            this.pb_register.Name = "pb_register";
            this.pb_register.Size = new System.Drawing.Size(228, 50);
            this.pb_register.TabIndex = 1;
            this.pb_register.TabStop = false;
            this.pb_register.Click += new System.EventHandler(this.pb_register_Click);
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_login.Location = new System.Drawing.Point(527, 454);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(228, 50);
            this.pb_login.TabIndex = 2;
            this.pb_login.TabStop = false;
            this.pb_login.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Close";
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.pb_register);
            this.Controls.Add(this.pb_leave);
            this.Name = "frm_menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pb_leave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_leave;
        private System.Windows.Forms.PictureBox pb_register;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

