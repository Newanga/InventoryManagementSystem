using IMS.Core.Models;
using System.Collections.Generic;

namespace IMS.DataAccess.FormCategoryData
{
    public interface IFormCategorySql
    {
        List<CategoryModel> GetAllCategoriesFromDatabase();

        void UpdateExistingCategory(CategoryModel Category);
        void CreateNewCategory(NewCategoryModel Category);
    }
}