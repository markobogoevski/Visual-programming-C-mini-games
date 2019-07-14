using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] developers = new Employee[]
            {
                new Employee
                {
                    Id=1,
                    Name="Scott"
                },
                new Employee
                {
                    Id=2,
                    Name="Chris"
                }
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{Id=3, Name="Alex"}
            };

            var query = from developer in developers
                        where developer.Name.Length == 5
                        orderby developer.Name
                        select developer;

        }
    }
}
