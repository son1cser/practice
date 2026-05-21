using System;
using System.Collections.Generic;

namespace HackerRank
{
    public class Result
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int highest = scores[0];
            int lowest = scores[0];
            
            int maxBreaks = 0;
            int minBreaks = 0;

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > highest)
                {
                    highest = scores[i];
                    maxBreaks++;
                }
                else if (scores[i] < lowest)
                {
                    lowest = scores[i];
                    minBreaks++;
                }
            }

            return new List<int> { maxBreaks, minBreaks };
        }
    }

    public class Programe
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
            Console.WriteLine("Running local tests for Task 9...");
            List<int> testScores = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 };

            List<int> result = Result.breakingRecords(testScores);
            if (result[0] == 2 && result[1] == 4)
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