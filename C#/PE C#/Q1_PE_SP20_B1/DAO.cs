using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Q1_PE_SP20_B1
{
    class DAO
    {
        public static DataTable getAllCountry()
        {
            string sql = "select distinct Country from DailyReport";
            DataTable data = Database.GetDataBySQL(sql);
            return data;
        }

        public static DataTable getInfo(string country, DateTime date)
        {
            string sql = "select Country,[Date],NewCases from DailyReport where " +
                "(" + country + ") and Date ='" + date+"'";
            DataTable data = Database.GetDataBySQL(sql);
            return data;
        }

        public static DataTable GetCountryByDate(string date)
        {
            return Database.GetDataBySQL("select Country, [Date], NewCases from DailyReport where [Date] = '" + date + "'");
        }

    }
}
