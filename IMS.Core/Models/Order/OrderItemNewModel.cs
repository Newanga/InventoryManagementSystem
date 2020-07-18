using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class OrderItemNewModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}
