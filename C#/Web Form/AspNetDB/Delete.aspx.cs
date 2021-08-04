using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetDB
{
    public partial class Delete : System.Web.UI.Page
    {
        public static SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["PRN292"].ToString();
            return new SqlConnection(strCon);
        }
        public static DataTable GetDataBySQL(string sql)
        {

            SqlCommand sqlCommand = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlCommand;
            DataSet ds = new DataSet(); // database cache
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static int ExecuteSQL(string sql, params SqlParameter[] sqlParameters)
        {
            SqlCommand cmd = new SqlCommand(sql, GetConnection()); // giống ps
            cmd.Parameters.AddRange(sqlParameters);
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }
        public static DataTable getProductByID(int id)
        {
            string sql = "select * from [Order Details] where ProductID =" + id + "";
            return GetDataBySQL(sql);
        }
        public static int DeleteListCateGoriesByID(int id)
        {
            int rs = 0;
            //quan hệ nhiều nhiều nên nếu bên kia có data => ko đc xóa
            if (getProductByID(id).Rows.Count > 0)
            {
                rs = 0;
            }
            else
            {

                string sql = "DELETE FROM [dbo].[Products] WHERE ProducId = @pid";
                SqlParameter sqlParameters = new SqlParameter("@CategoryId", SqlDbType.Char); ;
                sqlParameters.Value = id;
                rs = ExecuteSQL(sql, sqlParameters);
            }
            return rs;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(Request["pid"].ToString());
           DeleteListCateGoriesByID(pid);
            Response.Redirect("index.aspx");
        }
    }
}