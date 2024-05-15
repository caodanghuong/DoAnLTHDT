using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
    public interface IStoreExports
    {
		public void CreaterExport(int productID, int quantitiesEdit, int priceEdit, DateTime dateCheck, int totalproduct);
		public void DeleteExportDB(int idExportDelete);
		public Export getExportID(int id);
		public List<Export> getExportProduct();
		public void updateExport(int idExportEdit, int iDProductEdit, int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit);
	}
}
