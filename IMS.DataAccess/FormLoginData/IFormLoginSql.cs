using IMS.Core.Models;

namespace IMS.FormLoginData
{
    public interface IFormLoginSql
    {
        bool ValidateAccount(LoginModel login);

        void CacheCurrentUserDetails(string userName);
    }
}