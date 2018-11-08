using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectAssignment3

{
    class Number
    {
        public int MathOperation(int val)
        { 
            return (500 - val);
        }
        public decimal MathOperation(decimal val)
        {
            return (50 * val);
        }
        public int MathOperation(string val)
        {
            int valueThree = Convert.ToInt32(val);
            return valueThree;
        }


    }

    class Program
    {
        public static void Main(string[] args)
        {
        
            // 1. Calling the method in the class, passing in an integer
            Console.WriteLine("Pick a whole number number to do various math operations on");
            int valueOne = Convert.ToInt32(Console.ReadLine());

            //2. Calling the method in the class, passing in a decimal
            Console.WriteLine("Pick a decimal number to do various math operations on");
            decimal valueTwo = Convert.ToDecimal(Console.ReadLine());

            //3. Calling the method in the class, passing in a string and converting to integer
            Console.WriteLine("Pick a number to convert to an integer and do a math operation on it");
            string numberOne = Console.ReadLine();

            Number example = new Number();
           
            Console.WriteLine(example.MathOperation(valueOne));
            Console.WriteLine(example.MathOperation(valueTwo));
            Console.WriteLine(example.MathOperation(numberOne));
   
            Console.ReadKey();

        }
    }
}