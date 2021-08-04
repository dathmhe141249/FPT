using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Console.WriteLine("Enter number");
            b.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter tilte");
            b.Type = Console.ReadLine();
            Console.WriteLine("Enter author: ");
            b.Author = Console.ReadLine();

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
