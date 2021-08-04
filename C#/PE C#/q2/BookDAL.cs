using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace q2
{
    class BookDAL
    {
        public static DataTable getAllBook()
        {
            string sql = "SELECT ID,Title FROM [PRN292_Sum2020_B5].[dbo].[Books]";
            DataTable dataTable = Database.GetDataBySQL(sql);
           
            return dataTable;
        }
       
        public static List<Book> GetBooks()
        {
            List<Book> list = new List<Book>();
            string sql = "SELECT * FROM [PRN292_Sum2020_B5].[dbo].[Books]";
            DataTable dataTable = Database.GetDataBySQL(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                int id = Convert.ToInt32(row["ID"].ToString());
                string title = row["Title"].ToString();
                int year = Convert.ToInt32(row["Year"].ToString());
                string des = row["Description"].ToString();
                Book b = new Book(id, title, year, des);
                list.Add(b);
            }
                return list;
        } 
        public static DataTable getAllBookByTitle(int id)
        {
            DataTable dataTable = Database.GetDataBySQL("select * from Books where ID = '"+id+"'");

            return dataTable;
        }

        public static DataTable getAllAuthorByBookID(int id)
        {
            DataTable dataTable = Database.GetDataBySQL("select * from Author_Book ab, Authors a where ab.AuthorID = a.ID and ab.BookID =" + id+"");

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

       /* public static int DeleteInAuthorBook(int aid, int bid)
        {
            DELETE FROM[dbo].[Author_Book]
            WHERE AuthorID = '' and BookID = ''
        }*/
    }
}
