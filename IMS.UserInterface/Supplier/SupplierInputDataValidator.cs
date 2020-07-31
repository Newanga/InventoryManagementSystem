using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Supplier
{
    public static class SupplierInputDataValidator
    {
        public static bool ValidateAdd(SupplierModel data)
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

        private static bool NullOrWhiteSpace(SupplierModel data)
        {
            if (
                string.IsNullOrWhiteSpace(data.Name) ||
                string.IsNullOrWhiteSpace(data.Description) ||
                string.IsNullOrWhiteSpace(data.Address) ||
                string.IsNullOrWhiteSpace(data.PhoneNumber)
                )
            {
                MessageBox.Show("Incomplete Information.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }



        public static bool ValidateUpdate(SupplierFullModel data)
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

        private static bool NullOrWhiteSpace(SupplierFullModel data)
        {
            if (
                string.IsNullOrWhiteSpace(data.Name) ||
                string.IsNullOrWhiteSpace(data.Description) ||
                string.IsNullOrWhiteSpace(data.Address) ||
                string.IsNullOrWhiteSpace(data.PhoneNumber)
                )
            {
                MessageBox.Show("Incomplete Information.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
