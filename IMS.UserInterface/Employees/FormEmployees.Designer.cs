namespace IMS.UserInterface.Employees
{
    partial class FormEmployees
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
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtBxEmployeeId = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dTPDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBxAdress = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dTPStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.txtBxAccountId = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtBxEmailAddress = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.blPassword = new System.Windows.Forms.Label();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.lblAccountState = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.comboBxAccountState = new System.Windows.Forms.ComboBox();
            this.comboBxRole = new System.Windows.Forms.ComboBox();
            this.dGVEmployees = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEmployeesAdd = new System.Windows.Forms.Button();
            this.btnEmployeesEdit = new System.Windows.Forms.Button();
            this.btnEmployeesExistingUpdate = new System.Windows.Forms.Button();
            this.btnEmployeesNewUpdate = new System.Windows.Forms.Button();
            this.btnEmployeesReset = new System.Windows.Forms.Button();
            this.lblLeaveDate = new System.Windows.Forms.Label();
            this.dTPLeaveDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(122, 57);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(65, 13);
            this.lblEmployeeId.TabIndex = 0;
            this.lblEmployeeId.Text = "Employee Id";
            // 
            // txtBxEmployeeId
            // 
            this.txtBxEmployeeId.Enabled = false;
            this.txtBxEmployeeId.Location = new System.Drawing.Point(193, 54);
            this.txtBxEmployeeId.Name = "txtBxEmployeeId";
            this.txtBxEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtBxEmployeeId.TabIndex = 1;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Enabled = false;
            this.txtBxFirstName.Location = new System.Drawing.Point(193, 88);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(122, 91);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(122, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Enabled = false;
            this.txtBxLastName.Location = new System.Drawing.Point(193, 117);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLastName.TabIndex = 1;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(340, 57);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // dTPDOB
            // 
            this.dTPDOB.CustomFormat = " ";
            this.dTPDOB.Enabled = false;
            this.dTPDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPDOB.Location = new System.Drawing.Point(414, 57);
            this.dTPDOB.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dTPDOB.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dTPDOB.Name = "dTPDOB";
            this.dTPDOB.Size = new System.Drawing.Size(97, 20);
            this.dTPDOB.TabIndex = 2;
            this.dTPDOB.Value = new System.DateTime(2020, 7, 7, 0, 0, 0, 0);
            this.dTPDOB.ValueChanged += new System.EventHandler(this.dTPDOB_ValueChanged);
            this.dTPDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTPDOB_KeyDown);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(340, 151);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // txtBxAdress
            // 
            this.txtBxAdress.Enabled = false;
            this.txtBxAdress.Location = new System.Drawing.Point(414, 148);
            this.txtBxAdress.Name = "txtBxAdress";
            this.txtBxAdress.Size = new System.Drawing.Size(141, 20);
            this.txtBxAdress.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(340, 94);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Stae Date";
            // 
            // dTPStartDate
            // 
            this.dTPStartDate.Checked = false;
            this.dTPStartDate.CustomFormat = " ";
            this.dTPStartDate.Enabled = false;
            this.dTPStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPStartDate.Location = new System.Drawing.Point(414, 94);
            this.dTPStartDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dTPStartDate.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dTPStartDate.Name = "dTPStartDate";
            this.dTPStartDate.Size = new System.Drawing.Size(97, 20);
            this.dTPStartDate.TabIndex = 2;
            this.dTPStartDate.Value = new System.DateTime(2020, 7, 7, 0, 0, 0, 0);
            this.dTPStartDate.ValueChanged += new System.EventHandler(this.dTPStartDate_ValueChanged);
            this.dTPStartDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTPStartDate_KeyDown);
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Location = new System.Drawing.Point(614, 54);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(59, 13);
            this.lblAccountId.TabIndex = 0;
            this.lblAccountId.Text = "Account Id";
            // 
            // txtBxAccountId
            // 
            this.txtBxAccountId.Enabled = false;
            this.txtBxAccountId.Location = new System.Drawing.Point(693, 51);
            this.txtBxAccountId.Name = "txtBxAccountId";
            this.txtBxAccountId.Size = new System.Drawing.Size(156, 20);
            this.txtBxAccountId.TabIndex = 1;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(122, 147);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(32, 13);
            this.lblEmailAddress.TabIndex = 0;
            this.lblEmailAddress.Text = "Email";
            // 
            // txtBxEmailAddress
            // 
            this.txtBxEmailAddress.Enabled = false;
            this.txtBxEmailAddress.Location = new System.Drawing.Point(193, 144);
            this.txtBxEmailAddress.Name = "txtBxEmailAddress";
            this.txtBxEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.txtBxEmailAddress.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(618, 86);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Enabled = false;
            this.txtBxUsername.Location = new System.Drawing.Point(693, 82);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(156, 20);
            this.txtBxUsername.TabIndex = 1;
            // 
            // blPassword
            // 
            this.blPassword.AutoSize = true;
            this.blPassword.Location = new System.Drawing.Point(620, 109);
            this.blPassword.Name = "blPassword";
            this.blPassword.Size = new System.Drawing.Size(53, 13);
            this.blPassword.TabIndex = 0;
            this.blPassword.Text = "Password";
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Enabled = false;
            this.txtBxPassword.Location = new System.Drawing.Point(693, 109);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(156, 20);
            this.txtBxPassword.TabIndex = 1;
            // 
            // lblAccountState
            // 
            this.lblAccountState.AutoSize = true;
            this.lblAccountState.Location = new System.Drawing.Point(598, 172);
            this.lblAccountState.Name = "lblAccountState";
            this.lblAccountState.Size = new System.Drawing.Size(75, 13);
            this.lblAccountState.TabIndex = 0;
            this.lblAccountState.Text = "Account State";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(644, 141);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            // 
            // comboBxAccountState
            // 
            this.comboBxAccountState.Enabled = false;
            this.comboBxAccountState.FormattingEnabled = true;
            this.comboBxAccountState.Location = new System.Drawing.Point(693, 172);
            this.comboBxAccountState.Name = "comboBxAccountState";
            this.comboBxAccountState.Size = new System.Drawing.Size(156, 21);
            this.comboBxAccountState.TabIndex = 3;
            // 
            // comboBxRole
            // 
            this.comboBxRole.Enabled = false;
            this.comboBxRole.FormattingEnabled = true;
            this.comboBxRole.Location = new System.Drawing.Point(693, 138);
            this.comboBxRole.Name = "comboBxRole";
            this.comboBxRole.Size = new System.Drawing.Size(156, 21);
            this.comboBxRole.TabIndex = 3;
            // 
            // dGVEmployees
            // 
            this.dGVEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Username,
            this.Email,
            this.Password,
            this.StartDate,
            this.Role,
            this.AccountState,
            this.LeaveDate,
            this.EmployeeId,
            this.DateOfBirth,
            this.Address,
            this.AccountId});
            this.dGVEmployees.Location = new System.Drawing.Point(43, 246);
            this.dGVEmployees.Name = "dGVEmployees";
            this.dGVEmployees.Size = new System.Drawing.Size(937, 150);
            this.dGVEmployees.TabIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // AccountState
            // 
            this.AccountState.HeaderText = "AccountState";
            this.AccountState.Name = "AccountState";
            // 
            // LeaveDate
            // 
            this.LeaveDate.HeaderText = "LeaveDate";
            this.LeaveDate.Name = "LeaveDate";
            // 
            // EmployeeId
            // 
            this.EmployeeId.HeaderText = "EmployeeId";
            this.EmployeeId.Name = "EmployeeId";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // AccountId
            // 
            this.AccountId.HeaderText = "AccountId";
            this.AccountId.Name = "AccountId";
            // 
            // btnEmployeesAdd
            // 
            this.btnEmployeesAdd.Location = new System.Drawing.Point(886, 36);
            this.btnEmployeesAdd.Name = "btnEmployeesAdd";
            this.btnEmployeesAdd.Size = new System.Drawing.Size(94, 23);
            this.btnEmployeesAdd.TabIndex = 5;
            this.btnEmployeesAdd.Text = "Add";
            this.btnEmployeesAdd.UseVisualStyleBackColor = true;
            this.btnEmployeesAdd.Click += new System.EventHandler(this.btnEmployeesAdd_Click);
            // 
            // btnEmployeesEdit
            // 
            this.btnEmployeesEdit.Location = new System.Drawing.Point(886, 76);
            this.btnEmployeesEdit.Name = "btnEmployeesEdit";
            this.btnEmployeesEdit.Size = new System.Drawing.Size(94, 23);
            this.btnEmployeesEdit.TabIndex = 5;
            this.btnEmployeesEdit.Text = "Edit";
            this.btnEmployeesEdit.UseVisualStyleBackColor = true;
            // 
            // btnEmployeesExistingUpdate
            // 
            this.btnEmployeesExistingUpdate.Location = new System.Drawing.Point(886, 145);
            this.btnEmployeesExistingUpdate.Name = "btnEmployeesExistingUpdate";
            this.btnEmployeesExistingUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnEmployeesExistingUpdate.TabIndex = 5;
            this.btnEmployeesExistingUpdate.Text = "Update";
            this.btnEmployeesExistingUpdate.UseVisualStyleBackColor = true;
            // 
            // btnEmployeesNewUpdate
            // 
            this.btnEmployeesNewUpdate.Location = new System.Drawing.Point(886, 110);
            this.btnEmployeesNewUpdate.Name = "btnEmployeesNewUpdate";
            this.btnEmployeesNewUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnEmployeesNewUpdate.TabIndex = 5;
            this.btnEmployeesNewUpdate.Text = "Update";
            this.btnEmployeesNewUpdate.UseVisualStyleBackColor = true;
            this.btnEmployeesNewUpdate.Click += new System.EventHandler(this.btnEmployeesNewUpdate_Click);
            // 
            // btnEmployeesReset
            // 
            this.btnEmployeesReset.Location = new System.Drawing.Point(886, 172);
            this.btnEmployeesReset.Name = "btnEmployeesReset";
            this.btnEmployeesReset.Size = new System.Drawing.Size(94, 23);
            this.btnEmployeesReset.TabIndex = 5;
            this.btnEmployeesReset.Text = "Reset";
            this.btnEmployeesReset.UseVisualStyleBackColor = true;
            // 
            // lblLeaveDate
            // 
            this.lblLeaveDate.AutoSize = true;
            this.lblLeaveDate.Location = new System.Drawing.Point(340, 122);
            this.lblLeaveDate.Name = "lblLeaveDate";
            this.lblLeaveDate.Size = new System.Drawing.Size(63, 13);
            this.lblLeaveDate.TabIndex = 0;
            this.lblLeaveDate.Text = "Leave Date";
            // 
            // dTPLeaveDate
            // 
            this.dTPLeaveDate.CustomFormat = " ";
            this.dTPLeaveDate.Enabled = false;
            this.dTPLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPLeaveDate.Location = new System.Drawing.Point(414, 122);
            this.dTPLeaveDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dTPLeaveDate.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dTPLeaveDate.Name = "dTPLeaveDate";
            this.dTPLeaveDate.Size = new System.Drawing.Size(97, 20);
            this.dTPLeaveDate.TabIndex = 2;
            this.dTPLeaveDate.Value = new System.DateTime(2020, 7, 7, 0, 0, 0, 0);
            this.dTPLeaveDate.ValueChanged += new System.EventHandler(this.dTPLeaveDate_ValueChanged);
            this.dTPLeaveDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dTPLeaveDate_KeyDown);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 445);
            this.Controls.Add(this.btnEmployeesReset);
            this.Controls.Add(this.btnEmployeesNewUpdate);
            this.Controls.Add(this.btnEmployeesExistingUpdate);
            this.Controls.Add(this.btnEmployeesEdit);
            this.Controls.Add(this.btnEmployeesAdd);
            this.Controls.Add(this.dGVEmployees);
            this.Controls.Add(this.comboBxRole);
            this.Controls.Add(this.comboBxAccountState);
            this.Controls.Add(this.dTPLeaveDate);
            this.Controls.Add(this.dTPStartDate);
            this.Controls.Add(this.dTPDOB);
            this.Controls.Add(this.txtBxAdress);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.txtBxEmailAddress);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.txtBxAccountId);
            this.Controls.Add(this.lblLeaveDate);
            this.Controls.Add(this.txtBxEmployeeId);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblAccountState);
            this.Controls.Add(this.blPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblAccountId);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmployeeId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dGVEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtBxEmployeeId;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dTPDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBxAdress;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dTPStartDate;
        private System.Windows.Forms.Label lblAccountId;
        private System.Windows.Forms.TextBox txtBxAccountId;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtBxEmailAddress;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.Label blPassword;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label lblAccountState;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboBxAccountState;
        private System.Windows.Forms.ComboBox comboBxRole;
        private System.Windows.Forms.DataGridView dGVEmployees;
        private System.Windows.Forms.Button btnEmployeesAdd;
        private System.Windows.Forms.Button btnEmployeesEdit;
        private System.Windows.Forms.Button btnEmployeesExistingUpdate;
        private System.Windows.Forms.Button btnEmployeesNewUpdate;
        private System.Windows.Forms.Button btnEmployeesReset;
        private System.Windows.Forms.Label lblLeaveDate;
        private System.Windows.Forms.DateTimePicker dTPLeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountState;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountId;
    }
}