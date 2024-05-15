using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Exports
{
    public class EditExportsModel : PageModel
    {
		public String result = "";
		private IServiceExports _ServiceExport = new ServiceExports();
		public Export ExportModel = new Export();

		public void OnGet(int id)
		{
			Export ExportEdit = _ServiceExport.GetIdExport(id);
			ExportModel = ExportEdit;
		}
		public void OnPost(int IdExportEdit, int IDProductEdit,int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit)
		{
			result = _ServiceExport.UpdateExport(IdExportEdit, IDProductEdit, quantitesEdit, priceEdit, dateExpiredEdit, totalEdit);
		}
	}
}
