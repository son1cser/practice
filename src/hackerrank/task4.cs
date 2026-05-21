using System;
using System.Collections.Generic;

namespace HackerRank
{
    public class Task4
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>();

            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    roundedGrades.Add(grade);
                }
                else
                {
                    int nextMultipleOfFive = ((grade / 5) + 1) * 5;

                    if (nextMultipleOfFive - grade < 3)
                    {
                        roundedGrades.Add(nextMultipleOfFive);
                    }
                    else
                    {
                        roundedGrades.Add(grade);
                    }
                }
            }

            return roundedGrades;
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
                List<int> grades = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    grades.Add(Convert.ToInt32(Console.ReadLine().Trim()));
                }

                List<int> result = gradingStudents(grades);
                foreach (int res in result)
                {
                    Console.WriteLine(res);
                }
            }
        }

        private static void RunTests()
        {
            Console.WriteLine("Running local tests for Task 4...");

            List<int> inputGrades = new List<int> { 73, 67, 38, 33 };
            List<int> result = gradingStudents(inputGrades);

            if (result[0] == 75 && result[1] == 67 && result[2] == 40 && result[3] == 33)
            {
                Console.WriteLine("Test 1 (Sample Input): PASSED");
            }
            else
            {
                Console.WriteLine("Test 1 (Sample Input): FAILED");
            }

            Console.WriteLine("All tests executed with 0 warnings.");
        }
    }
}