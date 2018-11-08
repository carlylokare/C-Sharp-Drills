using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //GREETING
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.ReadLine();


            //PACKAGE WEIGHT
            Console.WriteLine("Please enter the package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heave to be shipped via Package Express. Have a good day.");
                return;
            }
            Console.ReadLine();

            //PACKAGE WIDTH
            Console.WriteLine("Please enter the package width");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            //PACKAGE HEIGHT
            Console.WriteLine("Please enter the package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            //PACKAGE LENGTH
            Console.WriteLine("Please enter the package length");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            Console.ReadLine();

            Console.WriteLine("Your estimated total for shipping this package is");
            int totalPrice = (packageWidth + packageHeight + packageLength) * packageWeight / 100;
            Console.WriteLine("$" + totalPrice);
            Console.ReadLine();
        }
    }
}
