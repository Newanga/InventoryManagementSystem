using IMS.Core.Models;
using System.Collections.Generic;

namespace IMS.DataAccess.FormCategoryData
{
    public interface IFormCategorySql
    {
        List<CategoryFullModel> GetAllCategoriesFromDatabase();

        void UpdateExistingCategory(CategoryFullModel Category);
        void CreateNewCategory(CategoryNewModel Category);
    }
}