using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex9:
            string msg = "Fpt@university";
            Console.WriteLine(newString(msg,0));
            Console.WriteLine(newString(msg, 3));
            Console.WriteLine(newString(msg, msg.Length -1 ));
            // ex10
            string msg0 = "w3resource";
            string msg1 = "Python";

            Console.WriteLine(first_Last(msg0));
            Console.WriteLine(first_Last(msg1));
            // ex 11:
            string input = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            char[] charSe = {' '};
            string[] s = input.Split(charSe);
            int maxlength = 0;
            string rs = "";
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i].Length > maxlength) {
                    maxlength = s[i].Length;
                    rs = s[i];
                }
            }
            Console.WriteLine(rs);

            //ex12:
            string str = "Display the pattern like pyramid using the alphabet.";
            string rsStr = "";
            string[] splitStr = input.Split(charSe);
            for (int i = splitStr.Length -1 ; i >= 0 ; i--)
            {
                rsStr += splitStr[i] +" ";
                
            }
            Console.WriteLine(rsStr);
        }
        static string newString(string str, int n)
        {
            // remove từ vị trí n, remove 1 index
            return str.Remove(n,1);
        }
        static string first_Last(string msg)
        {
            string rs;
            if (msg.Length > 1)
            {
                rs = msg.Substring(msg.Length - 1) + msg.Substring(1,msg.Length-2)+msg.Substring(0,1);
                return rs;
            }
            else
            {
                return msg;
            }
        }
    }
}
