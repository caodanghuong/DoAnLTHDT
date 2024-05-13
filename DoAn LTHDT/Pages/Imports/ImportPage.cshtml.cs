using LTHDT_2024_Service;
using LTHDT_2024_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Imports
{
    public class ImportPageModel : PageModel
    {
        private IServiceImports _ImportList = new ServiceImports();
        public List<Import> importList;
        public void OnGet()
        {
            importList = new List<Import>();
            importList = _ImportList.XulyGetImports();
        }
    }
}
