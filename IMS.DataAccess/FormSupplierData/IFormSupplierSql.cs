using IMS.Core.Models;
using IMS.Core.ViewModels;
using System.Collections.Generic;

namespace IMS.DataAccess.FormSupplierData
{
    public interface IFormSupplierSql
    {
        void CreateNewSupplier(SupplierModel supplier);

        List<SupplierDataGridVM> GetAllSuppliersFromDatabase();

        void UpdateExistingSupplier(SupplierFullModel supplier);
    }
}