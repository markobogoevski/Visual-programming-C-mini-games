using ACME.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACME.BL.Tests
{
    [TestClass]
    public class CalculateStepPercentTest
    {
        [TestMethod]
        public void TestLowValidInput()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "1";
            var actualCountTest = "0";
            decimal expected = 0M;
            //act
            var actual = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            //assert
            Assert.AreEqual(expected, actual,"0.1");
        }

        [TestMethod]
        public void TestMiddleValidInput()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "5000";
            var actualCountTest = "2531";
            decimal expected = 50.62M;
            //act
            var actual = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHighValidInput()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "99999";
            var actualCountTest = "99000";
             decimal expected = 99M;
            //act
            var actual = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEdgeCaseInvalidInput()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "-3";
            var actualCountTest = "0";
            var expected = "Goal step must be greater than 0," +
                  "and actual step must be lower than goal!";
            //act
            string actual = "";
            try
            {
                var res = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }catch(ArgumentException exception)
            {
                actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMiddleInvalidInput()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "-50";
            var actualCountTest = "-40";
            var expected = "Goal step must be greater than 0," +
                  "and actual step must be lower than goal!";
            //act
            string actual = "";
            try
            {
                testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHighInvalidInput()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "-100";
            var actualCountTest = "-200";
            var expected = "Goal step must be greater than 0," +
                  "and actual step must be lower than goal!";
            //act
            string actual = "";
            try
            {
                var res = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }
            catch (ArgumentException exception)
            {
                actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestForActualStepIsNull()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "1";
            string actualCountTest = null;
            var expected = "Actual step count must be entered";
            //act
            try
            {
                var res = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }
            catch (ArgumentException exception)
            {
                var actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGoalStepIsNull()
        {
            //arrange
            var testCustomer = new Customer();
            string goalCountTest = null;
            var actualCountTest = "0";
            var expected = "Goal must be entered";
            //act
            try
            {
                var res = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }
            catch (ArgumentException exception)
            {
               var actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfActualIsNumber()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "1";
            var actualCountTest = "gas1a--12x";
            var expected = "Actual steps must be numeric";
            //act
            try
            {
                var res = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }
            catch (ArgumentException exception)
            {
                var actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfGoalIsNumber()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "111 11";
            var actualCountTest = "0";
            var expected = "Goal must be numeric";
            //act
            try
            {
                var res = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }
            catch (ArgumentException exception)
            {
                var actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfGoalIs0()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "0";
            var actualCountTest = "0";
            var expected = "Goal step must be greater than 0," +
                  "and actual step must be lower than goal!";
            //act
            try
            {
                var res = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }
            catch (ArgumentException exception)
            {
                var actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfValidValuesForActual()
        {
            //arrange
            var testCustomer = new Customer();
            var goalCountTest = "1";
            var actualCountTest = "21";
            var expected = "Goal step must be greater than 0," +
                  "and actual step must be lower than goal!";
            //act
            try
            {
                var res = testCustomer.CalculatePercentOfGoalSteps(goalCountTest, actualCountTest);
            }
            catch (ArgumentException exception)
            {
                var actual = exception.Message;
                Assert.AreEqual(actual, expected);
                throw;
            }
            //assert
        }




    }
}
