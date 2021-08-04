using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WindowsFormsApp1.DAO
{
    static class Database
    {
        public static SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["BTVN"].ToString();
            return new SqlConnection(strCon);
        }
        //select -> disconnected
        public static DataTable GetDataBySQL(string sql)
        {
           
            SqlCommand sqlCommand = new SqlCommand(sql,GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            DataSet ds = new DataSet(); // database cache
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        //insert,update,delete -> connected
        public static int ExecuteSQL(string sql, params SqlParameter[] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection()); // giống ps
            cmd.Parameters.AddRange(sqlParameters);
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result ;
        }
    }
}
