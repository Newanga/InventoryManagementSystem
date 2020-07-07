using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class EmployeeFullModel:PersonModel
    {
        public int EmployeeId { get; set; }

        public DateTime JoinedDate { get; set; }

        public int AccountId { get; set; }

    }
}
