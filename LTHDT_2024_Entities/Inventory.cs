using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Entities
{
     public class Inventory
    {
        private int productId;
        private DateTime expireDate;
        private DateTime checkDate;
        private int restProduct;

        public int GETPRODUCTID()
        {
            return productId;
        }
        public void SETPRODUCTID(int productId)
        {
            this.productId = productId;
        }
        public DateTime GETEXPIREDATE() 
        {
            return expireDate;
        }
        public void SETEXPIREDATE(DateTime expireDate)
        {
            this.expireDate = expireDate;
        }

        public DateTime GETCHECKDATE()
        {
            return checkDate;
        }
        public void SETCHECKDATE(DateTime checkDate)
        {
            this.checkDate = checkDate;
        }

        public int GETRESTPRODUCT()
        {
            return restProduct;
        }
        public void SETRESTPRODUCT(int restProduct)
        {
            this.restProduct = restProduct;
        }
    }
}
