using LTHDT_2024_Entities;
using LTHDT_2024_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public class ServiceExports : IServiceExports
    {
        private IStoreExports _storeExports = new StoreExports();
        public List<Export> XulyGetExports()
        {
            return _storeExports.getExportProduct();
        }
    }
}
