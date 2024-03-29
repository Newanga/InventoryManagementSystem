﻿using IMS.Core.Models;
using IMS.DataAccess;
using IMS.UserInterface.Login;
using IMS.UserInterface.SplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using IMS.Common.Cache;
using IMS.FormLoginData;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace IMS.UserInterface
{
    public partial class FormLogin : Form
    {

        private readonly IFormLoginSql _db;
        private readonly IConfiguration _config;

        public FormLogin(IFormLoginSql db)
        {
            InitializeComponent();
            this._db = db;
            CheckForDatabaseConnection();
        }


        #region UX Improvement Events

        private void TxtBxPassword_Leave(object sender, EventArgs e)
        {
            if (txtBxPassword.Text == "")
            {
                txtBxPassword.Text = "Password";
                txtBxPassword.ForeColor = Color.DimGray;
                txtBxPassword.UseSystemPasswordChar = false;

            }
        }

        private void TxtBxPassword_Enter(object sender, EventArgs e)
        {
            if (txtBxPassword.Text == "Password")
            {
                txtBxPassword.Text = "";
                txtBxPassword.ForeColor = Color.LightGray;
                txtBxPassword.UseSystemPasswordChar = true;


            }
        }

        private void TxtBxUsername_Leave(object sender, EventArgs e)
        {

            if (txtBxUsername.Text == "")
            {
                txtBxUsername.Text = "UserName";
                txtBxUsername.ForeColor = Color.DimGray;
            }
        }

        private void TxtBxUsername_Enter(object sender, EventArgs e)
        {
            if (txtBxUsername.Text == "UserName")
            {
                txtBxUsername.Text = "";
                txtBxUsername.ForeColor = Color.LightGray;

            }
        }
        #endregion


        #region Onclick Events

        private void PicBxBtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicBxBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LinkLblForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact Admin to reset your login Details!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion


        #region Events to move the borderless winform
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PanelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PicBxLeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        #region Minimize borderless winform from taskbar
        const int Minimize = 0x20000;
        const int doubleClick = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= Minimize;
                cp.ClassStyle |= doubleClick;
                return cp;
            }
        }
        #endregion


        //Data Access
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            LoginModel data = new LoginModel { Username = txtBxUsername.Text, Password = txtBxPassword.Text };
            bool validData = LoginInputDataValidator.Validate(data);

            if (validData)
            {
                bool validAccount = _db.ValidateAccount(data);

                if (!validAccount)
                {
                    MessageBox.Show("Invalid Username or Password.", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _db.CacheCurrentUserDetails(data.Username);
                    var splash = Program.ServiceProvider.GetService<FormSplashScreen>();
                    this.Hide();
                    splash.ShowDialog();
                    var main = Program.ServiceProvider.GetService<FormMainWindow>();
                    main.Show();
                    main.FormClosed += LogOut;

                }
            }

        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            txtBxUsername.Clear();
            txtBxUsername.Text = "UserName";
            txtBxPassword.Clear();
            txtBxPassword.UseSystemPasswordChar = false;
            txtBxPassword.Text = "Password";
            this.Show();
        }

        private void CheckForDatabaseConnection()
        {
            var connExist=_db.CheckForDatabaseConnection();

            if(connExist==false)
            {
                MessageBox.Show("Please check database connection and try again!","Database can not be found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }


    }
}
