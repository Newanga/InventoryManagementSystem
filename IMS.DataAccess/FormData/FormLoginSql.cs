using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess
{
    public class FormLoginSql :IFormLoginSql
    {
        private readonly ISqlDataAccess _db;

        public FormLoginSql(ISqlDataAccess db)
        {
            this._db = db;
        }


        public bool ValidateAccount(LoginModel login)
        {

            string sql = @" Select *
                            from dbo.Account 
                            WHERE   
                            Username = @Username COLLATE SQL_Latin1_General_CP1_CS_AS
                            AND Password = @Password COLLATE SQL_Latin1_General_CP1_CS_AS
                            AND Username = @Username 
                            AND Password = @Password ";

            AccountModel account = new AccountModel();

            account = _db.LoadData<AccountModel, dynamic>(sql, new { Username = login.Username, Password = login.Password }).FirstOrDefault();

            if (account != null)
                return true;
            else 
                return false;
        }


    }


}
