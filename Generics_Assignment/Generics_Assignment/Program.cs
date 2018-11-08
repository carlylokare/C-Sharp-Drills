using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> clothes = new Employee<string>();
            clothes.clothes2 = new List<string>() { "shoes", "pants", "shirt", "hat", "shorts" };

            foreach (string item in clothes.clothes2)
            {
                Console.WriteLine(item);
            }

            Employee<int> numbers = new Employee<int>();
            numbers.clothes2 = new List<int>() { 5, 10, 15, 20, 25 };

            foreach (int num in numbers.clothes2 )
            {
                Console.WriteLine(num);
            }




            

            Console.ReadKey();
        }
    }
}
