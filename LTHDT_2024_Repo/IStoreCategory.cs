using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
    public interface IStoreCategory
    {
		public void createNewCategory(string nameCategory);
		void DeleteCategoryDB(int idCategoryDelete);
		Category getCategoryID(int id);
        public List<Category> getCategoryList();
        public void updateCategory(int IdCategoryEdit,string nameCategorytEdit);
    }

}
