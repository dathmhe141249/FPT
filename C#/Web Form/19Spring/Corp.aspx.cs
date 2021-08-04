using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _19Spring
{
    public partial class Corp : System.Web.UI.Page
    {
        public static SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["19SP"].ToString();
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

        public static DataTable GetAllRegion()
        {
            DataTable dataTable = GetDataBySQL("select * from region");
            
            return dataTable;
        }

        public static DataTable GetAllCorp(int id)
        {
            DataTable dataTable = GetDataBySQL("select * from corporation where region_no ="+id+"");

            return dataTable;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ddlregion.DataSource = GetAllRegion();
                ddlregion.DataTextField = "region_name";
                ddlregion.DataValueField = "region_no";
                ddlregion.DataBind();

                int no = Convert.ToInt32(ddlregion.SelectedValue);
                ddlCorp.DataSource = GetAllCorp(no);
                ddlCorp.DataTextField = "corp_name";
                ddlCorp.DataValueField = "corp_no";
                ddlCorp.DataBind();
            }
        }

        protected void ddlregion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int region_no = Convert.ToInt32(ddlregion.SelectedValue);
            ddlCorp.DataSource = GetAllCorp(region_no);
            ddlCorp.DataTextField = "corp_name";
            ddlCorp.DataValueField = "corp_no";
            ddlCorp.DataBind();
        }
    }
}