using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Core.ViewModels
{
    public class EmployeeDataGridVM
    {
        //PersonModel Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        //EmployeeModel Properties
        public int EmployeeId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime LeaveDate { get; set; }

        //AccountModel Properties
        public int AccountId { get; set; }

        public string EmailAddress { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string AccountState { get; set; }

        public string Role { get; set; }
    }
}
