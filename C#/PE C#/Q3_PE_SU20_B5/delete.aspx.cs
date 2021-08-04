using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3_PE_SU20_B5
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int bid = Convert.ToInt32(Request["id"].ToString());
            int count = DAO.DeleteBook(bid);
            if(count > 0)
            {
                Response.Redirect("books.aspx");
            }
        }
    }
}