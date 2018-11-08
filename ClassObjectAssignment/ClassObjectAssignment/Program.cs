using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectAssignment
{
    class Number
    {
        public int firstNumber = 200;

        public void Add(int val)
        {
            Console.WriteLine(firstNumber + val);
        }

        public void Subtact(int val)
        {
            Console.WriteLine(firstNumber - val);
        }

        public void Multiply (int val)
        {
            Console.WriteLine(firstNumber * val);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pick a whole number number to do various math operations on");
            int valueOne = Convert.ToInt32(Console.ReadLine());

            Number example = new Number();
            example.Add(valueOne);
            example.Subtact(valueOne);
            example.Multiply(valueOne);
            


            Console.ReadKey();

        }
    }
}
