using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models.Order
{
    public class UpdateOrderModel
    {
        public int OrderId { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string SpecialNotes { get; set; }

        public int OrderStateId { get; set; }

    }
}
