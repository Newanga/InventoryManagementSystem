using IMS.Core.Models;
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

        public List<SupplierModel> GetAllSuppliersFromDatabase()
        {
            string sql = "select * from dbo.Supplier";

            List<SupplierModel> suppliers = _db.LoadData<SupplierModel, dynamic>(sql, new { });

            return suppliers;
        }

        public void CreateNewSupplier(NewSupplierModel supplier)
        {
            string sql = "Insert into dbo.Supplier (Name,Description,PhoneNumber,Address,SupplierStateId) values (@Name,@Description,@PhoneNumber,@Address,@SupplierStateId);";

            _db.SaveData(sql, supplier);
        }

        public void UpdateExistingSupplier(SupplierModel supplier)
        {
            string sql = "Update dbo.Supplier Set Name=@Name,Description=@Description,PhoneNumber=@PhoneNumber,Address=@Address,SupplierStateId=@SupplierStateId where Id=@Id";

            _db.SaveData(sql, supplier);
        }
    }
}
