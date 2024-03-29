﻿using IMS.Core.Enums;
using IMS.Core.Models;
using IMS.DataAccess.FormSupplierData;
using System;
using System.Windows;
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
            btnSupplierAdd.Enabled = false;

            btnSupplierReset.Enabled = true;
            txtBxSupplierName.Enabled = true;
            txtBxSupplierDescription.Enabled = true;
            txtBxSupplierAddress.Enabled = true;
            txtBxSupplierphoneNo.Enabled = true;

            combobxSupplierState.Enabled = true;
            combobxSupplierState.DataSource = Enum.GetValues(typeof(SupplierStates));

            btnSupplierExistingUpdate.Visible = false;
            btnSupplierExistingUpdate.SendToBack();
            btnSupplierNewUpdate.Visible = true;
            btnSupplierNewUpdate.Enabled = true;
            btnSupplierNewUpdate.BringToFront();
        }

        private void PopulateDatagrid()
        {
            dGVSupplier.DataSource = _db.GetAllSuppliersFromDatabase();
        }

        private void dGVSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnSupplierAdd.Enabled == false)
                return;

            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGVSupplier.Rows[e.RowIndex];
                txtBxSupplierId.Text = dgvRow.Cells[0].Value.ToString();
                txtBxSupplierName.Text = dgvRow.Cells[1].Value.ToString();
                txtBxSupplierDescription.Text = dgvRow.Cells[2].Value.ToString();
                txtBxSupplierphoneNo.Text = dgvRow.Cells[3].Value.ToString();
                txtBxSupplierAddress.Text = dgvRow.Cells[4].Value.ToString();
                combobxSupplierState.DataSource = Enum.GetValues(typeof(SupplierStates));

                var text = dgvRow.Cells[5].Value.ToString();
                //converting text to enum
                Enum.TryParse(text, out SupplierStates state);
                //converting enum to int
                combobxSupplierState.SelectedIndex = (int)state-1;
            }
            
            btnSupplierAdd.Enabled = false;
            btnSupplierEdit.Enabled = true;
            btnSupplierReset.Enabled = true;

        }

        private void btnSupplierReset_Click(object sender, EventArgs e)
        {
            txtBxSupplierId.BorderStyle = BorderStyle.None;
            txtBxSupplierId.BorderStyle = BorderStyle.Fixed3D;

            txtBxSupplierName.BorderStyle = BorderStyle.None;
            txtBxSupplierName.BorderStyle = BorderStyle.Fixed3D;

            txtBxSupplierDescription.BorderStyle = BorderStyle.None;
            txtBxSupplierDescription.BorderStyle = BorderStyle.Fixed3D;

            txtBxSupplierAddress.BorderStyle = BorderStyle.None;
            txtBxSupplierAddress.BorderStyle = BorderStyle.Fixed3D;

            txtBxSupplierphoneNo.BorderStyle = BorderStyle.None;
            txtBxSupplierphoneNo.BorderStyle = BorderStyle.Fixed3D;

            combobxSupplierState.DataSource = null;
            combobxSupplierState.Enabled = false;



            txtBxSupplierId.Text = string.Empty;
            txtBxSupplierName.Text = string.Empty;
            txtBxSupplierDescription.Text = string.Empty;
            txtBxSupplierAddress.Text = string.Empty;
            txtBxSupplierphoneNo.Text = string.Empty;

            txtBxSupplierName.Enabled = false;
            txtBxSupplierAddress.Enabled = false;
            txtBxSupplierDescription.Enabled = false;
            txtBxSupplierphoneNo.Enabled = false;

            btnSupplierNewUpdate.Enabled = false;
            btnSupplierExistingUpdate.Enabled = false;

            btnSupplierExistingUpdate.Visible = false;
            btnSupplierNewUpdate.Visible = true;

            btnSupplierExistingUpdate.SendToBack();
            btnSupplierNewUpdate.BringToFront();

            btnSupplierAdd.Enabled = true;
            btnSupplierEdit.Enabled = false;

            btnSupplierReset.Enabled = false;

        }

        private void btnSupplierNewUpdate_Click(object sender, EventArgs e)
        {
            SupplierModel data = new SupplierModel
            {

                Name = txtBxSupplierName.Text,
                Description = txtBxSupplierDescription.Text,
                PhoneNumber = txtBxSupplierphoneNo.Text,
                Address = txtBxSupplierAddress.Text,
                SupplierStateId = (combobxSupplierState.SelectedIndex) + 1
            };

            bool validData = SupplierInputDataValidator.ValidateAdd(data);

            if (validData)
            {
                _db.CreateNewSupplier(data);
                dGVSupplier.DataSource = _db.GetAllSuppliersFromDatabase();
                MessageBox.Show("New Supplier Added to Database", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSupplierReset_Click(null, RoutedEventArgs.Empty);
            }
        }

        private void btnSupplierEdit_Click(object sender, EventArgs e)
        {
            btnSupplierAdd.Enabled = false;
            btnSupplierReset.Enabled = true;
            btnSupplierEdit.Enabled = false;

            txtBxSupplierName.Enabled = true;
            txtBxSupplierDescription.Enabled = true;
            txtBxSupplierAddress.Enabled = true;
            txtBxSupplierphoneNo.Enabled = true;

            btnSupplierNewUpdate.Visible = false;
            btnSupplierNewUpdate.SendToBack();
            btnSupplierExistingUpdate.Visible = true;
            btnSupplierExistingUpdate.Enabled = true;
            btnSupplierExistingUpdate.BringToFront();

            combobxSupplierState.Enabled = true;
        }

        private void btnSupplierExistingUpdate_Click(object sender, EventArgs e)
        {
            SupplierFullModel data = new SupplierFullModel
            {
                Id=int.Parse(txtBxSupplierId.Text),
                Name = txtBxSupplierName.Text,
                Description = txtBxSupplierDescription.Text,
                PhoneNumber = txtBxSupplierphoneNo.Text,
                Address = txtBxSupplierAddress.Text,
                SupplierStateId = (combobxSupplierState.SelectedIndex) + 1
            };

            bool validData = SupplierInputDataValidator.ValidateUpdate(data);

            if (validData)
            {
                _db.UpdateExistingSupplier(data);
                dGVSupplier.DataSource = _db.GetAllSuppliersFromDatabase();
                MessageBox.Show("Supplier Updated Successfully", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSupplierReset_Click(null, RoutedEventArgs.Empty);
            }
        }

        private void txtBxSupplierphoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please enter only numbers.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
