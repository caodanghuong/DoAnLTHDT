using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Exports
{
    public class DeleteExportModel : PageModel
    {
		public String result = "";
		private IServiceExports _ServiceExport = new ServiceExports();
		public Export ExportModel = new Export();

		public void OnGet(int id)
		{
			Export ExportDelete = _ServiceExport.GetIdExport(id);
			ExportModel = ExportDelete;
		}
		public void OnPost(int idExportDelete)
		{
			result = _ServiceExport.DeleteExports(idExportDelete);
		}
	}

}
