using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Categories
{
    public class CreateCategoryModel : PageModel
    {
        public String result = "";
		private IServiceCategory _ServiceCategory = new ServiceCategory();
		public void OnGet()
        {
        }
        public void OnPost(String nameCategory) 
        {
            result =  _ServiceCategory.validateCategory(nameCategory);


		}
    }
}
