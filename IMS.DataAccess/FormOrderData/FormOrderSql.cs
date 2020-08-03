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
            string sql= @"Select Distinct(s.Name)
                            from dbo.Supplier as s
                            inner join dbo.SupplierState as ss
                            on s.SupplierStateId=ss.Id
                            inner join dbo.Product as p
                            on p.SupplierId=s.Id
                            inner join dbo.ProductState as ps
                            on p.ProductStateId=ps.Id
                            where ss.State='Active' and ps.State!='Discontinued';";

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

        public void CreateNewOrder(NewOrderModel newOrder)
        {
            string sql = @"Select Id from dbo.supplier where Name=@Name;";

            var supplierId = _db.LoadData<IdLookUpModel, dynamic>(sql, new { Name = newOrder.SupplierName }).First().Id;


            sql=@"Insert into dbo.Orders 
                  (PlaceDate,DeliveryDate,SpecialNotes,OrderStateId,SupplierId)
                  Values 
                  (@PlaceDate,@DeliveryDate,@SpecialNotes,@OrderStateId,@SupplierId);";

            _db.SaveData<dynamic>(sql, new {
                PlaceDate=newOrder.PlaceDate,
                DeliveryDate=newOrder.DeliveryDate,
                SpecialNotes=newOrder.SpecialNotes,
                OrderStateId=newOrder.OrderStateId,
                SupplierId=supplierId
            });

            sql= @"select Id from dbo.Orders where SupplierId=@SupplierId and PlaceDate=@PlaceDate;";

            var orderId = _db.LoadData<IdLookUpModel, dynamic>(sql, new { SupplierId = supplierId, PlaceDate= newOrder.PlaceDate }).Last().Id;

            foreach (var item in newOrder.Items)
            {

                sql = @"Insert into dbo.OrderItem
                    (OrderId,ProductId,Quantity,Price)
                    values
                    (@OrderId,@ProductId,@Quantity,@Price);";

                _db.SaveData<dynamic>(sql, new
                {
                    OrderId = orderId,
                    ProductId=item.ProductId,
                    Quantity=item.Quantity,
                    Price=item.Price
                });
            }
        }

        public List<ExistingOrdersDataGridVM> GetExistingOrdersFromDatabase()
        {
            string sql= @"select o.Id,s.Name as SupplierName,o.PlaceDate,os.State as OrderState,
                            o.DeliveryDate, o.SpecialNotes
                        from dbo.Orders as o
                        inner join dbo.Supplier as s
                        on o.SupplierId=s.Id
                        inner join dbo.OrderState as os
                        on o.OrderStateId=os.Id;";

            List<ExistingOrdersDataGridVM> data = _db.LoadData<ExistingOrdersDataGridVM, dynamic>(sql, new { });

            return data;
        }

        public List<OrderItemModel> GetExistingOrderItemsFromDatabase(int orderId)
        {
            string sql = @"select p.Id as ProductId, p.Name as ProductName,o.Quantity,o.Price
                            from dbo.OrderItem as o
                            inner join dbo.Product as p
                            on o.ProductId=p.Id
                            where o.OrderId=@OrderId;";

            List<OrderItemModel>  data =_db.LoadData<OrderItemModel, dynamic>(sql, new { OrderId = orderId });

            return data;
        }


        public void UpdateExistingOrder(UpdateOrderModel order)
        {
            string sql = @"UPDATE dbo.Orders set
                            DeliveryDate=@DeliveryDate,
                            SpecialNotes=@SpecialNotes,
                            OrderStateId=@OrderStateId
                            where Id=@OrderId;";

            _db.SaveData<dynamic>(sql, new
            {
                DeliveryDate = order.DeliveryDate,
                SpecialNotes = order.SpecialNotes,
                OrderStateId = order.OrderStateId,
                OrderId=order.OrderId
            });


        }
    }
}
