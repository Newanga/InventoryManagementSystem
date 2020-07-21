using IMS.Core.Models;
using IMS.Core.Models.Order;
using IMS.Core.ViewModels;
using IMS.DataAccess.FormOrderData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Order
{
    public partial class FormOrder : Form
    {
        private OrderFormDropDownsVM orderFormDropDowns = new OrderFormDropDownsVM();
        private NewFullOrderModel newOrder = new NewFullOrderModel();
        private readonly IFormOrderSql _db;

        public FormOrder(IFormOrderSql db)
        {
            InitializeComponent();
            _db = db;
            LoadSuppliersFromDatabase();
        }

        private void btnOrderNew_Click(object sender, EventArgs e)
        {
            PopulateSupplierComboBox();
            comboBxSupplier.Enabled = true;
        }

        private void LoadSuppliersFromDatabase()
        {
            orderFormDropDowns.Suppliers = _db.GetSupplierFromDatabase();
        }

        private void PopulateSupplierComboBox()
        {
            comboBxSupplier.DataSource = orderFormDropDowns.Suppliers;
            comboBxSupplier.DisplayMember = "Name";
            comboBxSupplier.ValueMember = "Name";
        }

        private void LoadSupplierProductsFromDatabase()
        {
            string supplierName = ((SupplierName)comboBxSupplier.SelectedItem).Name;
            var data = new BindingList<SupplierProductsPriceModel>(_db.GetSupplierProductsFromDatabase(supplierName));
            orderFormDropDowns.Products = data;

            PopulateProductCombobox();
        }

        private void PopulateProductCombobox()
        {
            comboBxOrderItemName.DataSource = orderFormDropDowns.Products;
            comboBxOrderItemName.DisplayMember = "Name";
            comboBxOrderItemName.ValueMember = "Name";
        }




        #region UI/UX
        private void dTPPlaceDate_ValueChanged(object sender, EventArgs e)
        {
            dTPPlaceDate.CustomFormat = "MM-dd-yyyy";
        }

        private void dTPPlaceDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dTPPlaceDate.CustomFormat = " ";
            }

        }

        private void dTPDeliveryDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                dTPDeliveryDate.CustomFormat = " ";
            }
        }

        private void dTPDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            dTPDeliveryDate.CustomFormat = "MM-dd-yyyy";
        }


        #endregion

        private void comboBxSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSupplierProductsFromDatabase();

            comboBxOrderItemName.Enabled = true;
            txtBxOrderItemQuantity.Enabled = true;
            btnOrderItemAdd.Enabled = true;
        }

        private void comboBxOrderItemName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (orderFormDropDowns.Products.Count == 0)
                return;

            var selectedItem = ((SupplierProductsPriceModel)comboBxOrderItemName.SelectedItem);
            txtBxOrderItemPrice.Text = selectedItem.Price.ToString();
        }

        private void btnOrderItemAdd_Click(object sender, EventArgs e)
        {
            var addedItem = ((SupplierProductsPriceModel)comboBxOrderItemName.SelectedItem);
            NewOrderItemModel item = new NewOrderItemModel
            {
                ProductId = addedItem.Id,
                ProductName = addedItem.Name,
                Price = addedItem.Price,
                Quantity = int.TryParse(txtBxOrderItemQuantity.Text, out int ValidQuantity) ? ValidQuantity : (int?)null
            };

            //Add new item to the data grid data source
            newOrder.Items.Add(item);

            //Remove  item from the combobox datasource
            var removingItem = orderFormDropDowns.Products.Where(p => p.Id == addedItem.Id).First();

            orderFormDropDowns.Products.Remove(removingItem);
            PopulateOrderItemDataGrid();

            txtBxOrderItemQuantity.Text = string.Empty;

            //when product list is empty
            if (orderFormDropDowns.Products.Count == 0)
            {
                btnOrderItemAdd.Enabled = false;
                comboBxOrderItemName.Enabled = false;
                txtBxOrderItemQuantity.Enabled = false;
            }

        }

        private void PopulateOrderItemDataGrid()
        {
            dGVOrderItems.DataSource = newOrder.Items;
            dGVOrderItems.Update();
            dGVOrderItems.Refresh();
        }

    }
}
