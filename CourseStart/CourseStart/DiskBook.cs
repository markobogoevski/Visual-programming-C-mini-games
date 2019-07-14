using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStart
{
    class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event InMemoryBook.GradeIsAdded gradeIsAdded;

        public override void addGrade(double grade)
        {
            using (StreamWriter writer = File.AppendText($"{nameof(Name)}.txt"))
            {
                writer.WriteLine(grade);
                if (gradeIsAdded != null)
                {
                    gradeIsAdded(this,new EventArgs());
                }
            }
        }

        public override StatisticDisplayer computeStatistics()
        {
            StatisticDisplayer statistic = new StatisticDisplayer();
            using(StreamReader reader = File.OpenText($"{nameof(Name)}.txt"))
            {
                string line;
                while ((line=reader.ReadLine())!=null)
                {
                    line = line.Trim();
                    statistic.enrollGrade(double.Parse(line));
                }
            }
            return statistic;
        }
    }
}
