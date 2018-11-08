using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constuctor_Chaining_Assignment
{
    class Program
    {
        public class Customer
        {
            //Create a const variable
            const string color = "Red";
            
           
           
            public string first;
            public string last;
            public int id;

            //Create a constructor chain
            public Customer(string s1) : this(s1, "-", 0)
            {
                //created a var
                var first = s1;
            }
            public Customer(string s1, string s2) : this(s1, s2, 0)
            {
                first = s1;
                last = s2;

            }
            public Customer(string s1, string s2, int number)
            {
                first = s1;
                last = s2;
                id = number;
            }

            public void PrintName()
            {
                Console.WriteLine(id + ":" + first + " " + last);
            }
        }

            static void Main(string[] args)
            {
            Customer cust = new Customer("Robert");
            //Customer cust = new Customer("Robert", "Marks");
            //Customer cust = new Customer("Robert", "Marks", 20);
            cust.PrintName();
            Console.ReadLine();
            }
    }
}
