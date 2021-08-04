using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Q3_Sp20_B1
{
    public class DAO
    {
        public static DataTable getAllCountry()
        {
            string sql = "select distinct Country from DailyReport";
            DataTable data = Database.GetDataBySQL(sql);
            return data;
        }
        public static int AddRecord(ArrayList arraylist)
        {
            string sql = "INSERT INTO [dbo].[DailyReport]" +
                " ([Country],[Date],[NewCases],[TotalCases])VALUES" +
                "(@c,@d,@n,@t)";

            SqlParameter[] sqlParameters = new SqlParameter[]{
            new SqlParameter("@c", SqlDbType.VarChar),
           new SqlParameter("@d", SqlDbType.Date),
            new SqlParameter("@n", SqlDbType.Int),
            new SqlParameter("@t", SqlDbType.Int),

    };
            for (int i = 0; i< arraylist.Count; i++)
            {
                sqlParameters[i].Value = arraylist[i];
            }

            return Database.ExecuteSQL(sql, sqlParameters);
        }

        public static int getMaxTotalByCountry(string country)
        {
            int rs = 0;
            string sql = "select MAX(TotalCases) as total from DailyReport where Country ='"+country+"'";
            DataTable data = Database.GetDataBySQL(sql);
            if(data.Rows.Count> 0)
            {
                rs = Convert.ToInt32(data.Rows[0]["total"].ToString());
            }
            else { }
            return rs;
        }

        public static bool checkDataExist(string country, string date)
        {
            //(MM/dd/yyyy) format trong DB
            string sql = "select * from DailyReport where Country = '"+country+ "' and [Date] = '"+date+"'";
            DataTable data = Database.GetDataBySQL(sql);
            if(data.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int UpdateRecord(ArrayList arraylist)
        {
            string sql = "UPDATE [dbo].[DailyReport]" +
                "SET [NewCases] = @n" +
                ",[TotalCases] =@t where Country = @c and [Date] = @d";
            SqlParameter[] sqlParameters = new SqlParameter[]{
            new SqlParameter("@c", SqlDbType.VarChar),
           new SqlParameter("@d", SqlDbType.Date),
            new SqlParameter("@n", SqlDbType.Int),
            new SqlParameter("@t", SqlDbType.Int),

    };
            for (int i = 0; i < arraylist.Count; i++)
            {
                sqlParameters[i].Value = arraylist[i];
            }

            return Database.ExecuteSQL(sql, sqlParameters);
        }

    }
    }
    

