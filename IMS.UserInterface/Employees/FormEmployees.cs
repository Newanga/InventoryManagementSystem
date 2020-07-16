using IMS.Core.Enums;
using IMS.Core.Models;
using IMS.DataAccess.FormEmployeeData;
using System;
using System.Windows;
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
            PopulateDataGrid();
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
            dTPLeaveDate.Enabled = false;

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
            EmployeeDetailsNewModel data = new EmployeeDetailsNewModel
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
                    LeaveDate = (dTPLeaveDate.CustomFormat == " ") ? null : dTPLeaveDate.Value.Date.ToShortDateString()
                }
            };
            bool validData = EmployeeInputDataValidator.ValidateAdd(data);

            if (validData)
            {
                _db.CreateNewEmployee(data);
                dGVEmployees.DataSource = _db.GetAllEmployeesFromDatabase();
                MessageBox.Show("New Employee Successfully", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEmployeesReset_Click(null, RoutedEventArgs.Empty);
            }


        }

        private void PopulateDataGrid()
        {
            dGVEmployees.DataSource = _db.GetAllEmployeesFromDatabase();
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

        private void dGVEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnEmployeesAdd.Enabled == false)
                return;

            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGVEmployees.Rows[e.RowIndex];
                txtBxFirstName.Text = dgvRow.Cells[0].Value.ToString();
                txtBxLastName.Text = dgvRow.Cells[1].Value.ToString();
                txtBxUsername.Text = dgvRow.Cells[2].Value.ToString();

                dTPDOB.Value = Convert.ToDateTime(dgvRow.Cells[3].Value);

                txtBxEmailAddress.Text = dgvRow.Cells[4].Value.ToString();
                txtBxPassword.Text = dgvRow.Cells[5].Value.ToString();

                dTPStartDate.Value = Convert.ToDateTime(dgvRow.Cells[6].Value);



                comboBxRole.DataSource = Enum.GetValues(typeof(Roles));
                var roleTxt = dgvRow.Cells[7].Value.ToString();
                Enum.TryParse(roleTxt, out Roles role);
                comboBxRole.SelectedIndex = (int)role - 1;


                comboBxAccountState.DataSource = Enum.GetValues(typeof(AccountState));
                var acStateTxt = dgvRow.Cells[8].Value.ToString();
                Enum.TryParse(acStateTxt, out AccountState state);
                comboBxAccountState.SelectedIndex = (int)state - 1;


                if (dgvRow.Cells[9].Value.ToString() == "1/1/0001 12:00:00 AM")
                {
                    dTPLeaveDate.CustomFormat = " ";
                }
                else
                {
                    dTPLeaveDate.Value = Convert.ToDateTime(dgvRow.Cells[9].Value);
                }

                txtBxAdress.Text = dgvRow.Cells[10].Value.ToString();
                txtBxEmployeeId.Text = dgvRow.Cells[11].Value.ToString();
                txtBxAccountId.Text = dgvRow.Cells[12].Value.ToString();

            }

            btnEmployeesAdd.Enabled = false;
            btnEmployeesEdit.Enabled = true;
            btnEmployeesReset.Enabled = true;
        }

        private void btnEmployeesReset_Click(object sender, EventArgs e)
        {
            txtBxAccountId.BorderStyle = BorderStyle.None;
            txtBxAccountId.BorderStyle = BorderStyle.Fixed3D;

            txtBxAdress.BorderStyle = BorderStyle.None;
            txtBxAdress.BorderStyle = BorderStyle.Fixed3D;

            txtBxEmailAddress.BorderStyle = BorderStyle.None;
            txtBxEmailAddress.BorderStyle = BorderStyle.Fixed3D;

            txtBxEmployeeId.BorderStyle = BorderStyle.None;
            txtBxEmployeeId.BorderStyle = BorderStyle.Fixed3D;

            txtBxFirstName.BorderStyle = BorderStyle.None;
            txtBxFirstName.BorderStyle = BorderStyle.Fixed3D;

            txtBxLastName.BorderStyle = BorderStyle.None;
            txtBxLastName.BorderStyle = BorderStyle.Fixed3D;

            txtBxPassword.BorderStyle = BorderStyle.None;
            txtBxPassword.BorderStyle = BorderStyle.Fixed3D;

            txtBxUsername.BorderStyle = BorderStyle.None;
            txtBxUsername.BorderStyle = BorderStyle.Fixed3D;

            comboBxAccountState.DataSource = null;
            comboBxAccountState.Enabled = false;

            comboBxRole.DataSource = null;
            comboBxRole.Enabled = false;

            txtBxAccountId.Text = string.Empty;
            txtBxAdress.Text = string.Empty;
            txtBxEmailAddress.Text = string.Empty;
            txtBxEmployeeId.Text = string.Empty;
            txtBxFirstName.Text = string.Empty;
            txtBxLastName.Text = string.Empty;
            txtBxPassword.Text = string.Empty;
            txtBxUsername.Text = string.Empty;

            dTPDOB.Value = DateTime.Now;
            dTPDOB.CustomFormat = " ";
            dTPDOB.Enabled = false;

            dTPStartDate.Value = DateTime.Now;
            dTPStartDate.CustomFormat = " ";
            dTPStartDate.Enabled = false;

            dTPLeaveDate.Value = DateTime.Now;
            dTPLeaveDate.CustomFormat = " ";
            dTPLeaveDate.Enabled = false;

            txtBxAccountId.Enabled = false;
            txtBxAdress.Enabled = false;
            txtBxEmailAddress.Enabled = false;
            txtBxEmployeeId.Enabled = false;
            txtBxFirstName.Enabled = false;
            txtBxLastName.Enabled = false;
            txtBxPassword.Enabled = false;
            txtBxUsername.Enabled = false;

            btnEmployeesNewUpdate.Enabled = false;
            btnEmployeesExistingUpdate.Enabled = false;

            btnEmployeesExistingUpdate.Visible = false;
            btnEmployeesNewUpdate.Visible = true;

            btnEmployeesAdd.Enabled = true;
            btnEmployeesEdit.Enabled = false;

            btnEmployeesReset.Enabled = false;

        }

        private void btnEmployeesExistingUpdate_Click(object sender, EventArgs e)
        {

            EmployeeDetailsUpdateModel data = new EmployeeDetailsUpdateModel
            {
                Account = new AccountFullModel
                {
                    Id = int.Parse(txtBxAccountId.Text),
                    EmailAddress = txtBxEmailAddress.Text,
                    Username = txtBxUsername.Text,
                    Password = txtBxPassword.Text,
                    AccountStateId = comboBxAccountState.SelectedIndex + 1,
                    RoleId = comboBxRole.SelectedIndex + 1
                },
                Employee = new EmployeeFullModel
                {
                    FirstName = txtBxFirstName.Text,
                    LastName = txtBxLastName.Text,
                    Address = txtBxAdress.Text,
                    DateOfBirth = (dTPDOB.CustomFormat == " ") ? (DateTime?)null : dTPDOB.Value.Date,
                    StartDate = (dTPStartDate.CustomFormat == " ") ? (DateTime?)null : dTPStartDate.Value.Date,
                    LeaveDate = dTPLeaveDate.CustomFormat == " " ? (DateTime?)null : dTPLeaveDate.Value.Date,
                }
            };

            bool validData = EmployeeInputDataValidator.ValidateUpdate(data);

            if (validData)
            {
                _db.UpdateExistingEmployee(data);
                dGVEmployees.DataSource = _db.GetAllEmployeesFromDatabase();
                MessageBox.Show("Employee Updated Successfully", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEmployeesReset_Click(null, RoutedEventArgs.Empty);
            }


        }

        private void btnEmployeesEdit_Click(object sender, EventArgs e)
        {
            btnEmployeesAdd.Enabled = false;
            btnEmployeesReset.Enabled = true;
            btnEmployeesEdit.Enabled = false;

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

            btnEmployeesExistingUpdate.Visible = true;
            btnEmployeesExistingUpdate.Enabled = true;
            btnEmployeesNewUpdate.Visible = false;
            btnEmployeesNewUpdate.Enabled = false;

        }
    }
}
