using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CourseStart.InMemoryBook;

namespace CourseStart
{
    interface IBook
    {
        void addGrade(double grade);
        StatisticDisplayer computeStatistics();
        string Name { get; }
        event GradeIsAdded gradeIsAdded;
    }
}
