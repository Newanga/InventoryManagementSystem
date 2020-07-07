﻿using System;
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

        public DateTime JoinedDate { get; set; }

        //AccountModel Properties
        public int AccountId { get; set; }

        public string EmailAddress { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public int AccountStateId { get; set; }

        public int RoleId { get; set; }
    }
}