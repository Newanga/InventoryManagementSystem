using IMS.Core.Enums;
using IMS.Core.Models;
using IMS.DataAccess.FormEmployee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Employees
{
    public partial class FormEmployees : Form
    {
        private readonly IFormEmployeeSql _db;

        public FormEmployees(IFormEmployeeSql db)
        {
            InitializeComponent();
            _db = db;
        }

        private void btnEmployeesAdd_Click(object sender, EventArgs e)
        {
            PopulateComboBoxes();

            btnEmployeesAdd.Enabled = false;

            btnEmployeesReset.Enabled = true;
            txtBxFirstName.Enabled = true;
            txtBxLastName.Enabled = true;
            txtBxEmailAddress.Enabled = true;
            txtBxAdress.Enabled = true;
            txtBxUsername.Enabled = true;
            txtBxPassword.Enabled = true;

            dTPDOB.Enabled = true;
            dTPStartDate.Enabled = true;
            dTPLeaveDate.Enabled = true;

            comboBxRole.Enabled = true;
            comboBxAccountState.Enabled = true;

            btnEmployeesExistingUpdate.Visible = false;
            btnEmployeesNewUpdate.Visible = true;
            btnEmployeesNewUpdate.Enabled = true;

        }

        private void PopulateComboBoxes()
        {
            comboBxRole.DataSource = Enum.GetValues(typeof(Roles));
            comboBxAccountState.DataSource = Enum.GetValues(typeof(AccountState));
        }

        private void btnEmployeesNewUpdate_Click(object sender, EventArgs e)
        {
            AllEmployeeDetailsModel data = new AllEmployeeDetailsModel
            {
                Account = new AccountNewModel
                {
                    EmailAddress = txtBxEmailAddress.Text,
                    Username = txtBxUsername.Text,
                    Password = txtBxPassword.Text,
                    AccountStateId = comboBxAccountState.SelectedIndex + 1,
                    RoleId = comboBxRole.SelectedIndex + 1
                },
                Employee = new EmployeeNewModel
                {
                    FirstName = txtBxFirstName.Text,
                    LastName = txtBxLastName.Text,
                    Address = txtBxAdress.Text,
                    DateOfBirth = (dTPDOB.CustomFormat == " ") ? (DateTime?)null : dTPDOB.Value.Date,
                    StartDate = (dTPStartDate.CustomFormat == " ") ? (DateTime?)null : dTPStartDate.Value.Date,
                    LeaveDate = (dTPLeaveDate.CustomFormat == " ") ? (DateTime?)null : dTPLeaveDate.Value.Date
                }
            };

            bool validData = EmployeeInputDataValidator.ValidateAdd(data);

            if (validData)
            {
                _db.CreateNewEmployee(data);
            }

  
        }







        #region UI/UX Improvements
        private void dTPDOB_ValueChanged(object sender, EventArgs e)
        {
            dTPDOB.CustomFormat = "dd-MM-yyyy";
        }

        private void dTPDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dTPDOB.CustomFormat = " ";
            }
        }

        private void dTPStartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dTPStartDate.CustomFormat = " ";
            }

        }

        private void dTPStartDate_ValueChanged(object sender, EventArgs e)
        {
            dTPStartDate.CustomFormat = "dd-MM-yyyy";
        }

        private void dTPLeaveDate_ValueChanged(object sender, EventArgs e)
        {
            dTPLeaveDate.CustomFormat = "dd-MM-yyyy";
        }

        private void dTPLeaveDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dTPLeaveDate.CustomFormat = " ";
            }

        }

        #endregion


    }
}
