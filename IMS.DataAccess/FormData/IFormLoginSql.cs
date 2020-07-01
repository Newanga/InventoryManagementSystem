using IMS.Core.Models;

namespace IMS.DataAccess
{
    public interface IFormLoginSql
    {
        AccountModel GetUserLogedIn(LoginModel login);
    }
}