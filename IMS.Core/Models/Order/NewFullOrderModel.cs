using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models.Order
{
    public class NewFullOrderModel
    {
        public string SupplierName { get; set; }

        public DateTime PlaceDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string SpecialNotes { get; set; }

        public int OrderStateId { get; set; }

        public BindingList<NewOrderItemModel> Items  = new BindingList<NewOrderItemModel>();
    }
}
