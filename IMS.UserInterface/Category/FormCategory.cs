using IMS.Core.Models;
using IMS.DataAccess.FormCategoryData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Category
{
    public partial class FormCategory : Form
    {
        private readonly IFormCategorySql _db;
        List<CategoryModel> categories = new List<CategoryModel>();

        public FormCategory(IFormCategorySql db)
        {
            InitializeComponent();
            _db = db;
            PopulateDatagrid();
        }


        private void PopulateDatagrid()
        {
            dGVCategory.DataSource = _db.GetAllCategoriesFromDatabase();
        }
    }
}
