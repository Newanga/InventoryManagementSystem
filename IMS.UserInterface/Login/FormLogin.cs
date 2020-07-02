using IMS.Core.Models;
using IMS.DataAccess;
using IMS.UserInterface.Login;
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

namespace IMS.UserInterface
{
    public partial class FormLogin : Form
    {

        private readonly IFormLoginSql _db;
        public FormLogin(IFormLoginSql db)
        {
            InitializeComponent();
            this._db = db;
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
            bool validData = InputLoginDetailsValidator.Validate(data);


            AccountModel userAccount=new AccountModel();
            if (validData)
            {
                userAccount = _db.ValidateAccount(data);  
            }

            if (userAccount == null)
            {
                MessageBox.Show("Invalid Username or Password.", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }

        }

    }
}
