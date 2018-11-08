using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee n1 = new Employee();
            Employee n2 = new Employee();

            n1.id = 21;
            n2.id = 45;

            bool yes = n1 == n2;
            bool no = n1 != n2;


            Employee human = new Employee();
            human.firstName = "Sample";
            human.lastName = "Student";
            human.SayName();

            IQuittable example = new Employee();
            example.Quit();


            Console.ReadLine();
        }
    }
}
