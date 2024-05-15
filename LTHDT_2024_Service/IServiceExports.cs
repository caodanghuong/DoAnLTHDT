using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public interface IServiceExports
    {
		public string DeleteExports(int idExportDelete);
		public Export GetIdExport(int id);
		public string UpdateExport(int idExportEdit, int iDProductEdit,int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit);
		public string validateExport(int productID, int quantitiesEdit, int priceEdit, DateTime dateCheck, int totalproduct);
		public List<Export> XulyGetExports();
    }
}
