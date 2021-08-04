using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Q2_PE
{
    class BookDAL
    {
            public static DataTable getAllBook()
            {
                DataTable dataTable = Database.GetDataBySQL("select * from Books");

                return dataTable;
            }

            public static DataTable getAllBookByTitle(int id)
            {
                DataTable dataTable = Database.GetDataBySQL("select * from Books where ID = '" + id + "'");

                return dataTable;
            }

            public static DataTable getAllAuthorByBookID(int id)
            {
                DataTable dataTable = Database.GetDataBySQL("select * from Author_Book ab, Authors a where ab.AuthorID = a.ID and ab.BookID =" + id + "");

                return dataTable;
            }

            public static int DeleteAuthor(int id)
            {
                int rs = 0;
                //quan hệ nhiều nhiều nên nếu bên kia có data => ko đc xóa
                if (getAllAuthorByBookID(id).Rows.Count > 0)
                {
                    rs = 0;
                }
                else
                {

                    string sql = "DELETE FROM [dbo].[Author_Book] WHERE AuthorID = @ID";
                    SqlParameter sqlParameters = new SqlParameter("@ID", SqlDbType.Int); ;
                    sqlParameters.Value = id;
                    rs = Database.ExecuteSQL(sql, sqlParameters);

                }
                return rs;
            }
        }
}
