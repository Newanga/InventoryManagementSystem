using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class ProductNewModel
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public double? Price { get; set; }

        public int? Warrenty { get; set; }

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }

        public int ProductStateId { get; set; }
    }
}
