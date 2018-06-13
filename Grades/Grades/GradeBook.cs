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

        public void AddGrade(float grade)
        {
            //store grade need access to it outside 
            grades.Add(grade);
        }


        // classes that allow you to store multiple things
        // what is it storing?
        List<float> grades;
    }
}
