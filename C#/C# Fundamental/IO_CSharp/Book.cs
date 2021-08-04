using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO_CSharp
{
    class Book
    {
        private int id;
        private String type;
        private String author;

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Author { get => author; set => author = value; }

        public Book()
        {
        }

        public Book(int id, string type, string author)
        {
            this.Id = id;
            this.Type = type;
            this.Author = author;
        }

        public override string ToString()
        {
            return "Book no: " + Id + "\n" + "name: " + Type + "\nAuthor: " + Author;
        }

    }
}
