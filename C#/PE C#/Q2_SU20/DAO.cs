using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Q2_SU20
{
    class DAO
    {
        public static DataTable getAllCourse()
        {
            string sql = "select * from COURSES";
            return Database.GetDataBySQL(sql);
        }

        public static DataTable getAllRoom()
        {
            string sql = "select * from ROOMS";
            return Database.GetDataBySQL(sql);
        }

        public static int AddCourseSchedule(ArrayList arraylist)
        {
            string sql = "INSERT INTO [dbo].[COURSE_SCHEDULES]"
           +" ([CourseId]"
           +",[TeachingDate]"+
           ",[Slot]"+
           ",[RoomId]"+
           ",[Description])"+
     "VALUES(@cid,@date,@slot,@rid,@des)";
            SqlParameter[] sqlParameters = new SqlParameter[]{
            new SqlParameter("@cid", SqlDbType.Int),
           new SqlParameter("@date", SqlDbType.Date),
            new SqlParameter("@slot", SqlDbType.Int),
             new SqlParameter("@rid", SqlDbType.Int),
            new SqlParameter("@des", SqlDbType.NVarChar),

    };
            for (int i = 0; i< arraylist.Count; i++)
            {
                sqlParameters[i].Value = arraylist[i];
            }

            return Database.ExecuteSQL(sql, sqlParameters);
        }
    }
}
