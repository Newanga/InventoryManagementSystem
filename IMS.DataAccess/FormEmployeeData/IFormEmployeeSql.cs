using IMS.Core.Models;

namespace IMS.DataAccess.FormEmployee
{
    public interface IFormEmployeeSql
    {
        void CreateNewEmployee(AllEmployeeDetailsModel data);
    }
}