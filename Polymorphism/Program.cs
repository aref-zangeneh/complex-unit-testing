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
            List<Employee> employees = Utils.GetEmployees();

            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }
    }

    public static class Utils
    {
        public static List<Employee> GetEmployees()
        {
            var employees = new Employee();
            var contractors = new Contractor();

            return new List<Employee> { employees, contractors };

        }
    }
}
