using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Entities
{
    public class Export
    {
        private String exportId;
        private String productId;
        private int quantities;
        private int price;
        private DateTime exportDate;
        private int total;

        public String GETEXPORTID()
        {
            return exportId;
        }
        public void SETEXPORTID(String exportId)
        {
            this.exportId = exportId;
        }
        public String GETPRODUCTID()
        {
            return productId;
        }
        public void SETPRODUCTID(String productId)
        {
            this.productId = productId;
        }
        public int GETQUANTITIES()
        {
            return quantities;
        }
        public void SETQUANTITIES(int quantities)
        {
            this.quantities= quantities;
        }

        public int GETPRICE()
        {
            return price;
        }
        public void SETPRICE(int price)
        {
            this.price = price;
        }

        public DateTime GETEXPORTDATE()
        {
            return exportDate;
        }
        public void SETEXPORTDATE(DateTime exportDate)
        {
            this.exportDate = exportDate;
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
