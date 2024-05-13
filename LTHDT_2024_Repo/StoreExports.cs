using LTHDT_2024_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_2024_Repo
{
    public class StoreExports : IStoreExports
    {
        private String pathGetExport = "D:\\OOP\\Database\\Export.txt";
        public List<Export> getExportProduct()
        {
            List<Export> exportslist = new List<Export>();
            StreamReader reader = new StreamReader(pathGetExport);
            int quantitieCategory = int.Parse(reader.ReadLine());
            for (int i = 0; i < quantitieCategory; i++)
            {
                String dong = reader.ReadLine();
                Export exports = new Export();
                String[] cot1 = dong.Split(",");
                exports.SETEXPORTID(cot1[0]);
                exports.SETPRODUCTID(cot1[1]);
                exports.SETQUANTITIES(int.Parse(cot1[2]));
                exports.SETPRICE(int.Parse(cot1[3]));
                exports.SETEXPORTDATE(DateTime.Parse(cot1[4]));
                exports.SETTOTAL(int.Parse(cot1[5]));
                exportslist.Add(exports);
            }
            reader.Close();
            return exportslist;
        }

    }
}
