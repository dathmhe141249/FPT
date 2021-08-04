using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Q1_SP20_B1_2
{
    class DAO
    {
        public static DataTable getAllCountry()
        {
            string sql = "select distinct Country from DailyReport";
            DataTable data = Database.GetDataBySQL(sql);
            return data;
        }

        public static DataTable getAllDataByCountryAndDate(string country, DateTime from, DateTime to)
        {
            string fr = from.ToString("MM/dd/yyyy");
            string t = to.ToString("MM/dd/yyyy");
            string sql = "select Country,[Date],NewCases from DailyReport where " +
                "Country ='" + country+"' and [Date] " +
                "between '"+fr+"' and '"+t+ "' Order by [Date] desc";
            DataTable data = Database.GetDataBySQL(sql);
            return data;
        }
    }
}
