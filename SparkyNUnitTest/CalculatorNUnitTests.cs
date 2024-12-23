using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Sparky
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calulator = new Calculator();

            //Act
            int result = calulator.AddNumbers(15, 35);

            //Assert
            ClassicAssert.AreEqual(50, result);
        }

        [Test]
        [TestCase(51)]
        [TestCase(57)]
        [TestCase(10051)]
        [TestCase(53)]
        public void IsOddCheck_InputOneInt_ReturnTrue(int a)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            bool validation = calculator.IsOddNumber(a);

            //Assert
            ClassicAssert.True(validation);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIsOdd(int a)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act and Assert
            return calculator.IsOddNumber(a);
        }

        [Test]
        [TestCase(5.4, 10.5)]    // 15.9
        [TestCase(5.43, 10.53)]  // 15.96
        [TestCase(5.49, 10.59)]  // 16.08

        public void AddTwoDoubles_InputTwoDoubles_GetCorrectAddition(double a, double b)
        {
            // Arrange
            Calculator calculator = new();

            // Act
            double result = calculator.AddNumbersDouble(a, b);

            // Assert
           ClassicAssert.AreEqual(15.9, result, 0.5); // The las argument is the delta value which acts like a buffer of the adding operation in this case


        }

    }
}
