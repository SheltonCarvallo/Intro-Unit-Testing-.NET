using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {

        //Global Initialization for class
        private Customer customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        public void CombineName_InputFirstAndLastName_ReturnGreetingAndFullName()
        {
            //Arrange
            //Customer customer = new Customer();

            //Act
            customer.GreetAndCombineNames("Ben", "Spark");

            //Assert
            //Assert.Multiple allows you to check all the Asserts and not block the testing if one fails
            Assert.Multiple(() =>
            {
                Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
                Assert.That(customer.GreetMessage, Does.Contain(",")); //CaseSensitive
                Assert.That(customer.GreetMessage, Does.Contain("spark").IgnoreCase); // It's not case sensitive
                Assert.That(customer.GreetMessage, Does.StartWith("He"));
                Assert.That(customer.GreetMessage, Does.EndWith("k"));
                Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
            });
           
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull()
        {
            // Arrange
            //Customer customer = new Customer();

            // Act

            //Assert
            Assert.That(customer.GreetMessage, Is.Null);
        }

        [Test]
        public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
        {
            int result = customer.Discount;
            Assert.That(result, Is.InRange(10, 25));
        }

    }
}
