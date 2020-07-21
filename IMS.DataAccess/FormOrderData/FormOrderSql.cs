using IMS.Core.Models;
using IMS.Core.Models.Order;
using IMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

    }
}
