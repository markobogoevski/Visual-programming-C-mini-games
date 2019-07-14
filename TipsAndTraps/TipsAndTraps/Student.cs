using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipsAndTraps
{
    [DebuggerDisplay("This is {Name}, aged {Age} with an average" +
        "grade of {Average} !")]
    public class Student
    {
        public int Age { get; set; }
        public decimal Average { get; set; }
        public string Name { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public List<int> Grades { get; set; } = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

        public Student(int age, decimal average, string name)
        {
            Age = age;
            Average = average;
            Name = name;
        }

        public Student()
        {
        }
    }
}
