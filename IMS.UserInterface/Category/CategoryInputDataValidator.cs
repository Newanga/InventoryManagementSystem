using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Category
{
    public static class CategoryInputDataValidator
    {
        public static bool ValidateAdd(CategoryNewModel data)
        {
            if(!NullOrWhiteSpace(data))
            {
                return false;
            }
            else
            {
               return  true;
            }
        }

        public static bool NullOrWhiteSpace(CategoryNewModel data)
        {
            if (string.IsNullOrWhiteSpace(data.Name) && string.IsNullOrWhiteSpace(data.Description))
            {
                MessageBox.Show("Please enter new category details.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Name))
            {
                MessageBox.Show("Please enter new category name.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Description))
            {
                MessageBox.Show("Please enter new category description.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }



        public static bool ValidateUpdate(CategoryFullModel data)
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

        public static bool NullOrWhiteSpace(CategoryFullModel data)
        {
            if (string.IsNullOrWhiteSpace(data.Name) && string.IsNullOrWhiteSpace(data.Description))
            {
                MessageBox.Show("Please enter new category details.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Name))
            {
                MessageBox.Show("Please enter new category name.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Description))
            {
                MessageBox.Show("Please enter new category description.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
