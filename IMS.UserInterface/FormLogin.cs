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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public FormLogin()
        {
            InitializeComponent();
        }


        // UX Improvement Events
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



        //Onclick Events
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        //Events to move the borderless winform
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PanelLeft_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PicBxLeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
