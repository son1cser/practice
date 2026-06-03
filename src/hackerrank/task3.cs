using System;
using System.Collections.Generic;

namespace HackerRank
{
    public class Result
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
    }
}