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
                listImport.SETIMPORTID(int.Parse(cot1[0]));
                listImport.SETPRODUCTID(int.Parse(cot1[1]));
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

		public void createrImport(int createrImport, int quantitiesImport, int priceImport, DateTime dateCheckImport, int totalImport)
		{
			var importMax = GetImportsProduct()[0].GETIMPORTID();
			for (int i = 1; i < GetImportsProduct().Count; i++)
			{
				if (importMax < GetImportsProduct()[i].GETIMPORTID())
				{
					importMax = GetImportsProduct()[i].GETIMPORTID();
				}
			}
			importMax++;

			var importList = GetImportsProduct();
			Import importNew = new Import();
			importNew.SETIMPORTID(importMax);
			importNew.SETPRODUCTID(createrImport);
			importNew.SETQUANTITIES(quantitiesImport);
			importNew.SETPRICE(priceImport);
			importNew.SETIMPORTDATE(dateCheckImport);
			importNew.SETTOTAL(totalImport);
			importList.Add(importNew);
			AddImportListDB(importList);
		}


        public void AddImportListDB(List<Import> importList)
        {

			StreamWriter fileWriteImport = new StreamWriter(pathGetImports);
			fileWriteImport.WriteLine(importList.Count);
			for (int i = 0; i < importList.Count; i++)
			{
				fileWriteImport.WriteLine($"{importList[i].GETIMPORTID()},{importList[i].GETPRODUCTID()},{importList[i].GETQUANTITIES()},{importList[i].GETPRICE()},{importList[i].GETIMPORTDATE()},{importList[i].GETTOTAL()}");
			}
			fileWriteImport.Close();
		}

		public Import getImportID(int id)
		{
			var importList = GetImportsProduct();
			for (int i = 0; i < importList.Count; i++)
			{
				if (id == importList[i].GETIMPORTID())
				{
					return importList[i];
				}
			}
			return null;
		}

		public void DeleteImportDB(int idImportDelete)
		{
			var ImporttList = GetImportsProduct();
			var importDelete = ImporttList.Where(x => x.GETIMPORTID() == idImportDelete).FirstOrDefault();
			ImporttList.Remove(importDelete);
			AddImportListDB(ImporttList);
		}

		public void updateImport(int idImportEdit, int iDProductEdit, int quantitesEdit, int priceEdit, DateTime dateExpiredEdit, int totalEdit)
		{
			var ImportList = GetImportsProduct();
			for (int i = 0; i < ImportList.Count; i++)
			{
				if (idImportEdit == ImportList[i].GETIMPORTID())
				{
					ImportList[i].SETIMPORTID(idImportEdit);
					ImportList[i].SETPRODUCTID(iDProductEdit);
					ImportList[i].SETQUANTITIES(quantitesEdit);
					ImportList[i].SETPRICE(priceEdit);
					ImportList[i].SETIMPORTDATE(dateExpiredEdit);
					ImportList[i].SETTOTAL(totalEdit);

				}
			}
			AddImportListDB(ImportList);
		}
	}
}
