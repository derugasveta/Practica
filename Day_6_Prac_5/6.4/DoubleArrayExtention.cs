using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    internal static class DoubleArrayExtention
    {
        public static int CalcRow(this int [,] matrix , int row)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
               sum = sum+ matrix[row, j];


            }
            return sum;
        }
        public static int CalcCol(this int[,] matrix, int col)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sum = sum+  matrix[i,col];
            }
            return sum;
        }

    }
}
