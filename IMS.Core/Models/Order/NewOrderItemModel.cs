using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class NewOrderItemModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }
    }
}
