using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Categories
{
	public class DeleteCategorysModel : PageModel
	{
		public String result = "";
		private IServiceCategory _ServiceCategory = new ServiceCategory();
		public Category CategoryModel = new Category();
		public void OnGet(int id)
		{
			Category category = _ServiceCategory.GetIdCategory(id);
			CategoryModel = category;
		}
		public void OnPost(int IdCategoryDelete)
		{
			result = _ServiceCategory.DeleteCategory(IdCategoryDelete);


		}
	}
}
