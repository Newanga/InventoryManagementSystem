using System;
using System.Drawing;
using System.Windows.Forms;

namespace IMS.UserInterface
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.picBxLeftPanel = new System.Windows.Forms.PictureBox();
            this.picBxBtnClose = new System.Windows.Forms.PictureBox();
            this.picBxBtnMinimize = new System.Windows.Forms.PictureBox();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.linkLblForgot = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginForm = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBtnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelLeft.Controls.Add(this.picBxLeftPanel);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(325, 313);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLeft_MouseDown);
            // 
            // picBxLeftPanel
            // 
            this.picBxLeftPanel.Image = ((System.Drawing.Image)(resources.GetObject("picBxLeftPanel.Image")));
            this.picBxLeftPanel.Location = new System.Drawing.Point(31, 12);
            this.picBxLeftPanel.Name = "picBxLeftPanel";
            this.picBxLeftPanel.Size = new System.Drawing.Size(260, 277);
            this.picBxLeftPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLeftPanel.TabIndex = 0;
            this.picBxLeftPanel.TabStop = false;
            this.picBxLeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicBxLeftPanel_MouseDown);
            // 
            // picBxBtnClose
            // 
            this.picBxBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("picBxBtnClose.Image")));
            this.picBxBtnClose.Location = new System.Drawing.Point(818, -1);
            this.picBxBtnClose.Name = "picBxBtnClose";
            this.picBxBtnClose.Size = new System.Drawing.Size(25, 25);
            this.picBxBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxBtnClose.TabIndex = 4;
            this.picBxBtnClose.TabStop = false;
            this.picBxBtnClose.Click += new System.EventHandler(this.PicBxBtnClose_Click);
            // 
            // picBxBtnMinimize
            // 
            this.picBxBtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picBxBtnMinimize.Image")));
            this.picBxBtnMinimize.Location = new System.Drawing.Point(787, -1);
            this.picBxBtnMinimize.Name = "picBxBtnMinimize";
            this.picBxBtnMinimize.Size = new System.Drawing.Size(25, 25);
            this.picBxBtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxBtnMinimize.TabIndex = 5;
            this.picBxBtnMinimize.TabStop = false;
            this.picBxBtnMinimize.Click += new System.EventHandler(this.PicBxBtnMinimize_Click);
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtBxUsername.Location = new System.Drawing.Point(388, 81);
            this.txtBxUsername.MaxLength = 20;
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(423, 19);
            this.txtBxUsername.TabIndex = 1;
            this.txtBxUsername.Text = "UserName";
            this.txtBxUsername.Enter += new System.EventHandler(this.TxtBxUsername_Enter);
            this.txtBxUsername.Leave += new System.EventHandler(this.TxtBxUsername_Leave);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtBxPassword.Location = new System.Drawing.Point(388, 133);
            this.txtBxPassword.MaxLength = 15;
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(423, 19);
            this.txtBxPassword.TabIndex = 2;
            this.txtBxPassword.Text = "Password";
            this.txtBxPassword.Enter += new System.EventHandler(this.TxtBxPassword_Enter);
            this.txtBxPassword.Leave += new System.EventHandler(this.TxtBxPassword_Leave);
            // 
            // linkLblForgot
            // 
            this.linkLblForgot.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLblForgot.AutoSize = true;
            this.linkLblForgot.ForeColor = System.Drawing.Color.Gray;
            this.linkLblForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLblForgot.LinkColor = System.Drawing.Color.Gray;
            this.linkLblForgot.Location = new System.Drawing.Point(479, 276);
            this.linkLblForgot.Name = "linkLblForgot";
            this.linkLblForgot.Size = new System.Drawing.Size(188, 13);
            this.linkLblForgot.TabIndex = 0;
            this.linkLblForgot.TabStop = true;
            this.linkLblForgot.Text = "Forgot Your Username  or Passsword?";
            this.linkLblForgot.VisitedLinkColor = System.Drawing.Color.Gray;
            this.linkLblForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblForgot_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gray;
            this.btnLogin.Location = new System.Drawing.Point(372, 192);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(439, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblLoginForm
            // 
            this.lblLoginForm.AutoSize = true;
            this.lblLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginForm.ForeColor = System.Drawing.Color.Gray;
            this.lblLoginForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLoginForm.Location = new System.Drawing.Point(547, 9);
            this.lblLoginForm.Name = "lblLoginForm";
            this.lblLoginForm.Size = new System.Drawing.Size(101, 39);
            this.lblLoginForm.TabIndex = 6;
            this.lblLoginForm.Text = "Login";
            this.lblLoginForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(844, 313);
            this.Controls.Add(this.lblLoginForm);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkLblForgot);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.picBxBtnMinimize);
            this.Controls.Add(this.picBxBtnClose);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLeftPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBtnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox picBxLeftPanel;
        private System.Windows.Forms.PictureBox picBxBtnClose;
        private System.Windows.Forms.PictureBox picBxBtnMinimize;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.LinkLabel linkLblForgot;
        private System.Windows.Forms.Button btnLogin;
        private Label lblLoginForm;
    }
}