using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Exports
{
    public class CreateExportModel : PageModel 
    { 
        public String result = "";
        private IServiceExports _ServiceExport = new ServiceExports();
        public void OnGet()
        {
        }
        public void OnPost(int productID, int quantitiesEdit, int priceEdit, DateTime dateCheck, int totalproduct)
        {
            result = _ServiceExport.validateExport(productID, quantitiesEdit, priceEdit, dateCheck, totalproduct);

		}
    }
}
