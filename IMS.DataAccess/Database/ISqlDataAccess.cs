using System.Collections.Generic;

namespace IMS.DataAccess
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameters);
        void SaveData<T>(string sqlStatement, T parameters);
    }
}