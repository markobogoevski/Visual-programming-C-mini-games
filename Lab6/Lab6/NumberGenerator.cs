using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class NumberGenerator
    {
        Random generator { get; set; }
        public NumberGenerator()
        {
            generator = new Random();
        }

        public Equation getNewEquation()
        {
            int FirstOperand = generator.Next(-20, 21); //generating a number from -5000 to 5001
            int SecondOperand;
            while (true)
            {
                SecondOperand = generator.Next(-20, FirstOperand+1);
                if (SecondOperand == 0)
                    continue;

                if (FirstOperand % SecondOperand == 0)
                    break;
            }
            char[] signs = { '+', '-', '/', '*' };
            int picker = generator.Next(4);
            char Operator = signs[picker];

            return new Equation(FirstOperand, Operator, SecondOperand);
        }
    }
}
