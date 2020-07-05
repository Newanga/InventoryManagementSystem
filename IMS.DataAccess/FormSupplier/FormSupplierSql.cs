using IMS.Core.Models;
using IMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormSupplier
{
    public class FormSupplierSql : IFormSupplierSql
    {

        private readonly ISqlDataAccess _db;

        public FormSupplierSql(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<SupplierVM> GetAllSuppliersFromDatabase()
        {
            string sql = @"select s.Id,s.Name,s.Description,s.PhoneNumber,s.Address,ss.State
                            from dbo.supplier as s
                            inner join dbo.SupplierState as ss
                            on s.SupplierStateId=ss.Id;";

            List<SupplierVM> suppliers = _db.LoadData<SupplierVM, dynamic>(sql, new { });

            return suppliers;
        }

        public void CreateNewSupplier(SupplierNewModel supplier)
        {
            string sql = "Insert into dbo.Supplier (Name,Description,PhoneNumber,Address,SupplierStateId) values (@Name,@Description,@PhoneNumber,@Address,@SupplierStateId);";

            _db.SaveData(sql, supplier);
        }

        public void UpdateExistingSupplier(SupplierFullModel supplier)
        {
            string sql = "Update dbo.Supplier Set Name=@Name,Description=@Description,PhoneNumber=@PhoneNumber,Address=@Address,SupplierStateId=@SupplierStateId where Id=@Id";

            _db.SaveData(sql, supplier);
        }
    }
}
