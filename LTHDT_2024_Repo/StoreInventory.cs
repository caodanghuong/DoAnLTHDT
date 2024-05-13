using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
    public class StoreInventory : IStoreInventory
    {
        private String pathInventory = "D:\\OOP\\Database\\InventoryProduct.txt";
        public List<Inventory> GetInventoriesProduct()
        {
            List<Inventory> inventoryList = new List<Inventory>();
            StreamReader reader = new StreamReader(pathInventory);
            int quantitieInventory = int.Parse(reader.ReadLine());
            for (int i = 0; i < quantitieInventory; i++)
            {
                String dong = reader.ReadLine();
                Inventory listInventory = new Inventory();
                String[] cot1 = dong.Split(",");
                listInventory.SETPRODUCTID(int.Parse(cot1[0]));
                listInventory.SETEXPIREDATE(DateTime.Parse(cot1[1]));
                listInventory.SETCHECKDATE(DateTime.Parse(cot1[2]));
                listInventory.SETRESTPRODUCT(int.Parse(cot1[3]));
                inventoryList.Add(listInventory);
            }
            reader.Close();
            return inventoryList;
        }
       
    }
}
