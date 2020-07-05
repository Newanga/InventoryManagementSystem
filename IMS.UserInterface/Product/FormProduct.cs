using IMS.Core.ViewModels;
using IMS.DataAccess.FormProduct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.UserInterface.Product
{
    public partial class FormProduct : Form
    {
        private readonly IFormProductSql _db;

        public FormProduct(IFormProductSql db)
        {
            InitializeComponent();
            _db = db;
            PopulateProducts();
        }

        public void PopulateProducts()
        {
           dGVProducts.DataSource = _db.GetAllProductsFromDatabase();
        }

   
    }
}
