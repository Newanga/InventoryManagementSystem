using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.ViewModels
{
    public class OrderFormDropDownsVM
    {
        public List<SupplierName> Suppliers { get; set; }

        public BindingList<SupplierProductsPriceModel> Products { get; set; }


    }
}
