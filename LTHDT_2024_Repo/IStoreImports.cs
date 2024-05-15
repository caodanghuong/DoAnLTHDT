using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
    public interface IStoreImports
    {
        public List<Import> GetImportsProduct();
		public void createrImport(int createrImport, int quantitiesImport, int priceImport, DateTime dateCheckImport, int totalImport);
		public Import getImportID(int id);
		public void DeleteImportDB(int idImportDelete);
		public void updateImport(int idImportEdit, int iDProductEdit, int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit);
	}
}
