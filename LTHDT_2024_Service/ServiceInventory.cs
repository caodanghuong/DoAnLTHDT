using LTHDT_2024_Entities;
using LTHDT_2024_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public class ServiceInventory : IServiceInventory
    {
        private IStoreInventory _StoreImport = new StoreInventory();
        public List<Inventory> XulyGetInventory()
        {
            return _StoreImport.GetInventoriesProduct();
        }
    }
}
