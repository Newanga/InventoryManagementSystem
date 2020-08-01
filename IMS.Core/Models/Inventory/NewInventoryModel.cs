using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models.Inventory
{
    public class NewInventoryModel
    {
        public string SupplierName { get; set; }

        public int? OrderId { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
