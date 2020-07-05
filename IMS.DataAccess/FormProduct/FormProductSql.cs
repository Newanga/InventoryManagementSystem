using IMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormProduct
{
    public class FormProductSql : IFormProductSql
    {
        private readonly ISqlDataAccess _db;

        public FormProductSql(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<ProductVM> GetAllProductsFromDatabase()
        {
            string sql = @"select p.Id,p.Name,p.Description,p.Price,p.Warrenty,s.Name as SupplierName,c.Name as CategoryName,ps.State as ProductState
                            from dbo.Product as p
                            inner join dbo.Supplier as s
                            on p.SupplierId=s.Id
                            inner join dbo.Category as c
                            on p.CategoryId=c.Id
                            inner join dbo.ProductState as ps
                            on p.ProductStateId=ps.Id;";

            List<ProductVM> products = _db.LoadData<ProductVM, dynamic>(sql, new { });

            return products;

        }
    }
}
