using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace PE_SU20_Q3_B1
{
    public class DAL
    {
        public static DataTable getAllTeachingDate()
        {
            string sql = "select distinct TeachingDate from COURSE_SCHEDULES ORDER BY TeachingDate";
            return Database.GetDataBySQL(sql);
        }

        public static DataTable getAllRoom()
        {
            string sql = "select RoomId,RoomCode from ROOMS";
            return Database.GetDataBySQL(sql);
        }

        internal static string getInstructorName(DateTime teachingDate, int roomID, int slot)
        {
            string rs = "";
            string sql = "select (InstructorLastName+' '+ InstructorMidName+' '+InstructorFirstName) as" +
                " Fullname from INSTRUCTORS i,COURSES c, COURSE_SCHEDULES cs " +
                "where i.InstructorId = c.InstructorId and cs.CourseId = c.CourseId and" +
                " cs.TeachingDate='"+teachingDate+"' and cs.RoomId="+roomID+"and cs.Slot="+slot;
            DataTable table = Database.GetDataBySQL(sql);
            if(table.Rows.Count > 0)
            {
                rs = table.Rows[0]["Fullname"].ToString();
            }
            else
            {
                rs = "";
            }
           
            return rs;
        }
    }
}