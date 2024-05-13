using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Products
{
    public class CreateProductModel : PageModel
    {
        public String result = "";
        private IServiceProduct _ServiceProduct = new ServiceProduct();
        public void OnGet()
        {
        }
		public void OnPost(String nameProduct, DateTime dateExpired,String nameCompany, int yearoffProduct, int category)
		{
            result = _ServiceProduct.validateProduct(nameProduct, dateExpired, nameCompany, yearoffProduct, category);
		}
	}
}
