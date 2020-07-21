using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.ViewModels
{
    public class OrderFormDropDownsVM
    {
        public List<SupplierName> Suppliers { get; set; }

        public List<SupplierProductsPriceModel> Products { get; set; }


    }
}
