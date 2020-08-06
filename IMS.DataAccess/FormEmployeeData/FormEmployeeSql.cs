
using IMS.Core.Models;
using IMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormEmployeeData
{
    public class FormEmployeeSql : IFormEmployeeSql
    {
        private readonly ISqlDataAccess _db;

        public FormEmployeeSql(ISqlDataAccess db)
        {
            _db = db;
        }

        public bool UsernameExist(string username)
        {
            string sql = @"select Id
                            from dbo.Account
                            where UserName = @Username COLLATE SQL_Latin1_General_CP1_CS_AS;";

            var id= _db.LoadData<IdLookUpModel, dynamic>(sql, new { @Username = username }).FirstOrDefault();

            if (id == null)
                return false;
            else
                return true;



        }

        public bool EmailExist(string emailAddress)
        {
            string sql = @"select EmailAddress
                            from dbo.Account
                            where EmailAddress = @EmailAddress COLLATE SQL_Latin1_General_CP1_CS_AS;";

            var id = _db.LoadData<IdLookUpModel, dynamic>(sql, new { @EmailAddress = emailAddress }).FirstOrDefault();

            if (id == null)
                return false;
            else
                return true;

        }

        public void CreateNewEmployee(EmployeeDetailsNewModel data)
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


        public List<EmployeeDataGridVM> GetAllEmployeesFromDatabase()
        {
            string sql = @"select 
                            e.FirstName,
                            e.LastName,
                            a.Username ,
                            e.DateOfBirth,
                            a.EmailAddress ,
                            a.Password,
                            e.StartDate,
                            r.Name as Role,
                            ast.State as AccountState,  
                            e.LeaveDate,
                            e.Address,
                            e.Id as EmployeeId,
                            a.Id as AccountId
                            from dbo.Employee as e
                            inner join dbo.Account as a
                            on e.AccountId=a.Id
                            inner join dbo.AccountState as ast
                            on a.AccountStateId=ast.Id
                            inner join dbo.Roles as r
                            on a.RoleId=r.Id;";

            return _db.LoadData<EmployeeDataGridVM, dynamic>(sql, new { });



        }


        public bool CheckForAdminLockOut()
        {
            string sql = @"select a.Id
                            from dbo.Account as a
                            inner join  dbo.Roles as r
                            on a.RoleId=r.Id
                            inner join dbo.AccountState as acs
                            on a.AccountStateId=acs.Id
                            where r.Name='Admin'
                            and acs.State not in ('Disable','Block');";

            var adminList = _db.LoadData<int, dynamic>(sql, new { });

            if (adminList.Count == 1)
                return true;
            else
                return false;   
        }

        public void UpdateExistingEmployee(EmployeeDetailsUpdateModel data)
        {

            string sql = @"Update dbo.Account 
                            set 
                            EmailAddress=@EmailAddress,
                            Username=@Username,
                            Password=@Password,
                            AccountStateId=@AccountStateId,
                            RoleId=@RoleId
                            where Id=@Id;";

            _db.SaveData(sql, new
            {
                EmailAddress = data.Account.EmailAddress,
                Username = data.Account.Username,
                Password = data.Account.Password,
                AccountStateId = data.Account.AccountStateId,
                RoleId = data.Account.RoleId,
                Id = data.Account.Id
            });

            sql = @"Update dbo.Employee 
                    Set 
                    FirstName=@FirstName, 
                    LastName=@LastName,
                    DateOfBirth= @DateOfBirth,
                    Address=@Address,
                    StartDate=@StartDate, 
                    LeaveDate=@LeaveDate, 
                    AccountId=@AccountId 
                    where Id=@Id;";

            _db.SaveData(sql, new
            {
                FirstName = data.Employee.FirstName,
                LastName = data.Employee.LastName,
                DateOfBirth = data.Employee.DateOfBirth,
                Address = data.Employee.Address,
                StartDate = data.Employee.StartDate,
                LeaveDate = data.Employee.LeaveDate,
                AccountId = data.Employee.AccountId,
                Id = data.Employee.EmployeeId
            });

            sql = @"Update dbo.Employee 
                    Set 
                    DateOfBirth= @DateOfBirth,
                    StartDate=@StartDate, 
                    LeaveDate=@LeaveDate
                    where Id=@Id;";

            _db.SaveData(sql, new
            {
                DateOfBirth = data.Employee.DateOfBirth,
                StartDate = data.Employee.StartDate,
                LeaveDate = data.Employee.LeaveDate,
                Id = data.Employee.EmployeeId
            });
        }


    }
}
