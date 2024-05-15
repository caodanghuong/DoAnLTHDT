using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Imports
{
    public class EditImportModel : PageModel
    {
		public String result = "";
		private IServiceImports _ServiceImport = new ServiceImports();
		public Import ImportModel = new Import();

		public void OnGet(int id)
		{
			Import ImportEdit = _ServiceImport.GetIdImport(id);
			ImportModel = ImportEdit;
		}
		public void OnPost(int IdImportEdit, int IDProductEdit, int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit)
		{
			result = _ServiceImport.UpdateImport(IdImportEdit, IDProductEdit, quantitesEdit, priceEdit, dateExpiredEdit, totalEdit);
		}
	}
}
