using IMS.Core.Models;

namespace IMS.DataAccess
{
    public interface IFormLoginSql
    {
        AccountModel ValidateAccount(LoginModel login);
    }
}