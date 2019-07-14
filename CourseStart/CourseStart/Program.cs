using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStart
{

    class Program
    { 
        static void OnGradeAdded(object sender,EventArgs e)
        {
            Console.WriteLine("EVENT HANDLED!");
        }
         static void Main(string[] args)
        {

            IBook book = new InMemoryBook("My book");
            book.gradeIsAdded += OnGradeAdded;
            EnterGrades(book);
            Console.Write(book.computeStatistics());
            Console.ReadKey();
        }

        private static void EnterGrades(IBook book)
        {
            string input;
            while (true)
            {
                Console.WriteLine("Enter a grade: ");
                input = Console.ReadLine();
                if (input.ToLower() == "x")
                    break;
                try
                {
                    book.addGrade(double.Parse(input));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
