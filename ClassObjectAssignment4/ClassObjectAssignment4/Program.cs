using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassObjectAssignment4
{
    class Number
    {
        public int Add(int val, int val2)
        {
            return (val + val2);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // 1. Calling the method in the class, specifying the parameters by name
            Console.WriteLine("Pick a whole number number to do various math operations on");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick another number if you feel like it, if not you don't have to put anything");
            string _input = Console.ReadLine();
            if (int.TryParse(_input, out int _val)) { _val = Convert.ToInt32(_input); }


            Number example = new Number();
            Console.WriteLine(example.Add(valueOne, _val));

            Console.ReadKey();

        }
    }
}

