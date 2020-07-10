using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormEmployee
{
    public class FormEmployeeSql : IFormEmployeeSql
    {
        private readonly ISqlDataAccess _db;

        public FormEmployeeSql(ISqlDataAccess db)
        {
            _db = db;
        }

        public void CreateNewEmployee(AllEmployeeDetailsModel data)
        {
            string sql = @"Insert into dbo.Account (EmailAddress,Username,Password,AccountStateId,RoleId)
                          values (@EmailAddress,@Username,@Password,@AccountStateId,@RoleId);";

            _db.SaveData(sql, data.Account);


            sql = @"Select Id from dbo.Account where Username=@Username";

            int accountId = _db.LoadData<IdLookUpModel, dynamic>(sql, new { Username = data.Account.Username }).First().Id;

            sql = @"Insert into dbo.Employee (FirstName,LastName,DateOfBirth,Address,StartDate,LeaveDate,AccountId)
                    Values (@FirstName,@LastName,@DateOfBirth,@Address,@StartDate,@LeaveDate,@AccountId);";

            _db.SaveData(sql,
                         new
                         {
                             AccountId = accountId,
                             FirstName = data.Employee.FirstName,
                             LastName = data.Employee.LastName,
                             DateOfBirth = data.Employee.DateOfBirth,
                             Address = data.Employee.Address,
                             StartDate = data.Employee.StartDate,
                             LeaveDate = data.Employee.LeaveDate
                         });


        }
    }
}
