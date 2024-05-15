using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public interface IServiceImports
    {
		public string DeleteImports(int idImportDelete);
		public Import GetIdImport(int id);
		public string UpdateImport(int idImportEdit, int iDProductEdit, int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit);
		public string validateImport(int createrImport, int quantitiesImport, int priceImport, DateTime dateCheckImport, int totalImport);
		public List<Import> XulyGetImports();
    }
}
