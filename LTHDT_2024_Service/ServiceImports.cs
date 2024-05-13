using LTHDT_2024_Entities;
using LTHDT_2024_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Service
{
    public class ServiceImports : IServiceImports
    {
        private IStoreImports _StoreImport = new StoreImports();
        public List<Import> XulyGetImports()
        {
            return _StoreImport.GetImportsProduct();
        }


    }
}
