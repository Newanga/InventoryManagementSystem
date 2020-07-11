using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class EmployeeDetailsUpdateModel
    {
        public AccountFullModel Account { get; set; }

        public EmployeeFullModel Employee { get; set; }
    }
}
