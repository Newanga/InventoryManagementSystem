using IMS.Common.Cache;
using IMS.Core.Enums;
using IMS.Core.Models;
using IMS.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IMS.FormLoginData
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



            AccountFullModel account = _db.LoadData<AccountFullModel, dynamic>(sql, new { Username = login.Username, Password = login.Password }).FirstOrDefault();

            if (account == null)
                return false;
            else
            {
                Enum.TryParse("Online", out AccountState state);
                int AccountStateId = (int)state;

                sql = @"update dbo.Account
                        set AccountStateId=@AccountStateId
                        where Username=@Username;";

                _db.SaveData<dynamic>(sql, new { AccountStateId = AccountStateId, Username = account.Username });

                return true;
            }
        }


        public void CacheCurrentUserDetails(string userName)
        {
            string sql = @"select a.Id as CurrentAccountId,a.EmailAddress,e.FirstName,a.RoleId
                        from dbo.employee as e
                        inner join dbo.Account as a
                        on e.AccountId=a.Id
                        where a.Username=@UserName";

            CurrentUserDetails details = _db.LoadData<CurrentUserDetails, dynamic>(sql, new { Username = userName }).First();


            Cache.CurrentAccountId = details.CurrentAccountId;
            Cache.EmailAddress = details.EmailAddress;
            Cache.FirstName = details.FirstName;
            Cache.RoleId = details.RoleId;

        }


    }


}
