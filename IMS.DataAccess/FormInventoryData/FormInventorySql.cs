using IMS.Core.Models;
using IMS.Core.Models.Inventory;
using IMS.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormInventoryData
{
    public class FormInventorySql : IFormInventorySql
    {
        private readonly ISqlDataAccess _db;
        public FormInventorySql(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<SupplierName> GetSupplierFromDatabase()
        {
            string sql = @"Select s.Name
                            from dbo.Supplier as s
                            inner join dbo.SupplierState as ss
                            on s.SupplierStateId=ss.Id
                            where ss.State='Active';";

            List<SupplierName> suppliers = _db.LoadData<SupplierName, dynamic>(sql, new { });

            return suppliers;
        }

        public bool validateOrderId(NewInventoryModel data)
        {
            string sql = @" select o.Id 
                            from dbo.Orders as o
                            inner join dbo.Supplier as s
                            on o.SupplierId=s.Id
                            where o.Id=@OrderId and s.Name=@SupplierName;";

            var valid = _db.LoadData<IdLookUpModel, dynamic>(sql, new { OrderId = data.OrderId, SupplierName = data.SupplierName }).FirstOrDefault();

            if (valid == null)
                return false;
            else
                return true;
        }

        public bool ValidateOrderStateDelivered(NewInventoryModel data)
        {
            string sql = @" select o.Id 
                            from dbo.Orders as o
                            inner join dbo.Supplier as s
                            on o.SupplierId=s.Id
                            inner join dbo.OrderState as os
                            on o.OrderStateId=os.Id
                            where o.Id=@OrderId and s.Name=@SupplierName and os.State='Delivered';";

            var delivered = _db.LoadData<IdLookUpModel, dynamic>(sql, new { OrderId = data.OrderId, SupplierName = data.SupplierName }).FirstOrDefault();

            if (delivered == null)
                return false;
            else
                return true;
        }

        public bool CheckIfOrderIsAlreadyInInventory(NewInventoryModel data)
        {
            string sql = @"select I.Id 
                            from dbo.Inventory as I
                            inner join dbo.OrderItem as OI
                            on I.OrderItemId=OI.Id
                            where OI.OrderId=@OrderId;";

            var alreadyAdded = _db.LoadData<IdLookUpModel, dynamic>(sql, new { OrderId = data.OrderId }).FirstOrDefault();

            if (alreadyAdded == null)
                return false;
            else
                return true;
        }

        public void AddOrderItemsToInventory(NewInventoryModel data)
        {
            string sql = @"select Id
                            from dbo.OrderItem
                            where OrderId=@OrderId;";

            var orderItems = _db.LoadData<IdLookUpModel, dynamic>(sql, new { OrderId = data.OrderId });

            foreach (var item in orderItems)
            {

                sql = @"Insert into dbo.Inventory
                        (OrderItemId,DateAdded)
                        values
                        (@OrderItemId,@DateAdded);";

                _db.SaveData<dynamic>(sql, new
                {
                    OrderItemId = item.Id,
                    DateAdded = data.AddedDate
                });
            }

        }
        public List<InventoryDataGridVM> GetAllInventoryFromDatabase()
        {
            string sql = @"select I.Id as InventoryId,p.Name as ProductName ,S.Name as SupplierName ,OI.Quantity as Available ,I.DateAdded as DateAdded  
                            from dbo.Inventory as I
                            inner join dbo.OrderItem as OI
                            on I.OrderItemId=OI.Id
                            inner join dbo.Product as p
                            on OI.ProductId=P.Id
                            inner join dbo.Supplier as S
                            on P.SupplierId=S.Id;";

            List<InventoryDataGridVM> data = _db.LoadData<InventoryDataGridVM,dynamic>(sql,new { });

            return data;
        }
    }
}