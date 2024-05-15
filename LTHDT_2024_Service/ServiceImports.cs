using LTHDT_2024_Entities;
using LTHDT_2024_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public class ServiceImports : IServiceImports
    {
        private IStoreImports _StoreImport = new StoreImports();

		public string DeleteImports(int idImportDelete)
		{
			String result = "";
			_StoreImport.DeleteImportDB(idImportDelete);
			return "Delete Import Successfully";
		}

		public Import GetIdImport(int id)
		{
			return _StoreImport.getImportID(id);
		}

		public string UpdateImport(int idImportEdit, int iDProductEdit, int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit)
		{
			String result = "";
			_StoreImport.updateImport(idImportEdit, iDProductEdit, quantitesEdit, priceEdit, dateExpiredEdit, totalEdit);

			return "Update Export Successfully";
		}

		public string validateImport(int createrImport, int quantitiesImport, int priceImport, DateTime dateCheckImport, int totalImport)
		{
			String result = "";
			_StoreImport.createrImport(createrImport, quantitiesImport, priceImport, dateCheckImport, totalImport);

			return "Creater Import Successfully";
		}

		public List<Import> XulyGetImports()
        {
            return _StoreImport.GetImportsProduct();
        }


    }
}
