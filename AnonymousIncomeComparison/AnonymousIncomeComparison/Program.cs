using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Person 1
            Console.WriteLine("Person 1");
            Console.ReadLine();

            //Hourly Rate for Person 1.
            Console.WriteLine("What is your hourly rate?");
            string hourly = Console.ReadLine();
            int hourlyRate = Convert.ToInt32(hourly);


            //Hours Worked for Person 1.
            Console.WriteLine("How many hours a week do you work?");
            string hoursWeek = Console.ReadLine();
            int hoursPerWeek = Convert.ToInt32(hoursWeek);


            //Person 2
            Console.WriteLine("Person 2");
            Console.ReadLine();

            //Hourly Rate for Person 2.
            Console.WriteLine("What is your hourly rate?");
            string hourly2 = Console.ReadLine();
            int hourlyRate2 = Convert.ToInt32(hourly2);

            //Hours Worked for Person 2.
            Console.WriteLine("How many hours a week do you work?");
            string hoursWeek2 = Console.ReadLine();
            int hoursPerWeek2 = Convert.ToInt32(hoursWeek2);

            //Weekly Salary for Person 1.
            int totalSalary1 = hourlyRate * hoursPerWeek;
            Console.WriteLine("Weekly Salary of Person 1");
            Console.ReadLine();
            Console.WriteLine(totalSalary1);
            Console.ReadLine();

            //Weekly Salary for Person 2.
            int totalSalary2 = hourlyRate2 * hoursPerWeek2;
            Console.WriteLine("Weekly Salary of Person 2");
            Console.ReadLine();
            Console.WriteLine(totalSalary2);
            Console.ReadLine();

            //Does Person 1 make more than Person 2?
            bool person1More = totalSalary1 > totalSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            Console.WriteLine(person1More.ToString());
            Console.ReadLine();

        }
    }
}
