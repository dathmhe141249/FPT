using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibCore
{
    public class Parent
    {
        public int a;
        public int b;
        public void PublicMethod() { }

        //chỉ đc dùng trong đúng class đấy
        private void PrivateMethod() { }

        //chỉ đc dùng trong lớp con
        protected void ProtectedMethod() { }

       internal void InternalMethod() { }

        protected internal void ProtectedInternalaMethod() { }
    }
}
