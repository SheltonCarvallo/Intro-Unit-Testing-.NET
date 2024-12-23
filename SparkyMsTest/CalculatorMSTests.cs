using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sparky;

namespace SparkyMsTest
{
    [TestClass]
    public class CalculatorMSTests
    {
        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arrange
            Calculator calulator = new Calculator();

            //Act
            int result = calulator.AddNumbers(15, 35);

            //Assert
            Assert.AreEqual(50, result);
        }
    }
}
