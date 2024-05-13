using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Exports
{
    public class ExportsPageModel : PageModel
    {
        private IServiceExports _ServiceExport = new ServiceExports();
        public List<Export> ExportList;
        public void OnGet()
        {
            ExportList = new List<Export>();
            ExportList = _ServiceExport.XulyGetExports();
        }
    }
}
