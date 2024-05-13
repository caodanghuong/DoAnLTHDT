using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Entities
{
    public class Product
    {
        private int idProduct;
        private String nameProduct;
        private DateTime dateExpire;
        private String companyName;
        private int yearOfProduct;
        private int nameCategory;

        public int GETIDPRODUCT()
        {
            return idProduct;
        }
        public void SETIDPRODUCT(int idProduct)
        {
            this.idProduct = idProduct;
        }

        public String GETNAMEPRODUCT()
        {
            return nameProduct;
        }
        public void SETNAMEPRODUCT(String nameProduct)
        {
            this.nameProduct = nameProduct;
        }

        public DateTime GETDATEEXPIRE()
        {
            return dateExpire;
        }
        public void SETDATEEXPIRE(DateTime dateExpire)
        {
            this.dateExpire = dateExpire;
        }

        public String GETCOMPANYNAME()
        {
            return companyName;
        }
        public void SETCOMPANYMANE(String companyName)
        {
            this.companyName = companyName;
        }

        public int GETYEAROFPRODUCT()
        {
            return yearOfProduct;
        }
        public void SETYEAROFPRODUCT(int yearOfProduct)
        {
            this.yearOfProduct = yearOfProduct;
        }


        public int GETCATEGORY()
        {
            return nameCategory;
        }
        public void SETCATEGORY(int category)
        {
            this.nameCategory = category;
        }
    }
    
}
