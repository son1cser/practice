using System;
using System.Collections.Generic;

namespace HackerRank
{
    public class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int primarySum = 0;
            int secondarySum = 0;
            int n = arr.Count;

            for (int i = 0; i < n; i++)
            {
                primarySum += arr[i][i];
                secondarySum += arr[i][n - 1 - i];
            }

            return Math.Abs(primarySum - secondarySum);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                RunLocalTests();
            }
        }

        private static void RunLocalTests()
        {
            Console.WriteLine("Running local tests for Task 8 (Diagonal Difference)...");
            
            List<List<int>> matrix = new List<List<int>>
            {
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6 },
                new List<int> { 10, 8, -12 }
            };

            int result = Result.diagonalDifference(matrix);
            if (result == 15)
            {
                Console.WriteLine("Test 1 Passed!");
            }
            else
            {
                Console.WriteLine("Test 1 Failed!");
            }
        }
    }
}