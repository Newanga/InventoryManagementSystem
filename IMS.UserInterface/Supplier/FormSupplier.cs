using IMS.Core.Enums;
using IMS.Core.Models;
using IMS.DataAccess.FormSupplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Supplier

{
    public partial class FormSupplier : Form
    {
        private readonly IFormSupplierSql _db;

        public FormSupplier(IFormSupplierSql db)
        {
            InitializeComponent();
            _db = db;
            PopulateDatagrid();
        }

        private void btnSupplierAdd_Click(object sender, EventArgs e)
        {

        }

        private void PopulateDatagrid()
        {
            dGVSupplier.DataSource = _db.GetAllSuppliersFromDatabase();
        }

        private void dGVSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGVSupplier.Rows[e.RowIndex];
                txtBxSupplierId.Text = dgvRow.Cells[0].Value.ToString();
                txtBxSupplierName.Text = dgvRow.Cells[1].Value.ToString();
                txtBxSupplierDescription.Text = dgvRow.Cells[2].Value.ToString();
                txtBxSupplierphoneNo.Text = dgvRow.Cells[3].Value.ToString();
                txtBxSupplierAddress.Text = dgvRow.Cells[4].Value.ToString();
                combobxSupplierState.DataSource = Enum.GetValues(typeof(SupplierState));
                combobxSupplierState.SelectedIndex = (int)(dgvRow.Cells[5].Value) -1;
            }

        }
    }
}
