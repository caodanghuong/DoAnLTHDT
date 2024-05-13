using LTHDT_2024_Entities;
using LTHDT_2024_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
	public class ServiceProduct : IServiceProduct
	{
		private IStoreProduct _storeProduct = new StoreProduct();
		private IStoreCategory _storeCategory = new StoreCategory();

		public string DeleteProducts(int idProductDelete)
		{
			String result = "";
			_storeProduct.DeleteProductDB(idProductDelete);
			return "Delete Product Successfully";
		}

		public Product GetIdProducts(int id)
        {

			return _storeProduct.GetProductId(id);
        }

		public string UpdateProducts(int idProductEdit, string nameProductEdit, DateTime dateExpiredEdit, string nameCompanyEdit, int yearOffProductEdit, int categoryEdit)
		{
			var dataProducts = _storeProduct.GetStoreProduct();
			var dataCategory = _storeCategory.getCategoryList();

			String result = "";
			for (int i = 0; i < dataProducts.Count; i++)
			{
				if (nameProductEdit == dataProducts[i].GETNAMEPRODUCT())
				{
					return "Name Product Exits";
				}
			}

			for (int i = 0; i < dataCategory.Count; i++)
			{
				if (dataCategory[i].GETCATEGORYID() != categoryEdit)
				{
					
					return "Category Not Exits";
				}
			}
			_storeProduct.updateProducts(idProductEdit, nameProductEdit, dateExpiredEdit, nameCompanyEdit, yearOffProductEdit, categoryEdit);

            return "Update Product Successfully";
		}
        public string validateProduct(string nameProduct, DateTime dateExpired, string nameCompany, int yearoffProduct, int category)
		{
			var DataProduct = _storeProduct.GetStoreProduct();
			var DataCategory = _storeCategory.getCategoryList();
			bool checkData = false;
			for(int i = 0; i < DataProduct.Count; i++)
			{
				if(nameProduct == DataProduct[i].GETNAMEPRODUCT())
				{
					checkData = true;
					return "The Product Name have been exits, Please chose another Product Name";
				}
				
			}
			for (int j = 0; j < DataCategory.Count; j++)
			{
				var DateCategorynew = new Category();
				DateCategorynew = DataCategory[j];
				if (category == DataCategory[j].GETCATEGORYID())
				{
					checkData = true;
	
				}
			}
			if (checkData == false)
			{
				return "Category is not Exits";
			}
			else
			{
				_storeProduct.CreateProducts(nameProduct, dateExpired, nameCompany, yearoffProduct, category);
			}
			
			return "Add Product Successfully";
		}

		public List<Product> XulyGetProducts()
		{
			return _storeProduct.GetStoreProduct();
		}
	}
}
