using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMS.UserInterface.Product;

namespace IMS.UserInterface.Product
{
    public static class ProductInputDataValidator
    {
        public static bool ValidateAdd(ProductNewModel data)
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

        private static bool NullOrWhiteSpace(ProductNewModel data)
        {
            if (string.IsNullOrWhiteSpace(data.Name) ||
                string.IsNullOrWhiteSpace(data.Description))
            {
                MessageBox.Show("Incomplete Information.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(data.Price==null && data.Warrenty==null)
            {
                MessageBox.Show("Please enter a price and a warrenty.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(data.Price == null)
            {
                MessageBox.Show("Please enter a price.", "Invliad Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(data.Warrenty == null)
            {
                MessageBox.Show("Please enter a warrenty.", "Invalid Warrenty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else 
            {
                return true;
            }
        }



        public static bool ValidateUpdate(ProductFullModel data)
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

        private static bool NullOrWhiteSpace(ProductFullModel data)
        {
            if (string.IsNullOrWhiteSpace(data.Name) ||
             string.IsNullOrWhiteSpace(data.Description))
            {
                MessageBox.Show("Incomplete Information.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Price == null && data.Warrenty == null)
            {
                MessageBox.Show("Please enter a price and a warrenty.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Price == null)
            {
                MessageBox.Show("Please enter a price.", "Invliad Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (data.Warrenty == null)
            {
                MessageBox.Show("Please enter a warrenty.", "Invalid Warrenty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
