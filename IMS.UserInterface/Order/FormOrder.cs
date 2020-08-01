using IMS.Core.Enums;
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
using System.Windows;
using System.Windows.Forms;

namespace IMS.UserInterface.Order
{
    public partial class FormOrder : Form
    {
        private OrderFormDropDownsVM orderFormDropDowns = new OrderFormDropDownsVM();
        private NewOrderModel newOrder = new NewOrderModel();
        private List<ExistingOrdersDataGridVM> existingOrders = new List<ExistingOrdersDataGridVM>();
        private BindingList<OrderItemModel> existingOrderItems;
        private UpdateOrderModel updateOrder = new UpdateOrderModel();
        private readonly IFormOrderSql _db;

        public FormOrder(IFormOrderSql db)
        {
            InitializeComponent();
            _db = db;
            LoadExistingOrdersFromDatabase();
            PopulateOrdersDataGrid();
        }

        private void btnOrderNewCreate_Click(object sender, EventArgs e)
        {    
         
            txtBxOrderId.Clear();
            LoadSuppliersFromDatabase();

            if (orderFormDropDowns.Suppliers.Count == 0)
            {
                MessageBox.Show("Please Add suppliers to Database before creating a Order.", "Suppliers unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNewOrderCreate.Enabled = false;
                return;
            }

            PopulateSupplierComboBox();
            PopulateOrderStateComboBox();
            comboBxSupplier.Enabled = true;
            comboBxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            btnNewOrderCreate.Enabled = false;
            btnExistingOrderEdit.Enabled = false;

            btnNewOrderUpdate.Enabled = true;
            btnNewOrderUpdate.Visible = true;
            btnNewOrderUpdate.BringToFront();

            btnExistingOrderUpdate.Enabled = false;
            btnExistingOrderUpdate.Visible = false;
            btnExistingOrderUpdate.SendToBack();

            btnNewOrderCancel.Enabled = true;
            btnNewOrderCancel.Visible = true;
            btnNewOrderCancel.BringToFront();

            btnExistingOrderCancel.Enabled = false;
            btnExistingOrderCancel.Visible = false;
            btnExistingOrderCancel.SendToBack();


        }


        private void LoadExistingOrdersFromDatabase()
        {
            existingOrders = _db.GetExistingOrdersFromDatabase();
        }

        private void LoadExistingOrderItemsOfOrderFromDatabase(int orderId)
        {
            existingOrderItems = new BindingList<OrderItemModel>(_db.GetExistingOrderItemsFromDatabase(orderId));
        }

        public void PopulateExistingOrderItemsInDataGrid()
        {
            dGVOrderItems.DataSource = existingOrderItems;
        }

        private void LoadSuppliersFromDatabase()
        {
            orderFormDropDowns.Suppliers = _db.GetSupplierFromDatabase();
        }

        private void PopulateOrdersDataGrid()
        {
            dGVOrders.DataSource = existingOrders;
            dGVOrders.Update();
            dGVOrders.Refresh();
        }

        private void PopulateSupplierComboBox()
        {
            comboBxSupplier.DataSource = orderFormDropDowns.Suppliers;
            comboBxSupplier.DisplayMember = "Name";
            comboBxSupplier.ValueMember = "Name";
            comboBxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PopulateOrderStateComboBox()
        {
            comboBxOrderState.DataSource = Enum.GetValues(typeof(OrderState));
        }

        private void LoadSupplierProductsFromDatabase()
        {
            if (orderFormDropDowns.Suppliers.Count == 0)
                return;

            string supplierName = ((SupplierName)comboBxSupplier.SelectedItem).Name;
            var data = new BindingList<SupplierProductsPriceModel>(_db.GetSupplierProductsFromDatabase(supplierName));
            orderFormDropDowns.Products = data;

            PopulateOrderItemsCombobox();
        }


        private void comboBxSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadSupplierProductsFromDatabase();

            comboBxOrderItemName.Enabled = true;
            txtBxOrderItemQuantity.Enabled = true;
            btnOrderItemAdd.Enabled = true;
        }

        private void PopulateOrderItemDataGrid()
        {
            dGVOrderItems.DataSource = newOrder.Items;
            dGVOrderItems.Refresh();
            dGVOrderItems.Update();
        }

        private void PopulateOrderItemsCombobox()
        {
            comboBxOrderItemName.DataSource = orderFormDropDowns.Products;
            comboBxOrderItemName.DisplayMember = "Name";
            comboBxOrderItemName.ValueMember = "Name";
            comboBxOrderItemName.Refresh();
            comboBxOrderItemName.Update();
        }
        private void comboBxOrderItemName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (orderFormDropDowns.Products.Count == 0)
                return;

            var selectedItem = ((SupplierProductsPriceModel)comboBxOrderItemName.SelectedItem);
            txtBxOrderItemPrice.Text = selectedItem.Price.ToString();
        }
        private void dGVOrderItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnOrderItemEdit.Enabled == true)
                return;

            //Item double clicked and selected in the orderItems datagrid
            var selectedRowItem = (OrderItemModel)dGVOrderItems.CurrentRow.DataBoundItem;


            SupplierProductsPriceModel OrderItemView = new SupplierProductsPriceModel
            {
                Id = selectedRowItem.ProductId,
                Name = selectedRowItem.ProductName,
                Price = selectedRowItem.Price
            };

            //Add select item to the combobox to view
            orderFormDropDowns.Products.Add(OrderItemView);

            PopulateOrderItemsCombobox();
            comboBxOrderItemName_SelectedValueChanged(null, RoutedEventArgs.Empty);

            //set the selected item to the above item
            comboBxOrderItemName.SelectedItem = OrderItemView;

            comboBxOrderItemName.Enabled = false;
            comboBxOrderItemName.DropDownStyle = ComboBoxStyle.Simple;

            //convert (int)? ------> (int)
            int itemQuantity = (int)selectedRowItem.Quantity;
            txtBxOrderItemQuantity.Text = itemQuantity.ToString();
            txtBxOrderItemQuantity.Enabled = false;

            txtBxOrderItemPrice.Enabled = false;
            btnOrderItemAdd.Enabled = false;
            btnOrderItemEdit.Enabled = true;
            btnOrderItemRemove.Enabled = true;
            btnOrderItemCancel.Enabled = true;

        }

        private void btnOrderItemAdd_Click(object sender, EventArgs e)
        {
            var addedItem = ((SupplierProductsPriceModel)comboBxOrderItemName.SelectedItem);
            OrderItemModel item = new OrderItemModel
            {
                ProductId = addedItem.Id,
                ProductName = addedItem.Name,
                Price = addedItem.Price,
                Quantity = int.TryParse(txtBxOrderItemQuantity.Text, out int ValidQuantity) ? ValidQuantity : (int?)null
            };

            bool isValid = QuantityValidator.validate(item.Quantity);

            if (isValid == false)
                return;



            //Add new item to the data grid data source
            newOrder.Items.Add(item);

            //Remove  item from the combobox datasource
            var removingItem = orderFormDropDowns.Products.Where(p => p.Id == addedItem.Id).First();

            orderFormDropDowns.Products.Remove(removingItem);
            PopulateOrderItemsCombobox();
            txtBxOrderItemPrice.Text = string.Empty;
            txtBxOrderItemQuantity.Text = string.Empty;
            comboBxOrderItemName_SelectedValueChanged(null, RoutedEventArgs.Empty);
            PopulateOrderItemDataGrid();

            txtBxOrderItemQuantity.Text = string.Empty;

            //when product list is empty
            if (orderFormDropDowns.Products.Count == 0)
            {
                btnOrderItemAdd.Enabled = false;

                comboBxOrderItemName.DropDownStyle = ComboBoxStyle.Simple;
                comboBxOrderItemName.Enabled = false;

                txtBxOrderItemQuantity.Enabled = false;
                txtBxOrderItemQuantity.BorderStyle = BorderStyle.None;
                txtBxOrderItemQuantity.BorderStyle = BorderStyle.Fixed3D;
            }

            if (dGVOrderItems.Rows.Count > 0)
            {
                comboBxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBxSupplier.Enabled = false;
                txtBxOrderId.Enabled = false;
                txtBxSpecialNote.Enabled = true;
                dTPPlaceDate.Enabled = true;
                comboBxOrderState.Enabled = true;
                comboBxOrderState.Enabled = true;

                btnNewOrderUpdate.Enabled = true;
                btnNewOrderUpdate.Visible = true;
                btnNewOrderUpdate.BringToFront();

                btnExistingOrderUpdate.Enabled = false;
                btnExistingOrderUpdate.Visible = false;
                btnExistingOrderUpdate.SendToBack();
            }
              

        }
        private void btnOrderItemRemove_Click(object sender, EventArgs e)
        {
            var removingOrderItemId = ((SupplierProductsPriceModel)comboBxOrderItemName.SelectedItem).Id;

            //remove the above item from the order item datagrid datsource
            var obj = newOrder.Items.Where(i => i.ProductId == removingOrderItemId).First();
            newOrder.Items.Remove(obj);
            PopulateOrderItemDataGrid();


            btnOrderItemEdit.Enabled = false;
            btnOrderItemRemove.Enabled = false;

            comboBxOrderItemName.Enabled = true;
            comboBxOrderItemName.DropDownStyle = ComboBoxStyle.DropDownList;

            txtBxOrderItemQuantity.Text = string.Empty;
            txtBxOrderItemQuantity.Enabled = true;

            PopulateOrderItemsCombobox();
            comboBxOrderItemName_SelectedValueChanged(null, RoutedEventArgs.Empty);

            btnOrderItemAdd.Enabled = true;
            btnOrderItemCancel.Enabled = false;

            if (dGVOrderItems.Rows.Count == 0)
                comboBxSupplier.Enabled = true;



        }

        private void btnOrderItemCancel_Click(object sender, EventArgs e)
        {
            var currentProductId = ((SupplierProductsPriceModel)comboBxOrderItemName.SelectedItem).Id;
            var product = orderFormDropDowns.Products.Where(p => p.Id == currentProductId).First();
            orderFormDropDowns.Products.Remove(product);
            txtBxOrderItemQuantity.Text = string.Empty;
            txtBxOrderItemPrice.Text = string.Empty;



            if (btnOrderItemEdit.Enabled == true)
            {
                btnOrderItemRemove.Visible = true;
                btnOrderItemRemove.Enabled = false;
                btnOrderItemRemove.BringToFront();
                btnOrderItemUpdate.Visible = false;
                btnOrderItemUpdate.Enabled = false;
                btnOrderItemUpdate.SendToBack();

            }

            if (btnOrderItemUpdate.Enabled == true)
            {
                btnOrderItemRemove.Visible = true;
                btnOrderItemRemove.Enabled = false;
                btnOrderItemRemove.SendToBack();
                btnOrderItemUpdate.Visible = false;
                btnOrderItemUpdate.Enabled = false;
                btnOrderItemUpdate.BringToFront();
            }


            btnOrderItemEdit.Enabled = false;
            btnOrderItemRemove.Enabled = false;
            btnOrderItemCancel.Enabled = false;
            btnOrderItemUpdate.Enabled = false;

       

            if (orderFormDropDowns.Products.Count == 0)
            {
                txtBxOrderItemQuantity.Enabled = false;
                return;
            }


            PopulateOrderItemsCombobox();
            comboBxOrderItemName_SelectedValueChanged(null, RoutedEventArgs.Empty);

            comboBxOrderItemName.Enabled = true;
            comboBxOrderItemName.DropDownStyle = ComboBoxStyle.DropDownList;

            txtBxOrderItemQuantity.Enabled = true;
            txtBxOrderItemQuantity.BorderStyle = BorderStyle.None;
            txtBxOrderItemQuantity.BorderStyle = BorderStyle.Fixed3D;

            PopulateOrderItemDataGrid();

            btnOrderItemAdd.Enabled = true;



        }

        private void btnOrderItemEdit_Click(object sender, EventArgs e)
        {
            btnOrderItemRemove.Visible = false;
            btnOrderItemRemove.Enabled = false;
            txtBxOrderItemQuantity.Enabled = true;
            txtBxOrderItemQuantity.Text = string.Empty;
            btnOrderItemUpdate.Visible = true;
            btnOrderItemUpdate.Enabled = true;
            btnOrderItemCancel.Enabled = true;
            btnOrderItemEdit.Enabled = false;




            btnOrderItemRemove.Visible = false;
            btnOrderItemRemove.Enabled = false;
            btnOrderItemRemove.SendToBack();
            btnOrderItemUpdate.Visible = true;
            btnOrderItemUpdate.Enabled = true;
            btnOrderItemUpdate.BringToFront();


        }

        private void btnOrderItemUpdate_Click(object sender, EventArgs e)
        {
            var addedItem = ((SupplierProductsPriceModel)comboBxOrderItemName.SelectedItem);

            var productId = addedItem.Id;
            var quantity = int.TryParse(txtBxOrderItemQuantity.Text, out int ValidQuantity) ? ValidQuantity : (int?)null;


            bool isValid = QuantityValidator.validate(quantity);
            if (isValid == false)
                return;

            //search for above item in the datagrid datasource list and update the new quantity value.
            var itemInlist = newOrder.Items.Where(i => i.ProductId == productId).First();
            itemInlist.Quantity = quantity;

            MessageBox.Show("The order Item Quantity was updated Successfully", "Quantity Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnOrderItemCancel_Click(null, RoutedEventArgs.Empty);

        }

        private void txtBxOrderItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' )
            {
                MessageBox.Show("Please enter only numbers.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Please enter only numbers.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
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

        private void btnNewOrderCancel_Click(object sender, EventArgs e)
        {
            if(btnNewOrderCreate.Enabled==false)
            {
                orderFormDropDowns.Products.Clear();
                comboBxOrderItemName.DataSource = null;

                orderFormDropDowns.Suppliers.Clear();
                comboBxSupplier.DataSource = null;

                newOrder.Items.Clear();
                dGVOrderItems.Rows.Clear();

                comboBxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBxSupplier.Enabled = false;
                comboBxOrderItemName.Enabled = false;

                btnOrderItemAdd.Enabled = false;
                btnOrderItemEdit.Enabled = false;
                btnOrderItemCancel.Enabled = false;

                btnOrderItemRemove.Visible = true;
                btnOrderItemRemove.Enabled = false;
                btnOrderItemRemove.BringToFront();
                btnOrderItemUpdate.Visible = false;
                btnOrderItemUpdate.Enabled = false;
                btnOrderItemUpdate.SendToBack();

                btnNewOrderUpdate.Enabled = false;

                txtBxOrderItemQuantity.Enabled = false;
                txtBxOrderItemQuantity.Text = string.Empty;

                txtBxOrderItemPrice.Enabled = false;
                txtBxOrderItemPrice.Text = string.Empty;


                txtBxSpecialNote.Text = string.Empty;
                txtBxSpecialNote.Enabled = false;

                comboBxOrderState.DataSource = null;
                comboBxOrderState.Enabled = false;

                dTPPlaceDate.Enabled = false;
                dTPDeliveryDate.Enabled = false;
            }

            btnNewOrderCreate.Enabled = true;


            btnNewOrderUpdate.Enabled = false;
            btnNewOrderUpdate.Visible = true;
            btnNewOrderUpdate.BringToFront();

            btnExistingOrderUpdate.Enabled = false;
            btnExistingOrderUpdate.Visible = false;
            btnExistingOrderUpdate.SendToBack();

            btnNewOrderCancel.Enabled = false;
            btnNewOrderCancel.Visible = true;
            btnNewOrderCancel.BringToFront();

            btnExistingOrderCancel.Enabled = false;
            btnExistingOrderCancel.Visible = false;
            btnExistingOrderCancel.SendToBack();
        }

        private void btnNewOrderUpdate_Click(object sender, EventArgs e)
        {
            newOrder.SupplierName = ((SupplierName)comboBxSupplier.SelectedItem).Name;
            newOrder.SpecialNotes = txtBxSpecialNote.Text;
            newOrder.PlaceDate = dTPPlaceDate.Value.Date;
            newOrder.OrderStateId = comboBxOrderState.SelectedIndex + 1;
            newOrder.DeliveryDate = null;
            newOrder.PlaceDate = (dTPPlaceDate.CustomFormat == " ") ? (DateTime?)null : dTPPlaceDate.Value.Date;

            bool dataValid = OrderInputDataValidator.ValidateAdd(newOrder);

            if(dataValid)
            {
                _db.CreateNewOrder(newOrder);
                LoadExistingOrdersFromDatabase();
                PopulateOrdersDataGrid();
                MessageBox.Show("New Order created Successfully", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNewOrderCancel_Click(null, RoutedEventArgs.Empty);

            }




        }

        private void dGVOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Check if a new order is been created 
            if (btnNewOrderCreate.Enabled == false)
                return;

            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGVOrders.Rows[e.RowIndex];
                txtBxOrderId.Text = dgvRow.Cells[0].Value.ToString();
                txtBxSpecialNote.Text = dgvRow.Cells[5].Value.ToString();
                dTPPlaceDate.Value = Convert.ToDateTime(dgvRow.Cells[2].Value);

                comboBxOrderState.DataSource = Enum.GetValues(typeof(OrderState));
                var text = dgvRow.Cells[3].Value.ToString();
                //converting text to enum
                Enum.TryParse(text, out OrderState state);
                //converting enum to int
                comboBxOrderState.SelectedIndex = (int)state - 1;

                if (dgvRow.Cells[4].Value == null)
                {
                    dTPDeliveryDate.CustomFormat = " ";
                }
                else
                {
                    dTPDeliveryDate.Value = Convert.ToDateTime(dgvRow.Cells[4].Value);
                }

                comboBxSupplier.DropDownStyle = ComboBoxStyle.Simple;
                comboBxSupplier.Text= dgvRow.Cells[1].Value.ToString();
            }

            btnExistingOrderEdit.Enabled = true;

            btnNewOrderCancel.Enabled = false;
            btnNewOrderCancel.Visible = false;
            btnNewOrderCancel.SendToBack();

            btnExistingOrderCancel.Enabled = true;
            btnExistingOrderCancel.Visible = true;
            btnExistingOrderCancel.BringToFront();

            //Get the selected OrderId
            var selectedOrderId = ((ExistingOrdersDataGridVM)dGVOrders.CurrentRow.DataBoundItem).Id;

            LoadExistingOrderItemsOfOrderFromDatabase(selectedOrderId);
            PopulateExistingOrderItemsInDataGrid();

            btnNewOrderCreate.Enabled = false;
        }

        private void btnExistingOrderEdit_Click(object sender, EventArgs e)
        {
            btnNewOrderCreate.Enabled = false;
            txtBxSpecialNote.Enabled = true;
            dTPDeliveryDate.Enabled = true;
            comboBxOrderState.Enabled = true;
            btnExistingOrderEdit.Enabled = false;

            btnNewOrderUpdate.Enabled = false;
            btnNewOrderUpdate.Visible = false;
            btnExistingOrderUpdate.SendToBack();

            btnExistingOrderUpdate.Enabled = true;
            btnExistingOrderUpdate.Visible = true;
            btnExistingOrderUpdate.BringToFront();

            btnExistingOrderCancel.Enabled = true;
            btnExistingOrderCancel.Visible = true;
            btnExistingOrderCancel.BringToFront();

            btnNewOrderCancel.Enabled = false;
            btnNewOrderCancel.Visible = false;
            btnNewOrderCancel.SendToBack();



        }

        private void btnExistingOrderCancel_Click(object sender, EventArgs e)
        {
            txtBxOrderId.Clear();
            txtBxOrderId.Enabled = false;

            txtBxSpecialNote.Clear();
            txtBxSpecialNote.Enabled = false;

            comboBxOrderState.DataSource = null;

            comboBxSupplier.Text = string.Empty;
            comboBxSupplier.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBxOrderState.Enabled = false;

            existingOrderItems.Clear();
            dGVOrderItems.Rows.Clear();

            dTPDeliveryDate.Value = DateTime.Now;
            dTPDeliveryDate.CustomFormat = " ";
            dTPDeliveryDate.Enabled = false;

            dTPPlaceDate.Value = DateTime.Now;
            dTPPlaceDate.CustomFormat = " ";
            dTPPlaceDate.Enabled = false;

            btnExistingOrderUpdate.Enabled = false;
            btnExistingOrderUpdate.Visible = false;
            btnExistingOrderUpdate.SendToBack();

            btnNewOrderUpdate.Enabled = false;
            btnNewOrderUpdate.Visible = true;
            btnNewOrderUpdate.BringToFront();


            btnNewOrderCancel.Enabled = false;
            btnNewOrderCancel.Visible = true;
            btnNewOrderCancel.BringToFront();

            btnExistingOrderCancel.Enabled = false;
            btnExistingOrderCancel.Visible = false;
            btnExistingOrderCancel.SendToBack();

            btnExistingOrderEdit.Enabled = false;
            btnNewOrderCreate.Enabled = true;

        }

        private void btnExistingOrderUpdate_Click(object sender, EventArgs e)
        {
            updateOrder.OrderId = int.Parse(txtBxOrderId.Text);
            updateOrder.SpecialNotes = txtBxSpecialNote.Text;
            updateOrder.OrderStateId = comboBxOrderState.SelectedIndex + 1;
            updateOrder.DeliveryDate=(dTPDeliveryDate.CustomFormat == " ") ? (DateTime?)null : dTPDeliveryDate.Value.Date;

            _db.UpdateExistingOrder(updateOrder);
            LoadExistingOrdersFromDatabase();
            PopulateOrdersDataGrid();
            MessageBox.Show(" Order Updated Successfully", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnExistingOrderCancel_Click(null, RoutedEventArgs.Empty);





        }
    }
}


