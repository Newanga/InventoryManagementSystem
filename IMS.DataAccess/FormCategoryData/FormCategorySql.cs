using IMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DataAccess.FormCategoryData
{
    public class FormCategorySql:IFormCategorySql
    {
        private readonly ISqlDataAccess _db;

        public FormCategorySql(ISqlDataAccess db)
        {
            _db = db;
        }

        public List<CategoryModel> GetAllCategoriesFromDatabase()
        {
            string sql = "select * from dbo.category;";

            List<CategoryModel> categories = _db.LoadData<CategoryModel, dynamic>(sql, new { });

            return categories;
        }

        public void CreateNewCategory(NewCategoryModel Category)
        {
            string sql = "Insert into dbo.category (Name,Description) values (@Name,@Description);";

            _db.SaveData(sql, Category);
        }

        public void UpdateExistingCategory(CategoryModel Category)
        {
            string sql = "Update dbo.category Set Name=@Name,Description=@Description where Id=@Id";

            _db.SaveData(sql, Category);
        }

    }
}
