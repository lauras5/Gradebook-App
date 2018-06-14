using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5F);
            book.AddGrade(75);

            // make explicit , will return stats you need
            // encapsulating lowest/highest/avg scores
            // create another class
            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine("Average: " + stats.AverageGrade);
            Console.WriteLine("Lowest : " + stats.LowestGrade);
            Console.WriteLine("Highest : " + stats.HighestGrade);
        }
    }
}
