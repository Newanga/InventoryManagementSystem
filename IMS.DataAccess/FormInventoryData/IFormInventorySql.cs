using IMS.Core.Models;
using IMS.Core.Models.Inventory;
using IMS.Core.ViewModels;
using System.Collections.Generic;

namespace IMS.DataAccess.FormInventoryData
{
    public interface IFormInventorySql
    {
        void AddOrderItemsToInventory(NewInventoryModel data);
        bool CheckIfOrderIsAlreadyInInventory(NewInventoryModel data);
        List<SupplierName> GetSupplierFromDatabase();
        bool validateOrderId(NewInventoryModel data);
        bool ValidateOrderStateDelivered(NewInventoryModel data);

        List<InventoryDataGridVM> GetAllInventoryFromDatabase();
    }
}