using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Imports
{
    public class DeleteImportModel : PageModel
    {
		public String result = "";
		private IServiceImports _ServiceImports = new ServiceImports();
		public Import ImportModel = new Import();

		public void OnGet(int id)
		{
			Import ImportDelete = _ServiceImports.GetIdImport(id);
			ImportModel = ImportDelete;
		}
		public void OnPost(int idImportDelete)
		{
			result = _ServiceImports.DeleteImports(idImportDelete);
		}
	}
}
