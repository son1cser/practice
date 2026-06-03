using System;
using System.Collections.Generic;

namespace HackerRank
{
    public class Result
    {
        public static int sockMerchant(int n, List<int> ar)
        {
            HashSet<int> unmatchedSocks = new HashSet<int>();
            int pairs = 0;

            foreach (int sock in ar)
            {
                if (unmatchedSocks.Contains(sock))
                {
                    pairs++;
                    unmatchedSocks.Remove(sock);
                }
                else
                {
                    unmatchedSocks.Add(sock);
                }
            }

            return pairs;
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
            List<int> socks = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = Result.sockMerchant(9, socks);
            Console.WriteLine(result == 3 ? "Test 1 Passed!" : "Test 1 Failed!");
        }
    }
}