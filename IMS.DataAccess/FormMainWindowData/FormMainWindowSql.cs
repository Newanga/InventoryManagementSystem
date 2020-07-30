using IMS.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormMainWindowData
{
    public class FormMainWindowSql : IFormMainWindowSql
    {
        private readonly ISqlDataAccess _db;

        public FormMainWindowSql(ISqlDataAccess db)
        {
            _db = db;
        }

        public void UpdateUserLogOut(string emailAddress)
        {
            Enum.TryParse("Offline", out AccountState state);
            int AccountStateId = (int)state;

            string sql = @"update dbo.Account
                        set AccountStateId=@AccountStateId
                        where EmailAddress=@EmailAddress;";

            _db.SaveData<dynamic>(sql, new { AccountStateId = AccountStateId, EmailAddress = emailAddress });

        }

    }


}
