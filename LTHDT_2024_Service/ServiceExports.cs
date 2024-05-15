using LTHDT_2024_Entities;
using LTHDT_2024_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public class ServiceExports : IServiceExports
    {
        private IStoreExports _storeExports = new StoreExports();
		private IStoreProduct _storeProduct = new StoreProduct();
		private IStoreCategory _storeCategory = new StoreCategory();

		public string DeleteExports(int idExportDelete)
		{
			String result = "";
			_storeExports.DeleteExportDB(idExportDelete);
			return "Delete Export Successfully";
		}

		public Export GetIdExport(int id)
		{
			return _storeExports.getExportID(id);
		}

		public string UpdateExport(int idExportEdit, int iDProductEdit, int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit)
		{

			String result = "";
			_storeExports.updateExport(idExportEdit, iDProductEdit, quantitesEdit, priceEdit, dateExpiredEdit, totalEdit);

			return "Update Export Successfully";
		}

		public string validateExport(int productID, int quantitiesEdit, int priceEdit, DateTime dateCheck, int totalproduct)
		{
			var DataProduct = _storeProduct.GetStoreProduct();
			bool checkData = false;
			for(int i = 0; i < DataProduct.Count;i++ )
			{
				if(productID == DataProduct[i].GETIDPRODUCT())
				{
					checkData = true;
				}
			}

			if(quantitiesEdit <0 & priceEdit <0 || totalproduct < 0)
			{
				return "Input Wrong Data";
			}

			if (checkData == false)
			{
				return "ProductID is not Exits";
			}
			else
			{
				_storeExports.CreaterExport(productID, quantitiesEdit, priceEdit, dateCheck, totalproduct);
			}

			return "Add Export Successfully";
		}

		public List<Export> XulyGetExports()
        {
            return _storeExports.getExportProduct();
        }
    }
}
