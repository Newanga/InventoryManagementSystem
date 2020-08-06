using IMS.Core.Models;
using IMS.Core.Models.Inventory;
using IMS.DataAccess.FormInventoryData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Inventory
{
    public partial class FormInventory : Form
    {
        private readonly IFormInventorySql _db;
        public FormInventory(IFormInventorySql db)
        {
            InitializeComponent();
            _db = db;
            LoadSuppliersFromDatabase();
            LoadInventoryFromDatabase();
        }

        private void LoadSuppliersFromDatabase()
        {
            comboBoxSupplier.DataSource = _db.GetSupplierFromDatabase();
            comboBoxSupplier.DisplayMember = "Name";
            comboBoxSupplier.ValueMember = "Name";

        }

        private void LoadInventoryFromDatabase()
        {
            dGVInventory.DataSource = _db.GetAllInventoryFromDatabase();
            dGVInventory.Update();
            dGVInventory.Refresh();
        }

        private void btnInventoryAdd_Click(object sender, EventArgs e)
        {
            if (txtBxOrderId.Text == null)
            {
                MessageBox.Show("Please enter a Order ID", "Order Id Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NewInventoryModel data = new NewInventoryModel
            {
                SupplierName = ((SupplierName)comboBoxSupplier.SelectedItem).Name,
                OrderId= int.TryParse(txtBxOrderId.Text, out int ValidOrderId) ? ValidOrderId : (int?)null,
                AddedDate = dTPDateAdded.Value.Date
            };


            //check if supllier with a matching order is in order table.
            bool validateOrderId = _db.validateOrderId(data);
            if(validateOrderId==false)
            {
                MessageBox.Show("Please recheck Order Id for current supplier.", "Order Id Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //check if above orders' state is delivered.
            bool valideOrderState = _db.ValidateOrderStateDelivered(data);
            if(valideOrderState==false)
            {
                MessageBox.Show("Please notify Stock Manager or Admin.", "Invalid Order State", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //Check is that order is in the order table
            bool orderAlreadyIninventory = _db.CheckIfOrderIsAlreadyInInventory(data);
            if(orderAlreadyIninventory==true)
            {
                MessageBox.Show("Order is already in Inventory.", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _db.AddOrderItemsToInventory(data);

            MessageBox.Show("New delivered Order added to inventory", "Operation Scuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadInventoryFromDatabase();

            txtBxOrderId.Clear();
        }



        #region Data entry Validation
        private void txtBxOrderId_KeyPress(object sender, KeyPressEventArgs e)
        {      
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Please enter only numbers.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtBxOrderId_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBxOrderId.Text.Contains("."))
            {
                MessageBox.Show("Invalid Order Id", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBxOrderId.Clear();
                e.Handled = true;

            }
        }


        #endregion

        private void btnInventoryReset_Click(object sender, EventArgs e)
        {
            txtBxOrderId.Clear();
            comboBoxSupplier.Focus();
        }
    }
}
