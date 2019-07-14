using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStart
{
    public class StatisticDisplayer
    {
        public double High { get; private set; }
        public double Low { get; private set; }
        private double Sum { get;set; }
        public double Average
        {
            get
            {
                return Sum / Count;
            }
            private set { }
        }

        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var grade when grade >= 90:
                        return 'A';
                    case var grade when grade >= 80:
                        return 'B';
                    case var grade when grade >= 70:
                        return 'C';
                    case var grade when grade >= 60:
                        return 'D';
                    default:
                        return 'F';
                }
            }
            private set { }
        }

        public int Count { get; private set; }

        public StatisticDisplayer(){
            High = double.MinValue;
            Low = double.MaxValue;
            Sum = Average = 0;
            Letter = 'F';
        }

        public void enrollGrade(double grade)
        {
            High = Math.Max(High,grade);
            Low = Math.Min(Low, grade);
            Sum += grade;
            Count++;
        }

        public override String ToString()
        {
            return $"Highest grade is {High:N1}, lowest grade is {Low:N1}, " +
                $"and average grade is {Average:N1}!\n";
        }

    }
}
