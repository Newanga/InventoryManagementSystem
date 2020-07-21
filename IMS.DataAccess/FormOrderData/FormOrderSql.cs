using IMS.Core.Models;
using IMS.Core.Models.Order;
using IMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormOrderData
{
    public class FormOrderSql:IFormOrderSql
    {


        private readonly ISqlDataAccess _db;

        public FormOrderSql(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<SupplierName> GetSupplierFromDatabase()
        {
            string sql= @"Select s.Name
                            from dbo.Supplier as s
                            inner join dbo.SupplierState as ss
                            on s.SupplierStateId=ss.Id
                            where ss.State='Active';";

            List<SupplierName> suppliers = _db.LoadData<SupplierName,dynamic>(sql,new { });

            return suppliers;
        }

        public List<SupplierProductsPriceModel> GetSupplierProductsFromDatabase(string supplierName)
        {
            string sql = @"select p.Id,p.Name,p.Price
                            from dbo.Product as p
                            inner join dbo.Supplier as s
                            on p.SupplierId=s.Id
                            inner join dbo.ProductState as ps
                            on p.ProductStateId=ps.Id
                            where ps.State!='Discontinued' and s.Name=@Name;";

            List<SupplierProductsPriceModel> products = _db.LoadData<SupplierProductsPriceModel, dynamic>(sql, new { Name = supplierName });

            return products;
        }
    }
}
