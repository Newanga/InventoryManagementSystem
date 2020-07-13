using IMS.Core.Models;
using IMS.Core.ViewModels;
using System.Collections.Generic;

namespace IMS.DataAccess.FormProductData
{
    public interface IFormProductSql
    {
        List<ProductDataGridVM> GetAllProductsFromDatabase();

        ProductFormDropDownsVM GetAllDropDownValues();

        void CreateNewProduct(ProductNewModel data);

        void UpdateExistingProduct(ProductFullModel data);
    }
}