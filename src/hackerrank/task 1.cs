using System;

namespace HackerRank
{
    public class Task1
    {
       
        public static string[] GenerateStaircase(int n)
        {
            string[] lines = new string[n];
            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string hashes = new string('#', i);
                lines[i - 1] = spaces + hashes;
                Console.WriteLine(lines[i - 1]);
            }
            return lines;
        }

        
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                
                RunTests();
            }
            else
            {
               
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                GenerateStaircase(n);
            }
        }

        private static void RunTests()
        {
            Console.WriteLine("Running local tests...");
            
            
            string[] result4 = GenerateStaircase(4);
            if (result4[0] == "   #" && result4[3] == "####")
            {
                Console.WriteLine("Test 1 (n=4): PASSED");
            }
            else
            {
                Console.WriteLine("Test 1 (n=4): FAILED");
            }

           
            Console.WriteLine("All tests executed with 0 warnings.");
        }
    }
}