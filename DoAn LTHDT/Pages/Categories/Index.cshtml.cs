using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private IServiceCategory _ServiceCategory = new ServiceCategory();
        public List<Category> categories;
        public void OnGet()
        {
           categories= new List<Category>();
            categories = _ServiceCategory.XuLyGetCategory();
        }
    }
}
