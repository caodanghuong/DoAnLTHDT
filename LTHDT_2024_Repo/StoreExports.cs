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

		public void CreaterExport(int productID, int quantitiesEdit, int priceEdit, DateTime dateCheck, int totalproduct)
		{
            var exportMax = getExportProduct()[0].GETEXPORTID();
            for(int i = 1; i <getExportProduct().Count; i++)
            {
                if(exportMax < getExportProduct()[i].GETEXPORTID())
                {
					exportMax = getExportProduct()[i].GETEXPORTID();
				}
            }
            exportMax++;

            var exportList = getExportProduct();
            Export exportNew = new Export();
            exportNew.SETEXPORTID(exportMax);
            exportNew.SETPRODUCTID(productID);
            exportNew.SETQUANTITIES(quantitiesEdit);
            exportNew.SETPRICE(priceEdit);
            exportNew.SETEXPORTDATE(dateCheck);
            exportNew.SETTOTAL(totalproduct);
            exportList.Add(exportNew);
            AddExportListDB(exportList);
		}

        public void AddExportListDB(List<Export> exportList)
        {

			StreamWriter fileWriteExport = new StreamWriter(pathGetExport);
			fileWriteExport.WriteLine(exportList.Count);
			for (int i = 0; i < exportList.Count; i++)
			{
				fileWriteExport.WriteLine($"{exportList[i].GETEXPORTID()},{exportList[i].GETPRODUCTID()},{exportList[i].GETQUANTITIES()},{exportList[i].GETPRICE()},{exportList[i].GETEXPORTDATE()},{exportList[i].GETTOTAL()}");
			}
			fileWriteExport.Close();
		}

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
                exports.SETEXPORTID(int.Parse(cot1[0]));
                exports.SETPRODUCTID(int.Parse(cot1[1]));
                exports.SETQUANTITIES(int.Parse(cot1[2]));
                exports.SETPRICE(int.Parse(cot1[3]));
                exports.SETEXPORTDATE(DateTime.Parse(cot1[4]));
                exports.SETTOTAL(int.Parse(cot1[5]));
                exportslist.Add(exports);
            }
            reader.Close();
            return exportslist;
        }

		public Export getExportID(int id)
		{
			var exportList = getExportProduct();
			for (int i = 0; i < exportList.Count; i++)
			{
				if (id == exportList[i].GETEXPORTID())
				{
					return exportList[i];
				}
			}
			return null;
		}

		public void DeleteExportDB(int idExportDelete)
		{
			var ExportList = getExportProduct();
			var exportDelete = ExportList.Where(x => x.GETEXPORTID() == idExportDelete).FirstOrDefault();
			ExportList.Remove(exportDelete);
			AddExportListDB(ExportList);
		}

		public void updateExport(int idExportEdit, int iDProductEdit,int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit)
		{
			var ExportList = getExportProduct();
			for (int i = 0; i < ExportList.Count; i++)
			{
				if (idExportEdit == ExportList[i].GETEXPORTID())
				{
					ExportList[i].SETEXPORTID(idExportEdit);
					ExportList[i].SETPRODUCTID(iDProductEdit);
					ExportList[i].SETQUANTITIES(quantitesEdit);
					ExportList[i].SETPRICE(priceEdit);
					ExportList[i].SETEXPORTDATE(dateExpiredEdit);
					ExportList[i].SETTOTAL(totalEdit);

				}
			}
			AddExportListDB(ExportList);
		}
	}
}
