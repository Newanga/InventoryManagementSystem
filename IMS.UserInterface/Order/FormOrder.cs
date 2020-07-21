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

      
    }
}
