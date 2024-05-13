using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Products
{
    public class EditProductsModel : PageModel
    {
        public String result = "";
        private IServiceProduct _ServiceProduct = new ServiceProduct();
        public Product ProductModel = new Product();

        public void OnGet(int id)
        {
            Product productEdit = _ServiceProduct.GetIdProducts(id);
            ProductModel = productEdit;
        }
        public void OnPost(int IdProductEdit,String nameProductEdit, DateTime dateExpiredEdit, String nameCompanyEdit, int yearOffProductEdit, int categoryEdit)
        {
            result = _ServiceProduct.UpdateProducts(IdProductEdit, nameProductEdit, dateExpiredEdit, nameCompanyEdit, yearOffProductEdit, categoryEdit);
        }
    }
}
