using IMS.Core.Models;
using IMS.Core.ViewModels;
using System.Collections.Generic;

namespace IMS.DataAccess.FormEmployee
{
    public interface IFormEmployeeSql
    {
        void CreateNewEmployee(AllEmployeeDetailsModel data);
        List<EmployeeDataGridVM> GetAllEmployeesFromDatabase();
    }
}