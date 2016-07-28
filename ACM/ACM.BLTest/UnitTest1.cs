using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bill";
            customer.LastName = "Bags";

            string expected = "Bags, Bill";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = null;
            customer.LastName = "Bags";

            string expected = "Bags";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bill";
            customer.LastName = "";

            string expected = "Bill";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "bilbo";
            Customer.instanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.instanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Gandalf";
            Customer.instanceCount += 1;

            //Act
            //Assert
            Assert.AreEqual(3, Customer.instanceCount);
        }

        [TestMethod]
        public void ValidateTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.LastName = "Test1";
            c1.EmailAddress = "TestFirst";

            var expected = true;

            //Act
            var actual = c1.Validate();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.EmailAddress = "TestFirst";

            var expected = false;

            //Act
            var actual = c1.Validate();
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
