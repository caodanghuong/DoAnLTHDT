using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
	public interface IServiceProduct
	{
		public string DeleteProducts(int IdProductDelete);
		Product GetIdProducts(int id);
        public string UpdateProducts(int idProductEdit, string nameProductEdit, DateTime dateExpiredEdit, string nameCompanyEdit, int yearOffProductEdit, int categoryEdit);
        String validateProduct(String nameProduct, DateTime dateExpired, String nameCompany, int yearoffProduct, int category);
		public List<Product> XulyGetProducts();
	}
}
