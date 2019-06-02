using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class IllegalOperator:Exception
    {
        char Operator { get; set; }
        public IllegalOperator(char Operator):base(Operator.ToString())
        {
            this.Operator = Operator;
        }
    }
    public class Equation : IEquatable<Equation>
    {
        public int FirstOperand { get; set; }
        public char Operator { get; set; }
        public int SecondOperand { get; set; }
        public int result { get; set; }

        public Equation(int firstOperand, char @operator, int secondOperand)
        {
            FirstOperand = firstOperand;
            Operator = @operator;
            SecondOperand = secondOperand;
            switch (Operator)
            {
                case '+':
                    result = FirstOperand + SecondOperand;
                    break;
                case '-':
                    result = FirstOperand - SecondOperand;
                    break;
                case '/':
                    result = FirstOperand / SecondOperand;
                    break;
                case '*':
                    result = FirstOperand * SecondOperand;
                    break;
                default:
                    throw new IllegalOperator(Operator);

            }
        }

        public bool tryGuess(int guess)
        {
            return guess == result;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Equation);
        }

        public bool Equals(Equation other)
        {
            return other != null &&
                   FirstOperand == other.FirstOperand &&
                   Operator == other.Operator &&
                   SecondOperand == other.SecondOperand;
        }

        public override int GetHashCode()
        {
            var hashCode = -655746530;
            hashCode = hashCode * -1521134295 + FirstOperand.GetHashCode();
            hashCode = hashCode * -1521134295 + Operator.GetHashCode();
            hashCode = hashCode * -1521134295 + SecondOperand.GetHashCode();
            return hashCode;
        }
    }
}
