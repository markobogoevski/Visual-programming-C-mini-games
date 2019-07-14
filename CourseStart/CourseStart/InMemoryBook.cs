using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CourseStart.InMemoryBook;

namespace CourseStart
{ 
    public class InMemoryBook : Book
    {
        public delegate void GradeIsAdded(object sender, EventArgs args);
        public override event GradeIsAdded gradeIsAdded;

        private List<double> grades { get; set; }
       
        public int pages;

        public InMemoryBook(string bookName):base(bookName)
        {
            pages = 100;
         //   grades = new List<double>();
        }

        public void setPages(int pages) { this.pages = pages; }
     
        public override void addGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if (gradeIsAdded != null)
                {
                    gradeIsAdded(this, new EventArgs());
                }
            }
            else
                throw new ArgumentException($"Invalid {nameof(grade)}!");
        }

        public override StatisticDisplayer computeStatistics()
        {
            StatisticDisplayer statisticDisplayer = new StatisticDisplayer();
            foreach (var grade in grades)
            {
                statisticDisplayer.enrollGrade(grade);
            }
            return statisticDisplayer;
        }
    }
}
