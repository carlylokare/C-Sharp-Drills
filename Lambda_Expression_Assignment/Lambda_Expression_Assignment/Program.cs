using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            list.Add(new Employee { firstName = "Joe", lastName = "Smith", id = 6 });
            list.Add(new Employee { firstName = "John", lastName = "Rosecrance", id = 8 });
            list.Add(new Employee { firstName = "Carly", lastName = "Lokare", id = 7, });
            list.Add(new Employee { firstName = "Nicole", lastName = "Quinn", id = 6 });
            list.Add(new Employee { firstName = "Joe", lastName = "Lamba", id = 2 });
            list.Add(new Employee { firstName = "Sarah", lastName = "Geshell", id = 3 });
            list.Add(new Employee { firstName = "Joe", lastName = "Montana", id = 4 });

            List<Employee> joe = new List<Employee>();


            //USING A FOR EACH LOOP, CREATE A NEW LIST OF EMPLOYEES WITH THE FIRST NAME "JOE"
            foreach (Employee name in list)
            {
                if (name.firstName == "Joe")
                {
                    joe.Add(new Employee { firstName = name.firstName, lastName = name.lastName, id = name.id });
                }
            }

            foreach (Employee name in joe)
            {
                Console.WriteLine(name.firstName + " " + name.lastName + " " + name.id);
            }



            //DO THE SAME THING, BUT WITH A LAMBDA EXPRESSION

            List<Employee> joeLambda = list.Where(n => n.firstName == "Joe").ToList();

            foreach (Employee name in joeLambda)
            {
                Console.WriteLine(name.firstName + " " + name.lastName + " " + name.id);
            }



            //USING A LAMBDA EXPRESSION, MAKE A LIST OF EMPLOYEES WITH AN ID # GREATER THAN 5

            List<Employee> greaterThan = list.Where(x => x.id > 5).ToList();

            foreach (Employee name in greaterThan)
            {
                Console.WriteLine(name.firstName + " " + name.lastName + " " + name.id);
            }


            Console.ReadKey();
        }
    }
}
