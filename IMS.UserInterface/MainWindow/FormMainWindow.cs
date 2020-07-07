﻿using IMS.Common.Cache;
using IMS.Core.Enums;
using IMS.UserInterface.Category;
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
using IMS.DataAccess.FormCategoryData;
using IMS.UserInterface.Supplier;
using IMS.UserInterface.Product;

namespace IMS.UserInterface
{
    public partial class FormMainWindow : Form
    {

        public FormMainWindow()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lblRole.Text = ((Roles)Cache.RoleId).ToString();
            lblFirstName.Text = Cache.FirstName;
            lblEmail.Text = Cache.EmailAddress;
        }

        #region UI/UX Improvemnet Events
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Visible = true;
            btnMaximizer.Visible = false;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximizer.Visible = true;
        }

        private void BtnMenuExpander_Click(object sender, EventArgs e)
        {
            panelVerticalMenu.Width = 250;
            BtnMenuSlider.Visible = true;
            btnMenuExpander.Visible = false;
        }

        private void BtnMenuSlider_Click(object sender, EventArgs e)
        {
            panelVerticalMenu.Width = 70;
            btnMenuExpander.Visible = true;
            BtnMenuSlider.Visible = false;
        }
        #endregion

        #region Events related to ChildForms
        private Form currentChildForm;

        private void OpenChildForm(Form childForm)
        {
            //Close any active child forms
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
          
            //set new childform properties to fit the window
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.ServiceProvider.GetService<FormSupplier>());
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.ServiceProvider.GetService<FormProduct>());
        }

        private void BtnCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.ServiceProvider.GetService<FormCategory>());
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {

        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Minimize and Maximize borderless winform from taskbar
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

        #region Events to move bordleress winform

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        #endregion
    }
}