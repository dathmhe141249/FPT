using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PE_Q2_SU20
{
    class DAL
    {
        public static DataTable getAllCourse()
        {
            DataTable dataTable = Database.GetDataBySQL("select * from COURSES");
            return dataTable;
        }

        public static DataTable getAllData()
        {
            string sql = "select c.CourseId,c.InstructorId,c.CourseCode,c.CourseDescription,c.SubjectId,s.SubjectName,i.InstructorFirstName,i.InstructorMidName,i.InstructorLastName from COURSES c, SUBJECTS s, INSTRUCTORS i where c.InstructorId = i.InstructorId and c.SubjectId =s.SubjectId";
            DataTable dataTable = Database.GetDataBySQL(sql) ;
            return dataTable;
        }
        public static DataTable getAllSubject()
        {
            string sql = " select * from SUBJECTS";
            DataTable dataTable = Database.GetDataBySQL(sql);
            return dataTable;
        }

        public static DataTable getAllInstructor()
        {
            string sql = "select * from INSTRUCTORS";
            DataTable dataTable = Database.GetDataBySQL(sql);
            return dataTable;
        }

        public static DataTable getAllInstructorWithFullName()
        {
            string sql = "select INSTRUCTORS.InstructorId, (InstructorFirstName +' ' +InstructorMidName + ' ' +InstructorLastName) as fullname from INSTRUCTORS";
            DataTable dataTable = Database.GetDataBySQL(sql);
            return dataTable;
        }
        public static int CreateCourse(ArrayList arraylist)
        {
            string sql = "INSERT INTO [dbo].[COURSES]([CourseCode] ,[CourseDescription] ,[SubjectId],[InstructorId]) VALUES (@CourseCode,@CourseDes,@Sid,@Inid)";

            SqlParameter[] sqlParameters = new SqlParameter[]{
            new SqlParameter("@CourseCode", SqlDbType.NVarChar),
           new SqlParameter("@CourseDes", SqlDbType.NVarChar),
            new SqlParameter("@Sid", SqlDbType.Int),
            new SqlParameter("@Inid", SqlDbType.Int),

    };
            for (int i = 0; i< arraylist.Count; i++)
            {
                sqlParameters[i].Value = arraylist[i];
            }

            return Database.ExecuteSQL(sql, sqlParameters);
        }

    }
}
