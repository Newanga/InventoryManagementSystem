using IMS.Core.Models;
using IMS.Core.ViewModels;
using System.Collections.Generic;

namespace IMS.DataAccess.FormEmployee
{
    public interface IFormEmployeeSql
    {
        void CreateNewEmployee(EmployeeDetailsNewModel data);
        List<EmployeeDataGridVM> GetAllEmployeesFromDatabase();
        void UpdateExistingEmployee(EmployeeDetailsUpdateModel data);
    }
}