﻿namespace 名古屋市医師会会員管理システム
{
    partial class Login
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
            this.showMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showMenu
            // 
            this.showMenu.Location = new System.Drawing.Point(132, 188);
            this.showMenu.Name = "showMenu";
            this.showMenu.Size = new System.Drawing.Size(75, 23);
            this.showMenu.TabIndex = 0;
            this.showMenu.Text = "ログイン";
            this.showMenu.UseVisualStyleBackColor = true;
            this.showMenu.Click += new System.EventHandler(this.showMenu_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 223);
            this.Controls.Add(this.showMenu);
            this.Name = "Login";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showMenu;
    }
}