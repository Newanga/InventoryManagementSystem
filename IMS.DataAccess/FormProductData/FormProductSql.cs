using IMS.Core.Models;
using IMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormProductData
{
    public class FormProductSql : IFormProductSql
    {
        private readonly ISqlDataAccess _db;

        public FormProductSql(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<ProductDataGridVM> GetAllProductsFromDatabase()
        {
            string sql = @"select p.Id,p.Name,p.Description,p.Price,p.Warrenty,s.Name as SupplierName,c.Name as CategoryName,ps.State as ProductState
                            from dbo.Product as p
                            inner join dbo.Supplier as s
                            on p.SupplierId=s.Id
                            inner join dbo.Category as c
                            on p.CategoryId=c.Id
                            inner join dbo.ProductState as ps
                            on p.ProductStateId=ps.Id;";

            List<ProductDataGridVM> products = _db.LoadData<ProductDataGridVM, dynamic>(sql, new { });

            return products;
        }

        public ProductFormDropDownsVM GetAllDropDownValues()
        {
            ProductFormDropDownsVM data = new ProductFormDropDownsVM();

           //populate the category list of the above model
            string categorySql = @"Select Name from dbo.Category;";
            data.Categories = _db.LoadData<CategoryName, dynamic>(categorySql, new { });

            string productSql = @"Select Name from dbo.Supplier;";
            data.Suppliers = _db.LoadData<SupplierName, dynamic>(productSql, new { });

            return data;

        }

        public void CreateNewProduct(ProductNewModel data)
        {
            string sql = "Insert into dbo.Product (Name,Description,Price,Warrenty,SupplierId,CategoryId,ProductStateId) values (@Name,@Description,@Price,@Warrenty,@SupplierId,@CategoryId,@ProductStateId);";

            _db.SaveData(sql, data);
        }

        public void UpdateExistingProduct(ProductFullModel data)
        {
            string sql =@"Update dbo.Product set
                            Name=@Name,
                            Description=@Description,
                            Price=@Price,
                            Warrenty=@Warrenty,
                            SupplierId=@SupplierId,
                            CategoryId=@CategoryId,
                            ProductStateId=@ProductStateId 
                            where Id=@Id;";

            _db.SaveData(sql, data);
        }




    }
}
