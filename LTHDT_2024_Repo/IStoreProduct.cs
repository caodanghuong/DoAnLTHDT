using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
	public interface IStoreProduct
	{
		public void CreateProducts(string nameProduct, DateTime dateExpired, string nameCompany, int yearoffProduct, int category);
		public void DeleteProductDB(int idProductDelete);
		Product GetProductId(int id);
        public List<Product> GetStoreProduct();
        public void updateProducts(int idProductEdit, string nameProductEdit, DateTime dateExpiredEdit, string nameCompanyEdit, int yearOffProductEdit, int categoryEdit);
    }
}
