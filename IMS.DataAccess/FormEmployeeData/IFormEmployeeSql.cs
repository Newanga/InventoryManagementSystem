﻿using IMS.Core.Models;
using IMS.Core.ViewModels;
using System.Collections.Generic;

namespace IMS.DataAccess.FormEmployeeData
{
    public interface IFormEmployeeSql
    {
        void CreateNewEmployee(EmployeeDetailsNewModel data);
        List<EmployeeDataGridVM> GetAllEmployeesFromDatabase();
        void UpdateExistingEmployee(EmployeeDetailsUpdateModel data);
        bool UsernameExist(string username);

        bool CheckForAdminLockOut();
        bool EmailExist(string emailAddress);
    }
}