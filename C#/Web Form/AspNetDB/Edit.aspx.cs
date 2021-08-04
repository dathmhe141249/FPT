using System;
using System.Collections;
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

    public partial class Edit : System.Web.UI.Page
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
            string sql = "select * from Products where ProductID = " + id + "";
            return GetDataBySQL(sql);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                int pid = Convert.ToInt32(Request["pid"].ToString());
                string pName = getProductByID(pid).Rows[0]["ProductName"].ToString();
                double price = Convert.ToDouble(getProductByID(pid).Rows[0]["UnitPrice"].ToString());
                bool discon = Convert.ToBoolean(getProductByID(pid).Rows[0]["Discontinued"].ToString());

                //fill data vào textbox
                txtID.Text = pid.ToString();
                txtName.Text = pName;
                txtPrice.Text = price.ToString();
                Discontinuedcb.Checked = discon;

                //fill data vào category
                ddlCate.DataSource = GetAllCategory();
                ddlCate.DataTextField = "CategoryName";
                ddlCate.DataValueField = "CategoryID";
                ddlCate.DataBind();

                //chon danh muc cua san pham can update
                ddlCate.SelectedValue = getProductByID(pid).Rows[0]["CategoryID"].ToString();
            }
           

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
        public static int UpdateProduct(ArrayList list)
        {
            string sql = "UPDATE Products SET ProductName = @Name, UnitPrice= @Price, [CategoryID] = @cid, " +
                "[Discontinued]=@discon WHERE ProductID = @pid";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Name",SqlDbType.NVarChar),
                new SqlParameter("@Price",SqlDbType.Money),
                new SqlParameter("@cid",SqlDbType.Int),
                new SqlParameter("@discon",SqlDbType.Bit),
                new SqlParameter("@pid",SqlDbType.Int)
            };
            for (int i = 0; i < list.Count; i++)
            {
                sqlParameters[i].Value = list[i];
            }

            return ExecuteSQL(sql, sqlParameters);

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            string name = txtName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int cid = Convert.ToInt32(ddlCate.SelectedValue);
            bool discon = (Discontinuedcb.Checked == true) ? true : false;

            //check validation: tự làm

            // update
            ArrayList list = new ArrayList() { name, price, cid, discon, id};
            if(UpdateProduct(list) > 0)
            {
                // dieu huong ve aspx
                Response.Redirect("index.aspx");
            }
            else
            {

            }

        }
    }
}