using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)//chỉ chạy lần đầu
            {
                lblMsg.Text += "Su kien Load trang <br/>";
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            lblMsg.Text += "Su kien khoi tao trang <br/>";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            lblMsg.Text += "dc sinh ra khi cac su kien khac da ket thuc <br/>";
        }

        //sk sinh  ra khi ng dung tac dong vao doi tuong nao do tren trang
        protected void btnClick_Click(object sender, EventArgs e)
        {
            lblMsg.Text += "su kien vao btn click cua ng dung <br/>";
        
    }
    }
}