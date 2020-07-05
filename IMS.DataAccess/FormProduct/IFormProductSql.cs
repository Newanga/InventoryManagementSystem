using IMS.Core.ViewModels;
using System.Collections.Generic;

namespace IMS.DataAccess.FormProduct
{
    public interface IFormProductSql
    {
        List<ProductVM> GetAllProductsFromDatabase();
    }
}