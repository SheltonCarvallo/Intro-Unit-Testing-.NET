﻿using System;
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
        [Test]
        public void CombineName_InputFirstAndLastName_ReturnGreetingAndFullName()
        {
            //Arrange
            Customer customer = new Customer();

            //Act
            customer.GreetAndCombineNames("Ben", "Spark");

            //Assert
            Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
            Assert.That(customer.GreetMessage, Does.Contain(","));
            Assert.That(customer.GreetMessage, Does.Contain("spark").IgnoreCase); // It's not case sensitive
            Assert.That(customer.GreetMessage, Does.StartWith("He"));
            Assert.That(customer.GreetMessage, Does.EndWith("k"));
            Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnNull()
        {
            // Arrange
            Customer customer = new Customer();

            // Act

            //Assert
            Assert.That(customer.GreetMessage, Is.Null);
        }

    }
}
