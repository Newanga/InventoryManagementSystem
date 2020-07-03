﻿using IMS.Core.Models;
using IMS.DataAccess.FormCategoryData;
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

namespace IMS.UserInterface.Category
{
    public partial class FormCategory : Form
    {
        private readonly IFormCategorySql _db;

        public FormCategory(IFormCategorySql db)
        {
            InitializeComponent();
            _db = db;
            txtBxCategoryId.BorderStyle = BorderStyle.None;
            txtBxCategoryName.BorderStyle = BorderStyle.None;
            txtBxCategoryDescription.BorderStyle = BorderStyle.None;
            PopulateDatagrid();
        }


        private void PopulateDatagrid()
        {
            dGVCategory.DataSource = _db.GetAllCategoriesFromDatabase();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {

            btnCategoryAdd.Enabled = false;
            txtBxCategoryId.BorderStyle = BorderStyle.Fixed3D;
            txtBxCategoryName.BorderStyle = BorderStyle.Fixed3D;
            txtBxCategoryDescription.BorderStyle = BorderStyle.Fixed3D;

            btnCategoryReset.Enabled = true;
            txtBxCategoryName.Enabled = true;
            txtBxCategoryDescription.Enabled = true;

            btnCategoryExistingUpdate.Visible = false;
            btnCategoryNewUpdate.Visible = true;
            btnCategoryNewUpdate.Enabled = true;
        }

        private void btnCategoryReset_Click(object sender, EventArgs e)
        {
            txtBxCategoryId.BorderStyle = BorderStyle.None;
            txtBxCategoryName.BorderStyle = BorderStyle.None;
            txtBxCategoryDescription.BorderStyle = BorderStyle.None;

            txtBxCategoryId.Text = string.Empty;
            txtBxCategoryName.Text = string.Empty;
            txtBxCategoryDescription.Text = string.Empty;

            txtBxCategoryName.Enabled = false;
            txtBxCategoryDescription.Enabled = false;

            btnCategoryNewUpdate.Enabled = false;
            btnCategoryExistingUpdate.Enabled = false;

            btnCategoryExistingUpdate.Visible = false;
            btnCategoryNewUpdate.Visible = true;

            btnCategoryAdd.Enabled = true;
            btnCategoryEdit.Enabled = false;

            btnCategoryReset.Enabled=false;
        }

        private void btnCategoryNewUpdate_Click(object sender, EventArgs e)
        {
            NewCategoryModel data = new NewCategoryModel { Name = txtBxCategoryName.Text, Description = txtBxCategoryDescription.Text };
            bool validData = CategoryInputDataValidator.ValidateAdd(data);

            if(validData)
            {
                _db.CreateNewCategory(data);
                dGVCategory.DataSource = _db.GetAllCategoriesFromDatabase();
                MessageBox.Show("New Category Added to Database", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCategoryReset_Click(null, RoutedEventArgs.Empty);
            }
        }

        private void dGVCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                DataGridViewRow dgvRow = dGVCategory.Rows[e.RowIndex];
                txtBxCategoryId.Text = dgvRow.Cells[0].Value.ToString();
                txtBxCategoryName.Text = dgvRow.Cells[1].Value.ToString();
                txtBxCategoryDescription.Text = dgvRow.Cells[2].Value.ToString();
            }
            txtBxCategoryId.BorderStyle = BorderStyle.None;
            txtBxCategoryName.BorderStyle = BorderStyle.None;
            txtBxCategoryDescription.BorderStyle = BorderStyle.None;

            btnCategoryAdd.Enabled = false;
            btnCategoryEdit.Enabled = true;
            btnCategoryReset.Enabled = true;
        }

        private void btnCategoryExistingUpdate_Click(object sender, EventArgs e)
        {
            CategoryModel data = new CategoryModel { Id =int.Parse(txtBxCategoryId.Text),Name = txtBxCategoryName.Text, Description = txtBxCategoryDescription.Text };
            bool validData = CategoryInputDataValidator.ValidateUpdate(data);

            if (validData)
            {
                _db.UpdateExistingCategory(data);
                dGVCategory.DataSource = _db.GetAllCategoriesFromDatabase();
                MessageBox.Show("Category Updated Successfully", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCategoryReset_Click(null, RoutedEventArgs.Empty);
            }
        }

        private void btnCategoryEdit_Click(object sender, EventArgs e)
        {
            btnCategoryAdd.Enabled = false;
            btnCategoryReset.Enabled = true;


            txtBxCategoryName.Enabled = true;
            txtBxCategoryDescription.Enabled = true;

            txtBxCategoryId.BorderStyle = BorderStyle.Fixed3D;
            txtBxCategoryName.BorderStyle = BorderStyle.Fixed3D;
            txtBxCategoryDescription.BorderStyle = BorderStyle.Fixed3D;

            btnCategoryNewUpdate.Visible = false;
            btnCategoryExistingUpdate.Visible = true;
            btnCategoryExistingUpdate.Enabled = true;
        }
    }
}
