using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q3_SU20_B5
{
    public class Book
    {
        private int id;
        private string title;
        private int year;
        private string des;

        public Book()
        {
        }

        public Book(int iD, string title, int year, string des)
        {
            ID = iD;
            this.Title = title;
            this.Year = year;
            this.Des = des;
        }

        public int ID { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int Year { get => year; set => year = value; }
        public string Des { get => des; set => des = value; }
    }
}