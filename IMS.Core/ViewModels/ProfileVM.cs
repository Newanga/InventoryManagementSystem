using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.ViewModels
{
    public class ProfileVM
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime StartDate { get; set; }

        public string EmailAddress { get; set; }
        public string Role { get; set; }

        public string Address { get; set; }

        public string Username { get; set; }

    }
}
