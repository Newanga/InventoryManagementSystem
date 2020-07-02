using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public class CurrentUserDetails
    {
        public  int Id { get; set; }

        public  string EmailAddress { get; set; }
        public  string FirstName { get; set; }

        public  int RoleId { get; set; }
    }
}
