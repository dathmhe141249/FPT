using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Object
{
    class Book
    {
        int id;
        String type;
        String author;

        public Book()
        {
        }

        public Book(int id, string type, string author)
        {
            this.id = id;
            this.type = type;
            this.author = author;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Book no: " + id +"/n" +"name: " + type +"/nAuthor: "+ author;
        }

    }
}
