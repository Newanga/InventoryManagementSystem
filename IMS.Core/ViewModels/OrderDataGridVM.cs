using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.ViewModels
{
    public class OrderDataGridVM
    {
        public int Id { get; set; }

        public string Supplier { get; set; }

        public DateTime PlaceDate { get; set; }

        public string OrderState { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string SpecialNotes { get; set; }
    }
}
