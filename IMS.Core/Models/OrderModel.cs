using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public DateTime PlacedDate { get; set; }

        public DateTime DelieveredDate { get; set; }

        public string SpecialNotes { get; set; }

        public int OrderStateId { get; set; }

        public List<OrderItemModel> OrderItems { get; set; }

    }
}
