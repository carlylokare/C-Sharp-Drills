using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you age?");
            string age = Console.ReadLine();
            int myAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Answer True or False");
            string dui = Console.ReadLine();
            bool truthyOrFalsey = Convert.ToBoolean(dui);

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int myTickets = Convert.ToInt32(tickets);

            Console.WriteLine("Qualified?");
            bool qualified = (myAge > 15 && truthyOrFalsey == false && myTickets < 4);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
