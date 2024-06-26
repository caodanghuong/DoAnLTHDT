﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Entities
{
    public class Export
    {
        private int exportId;
        private int productId;
        private int quantities;
        private int price;
        private DateTime exportDate;
        private int total;

        public int GETEXPORTID()
        {
            return exportId;
        }
        public void SETEXPORTID(int exportId)
        {
            this.exportId = exportId;
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
