using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericClass2
{
    class MyCollection<T>
    {
        /* Cách 1: của Đạt :D
          T[] type = new T[1000];
        int length = 0;
        public void Add(T obj)
        {
            type.SetValue(obj,length);
            length++;
        }

        public void Add(T obj, int index)
        {
            for (int i = length; i > index; i--)
            {
                type[i] = type[i - 1];
            }
            // chen:
            type[index] = obj;
            length++;
        }

        public void DisplayItems()
        {
            Console.WriteLine("Items in my collection");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(type[i]);
            }
        }*/
        // cách 2:
        List<T> list = new List<T>();

        public MyCollection()
        {
        }

        public MyCollection(List<T> list)
        {
            this.list = list;
        }

        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Add(T obj, int k)
        {
            list.Insert(k,obj);
        }
        public void DisplayItems()
        {
            Console.WriteLine("Items in my collection");
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
