using IMS.Core.Models;
using IMS.Core.ViewModels;
using System.Collections.Generic;

namespace IMS.DataAccess.FormSupplier
{
    public interface IFormSupplierSql
    {
        void CreateNewSupplier(SupplierNewModel supplier);

        List<SupplierVM> GetAllSuppliersFromDatabase();

        void UpdateExistingSupplier(SupplierFullModel supplier);
    }
}