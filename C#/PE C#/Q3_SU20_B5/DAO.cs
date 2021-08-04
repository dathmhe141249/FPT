using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Q3_SU20_B5
{
    public class DAO
    {
        public static DataTable getAllBook()
        {
            string sql = "SELECT * FROM [PRN292_Sum2020_B5].[dbo].[Books]";
            DataTable dataTable = Database.GetDataBySQL(sql);

            return dataTable;
        }

    }
}