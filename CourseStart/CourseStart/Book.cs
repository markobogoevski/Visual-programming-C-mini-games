using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CourseStart.InMemoryBook;

namespace CourseStart
{
    public abstract class Book : NamedObject, IBook
    {
        public Book(string name) : base(name)
        {
        }

        public new string Name { get; set; }

        public abstract event GradeIsAdded gradeIsAdded;

        public abstract void addGrade(double grade);

        public abstract StatisticDisplayer computeStatistics();
    }
}
