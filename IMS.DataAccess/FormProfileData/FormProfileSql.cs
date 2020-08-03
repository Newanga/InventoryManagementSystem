using IMS.Common.Cache;
using IMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormProfileData
{
    public class FormProfileSql : IFormProfileSql
    {
        private readonly ISqlDataAccess _db;

        public FormProfileSql(ISqlDataAccess db)
        {
            _db = db;
        }

        public ProfileVM GetProfileDetails()
        {
            string sql = @"select 
                            e.FirstName,
                            e.LastName,
                            a.Username,
                            e.DateOfBirth,
                            a.EmailAddress,
                            e.StartDate,
                            r.Name as Role, 
                            e.Address
                            from dbo.Employee as e
                            inner join dbo.Account as a
                            on e.AccountId=a.Id
                            inner join dbo.AccountState as ast
                            on a.AccountStateId=ast.Id
                            inner join dbo.Roles as r
                            on a.RoleId=r.Id
                            where a.Id=@Id";


            ProfileVM data = _db.LoadData<ProfileVM, dynamic>(sql, new { Id = Cache.CurrentAccountId }).First();

            return data;


        }
    }
}
