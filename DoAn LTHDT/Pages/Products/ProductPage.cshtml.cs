using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Products
{
    public class ProductPageModel : PageModel
    {
        private IServiceProduct _ServiceProduct = new ServiceProduct();
        public List<Product> productList;

        public void OnGet()
        {
            productList = new List<Product>();
            productList = _ServiceProduct.XulyGetProducts();
        }
    }
}
