﻿namespace Townbuilder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginpress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_registerpress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_back)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(233, 300);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(332, 22);
            this.tb_username.TabIndex = 0;
            this.tb_username.TextChanged += new System.EventHandler(this.tb_username_TextChanged);
            // 
            // tb_passwort
            // 
            this.tb_passwort.Location = new System.Drawing.Point(233, 450);
            this.tb_passwort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_passwort.Name = "tb_passwort";
            this.tb_passwort.Size = new System.Drawing.Size(332, 22);
            this.tb_passwort.TabIndex = 1;
            // 
            // pb_loginpress
            // 
            this.pb_loginpress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_loginpress.Location = new System.Drawing.Point(176, 661);
            this.pb_loginpress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_loginpress.Name = "pb_loginpress";
            this.pb_loginpress.Size = new System.Drawing.Size(576, 138);
            this.pb_loginpress.TabIndex = 2;
            this.pb_loginpress.TabStop = false;
            this.pb_loginpress.Click += new System.EventHandler(this.pb_loginpress_Click);
            // 
            // pb_registerpress
            // 
            this.pb_registerpress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pb_registerpress.Location = new System.Drawing.Point(956, 661);
            this.pb_registerpress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_registerpress.Name = "pb_registerpress";
            this.pb_registerpress.Size = new System.Drawing.Size(576, 138);
            this.pb_registerpress.TabIndex = 3;
            this.pb_registerpress.TabStop = false;
            this.pb_registerpress.Click += new System.EventHandler(this.pb_registerpress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 624);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1013, 624);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Register";
            // 
            // pbx_back
            // 
            this.pbx_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbx_back.Location = new System.Drawing.Point(16, 15);
            this.pbx_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbx_back.Name = "pbx_back";
            this.pbx_back.Size = new System.Drawing.Size(95, 86);
            this.pbx_back.TabIndex = 6;
            this.pbx_back.TabStop = false;
            this.pbx_back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.pbx_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_registerpress);
            this.Controls.Add(this.pb_loginpress);
            this.Controls.Add(this.tb_passwort);
            this.Controls.Add(this.tb_username);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_login";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_back;
    }
}