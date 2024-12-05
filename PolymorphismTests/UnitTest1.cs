using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polymorphism;
using System;

namespace PolymorphismTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursReturns2800Dollars()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;

            Employee employee = new Employee();
            string expectedResponse = string.Format(" Angry Employee Worked {0} hrs." +
                "Paid for 40 hrs at ${1}" +
                "/hr = ${2}", weeklyHours, wage, salary);
            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(expectedResponse, response); // Reordered parameters for clarity
        }


        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursReturns2800Dollars()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;

            Contractor contractor = new Contractor();
            string expectedResponse = string.Format("This Happy Contractor Worked {0} hrs." +
                "Paid for {0} hrs at ${1}" +
                "/hr = ${2}", weeklyHours, wage, salary);
            // Act
            string response = contractor.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForEmployeeTest_70wage55hoursDoesNotReturnCorrectString()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = 40 * wage;

            Employee employee = new Employee();
            string expectedResponse = string.Format("Problem 1 - Angry Employee Worked {0} hrs." +
                "Paid for 40 hrs at ${1}" +
                "/hr = ${2} ", weeklyHours, wage, salary);
            // Act
            string response = employee.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(response, expectedResponse);
        }

        [TestMethod]
        public void CalculateWeeklySalaryForContractorTest_70wage55hoursDoesNotReturnCorrectString()
        {
            // Arrange
            int weeklyHours = 55;
            int wage = 70;
            int salary = weeklyHours * wage;

            Contractor contractor = new Contractor();
            string expectedResponse = string.Format("Problem 2 -This Happy Contractor Worked {0} hrs." +
                "Paid for {0} hrs at ${1}" +
                "/hr = ${2} \n", weeklyHours, wage, salary);
            // Act
            string response = contractor.CalculateWeeklySalary(weeklyHours, wage);

            // Assert
            Assert.AreNotEqual(response, expectedResponse);
        }
    }
}
