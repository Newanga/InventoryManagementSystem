using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Employees
{
    public static class EmployeeInputDataValidator
    {
        public static bool ValidateAdd(AllEmployeeDetailsModel data)
        {
            if (!NullOrWhiteSpace(data))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool NullOrWhiteSpace(AllEmployeeDetailsModel data)
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
                MessageBox.Show("Please enter Employee Date of Birth.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (data.Employee.StartDate == null)
            {
                MessageBox.Show("Please enter Employee Start Date.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if(string.IsNullOrWhiteSpace(data.Employee.Address))
            {
                MessageBox.Show("Please enter Employee Address.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if(string.IsNullOrWhiteSpace(data.Account.EmailAddress))
            {
                MessageBox.Show("Please enter Employee EmailAddress.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if(string.IsNullOrWhiteSpace(data.Account.Username))
            {
                MessageBox.Show("Please enter Employee Username.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else if (string.IsNullOrWhiteSpace(data.Account.Password))
            {
                MessageBox.Show("Please enter Employee Password.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return true;
            }
        }



    }
}
