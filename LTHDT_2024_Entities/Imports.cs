using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Entities
{
    public class Import
    {
        private int importID;
        private int productId;
        private int quantitis;
        private int price;
        private DateTime importDate;
        private int total;

        public int GETIMPORTID()
        {
            return importID;
        }
        public void SETIMPORTID(int importID) 
        { 
            this.importID = importID;
        }
        public int GETPRODUCTID()
        {
            return productId;
        }
        public void SETPRODUCTID(int productId)
        {
            this.productId = productId;
        }
        public int GETQUANTITIES()
        {
            return quantitis;
        }
        public void SETQUANTITIES(int quantitis)
        {
            this.quantitis = quantitis;
        }

        public int GETPRICE()
        {
            return price;
        }
        public void SETPRICE(int price)
        {
            this.price = price;
        }
        public DateTime GETIMPORTDATE()
        {
            return importDate;
        }
        public void SETIMPORTDATE(DateTime importDate)
        {
            this.importDate = importDate;
        }

        public int GETTOTAL()
        {
            return total;
        }
        public void SETTOTAL(int total)
        {
            this.total = total;
        }
    }
    
}
