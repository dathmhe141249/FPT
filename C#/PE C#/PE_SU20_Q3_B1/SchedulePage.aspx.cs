using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PE_SU20_Q3_B1
{
    public partial class SchedulePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlTeachingDate.DataSource = DAL.getAllTeachingDate();
                ddlTeachingDate.DataTextField = "TeachingDate";
                ddlTeachingDate.DataValueField = "TeachingDate";
                ddlTeachingDate.DataTextFormatString = "{0:MM/dd/yyyy}";
                ddlTeachingDate.DataBind();
                DateTime teachingDate = new DateTime(2011, 07, 23);
                ddlTeachingDate.SelectedValue = teachingDate.ToString();

                //load data của instructorname theo room và slot, teachingdate
                ShowInstructorName(teachingDate);
            }
        }
        public void ShowInstructorName(DateTime teachingDate)
        {
            StringBuilder objHtml = new StringBuilder();
            objHtml.Append("<table border = '1px' style='width:100%'>");
            objHtml.Append("<tr>");
            objHtml.Append("<th>");
            objHtml.Append("RoomCode");
            objHtml.Append("</th>");
            objHtml.Append("<th>");
            objHtml.Append("Slot1");
            objHtml.Append("</th>");
            objHtml.Append("<th>");
            objHtml.Append("Slot2");
            objHtml.Append("</th>");
            objHtml.Append("<th>");
            objHtml.Append("Slot3");
            objHtml.Append("</th>");
            objHtml.Append("<th>");
            objHtml.Append("Slot4");
            objHtml.Append("</th>");
            objHtml.Append("<th>");
            objHtml.Append("Slot5");
            objHtml.Append("</th>");
            objHtml.Append("<th>");
            objHtml.Append("Slot6");
            objHtml.Append("</th>");
            objHtml.Append("</tr>");
            //load Roomcode hiển thị vào cột đầu tiên của bảng
            DataTable rooms = DAL.getAllRoom();
            foreach(DataRow room in rooms.Rows)
            {
                int roomID = Convert.ToInt32(room["RoomId"].ToString());
                objHtml.Append("<tr>");
                objHtml.Append("<td>"+room["RoomCode"]+ "</td>");
                objHtml.Append("<td>"+DAL.getInstructorName(teachingDate,roomID,1)+"</td>");
                objHtml.Append("<td>"+DAL.getInstructorName(teachingDate, roomID, 2)+"</td>");
                objHtml.Append("<td>" + DAL.getInstructorName(teachingDate, roomID, 3) + "</td>");
                objHtml.Append("<td>" + DAL.getInstructorName(teachingDate, roomID, 4) + "</td>");
                objHtml.Append("<td>" + DAL.getInstructorName(teachingDate, roomID, 5) + "</td>");
                objHtml.Append("<td>" + DAL.getInstructorName(teachingDate, roomID, 6) + "</td>");
                objHtml.Append("</tr>");
            }
            
            objHtml.Append("</table>");
            //theo doi tuong vào objHtml vào phSchedule
            phSchedule.Controls.Add(new Literal { Text = objHtml.ToString() });
        }

        protected void ddlTeachingDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Convert.ToDateTime(ddlTeachingDate.SelectedValue);
            ShowInstructorName(selectedDate);
        }
    }
}