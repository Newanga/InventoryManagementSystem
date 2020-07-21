using IMS.Core.Models;
using System.Collections.Generic;

namespace IMS.DataAccess.FormOrderData
{
    public interface IFormOrderSql
    {
        List<SupplierName> GetSupplierFromDatabase();
        List<SupplierProductsPriceModel> GetSupplierProductsFromDatabase(string supplierName);
    }
}