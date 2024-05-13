using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
    public class StoreCategory : IStoreCategory
    {
        private String pathGetCategory = "D:\\OOP\\Database\\Category.txt";

		public void createNewCategory(string nameCategory)
		{
            var categoryMax = getCategoryList()[0].GETCATEGORYID();
            for(int i = 1; i < getCategoryList().Count; i++) {
                if(categoryMax < getCategoryList()[i].GETCATEGORYID())
                {
                    categoryMax = getCategoryList()[i].GETCATEGORYID();
				}
            }
            categoryMax++;
            
            var categoryList = getCategoryList();
            Category categoryNew = new Category();
			categoryNew.SETCATEGORYID(categoryMax);
            categoryNew.SETNAMECATEGORY(nameCategory);
            categoryList.Add(categoryNew);
            addCategoryListDB(categoryList);
		}

        public void addCategoryListDB(List<Category> categoryList) {
            StreamWriter fileWrite = new StreamWriter(pathGetCategory);
            fileWrite.WriteLine(categoryList.Count);
            for(int i = 0; i < categoryList.Count; i++)
            {
                fileWrite.WriteLine($"{categoryList[i].GETCATEGORYID()},{categoryList[i].GETNAMECATEGORY()}");

			}
			fileWrite.Close();

		}
        

		public List<Category> getCategoryList()
        {
            List<Category> categorylist = new List<Category>();
            StreamReader reader = new StreamReader(pathGetCategory);
            int quantitieCategory = int.Parse(reader.ReadLine());
            for(int i = 0; i < quantitieCategory;i++)
            {
                String dong = reader.ReadLine();
                Category category = new Category();
                String[] cot1 = dong.Split(",");
                category.SETCATEGORYID(int.Parse(cot1[0]));
                category.SETNAMECATEGORY(cot1[1]);
                categorylist.Add(category);
            }
            reader.Close();
            return categorylist;
        }

        public Category getCategoryID(int id)
        {

           var categoryList = getCategoryList();
            for(int i = 0; i< categoryList.Count; i++)
            {
                if(id == categoryList[i].GETCATEGORYID()) {
                    return categoryList[i];
                }
            }
            return null;
        }

        public void updateCategory(int IdCategoryEdit,string nameCategorytEdit)
        {
            var categoryList = getCategoryList();
            for(int i = 0; i< categoryList.Count; i++)
            {
                if(IdCategoryEdit == categoryList[i].GETCATEGORYID())
                {
                    categoryList[i].SETNAMECATEGORY(nameCategorytEdit);
                }

            }
            addCategoryListDB(categoryList);
        }

		public void DeleteCategoryDB(int idCategoryDelete)
		{
			var categoryList = getCategoryList();
			var categoryDelete = categoryList.Where(x=>x.GETCATEGORYID() ==idCategoryDelete).FirstOrDefault();
            categoryList.Remove(categoryDelete);
            addCategoryListDB(categoryList);
		}
	}
}
