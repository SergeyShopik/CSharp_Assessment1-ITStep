using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment1_library
{
    public class BusinessLogic
    {
        const int DEFAULT_ARRAY_SIZE = 1;
        public static int[] InitArray(int size, int range)
        {
            if (size < DEFAULT_ARRAY_SIZE)
            {
                size = DEFAULT_ARRAY_SIZE;
                Console.WriteLine("Array size error: size must be larger than zero." +
                    "\n size set to DEFAULT_ARRAY_SIZE");
            }
            Random rand = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(range);
            }
            return arr;
        }
        public static int[][] InitMatrix(int rows, int columns, int range)
        {
            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = InitArray(columns, range);
            }

            return matrix;
        }
        //task1-----------------------------------------------------------------------
        public static int FindSumOfPositiveElements(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                if (item > 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        //task2-----------------------------------------------------------------------
        public static int[] ReverseArray(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int j = 0, i = arr.Length - 1; j < result.Length && i >= 0; j++, i--)
            {
                result[j] = arr[i];
            }
            return result;
        }

        //task3-----------------------------------------------------------------------
        //first sort matrix columns, then count the largest series of equal elements
        //for each column, and finally find column with the largest series
        public static void SortMatrixColumns(int[][] matrix, int rows, int columns)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows; i++)
                { 
                    for (int k = i + 1; k < rows; k++)
                    {
                        int temp = matrix[i][j];
                        if (temp > matrix[k][j])
                        {
                            matrix[i][j] = matrix[k][j];
                            matrix[k][j] = temp;
                        }
                    }
                }
            }
        }
        public static int[] CountEqualElememtsInMatrixColumns(int[][] matrix, int rows, int columns)
        {
            SortMatrixColumns(matrix, rows, columns);

            int[] result = new int[columns];
            int count = 0;
            int maxCount = 0;

            for (int j = 0; j < columns; j++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    if (matrix[i][j] == matrix[i + 1][j])//count series
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;//if series is broken
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                if (maxCount == 0)//if no series were found
                {
                    result[j] = 0;
                }
                else
                {
                    result[j] = ++maxCount;//adjust maxCount cause count starts with zero
                }
                count = 0;
                maxCount = 0;
            }
            return result;
        }
        //not passing
        public static int FindMatrixColumnWithMostEqualElements(int[][] matrix, int rows, int columns)
        {
            int[] arr = CountEqualElememtsInMatrixColumns(matrix, rows, columns);
            int index = 0;
            int maxElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
