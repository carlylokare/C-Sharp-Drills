using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee human = new Employee();
            human.firstName = "Sample";
            human.lastName = "Student";
            human.SayName();

            IQuittable example = new Employee ();
            example.Quit();


            Console.ReadLine();
        }
    }
}
