using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Common.Cache
{
    public static class Cache
    {
        public static int? CurrentAccountId { get; set; } 

        public static string EmailAddress { get; set; }
        public static string FirstName { get; set; }

        public static int? RoleId { get; set; }
    }
}
