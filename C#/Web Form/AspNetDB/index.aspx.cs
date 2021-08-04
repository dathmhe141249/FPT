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
    public partial class index : System.Web.UI.Page
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
        public static DataTable GetAllCategory()
        {
            string sql = "select * from Categories";
            return GetDataBySQL(sql);
        }
        public static DataTable getProductByID(int id)
        {
            string sql = "select * from Products where CategoryID = " +id+"";
            return GetDataBySQL(sql);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //load Catename từ Categories vào DropDown
                ddlCategory.DataSource = GetAllCategory();
                ddlCategory.DataTextField = "CategoryName";
                ddlCategory.DataValueField = "CategoryID";
                ddlCategory.DataBind();
                //load du lieu của product theo CateID vào GridView
                int catId = Convert.ToInt32(ddlCategory.SelectedValue);
                gvProduct.DataSource = getProductByID(catId);
                
                gvProduct.DataBind();
            }
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int catId = Convert.ToInt32(ddlCategory.SelectedValue);
            gvProduct.DataSource = getProductByID(catId);
            gvProduct.DataBind();
        }
    }
}