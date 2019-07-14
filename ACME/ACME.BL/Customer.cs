using ACME.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }

        public OperationResult ValidateEmail()
        {
            var result = new OperationResult();

            if (string.IsNullOrWhiteSpace(Email))
            {
                result.Success = false;
                result.AddErrorMessage("Email must be valid format!");
            }

            var isValidFormat = true;
            if (!isValidFormat)
            {
                result.Success = false;
                result.AddErrorMessage("Email must be valid format!");
            }
           
            var isRealDomain = true;
            if (!isRealDomain)     
            {
                result.Success = false;
                result.AddErrorMessage("Email must represent a valid domain!");
            }
            return result;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal actualStepCount;
            decimal goalStepCount;

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual step count must be entered");

            if(!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric");
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual steps must be numeric");

            return CalculatePercentOfGoalSteps(goalStepCount,actualStepCount);
        }

        private decimal CalculatePercentOfGoalSteps(decimal goalSteps, decimal actualSteps)
        {
            if (!(goalSteps > 0 && actualSteps <= goalSteps && actualSteps >= 0)) throw new ArgumentException("Goal step must be greater than 0," +
                  "and actual step must be lower than goal!");
            return Math.Round((actualSteps / goalSteps) * 100,2);
        }
    }
}
