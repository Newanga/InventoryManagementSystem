using IMS.Core.Models;

namespace IMS.DataAccess
{
    public interface IFormLoginSql
    {
        bool ValidateAccount(LoginModel login);

        void CacheCurrentUserDetails(string userName);
    }
}