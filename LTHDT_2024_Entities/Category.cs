using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Entities
{
    public class Category
    {
        private int categoryId;
        private String nameCategory;
        public int GETCATEGORYID()
        {
            return categoryId;
        }
        public void SETCATEGORYID(int category)
        {
            this.categoryId = category;
        }
        public String GETNAMECATEGORY()
        {
            return nameCategory;
        }
        public void SETNAMECATEGORY(String nameCategory)
        {
            this.nameCategory = nameCategory;
        }

    }
    
}
