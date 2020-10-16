using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_assessment1.View
{
    class Printer
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        public static void PrintMatrix(int[][] matrix, int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
