using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.Models
{
    public  class AccountFullModel
    {
        public int Id { get; set; }

        public string EmailAddress { get; set; }
        public  string Username { get; set; }

        public string Password { get; set; }

        public int AccountStateId { get; set; }

        public int RoleId { get; set; }

    }
}
