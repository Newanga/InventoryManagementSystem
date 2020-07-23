using IMS.Core.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Order
{
    public static class OrderInputDataValidator
    {
        public static bool ValidateAdd(NewOrderModel data)
        {
            if (!CheckOrderItems(data))
            {
                return false;
            }
            else if (!CheckDateValidity(data))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private static bool CheckDateValidity(NewOrderModel data)
        {
            if (data.PlaceDate == null)
            {
                MessageBox.Show("Please select Place Date of the Order.", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool CheckOrderItems(NewOrderModel data)
        {
            if (data.Items.Count < 1)
            {
                MessageBox.Show("Please Add Order Items.", "Missing Order Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }


}
