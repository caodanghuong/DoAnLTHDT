using LTHDT_2024_Entities;
using LTHDT_2024_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DoAn_LTHDT.Pages.Inventorys
{
    public class InventoryPageModel : PageModel
    {
        private IServiceInventory _InventoryList = new ServiceInventory();
        public List<Inventory> inventoryList;
        public void OnGet()
        {
            inventoryList = new List<Inventory>();
            inventoryList = _InventoryList.XulyGetInventory();

        }
    }
}
