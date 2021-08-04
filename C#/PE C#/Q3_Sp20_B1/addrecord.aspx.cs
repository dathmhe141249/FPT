using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3_Sp20_B1
{
    public partial class addrecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlCountry.DataSource = DAO.getAllCountry();
                ddlCountry.DataTextField = "Country";
                ddlCountry.DataValueField = "Country";
                ddlCountry.SelectedValue = "Belarus";
                ddlCountry.DataBind();
                Button2.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime from =Convert.ToDateTime(Carlendar1.SelectedDate.ToString()).Date;
            DateTime to = Convert.ToDateTime(Calendar2.SelectedDate.ToString()).Date;
            AddInfo(from, to);
            Button2.Visible = true;
        }

        public void AddInfo(DateTime from, DateTime to)
        {
            StringBuilder objHtml = new StringBuilder();
            DateTime i = new DateTime();
            objHtml.Append("<form method='POST' id='form2' runat='server'");
            for (i = from.Date; i <= to.Date; i = i.AddDays(1).Date)
            {
                objHtml.Append("<label>"+i.ToString("dd/MM/yyyy")+"</label>");
                objHtml.Append("<input id ='" + i.ToString("dd/MM/yyyy") + "' type='text' name='case " +i.ToString("dd/MM/yyyy")+"' />");
               /* objHtml.Append("<asp:RegularExpressionValidator ID='RegularExpressionValidator1' runat='server' Style='top: 234px; ");
                objHtml.Append("left: 366px; position: absolute; height: 22px; width: 177px'");
                objHtml.Append("ErrorMessage='Cases must be number' ControlToValidate='" + i.ToString("dd/MM/yyyy") + "'");
                objHtml.Append("</asp:RegularExpressionValidator> ");*/
                objHtml.Append("</br>");
            }
            //objHtml.Append("< asp:Button ID = 'Button1' runat = 'server' Text = 'Submit' OnClick = 'Button2_Click' />");
           // objHtml.Append("<button type='submit' runat='server id='submit' name='submit' class='button' value='Submit' onclick='Button2_Click();'>");
            //objHtml.Append("<asp:Button ID='Button1' runat='server' onclick='Button2_Click' Text='Submit' />");
            objHtml.Append("</form>");
            phField.Controls.Add(new Literal { Text = objHtml.ToString() });
           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string country = ddlCountry.SelectedValue.ToString();
                DateTime from = Convert.ToDateTime(Carlendar1.SelectedDate.ToString()).Date;
                DateTime to = Convert.ToDateTime(Calendar2.SelectedDate.ToString()).Date;
                DateTime i = new DateTime();
                int total = DAO.getMaxTotalByCountry(country);
                for (i = from.Date; i <= to.Date; i = i.AddDays(1).Date)
                {
                    DateTime add = i;
                    string c = "";
                    c = Request.Form["case " + i.ToString("dd/MM/yyyy")].ToString();
                    
                    if (!(c == string.Empty))
                    {
                        Regex regex = new Regex(@"^[0-9]+$");
                            if (regex.IsMatch(c))
                        {
                            int newCase = Convert.ToInt32(c);
                            total += newCase;
                            ArrayList list = new ArrayList
                {
                        country,add,newCase,total
                };
                            string d = add.ToString("MM-dd-yyyy");
                            if (DAO.checkDataExist(country, d)){
                                DAO.UpdateRecord(list);
                                string mess = "Update Succesfully";
                                Page.ClientScript.RegisterStartupScript(Page.GetType(), "AlertBox", "alert('" + mess + "');", true);
                            }
                            else
                            {
                                DAO.AddRecord(list);
                                string mess = "Add Succesfully";
                                Page.ClientScript.RegisterStartupScript(Page.GetType(), "AlertBox", "alert('" + mess + "');", true);
                            }
                        }
                        else
                        {
                            //string mess = "data must be number";
                            ErrorMsg.Text = "data must be number";
                            //Page.ClientScript.RegisterStartupScript(Page.GetType(), "AlertBox", "alert('" + mess + "');", true);
                            //Session["Error"] = mess;
                            // Response.Redirect("addrecord.aspx");
                        }

                       
                    }
                    else {
                        ErrorMsg.Text = "data can not be blank";
                        //string mess = "data can not be blank";
                        //Page.ClientScript.RegisterStartupScript(Page.GetType(), "AlertBox", "alert('" + mess + "');", true);
                        //Session["Error"] = mess;
                        // Response.Redirect("addrecord.aspx");
                    }

                }

            }
            catch (Exception ex)
            {
                ErrorMsg.Text = ex.Message.ToString();
                //string mess = ex.Message.ToString();
                //Page.ClientScript.RegisterStartupScript(Page.GetType(), "AlertBox", "alert('" + mess + "');", true);
                //Session["Error"] = mess;
                // Response.Redirect("addrecord.aspx");

            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            
        }
    }
}