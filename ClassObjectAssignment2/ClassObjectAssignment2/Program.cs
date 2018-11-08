using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectAssignment2
{
    class Number
    {
 

        public void Add(int val, int val2)
        {
            Console.WriteLine(100 - val);
            Console.WriteLine(val2);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // 1. Calling the method in the class, specifying the parameters by name
            Console.WriteLine("Pick a whole number number to do various math operations on");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another whole number number to do various math operations on");
            int valueTwo = Convert.ToInt32(Console.ReadLine());

            Number example = new Number();
            example.Add(valueOne, valueTwo);


            // 2. Calling the method in the class, passing in two numbers
            example.Add(4, 4);


            Console.ReadKey();

        }
    }
}
