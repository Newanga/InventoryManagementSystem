using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Employees
{
    public static class EmployeeInputDataValidator
    {
        public static bool ValidateAdd(EmployeeDetailsNewModel data)
        {
            if (!NullOrWhiteSpace(data))
            {
                return false;
            }
            else if (!CheckDateValidity(data))
            {
                return false;
            }
            else if (!CheckAccountDetailsValidity(data))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool NullOrWhiteSpace(EmployeeDetailsNewModel data)
        {
            if (
                string.IsNullOrWhiteSpace(data.Employee.FirstName) &&
                string.IsNullOrWhiteSpace(data.Employee.LastName) &&
                (data.Employee.DateOfBirth == null) &&
                (data.Employee.StartDate == null) &&
                string.IsNullOrWhiteSpace(data.Employee.Address) &&
                string.IsNullOrWhiteSpace(data.Account.EmailAddress) &&
                string.IsNullOrWhiteSpace(data.Account.Username) &&
                string.IsNullOrWhiteSpace(data.Account.Password)
                )
            {
                MessageBox.Show("Please enter Employee Details.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Employee.FirstName))
            {
                MessageBox.Show("Please enter Employee FirstName.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Employee.LastName))
            {
                MessageBox.Show("Please enter Employee Last Name.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.DateOfBirth == null)
            {
                MessageBox.Show("Please select Date of Birth of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.StartDate == null)
            {
                MessageBox.Show("Please select Start Date of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Employee.Address))
            {
                MessageBox.Show("Please enter Employee Address.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.EmailAddress))
            {
                MessageBox.Show("Please enter Employee EmailAddress.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Username))
            {
                MessageBox.Show("Please enter Employee Username.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Password))
            {
                MessageBox.Show("Please enter Employee Password.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckDateValidity(EmployeeDetailsNewModel data)
        {
            if (data.Employee.DateOfBirth == null && data.Employee.StartDate == null)
            {
                MessageBox.Show("Please select Date of Birth and start date of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.DateOfBirth == null)
            {
                MessageBox.Show("Please select Date of Birth of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.StartDate == null)
            {
                MessageBox.Show("Please select Start Date of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //check for age valididty of 18
            else if (data.Employee.DateOfBirth > (DateTime.Now.AddYears(-18)))
            {
                MessageBox.Show("Select a valid Date of birth of employee.", "Invalid Date Of Birth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.StartDate > DateTime.Now.Date)
            {
                MessageBox.Show("Select a start date which is today or before.", "Invalid StartDate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckAccountDetailsValidity(EmployeeDetailsNewModel data)
        {
            if(string.IsNullOrWhiteSpace(data.Account.Username) && string.IsNullOrWhiteSpace(data.Account.Password) && string.IsNullOrWhiteSpace(data.Account.EmailAddress))
            {
                MessageBox.Show("Please enter a Username and Password and a email for new Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.EmailAddress))
            {
                MessageBox.Show("Please enter Email Address of new Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Username))
            {
                MessageBox.Show("Please enter a Username for new Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Username))
            {
                MessageBox.Show("Please enter a Password  for new Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(!Regex.IsMatch(data.Account.EmailAddress, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show("Please enter a valid Email for new Employee.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Account.Username.Length<6)
            {
                MessageBox.Show("Username should be greater than 6 characters.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Account.Password.Length < 6)
            {
                MessageBox.Show("Password should be greater than 6 characters.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        public static bool ValidateUpdate(EmployeeDetailsUpdateModel data)
        {
            if (!NullOrWhiteSpace(data))
            {
                return false;
            }
            else if (!CheckDateValidity(data))
            {
                return false;
            }
            else if (!CheckAccountDetailsValidity(data))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool NullOrWhiteSpace(EmployeeDetailsUpdateModel data)
        {
            if (
                string.IsNullOrWhiteSpace(data.Employee.FirstName) &&
                string.IsNullOrWhiteSpace(data.Employee.LastName) &&
                (data.Employee.DateOfBirth == null) &&
                (data.Employee.StartDate == null) &&
                string.IsNullOrWhiteSpace(data.Employee.Address) &&
                string.IsNullOrWhiteSpace(data.Account.EmailAddress) &&
                string.IsNullOrWhiteSpace(data.Account.Username) &&
                string.IsNullOrWhiteSpace(data.Account.Password)
                )
            {
                MessageBox.Show("Please enter Employee Details.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Employee.FirstName))
            {
                MessageBox.Show("Please enter Employee FirstName.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Employee.LastName))
            {
                MessageBox.Show("Please enter Employee Last Name.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.DateOfBirth == null)
            {
                MessageBox.Show("Please select Date of Birth of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.StartDate == null)
            {
                MessageBox.Show("Please select Start Date of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Employee.Address))
            {
                MessageBox.Show("Please enter Employee Address.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.EmailAddress))
            {
                MessageBox.Show("Please enter Employee EmailAddress.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Username))
            {
                MessageBox.Show("Please enter Employee Username.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Password))
            {
                MessageBox.Show("Please enter Employee Password.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckDateValidity(EmployeeDetailsUpdateModel data)
        {
            if (data.Employee.DateOfBirth == null && data.Employee.StartDate == null)
            {
                MessageBox.Show("Please select Date of Birth and start date of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.DateOfBirth == null)
            {
                MessageBox.Show("Please select Date of Birth of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.StartDate == null)
            {
                MessageBox.Show("Please select Start Date of Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //check for age valididty of 18
            else if (data.Employee.DateOfBirth > (DateTime.Now.AddYears(-18)))
            {
                MessageBox.Show("Select a valid Date of birth of employee.", "Invalid Date Of Birth", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.StartDate > DateTime.Now.Date)
            {
                MessageBox.Show("Select a start date which is today or before.", "Invalid StartDate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Employee.LeaveDate != null && data.Employee.LeaveDate > DateTime.Now.Date)
            {
                MessageBox.Show("Select a leave date which is today or before.", "Invalid LeaveDate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckAccountDetailsValidity(EmployeeDetailsUpdateModel data)
        {
            if (string.IsNullOrWhiteSpace(data.Account.Username) && string.IsNullOrWhiteSpace(data.Account.Password) && string.IsNullOrWhiteSpace(data.Account.EmailAddress))
            {
                MessageBox.Show("Please enter a Username and Password and a email for new Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.EmailAddress))
            {
                MessageBox.Show("Please enter Email Address of new Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Username))
            {
                MessageBox.Show("Please enter a Username for new Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Username))
            {
                MessageBox.Show("Please enter a Password  for new Employee.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Regex.IsMatch(data.Account.EmailAddress, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                MessageBox.Show("Please enter a valid Email for new Employee.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Account.Username.Length < 6)
            {
                MessageBox.Show("Username should be greater than 6 characters.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Account.Password.Length < 6)
            {
                MessageBox.Show("Password should be greater than 6 characters.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
