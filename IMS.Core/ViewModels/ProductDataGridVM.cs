using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.ViewModels
{
    public class ProductDataGridVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Warrenty { get; set; }

        public string SupplierName { get; set; }

        public string CategoryName { get; set; }

        public string ProductState { get; set; }
    }
}
