using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        public virtual string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            string result = $" Angry Employee Worked {weeklyHours} hrs." +
                $"Paid for 40 hrs at ${wage}" +
                $"/hr = ${salary}";
            Console.WriteLine("\n"+result+"\n");
            Console.WriteLine("*******************************************\n");
            return result;
        }
    }

    public class Contractor : Employee 
    {
        public override string CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;

            string result = $"This Happy Contractor Worked {weeklyHours} hrs." +
                $"Paid for {weeklyHours} hrs at ${wage}" +
                $"/hr = ${salary}";
            Console.WriteLine("\n" + result + "\n");
            Console.WriteLine("*******************************************\n");
            return result;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            const int hours = 55, wage = 70;

            var mock = new Mock<Utils>();
            mock.Setup(m => m.GetMockEmployee()).Returns(() => new List<Employee>()
            {
                new Employee(),
                new Contractor()
            });

            List<Employee> employees = mock.Object.GetMockEmployee();

            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }
    }

    public class Utils
    {
        //public static List<Employee> GetEmployees()
        //{
        //    var employees = new Employee();
        //    var contractors = new Contractor();

        //    return new List<Employee> { employees, contractors };

        //}

        public virtual List<Employee> GetMockEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
