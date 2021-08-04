using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace WindowsFormsApp1.DAO
{
     class Category
    {
         string CatID;
         string CatName;
        string desc;

        public Category()
        {
        }

        public Category(string catID, string catName, string desc)
        {
            CatID1 = catID;
            CatName1 = catName;
            this.Desc = desc;
        }

        public  string CatID1 { get => CatID; set => CatID = value; }
        public  string CatName1 { get => CatName; set => CatName = value; }
        public string Desc { get => desc; set => desc = value; }

        public static List<Category> GetCategories()
        {
            List<Category> listC = new List<Category>();
            DataTable dataTable = Database.GetDataBySQL("select*from Categories");
            foreach (DataRow row in dataTable.Rows)
            {
                string cateID = row["CategoryID"].ToString();
                string catename = row["CategoryName"].ToString();
                string catedes = row["Description"].ToString();
                Category cate = new Category(cateID,catename,catedes);
                listC.Add(cate);
            }
            return listC;
        }

        public static DataTable GetCategoriesByID(string cateID)
        {
            DataTable dataTable = Database.GetDataBySQL("select*from Categories where CategoryID = '" + cateID+"'");
          
            return dataTable;
        }
        
               /* public static DataTable GetCategoriesByName(string cateName)
                {
         DataTable dataTable = Database.GetDataBySQL("select*from Categories where CategoryName Like '%" + cateName+"%'");
           
            return dataTable;
                }*/
        public static List<Category> GetCategoriesByName(string cateName)
        {
            List<Category> listC = new List<Category>();
            DataTable dataTable = Database.GetDataBySQL("select*from Categories where CategoryName Like '%" + cateName + "%'");
            foreach (DataRow row in dataTable.Rows)
            {
                string cateID = row["CategoryID"].ToString();
                string catename = row["CategoryName"].ToString();
                string catedes = row["Description"].ToString();
                Category cate = new Category(cateID, catename, catedes);
                listC.Add(cate);
            }
            return listC;
        }
                public static int AddCateGories(ArrayList arrayList)
                {
            string sql = "INSERT INTO dbo.Categories( CategoryId ,CategoryName ,Description) VALUES ( @CategoryId ,  @CategoryName , @Description)";

            Category cate = new Category();
            foreach (Category item in arrayList)
            {
                cate.CatID = item.CatID;
                cate.CatName = item.CatName;
                cate.desc = item.desc;
            }

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@CategoryId", SqlDbType.Char);
            sqlParameters[0].Value = cate.CatID;
            sqlParameters[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar);
            sqlParameters[1].Value = cate.CatName;
            sqlParameters[2] = new SqlParameter("@Description", SqlDbType.NText);
            sqlParameters[2].Value = cate.desc;

            int abc = Database.ExecuteSQL(sql, sqlParameters);
            return abc;
        }
        
                public static int UpdateCateGories(ArrayList arrayList)
                {
            string sql = "UPDATE dbo.Categories SET CategoryName = @CategoryName, [Description] = @Description WHERE CategoryId = @CategoryId";

            Category cate = new Category();
            foreach (Category item in arrayList)
            {
                cate.CatID = item.CatID;
                cate.CatName = item.CatName;
                cate.desc = item.desc;
            }

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@CategoryId", SqlDbType.Char);
            sqlParameters[0].Value = cate.CatID;
            sqlParameters[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar);
            sqlParameters[1].Value = cate.CatName;
            sqlParameters[2] = new SqlParameter("@Description", SqlDbType.NText);
            sqlParameters[2].Value = cate.desc;

            int abc = Database.ExecuteSQL(sql, sqlParameters);
            return abc;
        }
               public static int DeleteCateGories(string cateID)
                {
            string sql = "DELETE dbo.Categories WHERE CategoryId = @CategoryId";
            Category cate = new Category();
            cate.CatID = cateID;

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@CategoryId", SqlDbType.Char);
            sqlParameters[0].Value = cate.CatID;
            int rs = Database.ExecuteSQL(sql, sqlParameters);
            return rs;
        }
        public static int DeleteListCateGoriesByID(ArrayList list)
        {
            int rs = 0;
            foreach (var item in list)
            {
                string sql = "DELETE dbo.Categories WHERE CategoryId = @CategoryId";
                SqlParameter[] sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@CategoryId", SqlDbType.Char);
                sqlParameters[0].Value = item;
                rs = Database.ExecuteSQL(sql, sqlParameters);
            }
            return rs;
        }
    }
}
