using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        // class or cookie cutter used to create object
        // constructor
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                //if (grade > stats.HighestGrade)
                //{
                //    stats.HighestGrade = grade;
                //}

                // or 

                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                // looping through grades
                sum += grade;
            }

            // Count lets you know how many grade are in grades
            stats.AverageGrade = sum / grades.Count;
            
            return stats;
        }


        public void AddGrade(float grade)
        {
            //store grade need access to it outside 
            grades.Add(grade);
        }


        // classes that allow you to store multiple things
        // what is it storing?
        // when you go public, do uppercase
        private List<float> grades;
    }
}
