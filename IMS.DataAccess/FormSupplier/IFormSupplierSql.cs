using IMS.Core.Models;
using System.Collections.Generic;

namespace IMS.DataAccess.FormSupplier
{
    public interface IFormSupplierSql
    {
        void CreateNewSupplier(NewSupplierModel supplier);
        List<SupplierModel> GetAllSuppliersFromDatabase();
        void UpdateExistingSupplier(SupplierModel supplier);
    }
}