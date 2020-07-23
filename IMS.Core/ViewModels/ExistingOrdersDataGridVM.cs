using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class ExistingOrdersDataGridVM
    {
        public int Id { get; set; }

        public string Supplier { get; set; }

        public DateTime? PlaceDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string SpecialNotes { get; set; }

        public string OrderState { get; set; }


    }
}
