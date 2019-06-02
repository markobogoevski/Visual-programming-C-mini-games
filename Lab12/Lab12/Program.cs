using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Enter number of elements: ");
            N=int.Parse(Console.ReadLine());
            List<double> numbers = new List<double>();

            Console.WriteLine("Do you want to enter the numbers manually or would you rather have them " +
                "randomly generated for you (integer numbers in the range 1-1000) ? ('y'-for manual, 'n'-for automatic)");

            char c = char.Parse(Console.ReadLine());
            if (c == 'y')
            { 
                for (int i = 0; i < N; i++)
                    numbers.Add(double.Parse(Console.ReadLine()));
            }
            else
            {
                Random random = new Random();
                for (int i = 0; i < N; i++)
                    numbers.Add(random.Next(1, 1001));
            }

            
            Console.WriteLine("Average of entered numbers is {0:F3}, max is {1} and min is {2}.", numbers.Average(), numbers.Max(), numbers.Min());
            Console.ReadKey();



            // SMENETA OD POSLEDNO BARANJE DOLE
            /*
            double max, min;
            maximum(numbers, out max);
            minimum(numbers, out min);

            Console.WriteLine("Average of entered numbers is {0:F3}, max is {1} and min is {2}.", average(numbers), max, min);
            Console.ReadKey();*/

        }

        /*
        public static void maximum(List<double> numbers,out double maximum)
        {
            maximum = numbers.ElementAt(0);
            foreach (double number in numbers)
                if (number > maximum)
                    maximum = number;

        }
        public static void minimum(List<double> numbers,out double minimum)
        {
            minimum = numbers.ElementAt(0);
            foreach (double number in numbers)
                if (number < minimum)
                    minimum = number;
        }
        public static double average(List<double>numbers)
        {
            double avg = 0;
            foreach (double number in numbers)
                avg += number;
            avg /= numbers.Count;
            return avg;
        }
        */
    }

    
}
