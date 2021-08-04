using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class Q3 : System.Web.UI.Page
    {
        public static SqlConnection GetConnection()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Q3"].ToString();
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
        public static DataTable GetAllMaster()
        {
            DataTable dataTable = GetDataBySQL("select*from DummyMaster");

            return dataTable;
        }

        public static DataTable GetAllDetail()
        {
            DataTable dataTable = GetDataBySQL("select*from DummyDetail");

            return dataTable;
        }
        public static DataTable Filter(string name, int id)
        {
            DataTable dataTable =GetDataBySQL(" select * from DummyDetail where detail_name like '%" + name + "%' and master_id=" + id + "");

            return dataTable;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlMaster.DataSource = GetAllMaster();
                ddlMaster.DataTextField = "master_name";
                ddlMaster.DataValueField = "master_id";
                ddlMaster.DataBind();

                gvMaster.DataSource = GetAllMaster() ;
                gvMaster.DataBind();
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int id = Convert.ToInt32(ddlMaster.SelectedValue);
            gvMaster.DataSource = Filter(name, id);
            gvMaster.DataBind();
        }
    }
}