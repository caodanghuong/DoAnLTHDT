using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
	public class StoreProduct : IStoreProduct
	{
		private String pathProduct = "D:\\OOP\\Database\\Product.txt";

		public void CreateProducts(string nameProduct, DateTime dateExpired, string nameCompany, int yearoffProduct, int category)
		{
			var productMax = GetStoreProduct()[0].GETIDPRODUCT();
			for(int i = 1; i < GetStoreProduct().Count; i++)
			{
				if(productMax < GetStoreProduct()[i].GETIDPRODUCT()){
					productMax = GetStoreProduct()[i].GETIDPRODUCT();
				}
			}
			productMax++;

			var productList = GetStoreProduct();
			Product productNew = new Product();
            productNew.SETIDPRODUCT(productMax);
            productNew.SETNAMEPRODUCT(nameProduct);
            productNew.SETDATEEXPIRE(dateExpired);
            productNew.SETCOMPANYMANE(nameCompany);
            productNew.SETYEAROFPRODUCT(yearoffProduct);
            productNew.SETCATEGORY(category);
            productList.Add(productNew);
			AddProductListDB(productList);
		}

		public void AddProductListDB(List<Product> productList)
		{
			StreamWriter fileWriteProduct = new StreamWriter(pathProduct);
			fileWriteProduct.WriteLine(productList.Count);
			for(int i = 0; i< productList.Count; i++)
			{
				fileWriteProduct.WriteLine($"{productList[i].GETIDPRODUCT()},{productList[i].GETNAMEPRODUCT()},{productList[i].GETDATEEXPIRE()},{productList[i].GETCOMPANYNAME()},{productList[i].GETYEAROFPRODUCT()},{productList[i].GETCATEGORY()}");
			}
			fileWriteProduct.Close();
		}

		public List<Product> GetStoreProduct()
		{
			List<Product> productList = new List<Product>();
			StreamReader reader = new StreamReader(pathProduct);
			int quantitieProducts = int.Parse(reader.ReadLine());
			for (int i = 0; i < quantitieProducts; i++)
			{
				String dong = reader.ReadLine();
				Product products = new Product();
				String[] cot1 = dong.Split(",");
				products.SETIDPRODUCT(int.Parse(cot1[0]));
				products.SETNAMEPRODUCT(cot1[1]);
				products.SETDATEEXPIRE(DateTime.Parse(cot1[2]));
				products.SETCOMPANYMANE(cot1[3]);
				products.SETYEAROFPRODUCT(int.Parse(cot1[4]));
				products.SETCATEGORY(int.Parse(cot1[5]));
				productList.Add(products);
			}
			reader.Close();
			return productList;

		}

        public Product GetProductId(int id)
        {
            var productList = GetStoreProduct();
			for(int i = 0; i< productList.Count; i++)
			{
				if(id == productList[i].GETIDPRODUCT())
				{
					return productList[i];
				}
			}
			return null;
        }

        public void updateProducts(int idProductEdit, string nameProductEdit, DateTime dateExpiredEdit, string nameCompanyEdit, int yearOffProductEdit, int categoryEdit)
        {
			var productList = GetStoreProduct();
			for(int i = 0; i< productList.Count; i++)
			{
				if(idProductEdit == productList[i].GETIDPRODUCT())
				{
					productList[i].SETNAMEPRODUCT(nameProductEdit);
                    productList[i].SETDATEEXPIRE(dateExpiredEdit);
					productList[i].SETCOMPANYMANE(nameCompanyEdit);
					productList[i].SETYEAROFPRODUCT(yearOffProductEdit);
					productList[i].SETCATEGORY(categoryEdit);

                }
			}
            AddProductListDB(productList);
        }

		public void DeleteProductDB(int idProductDelete)
		{
			var productList = GetStoreProduct();
			var productDelete = productList.Where(x => x.GETIDPRODUCT() == idProductDelete).FirstOrDefault();
			productList.Remove(productDelete);
			AddProductListDB(productList);
		}

		
	}
}
