using LTHDT_2024_Entities;
using LTHDT_2024_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public class ServiceCategory : IServiceCategory 

    { 
        private IStoreCategory _storeCategory = new StoreCategory();

		public string CheckCategory(string nameCategory)
		{
			var DataCategory = _storeCategory.getCategoryList();
			bool checkCategory = false;
			for (int i = 0; i < DataCategory.Count; i++)
			{
				if (nameCategory == DataCategory[i].GETNAMECATEGORY())
				{
					checkCategory = false; 
				}
			}
			if (checkCategory == true)
			{
				return "The Category Name have been not existed";
			}
			return "The Category Name have been not existed";
		}

		public string DeleteCategory(int idCategoryDelete)
		{
			String result = "";
			_storeCategory.DeleteCategoryDB(idCategoryDelete);
			return "Delete Category Successfully";
		}

		public Category GetIdCategory(int id)
        {
            return _storeCategory.getCategoryID(id);
        }

        public string UpdateCategory(int IdCategoryEdit,string nameCategorytEdit)
        {
            var CategoryName = _storeCategory.getCategoryList();
            String result = "";
            for(int i = 0; i < CategoryName.Count;i++)
            {
                if(nameCategorytEdit == CategoryName[i].GETNAMECATEGORY())
                {
                    return "Category Name  Exits";
                }
            }
            _storeCategory.updateCategory(IdCategoryEdit,nameCategorytEdit);
            return "Edit Category Successfully";
        }

        public string validateCategory(string nameCategory)
		{
          var DataCategory =  _storeCategory.getCategoryList();
            bool checkCategory = false;
            for(int i = 0; i < DataCategory.Count; i++)
            {
               if(nameCategory == DataCategory[i].GETNAMECATEGORY())
                {
                     checkCategory = true;
                }
            }
            if(checkCategory ==  true)
            {
              return "The Category Name have been existed, Plese chose anthor Category Name";
            } else
            {
                 _storeCategory.createNewCategory(nameCategory);

			}
            return "create Category Successfully";
		}

		public List<Category> XuLyGetCategory()
        {
            return _storeCategory.getCategoryList();
        }
    }
}
