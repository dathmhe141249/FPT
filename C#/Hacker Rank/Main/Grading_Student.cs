using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class Grading_Student
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if(grades[i] < 38)
                {

                }
                else
                {
                    int diff = 5 - grades[i] % 5;
                    if (diff < 3)
                    {
                        grades[i] = grades[i] + diff;
                    }
                }
            }
            return grades;
        }
    }
}
