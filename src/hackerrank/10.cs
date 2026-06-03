using System;

namespace HackerRank
{
    public class Result
    {
        public static int pageCount(int n, int p)
        {
            int fromFront = p / 2;
            int fromBack = (n / 2) - (p / 2);

            return Math.Min(fromFront, fromBack);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0) RunLocalTests();
        }

        private static void RunLocalTests()
        {
            int result = Result.pageCount(6, 2);
            Console.WriteLine(result == 1 ? "Test 1 Passed!" : "Test 1 Failed!");
        }
    }
}