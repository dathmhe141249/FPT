using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexTryCatch
{
    class Student
    {
        private int roll;
        private string email;
        private string name;

        public Student()
        {
        }

        public Student(int roll, string email, string name)
        {
            this.roll = roll;
            this.email = email;
            this.name = name;
        }

        public int Roll { get => roll; set => roll = value; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }

        
    }
}
