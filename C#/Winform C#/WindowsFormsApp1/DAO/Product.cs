using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1.DAO
{
    class Product
    {
        string productID;
        string productName;
        string cateID;
        string unit;
        int price;
        int quantity;
        byte discontinued;
        DateTime date;

        public Product(string productID, string productName, string cateID, string unit, int price, int quantity, byte discontinued, DateTime date)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.CateID = cateID;
            this.Unit = unit;
            this.Price = price;
            this.Quantity = quantity;
            this.Discontinued = discontinued;
            this.Date = date;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string CateID { get => cateID; set => cateID = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public byte Discontinued { get => discontinued; set => discontinued = value; }
        public DateTime Date { get => date; set => date = value; }

        public static List<Product> GetProducts()
        {
            List<Product> listC = new List<Product>();
            DataTable dataTable = Database.GetDataBySQL("select* from Products");
            foreach (DataRow row in dataTable.Rows)
            {
                string pID = row["ProductId"].ToString();
                string ProductName = row["ProductName"].ToString();
                string cateName = row["CategoryID"].ToString();
                string unit = row["Unit"].ToString();
                int price = Convert.ToInt32(row["Price"].ToString());
                int quantity = Convert.ToInt32(row["Quantity"].ToString());
                byte discon = Convert.ToByte(row["Discontinued"].ToString());
                DateTime date = Convert.ToDateTime(row["CreateDate"].ToString());
                Product product = new Product(pID,ProductName,cateName, unit,price,quantity,discon,date);
                listC.Add(product);
            }
            return listC;
        }
    }
}
