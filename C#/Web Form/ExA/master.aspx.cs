using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExA
{
    public partial class master : System.Web.UI.Page
    {
        public static DataTable GetAllMaster()
        {
            DataTable dataTable = Database.GetDataBySQL("select*from DummyMaster");
            
            return dataTable;
        }

        public static DataTable GetAllDetail()
        {
            DataTable dataTable = Database.GetDataBySQL("select*from DummyDetail");

            return dataTable;
        }
        public static DataTable Filter(string name, int id)
        {
            DataTable dataTable = Database.GetDataBySQL(" select * from DummyDetail where detail_name like '%"+name+"%' and master_id="+id+"");

            return dataTable;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlmaster.DataSource = GetAllMaster();
                ddlmaster.DataTextField = "master_name";
                ddlmaster.DataValueField = "master_id";
                ddlmaster.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int id = Convert.ToInt32(ddlmaster.SelectedValue);
            gvmaster.DataSource = Filter(name, id);
            gvmaster.DataBind();
        }
    }
}