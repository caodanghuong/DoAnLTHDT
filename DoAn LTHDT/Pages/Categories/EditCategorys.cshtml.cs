using LTHDT_2024_Entities;
using LTHDT_2024_Repo;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Categories
{
    
    public class EditCategorysModel : PageModel
    {
        public String result = "";
        private IServiceCategory _ServiceCategory = new ServiceCategory();
        public Category CategoryModel = new Category();
        public void OnGet(int id)
        {
            Category category = _ServiceCategory.GetIdCategory(id);
            CategoryModel = category;
        }
        public void OnPost(int IdCategoryEdit,String nameCategorytEdit)
        {
            result =  _ServiceCategory.UpdateCategory(IdCategoryEdit,nameCategorytEdit);


        }
    }
}
