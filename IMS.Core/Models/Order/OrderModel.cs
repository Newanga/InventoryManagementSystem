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

        public int SupplierId { get; set; }

        public DateTime PlaceDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string SpecialNotes { get; set; }

        public int OrderStateId { get; set; }


    }
}
