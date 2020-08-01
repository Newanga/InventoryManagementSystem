using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.ViewModels
{
    public class InventoryDataGridVM
    {
        public int InventoryId { get; set; }

        public string ProductName { get; set; }
        public string SupplierName { get; set; }

        public int Available { get; set; }

        public DateTime DateAdded { get; set; }

    }
}
