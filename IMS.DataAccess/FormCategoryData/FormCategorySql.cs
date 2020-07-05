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

        public List<CategoryFullModel> GetAllCategoriesFromDatabase()
        {
            string sql = "select * from dbo.category;";

            List<CategoryFullModel> categories = _db.LoadData<CategoryFullModel, dynamic>(sql, new { });

            return categories;
        }

        public void CreateNewCategory(CategoryNewModel Category)
        {
            string sql = "Insert into dbo.category (Name,Description) values (@Name,@Description);";

            _db.SaveData(sql, Category);
        }

        public void UpdateExistingCategory(CategoryFullModel Category)
        {
            string sql = "Update dbo.category Set Name=@Name,Description=@Description where Id=@Id";

            _db.SaveData(sql, Category);
        }

    }
}
