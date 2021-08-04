using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  2 loại mảng 2 chiều : vuông(số cột trong hàng = nhau) / zigzag
            // mảng vuông:
            int[,] matrix = new int[10,8];
            bool[,] smt = new bool[5,5];

            int row = matrix.GetLength(0); // so hang
            int rol = matrix.GetLength(1);// so cot

            //hiển thị gtri
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            // mảng zigzag:
            int[][] zigzag = new int[10][];
            for (int i = 0; i < zigzag.Length; i++)
            {
                zigzag[i] = new int[i + 1]; 
            }

            int row1 = zigzag.Length; // so hang
            int colOfRow0 = zigzag[0].Length; // so cot hang 0

            //hiển thị gtri
            for (int i = 0; i < zigzag.Length; i++)
            {
                for (int j = 0; j < zigzag[i].Length; j++)
                {
                    Console.Write(zigzag[i][j]+" ");
                }
                Console.WriteLine();
            }
            string[][] abc;
        }
    }
}
