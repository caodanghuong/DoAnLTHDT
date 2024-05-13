using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
    public class StoreImports : IStoreImports
    {
        private String pathGetImports = "D:\\OOP\\Database\\Export.txt";
        public List<Import> GetImportsProduct()
        {
            List<Import> importslist = new List<Import>();
            StreamReader reader = new StreamReader(pathGetImports);
            int quantitieImport = int.Parse(reader.ReadLine());
            for (int i = 0; i < quantitieImport; i++)
            {
                String dong = reader.ReadLine();
                Import listImport = new Import();
                String[] cot1 = dong.Split(",");
                listImport.SETIMPORTID(cot1[0]);
                listImport.SETPRODUCTID(cot1[1]);
                listImport.SETQUANTITIES(int.Parse(cot1[2]));
                listImport.SETPRICE(int.Parse(cot1[3]));
                listImport.SETIMPORTDATE(DateTime.Parse(cot1[4]));
                listImport.SETTOTAL(int.Parse(cot1[5]));
                importslist.Add(listImport);
            }
            reader.Close();
            return importslist;

            throw new NotImplementedException();
        }
    }
}
