using IMS.Core.Enums;
using IMS.Core.Models;
using IMS.Core.ViewModels;
using IMS.DataAccess.FormProductData;
using System;
using System.Windows;
using System.Windows.Forms;

namespace IMS.UserInterface.Product
{
    public partial class FormProduct : Form
    {
        private readonly IFormProductSql _db;
        private ProductFormDropDownsVM data;

        public FormProduct(IFormProductSql db)
        {
            InitializeComponent();
            _db = db;
            PopulateDataGrid();
            GetComboBoxDataInDatabase();
        }



        public void PopulateComboBoxes()
        {
            comboBxlblProductCategory.DataSource = data.Categories;
            comboBxlblProductCategory.DisplayMember = "Name";
            comboBxlblProductCategory.ValueMember = "Name";
            comboBxlProductSupplier.DataSource = data.Suppliers;
            comboBxlProductSupplier.DisplayMember = "Name";
            comboBxlProductSupplier.ValueMember = "Name";
            comboBxProductState.DataSource = Enum.GetValues(typeof(ProductState));
        }

        public void GetComboBoxDataInDatabase()
        {
            data = _db.GetAllDropDownValues();
        }
        public void PopulateDataGrid()
        {
            dGVProducts.DataSource = _db.GetAllProductsFromDatabase();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            if(data.Suppliers.Count<1)
            {
                MessageBox.Show("Please Add suppliers to Database before adding a product.", "Supplier unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnProductReset_Click(null, RoutedEventArgs.Empty);
                return;
            }

            PopulateComboBoxes();

            btnProductAdd.Enabled = false;
            btnProductReset.Enabled = true;

            txtBxProductName.Enabled = true;
            txtBxPurchasePrice.Enabled = true;
            txtBxProductDescription.Enabled = true;
            txtBxProductWarrenty.Enabled = true;

            comboBxlblProductCategory.Enabled = true;
            comboBxlProductSupplier.Enabled = true;
            comboBxProductState.Enabled = true;

            btnProductExistingUpdate.Visible = false;
            btnProductNewUpdate.Visible = true;
            btnProductNewUpdate.Enabled = true;

        }

        private void btnProductReset_Click(object sender, EventArgs e)
        {
            txtBxProductId.BorderStyle = BorderStyle.None;
            txtBxProductId.BorderStyle = BorderStyle.Fixed3D;

            txtBxProductName.BorderStyle = BorderStyle.None;
            txtBxProductName.BorderStyle = BorderStyle.Fixed3D;

            txtBxPurchasePrice.BorderStyle = BorderStyle.None;
            txtBxPurchasePrice.BorderStyle = BorderStyle.Fixed3D;

            txtBxProductWarrenty.BorderStyle = BorderStyle.None;
            txtBxProductWarrenty.BorderStyle = BorderStyle.Fixed3D;

            txtBxProductDescription.BorderStyle = BorderStyle.None;
            txtBxProductDescription.BorderStyle = BorderStyle.Fixed3D;

            comboBxlblProductCategory.DataSource = null;
            comboBxlblProductCategory.Enabled = false;

            comboBxlProductSupplier.DataSource = null;
            comboBxlProductSupplier.Enabled = false;

            comboBxProductState.DataSource = null;
            comboBxProductState.Enabled = false;

            txtBxProductId.Text = string.Empty;
            txtBxProductName.Text = string.Empty;
            txtBxPurchasePrice.Text = string.Empty;
            txtBxProductDescription.Text = string.Empty;
            txtBxProductWarrenty.Text = string.Empty;

            txtBxProductName.Enabled = false;
            txtBxPurchasePrice.Enabled = false;
            txtBxProductDescription.Enabled = false;
            txtBxProductWarrenty.Enabled = false;

            btnProductNewUpdate.Enabled = false;
            btnProductExistingUpdate.Enabled = false;

            btnProductExistingUpdate.Visible = false;
            btnProductNewUpdate.Visible = true;

            btnProductAdd.Enabled = true;
            btnProductEdit.Enabled = false;

            btnProductReset.Enabled = false;
        }

        private void dGVProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnProductAdd.Enabled == false)
                return;

            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dGVProducts.Rows[e.RowIndex];
                txtBxProductId.Text = dgvRow.Cells[0].Value.ToString();
                txtBxProductName.Text = dgvRow.Cells[1].Value.ToString();
                txtBxProductDescription.Text = dgvRow.Cells[2].Value.ToString();
                txtBxPurchasePrice.Text = dgvRow.Cells[3].Value.ToString();
                txtBxProductWarrenty.Text = dgvRow.Cells[4].Value.ToString();

                comboBxProductState.DataSource = Enum.GetValues(typeof(ProductState));
                var text = dgvRow.Cells[7].Value.ToString();
                //converting text to enum
                Enum.TryParse(text, out ProductState state);
                //converting enum to int
                comboBxProductState.SelectedIndex = (int)state - 1;

                comboBxlblProductCategory.DataSource = data.Categories;
                comboBxlblProductCategory.DisplayMember = "Name";
                comboBxlblProductCategory.ValueMember = "Name";
                var CategoryName = dgvRow.Cells[6].Value.ToString();
                comboBxlblProductCategory.SelectedIndex = data.Categories.FindIndex(u => u.Name == CategoryName);

                comboBxlProductSupplier.DataSource = data.Suppliers;
                comboBxlProductSupplier.DisplayMember = "Name";
                comboBxlProductSupplier.ValueMember = "Name";
                var SupplierName = dgvRow.Cells[5].Value.ToString();
                comboBxlblProductCategory.SelectedIndex = data.Suppliers.FindIndex(u => u.Name == SupplierName);

            }
            btnProductAdd.Enabled = false;
            btnProductEdit.Enabled = true;
            btnProductReset.Enabled = true;
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            btnProductAdd.Enabled = false;
            btnProductReset.Enabled = true;
            btnProductEdit.Enabled = false;

            txtBxProductName.Enabled = true;
            txtBxProductDescription.Enabled = true;
            txtBxProductWarrenty.Enabled = true;
            txtBxPurchasePrice.Enabled = true;

            btnProductNewUpdate.Visible = false;
            btnProductExistingUpdate.Visible = true;
            btnProductExistingUpdate.Enabled = true;

            comboBxlblProductCategory.Enabled = true;
            comboBxlProductSupplier.Enabled = true;
            comboBxProductState.Enabled = true;


        }

        private void btnProductNewUpdate_Click(object sender, EventArgs e)
        {
            ProductNewModel data = new ProductNewModel
            {
                Name = txtBxProductName.Text,
                Description = txtBxProductDescription.Text,
                Price=double.TryParse(txtBxPurchasePrice.Text,out double ValidPrice)?ValidPrice:(double?)null,
                Warrenty=int.TryParse(txtBxProductWarrenty.Text,out int ValidWarrenty)? ValidWarrenty : (int?)null,
                SupplierName = comboBxlProductSupplier.SelectedValue.ToString(),
                CategoryId=comboBxlblProductCategory.SelectedIndex +1,
                ProductStateId=comboBxProductState.SelectedIndex + 1
            };
            bool validData = ProductInputDataValidator.ValidateAdd(data);

            if (validData)
            {
                _db.CreateNewProduct(data);
                dGVProducts.DataSource = _db.GetAllProductsFromDatabase();
                MessageBox.Show("New Product Added to Database", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnProductReset_Click(null, RoutedEventArgs.Empty);
            }
        }

        private void btnProductExistingUpdate_Click(object sender, EventArgs e)
        {

            ProductFullModel data = new ProductFullModel
            {
                Id=int.Parse(txtBxProductId.Text),
                Name = txtBxProductName.Text,
                Description = txtBxProductDescription.Text,
                Price = double.TryParse(txtBxPurchasePrice.Text, out double ValidPrice) ? ValidPrice : (double?)null,
                Warrenty = int.TryParse(txtBxProductWarrenty.Text, out int ValidWarrenty) ? ValidWarrenty : (int?)null,
                SupplierName = comboBxlProductSupplier.SelectedValue.ToString(),
                CategoryId = comboBxlblProductCategory.SelectedIndex + 1,
                ProductStateId = comboBxProductState.SelectedIndex + 1
            };

            bool validData = ProductInputDataValidator.ValidateUpdate(data);

            if (validData)
            {
                _db.UpdateExistingProduct(data);
                dGVProducts.DataSource = _db.GetAllProductsFromDatabase();
                MessageBox.Show("Product Updated Successfully!", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnProductReset_Click(null, RoutedEventArgs.Empty);
            }
        }


        private void txtBxProductWarrenty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Please enter only numbers.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtBxPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txtBxPurchasePrice.Text.Contains("."))
            {
                MessageBox.Show("Invalid Number", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }
            else if (e.KeyChar == '.' && txtBxPurchasePrice.Text.Length == 0)
            {
                MessageBox.Show("Price should be greater than 1.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Please enter only numbers.", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
