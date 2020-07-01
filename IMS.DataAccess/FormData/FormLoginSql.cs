using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess
{
    public class FormLoginSql : IFormLoginSql
    {
        private readonly ISqlDataAccess _db;

        public FormLoginSql(ISqlDataAccess db)
        {
            this._db = db;
        }


        public AccountModel GetUserLogedIn(LoginModel login)
        {
            string sql = @"Select * from dbo.Account where Username=@Username and Password=@Password";

            AccountModel account = new AccountModel();

            account = _db.LoadData<AccountModel, dynamic>(sql, new { Username = login.Username, Password = login.Password }).FirstOrDefault();

            return account;
        }


    }


}
