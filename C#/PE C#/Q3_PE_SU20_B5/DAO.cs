using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Q3_PE_SU20_B5
{
    public class DAO
    {
        public static DataTable getAllBook()
        {
            string sql = "SELECT * FROM [PRN292_Sum2020_B5].[dbo].[Books]";
            DataTable dataTable = Database.GetDataBySQL(sql);

            return dataTable;
        }

        public static int DeleteBook(int id)
        {
            int rs = 0;
            string sql = "DELETE FROM [dbo].[Books] Where ID = @id";
            SqlParameter sqlParameters = new SqlParameter("@id", SqlDbType.Char); ;
            sqlParameters.Value = id;
            int count = DeleteRelevant(id);
            if (count > 0)
            {
                rs = Database.ExecuteSQL(sql, sqlParameters);

            }
            else
            {
                rs = 0;
            }

            return rs;
        }

        public static int DeleteRelevant(int id)
        {
            int rs = 0;
            string sql = "DELETE FROM [dbo].[Author_Book] where BookID = @bid";
            SqlParameter sqlParameters = new SqlParameter("@bid", SqlDbType.Char); ;
            sqlParameters.Value = id;
            rs = Database.ExecuteSQL(sql, sqlParameters);
            return rs;
        }
    }
}