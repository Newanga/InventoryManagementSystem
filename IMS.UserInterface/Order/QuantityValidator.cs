using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Order
{
    public class QuantityValidator
    {
        public static bool validate(int? quantity)
        {
            if (quantity==null)
            {
                MessageBox.Show("Please enter a Quantity", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
              

            return true;
        }
    }
}
