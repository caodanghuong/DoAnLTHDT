using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Imports
{
    public class CreaterImportModel : PageModel
    {
		public String result = "";
		private IServiceImports _ServiceImport = new ServiceImports();
		public void OnGet()
		{
		}
		public void OnPost(int createrImport, int quantitiesImport, int priceImport, DateTime dateCheckImport, int totalImport)
		{
			result = _ServiceImport.validateImport(createrImport, quantitiesImport, priceImport, dateCheckImport, totalImport);

		}
	}
}
