using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class EmployeeNewModel:PersonModel
    {
        public DateTime? StartDate { get; set; }

        public DateTime? LeaveDate { get; set; }
        public int AccountId { get; set; }
    }
}
