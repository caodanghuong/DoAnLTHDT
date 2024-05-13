using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
    public interface IStoreInventory
    {
        public List<Inventory> GetInventoriesProduct();
    }
}
