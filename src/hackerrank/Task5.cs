using System;

namespace HackerRank
{
    public class Result
    {
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
           
            if (v1 <= v2)
            {
                return "NO";
            }

            
            if ((x2 - x1) % (v1 - v2) == 0)
            {
                return "YES";
            }

            return "NO";
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
            Console.WriteLine("Running local tests for Task 5 (Kangaroo)...");
            
            
            string res1 = Result.kangaroo(0, 3, 4, 2);
            Console.WriteLine(res1 == "YES" ? "Test 1 Passed!" : "Test 1 Failed!");

          
            string res2 = Result.kangaroo(0, 2, 5, 3);
            Console.WriteLine(res2 == "NO" ? "Test 2 Passed!" : "Test 2 Failed!");
        }
    }
}