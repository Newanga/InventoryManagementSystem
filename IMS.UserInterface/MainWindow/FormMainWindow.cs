using IMS.Common.Cache;
using IMS.Core.Enums;
using IMS.DataAccess.FormMainWindowData;
using IMS.UserInterface.Category;
using IMS.UserInterface.Employees;
using IMS.UserInterface.Inventory;
using IMS.UserInterface.Order;
using IMS.UserInterface.Product;
using IMS.UserInterface.Profile;
using IMS.UserInterface.Supplier;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IMS.UserInterface
{
    public partial class FormMainWindow : Form
    {
        private readonly IFormMainWindowSql _db;

        public FormMainWindow(IFormMainWindowSql db)
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            _db = db;
            Authorization();
            SetCurrentUserDetails();
        }

        #region UI/UX Improvemnet Events
        private void BtnClose_Click(object sender, EventArgs e)
        {
            _db.UpdateUserLogOut(Cache.EmailAddress);
            ClearCache();
            this.Close();
        }
        private void BtnMaximizer_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Visible = true;
            btnRestore.BringToFront();
            btnMaximizer.Visible = false;
            btnMaximizer.SendToBack();

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnRestore.SendToBack();
            btnMaximizer.Visible = true;
            btnMaximizer.BringToFront();
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
            //prevent reloading same childform
            if (currentChildForm != null && currentChildForm.ToString() == childForm.ToString())
                return;

            //Close any active child forms
            if (currentChildForm != null)
                currentChildForm.Close();
           

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
            OpenChildForm(Program.ServiceProvider.GetService<FormEmployees>());
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.ServiceProvider.GetService<FormOrder>());
        }


        private void BtnInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.ServiceProvider.GetService<FormInventory>());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(Program.ServiceProvider.GetService<FormProfile>());
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


        private void ClearCache()
        {
            Cache.CurrentAccountId = null;
            Cache.EmailAddress = null;
            Cache.FirstName = null;
            Cache.RoleId = null;
        }

        private void SetCurrentUserDetails()
        {
            lblRole.Text = ((Roles)Cache.RoleId).ToString();
            lblFirstName.Text = Cache.FirstName;
            lblEmail.Text = Cache.EmailAddress;
        }

        private void Authorization()
        {
            var role = ((Roles)Cache.RoleId);

            if(role==Roles.Admin)
            {
                btnProfile.Enabled = true;
                btnInventory.Enabled = true;
                btnSuppliers.Enabled = true;
                btnEmployees.Enabled = true;
                btnCategories.Enabled = true;
                btnOrders.Enabled = true;
                btnProducts.Enabled = true;
                btnProfile.Enabled = true;
            }
            if (role == Roles.StockManager)
            {
                btnProfile.Enabled = true;
                btnInventory.Enabled = true;
                btnSuppliers.Enabled = false;
                btnEmployees.Enabled = false;
                btnCategories.Enabled = true;
                btnOrders.Enabled = true;
                btnProducts.Enabled = false;
                btnProfile.Enabled = true;
            }
            if (role == Roles.StockKeeper)
            {
                btnProfile.Enabled = true;
                btnInventory.Enabled = true;
                btnSuppliers.Enabled = false;
                btnEmployees.Enabled = false;
                btnCategories.Enabled = false;
                btnOrders.Enabled = false;
                btnProducts.Enabled = false;
                btnProfile.Enabled = true;
            }


        }

    }
}
