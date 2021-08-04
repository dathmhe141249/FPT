using Sp2019B5.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Sp2019B5.DAL
{
    class CorDAL
    {
        /*public static List<Corporation> GetCategories()
        {
            List<Corporation> listC = new List<Corporation>();
            DataTable dataTable = Database.GetDataBySQL("SELECT [corp_no],[corp_name],[street],[region_no] FROM [PRN292_19_Spring].[dbo].[corporation]");
            foreach (DataRow row in dataTable.Rows)
            {
                int corpno = Convert.ToInt32(row["corp_no"].ToString());
                string corpname = row["corp_name"].ToString();
                string street = row["street"].ToString();
                int regionNo = Convert.ToInt32(row["region_no"].ToString());
                Corporation cate = new Corporation(corpno, corpname, street, regionNo);
                listC.Add(cate);
            }
            return listC;
        }*/

        public static DataTable getAllCorp()
        {
            string sql = "SELECT [corp_no],[corp_name],c.[street], r.region_name" +
                " FROM corporation c, region r" +
                " where r.region_no = c.region_no";
            DataTable dataTable = Database.GetDataBySQL(sql);
            return dataTable;
        }
    }
}
