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
            string result = string.Format(" Angry Employee Worked {0} hrs." +
                "Paid for 40 hrs at ${1}" +
                "/hr = ${2} ", weeklyHours, wage, salary);
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
            
            string result = string.Format("\n This Happy Contractor Worked {0} hrs." +
                "Paid for {0} hrs at ${1}" +
                "/hr = ${2} \n", weeklyHours, wage, salary);
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
            List<Employee> employees = GetEmployees();

            foreach (var e in employees)
            {
                e.CalculateWeeklySalary(hours, wage);
            }
        }

        private static List<Employee> GetEmployees()
        {
            var employees = new Employee();
            var contractors = new Contractor();

            return new List<Employee> { employees, contractors };

        }
    }
}
