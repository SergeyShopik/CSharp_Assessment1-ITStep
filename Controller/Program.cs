
/*Assessment task1: Fundamentals
Student: Sergey Shopik
Variant: 4
Date (issued): 15.10.2020
Date (done): 16.10.2020*/

using System;
using static C_sharp_assessment1.View.Printer;
using static Assessment1_library.BusinessLogic;

namespace C_sharp_assessment1
{
    class Program
    {
        const int ARRAY_SIZE = 10;
        const int RANGE_OF_RANDOM = 5;

        const int ROWS = 3;
        const int COLUMNS = 3;
        public static void Main()
        {
            int size = ARRAY_SIZE;
            int[] arr = InitArray(size, RANGE_OF_RANDOM);

            Console.Write("Initial array: ");
            PrintArray(arr);

            //task 1
            Console.WriteLine("Sum = " + FindSumOfPositiveElements(arr));

            //task 2
            int[] revArr = ReverseArray(arr);
            Console.Write("Reverse array: ");
            PrintArray(revArr);

            //task 3
            int[][] matrix = InitMatrix(ROWS, COLUMNS, RANGE_OF_RANDOM);

            Console.WriteLine("Initial matrix: ");
            PrintMatrix(matrix, ROWS, COLUMNS);

            SortMatrixColumns(matrix, ROWS, COLUMNS);
            Console.WriteLine("Sorted matrix: ");
            PrintMatrix(matrix, ROWS, COLUMNS);

            Console.WriteLine("Num of equal elements in matrix columns: ");
            PrintArray(CountEqualElememtsInMatrixColumns(matrix, ROWS, COLUMNS));

            Console.WriteLine("Number of column: "
                + FindMatrixColumnWithMostEqualElements(matrix, ROWS, COLUMNS));

        }
    }
}
