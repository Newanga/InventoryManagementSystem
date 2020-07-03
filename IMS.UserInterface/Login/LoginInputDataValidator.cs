using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Login
{
    public static class LoginInputDataValidator
    {
        public static bool Validate(LoginModel data)
        {
            if (!(DefaultData(data)))
            {
                return false;
            }
            else if (!(NullOrWhiteSpace(data)))
            {
                return false;
            }
            else if (!(DataLength(data)))
            {
                return false;
            }
            else
            {
                return true;
            }
              

        }
        public static bool DefaultData(LoginModel data)
        {
            if(data.Password=="Password" && data.Username=="UserName")
            {
                MessageBox.Show("Please enter your login details.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Username == "UserName")
            {
                MessageBox.Show("Please enter your Username.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(data.Password == "Password")
            {
                MessageBox.Show("Please enter your Password.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
             
        }
        public static bool NullOrWhiteSpace(LoginModel data)
        {
            if (string.IsNullOrWhiteSpace(data.Username) && string.IsNullOrWhiteSpace(data.Password))
            {
                MessageBox.Show("Please enter your login details.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Username))
            {
                MessageBox.Show("Please enter your Username.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Password))
            {
                MessageBox.Show("Please enter your Password.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool DataLength(LoginModel data)
        {
            if (data.Password.Length < 6 && data.Username.Length < 6)
            {
                MessageBox.Show("The lengths of your UserName and password are too short.", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Username.Length < 6)
            {
                MessageBox.Show("The length of your UserName is too short", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Password.Length < 6)
            {
                MessageBox.Show("The length of your Password is too short", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
