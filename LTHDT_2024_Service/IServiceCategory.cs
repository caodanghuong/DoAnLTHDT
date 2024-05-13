using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public interface IServiceCategory
    {
		public string validateCategory(string nameCategory);
		public String CheckCategory(string nameCategory);
		public List<Category> XuLyGetCategory();
        Category GetIdCategory(int id);
        public string UpdateCategory(int IdCategoryEdit,string nameCategorytEdit);
		public string DeleteCategory(int idCategoryDelete);
	}
}
