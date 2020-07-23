using IMS.Core.Models;
using IMS.Core.Models.Order;
using System.Collections.Generic;

namespace IMS.DataAccess.FormOrderData
{
    public interface IFormOrderSql
    {
        void CreateNewOrder(NewOrderModel newOrder);
        List<OrderItemModel> GetExistingOrderItemsFromDatabase(int orderId);
        List<ExistingOrdersDataGridVM> GetExistingOrdersFromDatabase();
        List<SupplierName> GetSupplierFromDatabase();
        List<SupplierProductsPriceModel> GetSupplierProductsFromDatabase(string supplierName);
        void UpdateExistingOrder(UpdateOrderModel order);
    }
}